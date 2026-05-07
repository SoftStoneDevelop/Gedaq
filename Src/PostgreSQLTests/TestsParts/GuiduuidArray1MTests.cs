

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
    internal partial interface IGuidArrayuuidArray
    {
    }
    
    internal partial class GuidArrayuuidArray : IGuidArrayuuidArray
    {


#region TestData

        private readonly GuiduuidArray1M[] _testData = new GuiduuidArray1M[]
        {
            new GuiduuidArray1M
{
    Id = 5,
    Value = 
new System.Guid[4]
{
Guid.Parse("24da13fd-fb25-40b6-b69d-7916a0d8d5ec"),
Guid.Parse("38f93429-7f86-4506-a1b6-d6c4b3242868"),
Guid.Parse("392b0e50-e25c-4be3-8660-7c66d2df1db7"),
Guid.Parse("1f26fda2-59b4-405d-8f24-846657bccb34"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 11,
    Value = 
new System.Guid[4]
{
Guid.Parse("3bb42aea-49e2-4425-824a-ff25962b8604"),
Guid.Parse("4ac9bf7a-30f0-4b0d-83bd-102113ac181f"),
Guid.Parse("2e9f1a94-51d4-48ac-b995-5d8e084f25a8"),
Guid.Parse("3a9b650d-bf39-4795-b5f6-cca4ad0e264f"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 7,
    Value = 
new System.Guid[4]
{
Guid.Parse("b1dc9e88-6a54-43d9-a533-9d890cfdaba5"),
Guid.Parse("ff261bd5-f9af-4912-8254-08af15d7fab2"),
Guid.Parse("6b88e924-cd86-4fea-9c30-03b0c35774f8"),
Guid.Parse("7b93e8c4-9e04-4d5c-bb52-85fc0790d791"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("170ec279-fe02-4daa-83e2-43634de9b949"),
Guid.Parse("f7a85bc6-9f2e-4654-90ea-ef95ae837f63"),
Guid.Parse("e9a8c66c-37cf-4600-801a-ac27d7383f90"),
Guid.Parse("fadf56bc-2faf-444f-8804-9188989364c1"),
},
},
            new GuiduuidArray1M
{
    Id = 15,
    Value = 
new System.Guid[4]
{
Guid.Parse("056de85c-7ad7-4aa8-b068-1f2a49f00920"),
Guid.Parse("fa67d9de-6f9d-49ce-8e22-bae50fa82bf7"),
Guid.Parse("3b9123bf-e9e8-48ce-b541-fc8e9d3e88b9"),
Guid.Parse("2dfab459-34f9-46c3-938f-51322f2055a7"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 24,
    Value = 
new System.Guid[3]
{
Guid.Parse("f5f081ec-0e4d-4be6-a0bc-625c06d2b6dd"),
Guid.Parse("ce186ac3-6da7-4cca-8f6b-03dad10a7685"),
Guid.Parse("b9eddfd0-18ff-48ca-8b20-72fc3da109dd"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 8,
    Value = 
new System.Guid[4]
{
Guid.Parse("89e47de8-27a0-411b-8119-ffc32a032756"),
Guid.Parse("f5994080-ebc3-4529-9a84-7afe897a44bf"),
Guid.Parse("b14d9dd1-3c29-4037-b705-ad1209398b3b"),
Guid.Parse("8d04944a-7c81-4eca-9167-e9aab9af3f57"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0ff588a8-498f-478e-94ed-5296b336d3d8"),
Guid.Parse("b8cdc90c-5087-4e8a-ac2c-bb36ee6c1e7b"),
Guid.Parse("6e83fd92-2133-4241-82b3-9756db6f2f82"),
},
},
            new GuiduuidArray1M
{
    Id = 27,
    Value = 
new System.Guid[4]
{
Guid.Parse("0c271152-fd40-45f3-9aa6-bd6d7a1002e2"),
Guid.Parse("391f8a68-bdb0-4142-a7f7-1158e0977c03"),
Guid.Parse("742b86d5-0767-42ce-b2e3-bf3cb9657d33"),
Guid.Parse("e5bf644b-3793-4f31-b4cf-44a18ac0650f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bc0f1693-4021-4a20-9e0b-ea49fb21a5bf"),
Guid.Parse("61a872b7-5e03-4b07-85af-686341ffe90a"),
Guid.Parse("53f53c4b-d3a6-4e24-bdf0-46ea00ac5a56"),
},
},
            new GuiduuidArray1M
{
    Id = 31,
    Value = 
new System.Guid[3]
{
Guid.Parse("8bb47b0f-0bf6-4c49-b0a6-8b3d6ff12068"),
Guid.Parse("eeaa2949-f999-4b6d-acab-3a7a1ced07af"),
Guid.Parse("1b7a619d-2cb2-412a-927d-b4efa703d87c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 12,
    Value = 
new System.Guid[3]
{
Guid.Parse("37d62a25-65c1-4761-9830-2727ebd4f9f4"),
Guid.Parse("c2351be5-8f2c-4680-b6e1-18a79e03bcbc"),
Guid.Parse("b488d515-8054-48ab-bb96-322c93f94f48"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 36,
    Value = 
new System.Guid[3]
{
Guid.Parse("a90e598c-4e5e-4b0a-8dcf-6a10fc0404d3"),
Guid.Parse("044837d0-78fa-444d-83e3-291da7e305cc"),
Guid.Parse("e61e89f9-be7f-4a02-9ff4-fb694b87b463"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5b366cd1-beae-4b5f-b531-d94f0888c9c3"),
Guid.Parse("568bb5c8-6e2b-4a25-8b7a-df1d2a66f71f"),
Guid.Parse("04bd951b-418a-49c4-b2b7-ec2c50c44f7e"),
Guid.Parse("9d029ca4-e2da-4a5e-aa14-ddc275f1eddc"),
},
},
            new GuiduuidArray1M
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("f8e7d830-443e-4e37-a37d-ff012033c827"),
Guid.Parse("a0e256d6-ba19-4f0e-899c-824c755175a8"),
Guid.Parse("33352c45-69a5-466a-822c-6de939abeb88"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 19,
    Value = 
new System.Guid[4]
{
Guid.Parse("1835b282-f9cd-431a-b22d-7769fef70baf"),
Guid.Parse("62ab0971-a214-4728-b7f1-733b0ccc79f9"),
Guid.Parse("b34ca402-32f2-4413-a1a9-842f516735ed"),
Guid.Parse("be0e8781-9a1c-49fe-881e-11060f574578"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8e92204a-980a-4205-aca5-f03a04041e5c"),
Guid.Parse("10f49486-3272-43e7-babc-77174f5fa927"),
Guid.Parse("6ba0e0fd-5d91-49f6-ae8d-5c6bb9839457"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 52,
    Value = 
new System.Guid[3]
{
Guid.Parse("1ba9d2e5-c18d-45e6-a8f1-7d1850c28ffb"),
Guid.Parse("5a20f1f4-b424-4b05-8c14-369b29329440"),
Guid.Parse("12a9debf-95f1-4363-a90d-d9386c4dd9d5"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 59,
    Value = 
new System.Guid[4]
{
Guid.Parse("59026645-be83-4a67-baf4-1256b6259f40"),
Guid.Parse("3b67a35c-1f1c-4c87-9c68-6c2375cd8905"),
Guid.Parse("42355038-1641-4095-af6d-6c8087494e36"),
Guid.Parse("30cd3ffd-ef2c-46a1-96de-1afeebbfa4e4"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 21,
    Value = 
new System.Guid[4]
{
Guid.Parse("ac7a3771-5f8f-4dab-8067-018f9b8f3351"),
Guid.Parse("1c1e84a9-8006-426f-a2c2-8eb95590dbef"),
Guid.Parse("4a6e4255-b3fb-4717-baa2-538022274d83"),
Guid.Parse("04c8e538-f0bc-4a91-b610-5b4a26b31dee"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("702ef735-64c7-473a-b7aa-bdc30714e72b"),
Guid.Parse("8ce698ac-3631-46f5-bc2a-373ebd40b6ec"),
Guid.Parse("209d7c35-8087-459b-a552-5f46731c2ab7"),
},
},
            new GuiduuidArray1M
{
    Id = 68,
    Value = 
new System.Guid[4]
{
Guid.Parse("40818f7c-d5f3-4ec2-9abc-edff4035fa96"),
Guid.Parse("292d0163-065d-440c-941b-10f56a4bc6ea"),
Guid.Parse("535f2047-e5f2-4e38-812a-369c27ea3061"),
Guid.Parse("5515a38d-5d9b-437a-93d9-22777e09dae2"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 70,
    Value = 
new System.Guid[3]
{
Guid.Parse("aef78c22-9ee2-4033-bcb4-37e2d3231635"),
Guid.Parse("fa20a4a0-a86f-4271-a8e6-5ba644468781"),
Guid.Parse("52bc2b17-7f78-45ae-a801-192063e34530"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 28,
    Value = 
new System.Guid[4]
{
Guid.Parse("20eb2f8f-829f-4c5e-b80f-f18156d174ac"),
Guid.Parse("aab3c357-9405-4675-8f65-85c3f09fc96f"),
Guid.Parse("a6215bd8-04fb-477a-b6e2-696598922db9"),
Guid.Parse("99442e84-5087-48ac-9243-1c1287d15579"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("35708ba8-d1cf-4337-8092-ceb3c150219f"),
Guid.Parse("644cac59-05d4-4804-bd2c-9e813f160774"),
Guid.Parse("4b317293-e2ff-4745-af14-c9d6794c3dad"),
},
},
            new GuiduuidArray1M
{
    Id = 79,
    Value = 
new System.Guid[4]
{
Guid.Parse("e66caa0d-258b-4208-89bf-691914aaf15a"),
Guid.Parse("c2a92ca2-a771-45aa-abf8-b024a7be91cd"),
Guid.Parse("323fc00f-bb18-4cf1-95fe-ce315ade4a13"),
Guid.Parse("0db2ea27-b5db-4618-ae86-02e5d05463e5"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7087368d-f16f-4061-a9c7-24b4278cb3de"),
Guid.Parse("881fcd9e-6ce0-4557-b9e5-d892c886ffb6"),
Guid.Parse("4879d9fb-2a7e-416c-b302-3ac5e46dc58f"),
},
},
            new GuiduuidArray1M
{
    Id = 83,
    Value = 
new System.Guid[3]
{
Guid.Parse("27d9b167-968f-4279-82ae-8e97e2c69e12"),
Guid.Parse("195ff2a7-99db-4b92-a02a-016ca1532bd0"),
Guid.Parse("7aaf6aa4-1478-4577-9bb0-56c7f653da78"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("1d7b24a9-cc71-411a-b146-1c97f4337da3"),
Guid.Parse("73988873-7a7e-4262-87c9-24982b2f73ae"),
Guid.Parse("550b8420-6f8c-49b2-866e-64f5bb10f45c"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 91,
    Value = 
new System.Guid[4]
{
Guid.Parse("dc954b91-2570-48ca-bb37-604b3fee1fd4"),
Guid.Parse("1626bf1e-cdc7-4a29-ade4-f24829b2c6fb"),
Guid.Parse("9fca3eba-0fa5-443f-b69f-54e5de3c4345"),
Guid.Parse("7063fc9f-e363-4903-ab7f-7779b9801832"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 92,
    Value = 
new System.Guid[3]
{
Guid.Parse("c5eeedcf-8786-4475-a2c9-d582bdb2d8d5"),
Guid.Parse("9ab44f2b-062c-49da-9484-5ac246d0fb76"),
Guid.Parse("d5b0b30f-1cb5-4e10-aa01-a925c2277917"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("63279420-1be4-44fe-b318-7696a48aac44"),
Guid.Parse("a5bc7e23-526e-418e-bcae-cf446da15ee3"),
Guid.Parse("4e8649c3-c375-4936-aa58-b3e7445daf04"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 101,
    Value = 
new System.Guid[4]
{
Guid.Parse("9968d74e-0c02-4088-b1b9-54d10c1e3f60"),
Guid.Parse("fa27a576-d88f-4d6c-bcbb-efc3733b21b2"),
Guid.Parse("5fcb608f-1210-4c93-898e-b8342ed6a09d"),
Guid.Parse("0fd07fc9-3851-40e0-911f-fc294b71d7d2"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 103,
    Value = 
new System.Guid[3]
{
Guid.Parse("4017895d-a87c-43ba-917d-4476800de4fd"),
Guid.Parse("0d371444-ded3-4eff-96a3-ae3bb8aaca98"),
Guid.Parse("1bb67396-8f83-4ef7-b733-6f6b2eae4764"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("fab11cbf-5966-4a17-97d4-118302f7f580"),
Guid.Parse("3a9cf873-25a0-48b7-b2b3-19c5772e9de2"),
Guid.Parse("24dea0c2-f31b-4661-bf18-a637746af35d"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 106,
    Value = 
new System.Guid[3]
{
Guid.Parse("cfe85e90-5e9f-4101-b874-939d3297c372"),
Guid.Parse("854fe04a-7e38-4718-b951-b7d37c6fe66f"),
Guid.Parse("5303c132-9fa6-4c98-872f-655cd5849a21"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 110,
    Value = 
new System.Guid[3]
{
Guid.Parse("076f6bea-e245-426e-94ac-885f22c5138c"),
Guid.Parse("aee4ea4f-2947-4ce3-8010-16608e1880ab"),
Guid.Parse("b1ddd22c-c4f9-40ce-8e90-01e75effe68a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 47,
    Value = 
new System.Guid[4]
{
Guid.Parse("001e922e-3ba8-4f9e-884d-d80f8c614f6e"),
Guid.Parse("3ce0f40e-57d9-46cc-989f-e30e88ff4b2d"),
Guid.Parse("810fcf5e-2c83-40db-90d1-499e792c86d1"),
Guid.Parse("8d87f787-fe59-48f6-8404-f0071a6080dd"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 112,
    Value = 
new System.Guid[3]
{
Guid.Parse("cfe26501-9629-4859-b903-652ad056d66b"),
Guid.Parse("2b08717e-846c-43d6-bd1d-30f4b865dc71"),
Guid.Parse("8a26b826-02da-4f7d-b1fc-3a0d5fb0a650"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 115,
    Value = 
new System.Guid[4]
{
Guid.Parse("6e669a90-e772-4e0e-a5e6-633a678eb378"),
Guid.Parse("cfbb0bdb-bf3f-4660-b296-4ce4dddab2f0"),
Guid.Parse("19962cc1-fc6f-42db-981d-ac4d2938912a"),
Guid.Parse("fabe6040-87db-4cfc-819f-6bb7e1d1ab6a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 54,
    Value = 
new System.Guid[4]
{
Guid.Parse("70c9b9da-043c-41b6-9dc6-2e3989a62346"),
Guid.Parse("b8c831b3-d037-4a7d-bb3a-8be3e0a1dc51"),
Guid.Parse("8840e24c-aac1-46a9-b40d-96ed62b9d68a"),
Guid.Parse("0ebecc66-b67f-4fd4-96a4-30341f63e660"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7ffd802e-f8b6-475f-ad1c-ccb0ac6eb263"),
Guid.Parse("97bad8db-8e8e-4b89-845f-2f63b1cc6b74"),
Guid.Parse("cfee31c4-e2d2-47be-aced-40b0b65e34b1"),
Guid.Parse("e9c72e96-00bf-4831-9900-c5b035549519"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a711042d-b38c-4813-8a6e-bbe13bbd3afe"),
Guid.Parse("38bada04-a1f3-4131-8647-67a2e2ce6eec"),
Guid.Parse("4adcd297-d4bf-4e49-8de6-8a50a2802a9b"),
},
},
            new GuiduuidArray1M
{
    Id = 120,
    Value = 
new System.Guid[4]
{
Guid.Parse("56ff5ee5-6d86-41c3-8ddb-735f4849879e"),
Guid.Parse("9f6525b9-c50e-4d5f-908e-9a5704675020"),
Guid.Parse("82832c6e-a19d-4f70-9c69-aa2d07c0a52d"),
Guid.Parse("289f1e45-4b79-48ca-84f6-ccc8fe8b31c7"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 125,
    Value = 
new System.Guid[3]
{
Guid.Parse("c5e53d2a-113b-49ec-a0cd-0042d82c1d8e"),
Guid.Parse("5f9a1723-deb6-4d24-98df-f77f1fba8a4c"),
Guid.Parse("0db95ca2-fa4a-41e1-aaa1-fef0bcfddbbf"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 57,
    Value = 
new System.Guid[3]
{
Guid.Parse("af68eb3a-d0ed-4831-8e52-791c869f6238"),
Guid.Parse("e1c96985-8c98-4dd3-ab16-8b6856852367"),
Guid.Parse("2f17426e-24dd-4a29-af95-40fc8e6c1295"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a47a07a0-e4ef-4f64-a420-2a3626db5973"),
Guid.Parse("0b8c92b0-591c-4c00-a53c-d3e87abfc69f"),
Guid.Parse("5f47df7b-d614-44cb-9ade-8512c78748e2"),
},
},
            new GuiduuidArray1M
{
    Id = 128,
    Value = 
new System.Guid[3]
{
Guid.Parse("2947ad7e-7bde-4283-b3db-fe66e9a1f0f8"),
Guid.Parse("63fc9256-b554-4417-980b-059dd69b1e7f"),
Guid.Parse("479e2301-2c54-47cd-a7a7-900f53fae71a"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 129,
    Value = 
new System.Guid[4]
{
Guid.Parse("8fb07956-4e4e-46ed-9348-4fb950a1a7d8"),
Guid.Parse("12b771a4-078b-4bff-9938-8237a5a99b10"),
Guid.Parse("11c7db52-c8f4-4678-ac69-e969801c7497"),
Guid.Parse("59a6a919-98c8-4e9d-9d30-1a18fe5e1e7b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 59,
    Value = 
new System.Guid[4]
{
Guid.Parse("0d06fec4-93e6-4336-a576-5dbbbb63d303"),
Guid.Parse("4a24d72e-df62-4b39-b4f6-e782b515d35a"),
Guid.Parse("13f869f0-be94-4522-8c8d-ffc56d559f13"),
Guid.Parse("b63b26c9-7e53-4b05-8678-e466db9b8ab4"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0cce1603-622d-4de6-93ab-15d3febd062e"),
Guid.Parse("52f096a2-1461-4c1d-aedd-72d7cd7e5627"),
Guid.Parse("ebaec2ed-5533-4f4a-8e1a-ac618a74f94f"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("67372f83-e435-4e9d-8bfb-f722e43e26e3"),
Guid.Parse("165a5c51-ead3-420f-a9ea-6ead95177013"),
Guid.Parse("5d2ee62c-5602-4e8b-abb6-c34feb952a74"),
},
},
            new GuiduuidArray1M
{
    Id = 132,
    Value = 
new System.Guid[3]
{
Guid.Parse("46491037-3a70-4957-be44-6b817017b229"),
Guid.Parse("076d2ca1-11dd-4f5d-9523-cecb4d9b045c"),
Guid.Parse("71348efe-4d4c-4070-b7cd-6615230ed7f9"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 139,
    Value = 
new System.Guid[3]
{
Guid.Parse("514a9c0f-0f13-4164-b217-403abb56f75c"),
Guid.Parse("d9c63659-20c0-4f8f-98ed-8f7db17390c6"),
Guid.Parse("34bb628d-ebde-48cc-8a95-8a2e81ad965c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 63,
    Value = 
new System.Guid[4]
{
Guid.Parse("3f694805-ba6a-4591-92c6-b533bd96e741"),
Guid.Parse("3ec7e130-8487-4a39-b36e-d6e291ccca79"),
Guid.Parse("369ebd9d-8aef-4847-b213-55e2254e0077"),
Guid.Parse("0ffd27a6-2b46-47ee-95d7-ede9ae18583d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fd3ecbaf-798e-48a2-8117-300cbf10104f"),
Guid.Parse("68f0afcb-68cf-49a8-aad1-36f0642c7092"),
Guid.Parse("7d471fda-17d3-44be-bc0e-c21d4e87a297"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("364a80d2-7679-4830-94e9-4fff84e53f1e"),
Guid.Parse("dc59a65f-a21d-4c54-9a39-9a0774953448"),
Guid.Parse("8dc9ec0e-8c9a-487b-99ad-d6261fb7b962"),
Guid.Parse("5c70f9c7-86d3-4746-a780-9e116b79cfd7"),
},
},
            new GuiduuidArray1M
{
    Id = 144,
    Value = 
new System.Guid[3]
{
Guid.Parse("304d91ba-ada0-4ea2-b0dc-a3b79153cd1b"),
Guid.Parse("e016102d-d698-4f91-bbcd-8917987cf185"),
Guid.Parse("545dd265-83d0-4731-9644-384749116e58"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("db85c733-e86f-4dfc-b02b-cf1e33ea7676"),
Guid.Parse("c313cdcf-adce-4576-8986-9f9f977f2b4b"),
Guid.Parse("248b3039-6c60-465c-84bb-a1a43d107277"),
},
},
            new GuiduuidArray1M
{
    Id = 151,
    Value = 
new System.Guid[3]
{
Guid.Parse("04de2ad9-97ca-4a8d-a833-ef78d50caff5"),
Guid.Parse("67c2ff62-5473-41eb-b753-69fa3ce94234"),
Guid.Parse("64bc0780-63e6-4466-b3f9-e716f17b87f3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 70,
    Value = 
new System.Guid[4]
{
Guid.Parse("76fa7f0b-2eca-41d7-9e63-010d16575567"),
Guid.Parse("0754f063-fc47-4665-b5cb-bba6a4256d46"),
Guid.Parse("2aae2ef7-ba01-4baf-910e-d88338991b70"),
Guid.Parse("08f68021-270b-4144-a89e-ec2a5e7bdddf"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 157,
    Value = 
new System.Guid[4]
{
Guid.Parse("2c4a8e89-2668-4efe-96a2-ae65b8cfd674"),
Guid.Parse("96321d3d-469d-481c-9473-d0b2a36560cc"),
Guid.Parse("fda442bc-c54f-4987-b3b4-a4e660f3e4e5"),
Guid.Parse("56b55b3b-6a16-40e8-8741-b5c780eb77a5"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3bb5225b-999d-48ef-b856-8d269df37a5c"),
Guid.Parse("dff936c2-b375-47e8-bd7b-febed1f3196c"),
Guid.Parse("4d5b9e95-f4ae-49a2-bf3e-8360f229aa32"),
},
},
            new GuiduuidArray1M
{
    Id = 158,
    Value = 
new System.Guid[3]
{
Guid.Parse("22e3cc7b-8471-4b7c-ad74-53be5f8cefde"),
Guid.Parse("0de6bd71-5a97-490b-9bfa-307fbe6f3307"),
Guid.Parse("61e52f7c-2bfb-453b-8f7b-e07a5fe95638"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("e340ef0b-2e01-40c4-b9de-e30a88f2d10d"),
Guid.Parse("308f927f-1b39-4c85-af11-1883093a196a"),
Guid.Parse("9ef3620b-2dc9-45db-807c-e07000ca0cad"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2ffa883c-c5f2-4c3c-844b-2858363020f0"),
Guid.Parse("eea3ca1e-508d-4227-8ed3-9fe25d00fa7f"),
Guid.Parse("93c7f8d9-9f10-4521-b968-d516f242926a"),
Guid.Parse("bc84798b-5f69-42be-b38f-8dfbdecb59d5"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("00df764c-741e-4982-a630-af579038541c"),
Guid.Parse("1a82b71f-6a71-443f-81ee-14e7104efe0d"),
Guid.Parse("1cfe2318-6312-459c-813f-18dcf4624863"),
Guid.Parse("7e3da57e-d115-4526-9107-f1fbf8f234b7"),
},
},
            new GuiduuidArray1M
{
    Id = 167,
    Value = 
new System.Guid[4]
{
Guid.Parse("de4a4cef-bad0-48a8-9596-3aec1eac1997"),
Guid.Parse("865beb87-7faa-40ec-aede-848a727a89e4"),
Guid.Parse("02f589f3-50c2-4ab5-8abe-d1980e81931f"),
Guid.Parse("4520d38b-7542-495a-a75c-eae7b0e18a6c"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 171,
    Value = 
new System.Guid[4]
{
Guid.Parse("9c5f18f0-c881-4bd8-8a8a-6a5ec4f663d8"),
Guid.Parse("bcc7d0b0-31b0-4da0-a410-ca16a57a18eb"),
Guid.Parse("d4545ce3-2284-43ab-bd0e-3b409e734481"),
Guid.Parse("dd1a2820-46d7-4699-91b3-392c5978c888"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 88,
    Value = 
new System.Guid[3]
{
Guid.Parse("eda425d2-6a2c-48c6-a263-9476bd92c0e1"),
Guid.Parse("931a78a4-376f-4141-9ca3-7ec47736cde9"),
Guid.Parse("ab7fd119-d9f8-4b8a-9533-5bdc44b907df"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3fea8aaf-76d7-477d-9f0b-468741a1429f"),
Guid.Parse("e5026976-e77d-4e83-b6d7-25b545c2edde"),
Guid.Parse("23872f72-6d5e-43c9-888c-c80828e321a9"),
Guid.Parse("fa85a1d0-d4f8-4084-9f74-890855bf0a24"),
},
},
            new GuiduuidArray1M
{
    Id = 174,
    Value = 
new System.Guid[4]
{
Guid.Parse("b43e3438-e46a-46c3-bafa-4cb21c3e627b"),
Guid.Parse("3b8e5c45-46cf-4644-86d9-4570f75b747c"),
Guid.Parse("804cdc43-c66b-45bd-92fb-536f4a1457e6"),
Guid.Parse("dba1ce46-972e-4700-a6d2-f62960f87cf4"),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1mi(
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
INSERT INTO public.guiduuidarray1mi(
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
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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

                changedRows =  ((IGuidArrayuuidArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidArrayuuidArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidArrayuuidArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidArrayuuidArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidArrayuuidArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidArrayuuidArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
            asPartInterface: typeof(IGuidArrayuuidArray)), 
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
                methodParametrName: "guiduuidarray1mi_id", 
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
                changedRows =  ((IGuidArrayuuidArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidArrayuuidArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidArrayuuidArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidArrayuuidArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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

                    nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("bc0f1693-4021-4a20-9e0b-ea49fb21a5bf"),
Guid.Parse("61a872b7-5e03-4b07-85af-686341ffe90a"),
Guid.Parse("53f53c4b-d3a6-4e24-bdf0-46ea00ac5a56"),
}));
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

                    nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("5b366cd1-beae-4b5f-b531-d94f0888c9c3"),
Guid.Parse("568bb5c8-6e2b-4a25-8b7a-df1d2a66f71f"),
Guid.Parse("04bd951b-418a-49c4-b2b7-ec2c50c44f7e"),
Guid.Parse("9d029ca4-e2da-4a5e-aa14-ddc275f1eddc"),
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

                    nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                methodParametrName: "guiduuidarray1mi_id", 
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
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("702ef735-64c7-473a-b7aa-bdc30714e72b"),
Guid.Parse("8ce698ac-3631-46f5-bc2a-373ebd40b6ec"),
Guid.Parse("209d7c35-8087-459b-a552-5f46731c2ab7"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[] nullable = null;
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("35708ba8-d1cf-4337-8092-ceb3c150219f"),
Guid.Parse("644cac59-05d4-4804-bd2c-9e813f160774"),
Guid.Parse("4b317293-e2ff-4745-af14-c9d6794c3dad"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray1M> models = null;

                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray1M> models = null;

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidArrayuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidArrayuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 27;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        GuiduuidArray1M.AssertModel(models[0],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidArray1M.AssertModel(models[0],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidArray1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 120, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 120, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 115, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 106, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 120, query1, 27, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[29],_testData[34], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 36, query1, 101, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 101, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[34], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 36, query1, 139, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await((IGuidArrayuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 83, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidArray1M.AssertModel(models[0],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidArray1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((IGuidArrayuuidArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 167, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidArray1M.AssertModel(models[0],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidArray1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[34], false);
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
                await using var cmd = await ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                GuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[29], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[30], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[31], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[32], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 167);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                GuiduuidArray1M.AssertModel(models[0],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[34], false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidArrayuuidArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidArrayuuidArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidArray1MI),
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidArrayuuidArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidArrayuuidArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidArray1M),
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
FROM public.binary_guiduuidarray1m m
LEFT JOIN public.binary_guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidArrayuuidArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidArrayuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models =  ((IGuidArrayuuidArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidArrayuuidArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA), typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                await ((IGuidArrayuuidArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                ((IGuidArrayuuidArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA), typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                await ((IGuidArrayuuidArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                ((IGuidArrayuuidArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models = await ((IGuidArrayuuidArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI), typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models1 = new List<GuiduuidArray1MI>();
                var models2 = new List<GuiduuidArray1MI>();
                await ((IGuidArrayuuidArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MI>();
                var models2 = new List<GuiduuidArray1MI>();
                ((IGuidArrayuuidArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA), typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                await ((IGuidArrayuuidArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                ((IGuidArrayuuidArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models = await ((IGuidArrayuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


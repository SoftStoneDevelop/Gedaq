

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
    Id = 6,
    Value = 
new System.Guid[3]
{
Guid.Parse("dc1d9394-6b39-4d4f-b180-370793d23876"),
Guid.Parse("71335630-5c2e-42c2-b294-3bb03afb171c"),
Guid.Parse("9ea4194f-41a2-4c16-a425-e7d195153a26"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("24f4e73a-0868-4df1-af43-f52948e6bb6e"),
Guid.Parse("91e6b19c-ae42-4986-ab0f-b46a515e3e6b"),
Guid.Parse("333a8650-bef0-49af-999e-0c3c32d70bdf"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 3,
    Value = 
new System.Guid[3]
{
Guid.Parse("2531d494-f556-4e39-ba22-a6f77f59f0dc"),
Guid.Parse("43b84363-24e9-49e9-b7a4-a78a86e3fcca"),
Guid.Parse("8e2821eb-f253-4db0-a53f-8eaac04ddb84"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 19,
    Value = 
new System.Guid[3]
{
Guid.Parse("693c953b-24b9-48f6-a1f1-750f873e5f2f"),
Guid.Parse("be8338e4-cff6-4510-9f4e-f2487096bd34"),
Guid.Parse("d628fea2-0d24-4e52-9a7e-64a3b35bae2e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a24fdaa0-659a-4d7a-9162-e33ce96efffc"),
Guid.Parse("e397444a-fc18-4f87-b7fd-1b9792886728"),
Guid.Parse("ca3cdf7e-06f0-473e-b15d-cdc2c7e1a9c8"),
},
},
            new GuiduuidArray1M
{
    Id = 26,
    Value = 
new System.Guid[3]
{
Guid.Parse("8712affa-a7a0-4cb0-bdcf-38203b3b8458"),
Guid.Parse("e04d087e-c8e1-4dec-aabf-429cded72c84"),
Guid.Parse("d888fdf8-2258-4851-a389-ba7dec7b8afd"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("538ebe19-d105-421d-968a-2fd3188f4a18"),
Guid.Parse("cd211403-e80e-4494-b1ea-f64881c3abf7"),
Guid.Parse("06cf950a-9f58-49fa-9752-941491e4bd3d"),
Guid.Parse("3f95c8bb-00be-4bfe-9c45-baab125a7b62"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("f160f524-6560-4334-a2b5-cff20c48c20d"),
Guid.Parse("cae77148-15ca-40c7-af83-a5d74f963201"),
Guid.Parse("9d0babaa-2fdd-4e8c-ad2d-940b1c21709b"),
Guid.Parse("bdb46609-79ba-4195-b775-18a45a2ff68f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("12f39b9f-b78d-4097-b82b-8309e37caeca"),
Guid.Parse("330b9704-b5fb-400d-ac6c-46e734b43f6b"),
Guid.Parse("fc4ad27d-dbe5-4a0c-b193-62bfdef772fe"),
Guid.Parse("f6038c0d-065c-4aba-a6b4-b472b33cb437"),
},
},
            new GuiduuidArray1M
{
    Id = 37,
    Value = 
new System.Guid[4]
{
Guid.Parse("aad33cad-e1de-416f-85e5-7f8104348502"),
Guid.Parse("1b33eaa0-96f0-408b-abbe-23443da5b9ed"),
Guid.Parse("b58e3b6f-3434-49cf-8547-7fb249a490c2"),
Guid.Parse("be5b3f82-d073-4094-b589-878db8464ba1"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 10,
    Value = 
new System.Guid[4]
{
Guid.Parse("0b38760d-5017-4cd5-bba7-9e8b7c657e02"),
Guid.Parse("4ef3326a-1491-477c-8f29-ad8126991ea3"),
Guid.Parse("03db1eff-2fdf-4898-aa02-1c860f5840a9"),
Guid.Parse("ab8a875c-d419-4162-ad21-48dd6b1f9512"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("03a71836-205a-43f3-8c84-93a0f081b444"),
Guid.Parse("6423e6a3-e5eb-4098-a8dc-4981f7c4a227"),
Guid.Parse("12d79d83-3961-4ca0-9cce-ff843b6f4374"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("09073994-c34d-45d2-a666-b91cb1758fc7"),
Guid.Parse("1f3db29c-5e43-4aa4-9491-a8a3d808cb4f"),
Guid.Parse("cc33b7ce-fc3f-4406-b532-adfb1d12273f"),
Guid.Parse("5c670a5b-3270-43c1-9d33-c8b02d1974f5"),
},
},
            new GuiduuidArray1M
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("b20bc7b6-fd3e-4f79-967c-e12625e75b6d"),
Guid.Parse("91f3f010-4117-4ffb-8f82-2e6fd1c29d1a"),
Guid.Parse("62d16350-504b-4ccd-8bb7-42938abd2330"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fb21ee19-5124-4687-9831-3147b2e7c08d"),
Guid.Parse("bf188e8b-6899-4fa9-bdfd-76a5296dcee0"),
Guid.Parse("8ff63ecc-fb73-4cfc-8dd4-9bf227de4e62"),
Guid.Parse("c4ea7d32-1e5f-464a-bdd5-e7ef40048cf9"),
},
},
            new GuiduuidArray1M
{
    Id = 47,
    Value = 
new System.Guid[3]
{
Guid.Parse("62862d44-ed2a-4545-858f-93b40b36c976"),
Guid.Parse("9d0e20f2-6d8a-4c5c-a934-088f11eb771c"),
Guid.Parse("b714499d-bb5a-464a-bc06-76e26fcb4c5a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 12,
    Value = 
new System.Guid[3]
{
Guid.Parse("7096cb29-8d1e-4b49-853e-eb6fb36b9c4c"),
Guid.Parse("1a63c923-d80e-407d-b84b-7f207a926e6e"),
Guid.Parse("a8cda140-bec3-4f2a-bdb5-33b86e5761bf"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6cb137fa-48b0-4711-890f-c510070dfd1e"),
Guid.Parse("d5aedc5f-d957-4303-b3dd-5c93be5938ee"),
Guid.Parse("6bb3e0c4-139b-4d7e-8b57-95140378f645"),
Guid.Parse("dc81fd8e-3c4c-4495-9090-64bdde15900b"),
},
},
            new GuiduuidArray1M
{
    Id = 52,
    Value = 
new System.Guid[3]
{
Guid.Parse("abbb51e0-6030-45e9-8d6e-9a82ceedc3d5"),
Guid.Parse("1e743e74-a4b1-48e3-a7c5-2e516e26696d"),
Guid.Parse("a738ad6c-93fd-48c7-a373-f9dd7bbee2b5"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 56,
    Value = 
new System.Guid[3]
{
Guid.Parse("327db165-ddcc-4665-a8b7-18d777ebce0b"),
Guid.Parse("c838f7cb-9f2d-4abe-9a17-c0805ef5501e"),
Guid.Parse("d4e35c72-07b1-4d6e-bc64-abf2270ba49f"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("3bb780b9-26c6-4740-beea-e3aef69353f1"),
Guid.Parse("4189f279-80cf-4878-bc0d-d86de6723b4c"),
Guid.Parse("7589244a-8201-417a-bd1a-ce9741a5570e"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 58,
    Value = 
new System.Guid[4]
{
Guid.Parse("b3fbcee7-bc44-4979-88b3-49f2a9091836"),
Guid.Parse("b0de2e2b-b95e-4002-8e41-b93f6be267f8"),
Guid.Parse("3ed724d6-9648-4f96-9dc7-6a23b518d47e"),
Guid.Parse("e9faaf42-5a25-422c-9ab5-48d19cd8b0a0"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("422aba7c-7c3b-42af-adaa-47b1ba122700"),
Guid.Parse("561eb0f6-8e42-4cf6-9261-74cfc583bab2"),
Guid.Parse("4a52c0b9-d171-4d98-8eda-7ed2c92799bd"),
},
},
            new GuiduuidArray1M
{
    Id = 66,
    Value = 
new System.Guid[3]
{
Guid.Parse("55a55a86-32b4-456e-9041-ab2673c112b6"),
Guid.Parse("096e5601-52e4-4a9d-ba2b-13c7032976de"),
Guid.Parse("a12d1234-96f6-4688-9268-82c52e6f0f1c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 20,
    Value = 
new System.Guid[4]
{
Guid.Parse("a746f36e-a4f5-49d1-b021-fd0c351267b9"),
Guid.Parse("3034910b-bb4e-4b33-9679-511ea3dfc810"),
Guid.Parse("f8d299a8-551b-42cc-a11e-ed426dc1dfe8"),
Guid.Parse("24d72245-4e91-414a-abf9-da06a0831305"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 68,
    Value = 
new System.Guid[4]
{
Guid.Parse("6b9831f1-34eb-44aa-8563-20c05b4fef91"),
Guid.Parse("9d9288c1-7a93-4b3a-9129-7fcf44c8507e"),
Guid.Parse("6030ee2c-0202-4b76-a641-24047200b625"),
Guid.Parse("4d5dfba0-69c6-4aa2-8e34-930cefbd9033"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8ce2c5a6-4be6-410d-b731-39de9068e6ad"),
Guid.Parse("665e3114-99d7-4d51-b21c-68ea290e1926"),
Guid.Parse("31fa2132-b933-4e28-a91f-6b5a49626203"),
Guid.Parse("5df9f39f-a8ff-40ca-9921-090ec86e69c1"),
},
},
            new GuiduuidArray1M
{
    Id = 72,
    Value = 
new System.Guid[3]
{
Guid.Parse("46558130-8687-4bd4-9042-2c8e065f068d"),
Guid.Parse("bce32601-5845-4911-ae8b-065eab8dd008"),
Guid.Parse("3f3be9dd-7018-4c8f-bcd2-f2f5d5cf4fc9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 25,
    Value = 
new System.Guid[4]
{
Guid.Parse("8047c9ab-3694-4c0a-a88e-15b50bb2b9aa"),
Guid.Parse("37a44c6b-9e66-4ebd-aa26-6d9ab6624c87"),
Guid.Parse("f625caae-9187-4588-b3ba-5c0a59c1eeec"),
Guid.Parse("f14ebb40-e678-4e47-95ff-c12c2e69580b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("509d20e2-5907-4d56-9931-e7c8474cd47c"),
Guid.Parse("0aef9279-e6b0-42cd-83db-a87ae9b78261"),
Guid.Parse("1ff0124f-7a18-4e3f-9859-d05f4e7c8506"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9557eab8-4fcf-412a-9830-5ed0bde80308"),
Guid.Parse("8a668d77-3157-4031-ad1d-9abe9730588f"),
Guid.Parse("32b46a27-1fc3-48fc-906b-f7f236d6f99e"),
},
},
            new GuiduuidArray1M
{
    Id = 79,
    Value = 
new System.Guid[4]
{
Guid.Parse("fb9bce28-1de5-47f5-b094-3af16e852960"),
Guid.Parse("6a3be093-7aa2-49a3-b6fd-4c5eada07f2f"),
Guid.Parse("fa01e4a0-3929-4fae-b530-eff9589b5a53"),
Guid.Parse("bd374493-fbfc-4a8d-9f7b-c1f679290d7e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("02ed2230-07ab-4d45-b382-27eb323f2039"),
Guid.Parse("8ee05a2b-705b-49e9-8f8f-dbe6c4144a6c"),
Guid.Parse("4c8a2f86-3928-48c1-9cda-71476a5c92cb"),
Guid.Parse("01ac6044-ac4e-4794-8094-6ce380429ae3"),
},
},
            new GuiduuidArray1M
{
    Id = 87,
    Value = 
new System.Guid[4]
{
Guid.Parse("b5b225c2-7635-44ed-a160-633c696176d9"),
Guid.Parse("2024158b-a51c-4da8-a3ca-0946a0a95ccd"),
Guid.Parse("de7f1b98-e527-44db-870a-445822cc7779"),
Guid.Parse("9a10a1bd-0bd5-4936-85a3-0cefc56541c1"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 28,
    Value = 
new System.Guid[4]
{
Guid.Parse("0146f442-ae74-434f-b851-d9e6c8465e0d"),
Guid.Parse("8bc06848-fb72-454e-8b78-554bba460524"),
Guid.Parse("c92fd5ff-8e47-415b-b70f-6ca47d6d25a0"),
Guid.Parse("49ca90e0-375a-4e67-ba97-6d92a0c899c8"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("73acfbc2-4781-4690-8e4a-6abc4397c09a"),
Guid.Parse("337f73eb-15b8-42b4-beb4-ca36bd399123"),
Guid.Parse("1eed2c56-648d-47d5-8e4a-d3e18007fdfc"),
Guid.Parse("eeded492-ddf3-4c2b-97d0-68905f2f1c16"),
},
},
            new GuiduuidArray1M
{
    Id = 89,
    Value = 
new System.Guid[3]
{
Guid.Parse("b0d17cd2-316f-4d40-9abd-669f202f3cf7"),
Guid.Parse("37d0e2ef-e68c-440f-8ca0-e54033393cdf"),
Guid.Parse("7496a207-798a-4790-8304-37a599c9a3bc"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 93,
    Value = 
new System.Guid[3]
{
Guid.Parse("5d90220d-cfbb-4201-a650-1ec5d5eb7784"),
Guid.Parse("ef40b766-3f81-41fd-9449-d198311fac0e"),
Guid.Parse("35c86120-dfb6-4c6d-92b6-136a31cd371f"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 32,
    Value = 
new System.Guid[3]
{
Guid.Parse("74e603a9-4c54-4ddd-b465-5d63c082cf23"),
Guid.Parse("1123f353-584d-4054-bcf3-331de7c7f2fc"),
Guid.Parse("2c76132a-5a69-428c-8cf9-ad2e8be219ed"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9b5b3c6c-069f-43a6-9a50-1b6d057218d9"),
Guid.Parse("dd3366c4-60b2-4cad-af84-5a933041105f"),
Guid.Parse("45ed60e2-55ee-4358-bf71-442ba7ce8fba"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 102,
    Value = 
new System.Guid[4]
{
Guid.Parse("95e4c23d-c360-40b9-9178-8edf7c2a5eaf"),
Guid.Parse("d186a332-b8d1-44a5-b073-4d9209f69867"),
Guid.Parse("bc375f55-1bf1-4873-9725-86f8d61e06b6"),
Guid.Parse("f3567194-8176-48da-900d-fe24be4451ad"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f31df6ba-ff09-4919-9ea1-f05ec9b02016"),
Guid.Parse("178e2e46-81e5-4962-bcae-9195548f9c3f"),
Guid.Parse("1f1718f2-68c5-4a3e-ac02-813ffcb48674"),
},
},
            new GuiduuidArray1M
{
    Id = 104,
    Value = 
new System.Guid[3]
{
Guid.Parse("ec24eb26-263a-476a-9728-4c94f9bec7b1"),
Guid.Parse("821832f0-59df-4d5a-8140-15236c785319"),
Guid.Parse("d06e99b4-2901-47d4-add0-db14e5f2af8c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 36,
    Value = 
new System.Guid[3]
{
Guid.Parse("f3cf2371-e58a-48fe-bde2-a812e7128bbf"),
Guid.Parse("0d97bc18-acc5-4d54-be6c-a141a7bfe45f"),
Guid.Parse("5add6f1a-9410-4582-9e73-e9833eee65d4"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 111,
    Value = 
new System.Guid[3]
{
Guid.Parse("15e63294-94f2-471a-9335-c003a197265c"),
Guid.Parse("ca37dbe3-85a0-44de-acdd-97f728a95f89"),
Guid.Parse("00a575fc-340e-483c-8522-77d0a812ca35"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3f3fa24b-b328-4ce2-bf77-8e7d086fe752"),
Guid.Parse("cb86d087-05e4-4212-b37a-d14b62fb1637"),
Guid.Parse("003e704e-6050-49f7-a056-41a5bd0bdeaa"),
},
},
            new GuiduuidArray1M
{
    Id = 112,
    Value = 
new System.Guid[3]
{
Guid.Parse("ca928c12-68c6-45bc-b690-9c70f5b46347"),
Guid.Parse("cda117ea-e7e6-4ac0-8dbc-97539e1bd24b"),
Guid.Parse("d37b660a-dab1-4161-8c6a-5f361a75d568"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("2d306efb-02c6-4b0f-ae33-3ead15cad868"),
Guid.Parse("ed990334-5e5e-426b-bb0a-09befaa491be"),
Guid.Parse("84a97436-5cfa-478a-bb42-f74691a3e2c8"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8a6ee694-a5c8-471a-9e88-7cf782a8341f"),
Guid.Parse("fb026715-0cf1-4b8d-879d-1c122be64037"),
Guid.Parse("e6d37e9e-8f23-4111-a5f5-f5f4c1e5df91"),
Guid.Parse("b4b208f0-e851-45a5-b150-d92e6af0fcc7"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 121,
    Value = 
new System.Guid[4]
{
Guid.Parse("fa299581-03d9-45d1-a9b7-739487109b82"),
Guid.Parse("46c9dd09-7c87-4058-a662-cdcbf393f487"),
Guid.Parse("a11c3d91-861f-4826-948b-09fc83e8bf01"),
Guid.Parse("7dbfc9ee-48bb-4a7f-947e-f7477da55b12"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 122,
    Value = 
new System.Guid[3]
{
Guid.Parse("73b608ef-9093-4538-b91c-d77f2c4941e7"),
Guid.Parse("967fd8f3-f3d3-49f2-92f7-575204bca4f5"),
Guid.Parse("2bf5e26d-e7ae-4f28-b7cd-d38b7dac232a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 50,
    Value = 
new System.Guid[3]
{
Guid.Parse("2d8d2a03-7eec-4358-a9c9-9439eb11a9a9"),
Guid.Parse("03e252e5-8a46-4fa5-bb9f-8608dda5d5e3"),
Guid.Parse("214dceeb-3687-49e9-9c81-1564a62f88e1"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("db076304-a4a6-40cb-a207-5ee862fffa8d"),
Guid.Parse("02566be7-ce21-4a30-9ea0-8c48daf5c862"),
Guid.Parse("f1fa5b6f-5ad1-4a6a-b373-9d61ecd461a1"),
},
},
            new GuiduuidArray1M
{
    Id = 126,
    Value = 
new System.Guid[4]
{
Guid.Parse("99981908-7e42-42b1-890a-f05508152a46"),
Guid.Parse("38f61358-ce05-40e1-9144-6962032e722b"),
Guid.Parse("d5d69684-9c2d-469d-8c44-aedc96a7ded3"),
Guid.Parse("a13ba785-0cd4-495b-aa20-b0e321c31523"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 130,
    Value = 
new System.Guid[3]
{
Guid.Parse("d5b0eab1-00d0-4715-b952-4701d86351f8"),
Guid.Parse("44fb0a7a-832e-4c71-9f1e-468fdf5a326a"),
Guid.Parse("ad25095d-965d-44ec-a21c-e4e21038e62e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("980b569a-505a-4b43-ac0c-d5055e27d242"),
Guid.Parse("a80788e7-7037-4f97-91d6-ca9b9dbce26a"),
Guid.Parse("86d6dca9-18f6-44a7-a7df-68bc00f61a9d"),
Guid.Parse("a703d21f-041c-40fd-bc78-3517639577f7"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("88f09d54-3ca3-4f8c-a8ce-44a5087e1875"),
Guid.Parse("0043897d-9e93-4485-a137-c5318d4dfa53"),
Guid.Parse("1bae644c-cb59-429b-a4ee-c42a86676138"),
Guid.Parse("4402f67e-b23c-41f1-9019-3cfe440c9d48"),
},
},
            new GuiduuidArray1M
{
    Id = 138,
    Value = 
new System.Guid[3]
{
Guid.Parse("5acfdf56-3aef-49a3-adf0-3f3e56e2f5f1"),
Guid.Parse("b421f796-d0ff-42f7-ae5f-2b27843d8b91"),
Guid.Parse("ea00b079-161f-47db-9d9c-858ca20fa7dd"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 139,
    Value = 
new System.Guid[4]
{
Guid.Parse("70cbbdc5-da9d-4b5b-a417-31af0fd26c73"),
Guid.Parse("bf9ae52e-075b-456f-a5b3-0f9a84b1d7fa"),
Guid.Parse("bb9b2072-76a0-4e9b-a549-f7df695632f8"),
Guid.Parse("5fea7e66-d546-41bb-a8fb-8674545103f3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 63,
    Value = 
new System.Guid[4]
{
Guid.Parse("2cec4906-e80c-4840-abcf-8a82ca53e943"),
Guid.Parse("62f3ac66-5498-44a6-a1b5-3061d3bee470"),
Guid.Parse("6c25a854-d1d5-4644-8425-cd4979e15935"),
Guid.Parse("7b67e9d0-da1d-438a-8623-00cd100d40e4"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0a010e1c-b679-4b4d-9a09-30d4f3ad7330"),
Guid.Parse("9cc3db51-d7b9-4264-9072-eee488f2738b"),
Guid.Parse("e0e607a4-cd03-45c7-b7f0-8460906fc705"),
Guid.Parse("23331d3f-48e0-4571-b050-4ca8b85f333b"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 141,
    Value = 
new System.Guid[4]
{
Guid.Parse("d9d92c7b-99b1-46de-995e-f680f6edae22"),
Guid.Parse("1483f396-fdbc-41c9-a676-b7edc0b28b7b"),
Guid.Parse("7e8d720d-b146-472f-9d8b-adc72689355d"),
Guid.Parse("3c48c9cd-b3d7-46ad-af0f-52ecdf4f6eed"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 148,
    Value = 
new System.Guid[3]
{
Guid.Parse("e5438c64-dc90-4149-b3ac-b47719822e37"),
Guid.Parse("8ecb22f5-a254-4ac0-95d4-594eeee5a96f"),
Guid.Parse("5e43f24f-6cb2-4ffb-85ca-f116fc3610dc"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 66,
    Value = 
new System.Guid[3]
{
Guid.Parse("ff212072-7c6b-47d1-a441-2703ce8ca308"),
Guid.Parse("5b8d00ea-a714-4ac7-9420-3ae3b2029526"),
Guid.Parse("9fe50e1e-7dc9-4f50-b024-1ccc68259716"),
},
    NullableValue = null,
},
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
new System.Guid[4]
{
Guid.Parse("12f39b9f-b78d-4097-b82b-8309e37caeca"),
Guid.Parse("330b9704-b5fb-400d-ac6c-46e734b43f6b"),
Guid.Parse("fc4ad27d-dbe5-4a0c-b193-62bfdef772fe"),
Guid.Parse("f6038c0d-065c-4aba-a6b4-b472b33cb437"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("09073994-c34d-45d2-a666-b91cb1758fc7"),
Guid.Parse("1f3db29c-5e43-4aa4-9491-a8a3d808cb4f"),
Guid.Parse("cc33b7ce-fc3f-4406-b532-adfb1d12273f"),
Guid.Parse("5c670a5b-3270-43c1-9d33-c8b02d1974f5"),
}));
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
Guid.Parse("fb21ee19-5124-4687-9831-3147b2e7c08d"),
Guid.Parse("bf188e8b-6899-4fa9-bdfd-76a5296dcee0"),
Guid.Parse("8ff63ecc-fb73-4cfc-8dd4-9bf227de4e62"),
Guid.Parse("c4ea7d32-1e5f-464a-bdd5-e7ef40048cf9"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("6cb137fa-48b0-4711-890f-c510070dfd1e"),
Guid.Parse("d5aedc5f-d957-4303-b3dd-5c93be5938ee"),
Guid.Parse("6bb3e0c4-139b-4d7e-8b57-95140378f645"),
Guid.Parse("dc81fd8e-3c4c-4495-9090-64bdde15900b"),
}));
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
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("422aba7c-7c3b-42af-adaa-47b1ba122700"),
Guid.Parse("561eb0f6-8e42-4cf6-9261-74cfc583bab2"),
Guid.Parse("4a52c0b9-d171-4d98-8eda-7ed2c92799bd"),
}));
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 87;
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
GuiduuidArray1M.AssertModel(models[0],_testData[1], false);GuiduuidArray1M.AssertModel(models[1],_testData[2], false);GuiduuidArray1M.AssertModel(models[2],_testData[3], false);GuiduuidArray1M.AssertModel(models[3],_testData[4], false);GuiduuidArray1M.AssertModel(models[4],_testData[5], false);GuiduuidArray1M.AssertModel(models[5],_testData[6], false);GuiduuidArray1M.AssertModel(models[6],_testData[7], false);GuiduuidArray1M.AssertModel(models[7],_testData[8], false);GuiduuidArray1M.AssertModel(models[8],_testData[9], false);GuiduuidArray1M.AssertModel(models[9],_testData[10], false);GuiduuidArray1M.AssertModel(models[10],_testData[11], false);GuiduuidArray1M.AssertModel(models[11],_testData[12], false);GuiduuidArray1M.AssertModel(models[12],_testData[13], false);GuiduuidArray1M.AssertModel(models[13],_testData[14], false);GuiduuidArray1M.AssertModel(models[14],_testData[15], false);GuiduuidArray1M.AssertModel(models[15],_testData[16], false);GuiduuidArray1M.AssertModel(models[16],_testData[17], false);GuiduuidArray1M.AssertModel(models[17],_testData[18], false);GuiduuidArray1M.AssertModel(models[18],_testData[19], false);GuiduuidArray1M.AssertModel(models[19],_testData[20], false);GuiduuidArray1M.AssertModel(models[20],_testData[21], false);GuiduuidArray1M.AssertModel(models[21],_testData[22], false);GuiduuidArray1M.AssertModel(models[22],_testData[23], false);GuiduuidArray1M.AssertModel(models[23],_testData[24], false);GuiduuidArray1M.AssertModel(models[24],_testData[25], false);GuiduuidArray1M.AssertModel(models[25],_testData[26], false);GuiduuidArray1M.AssertModel(models[26],_testData[27], false);GuiduuidArray1M.AssertModel(models[27],_testData[28], false);GuiduuidArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
GuiduuidArray1M.AssertModel(models[0],_testData[1], false);GuiduuidArray1M.AssertModel(models[1],_testData[2], false);GuiduuidArray1M.AssertModel(models[2],_testData[3], false);GuiduuidArray1M.AssertModel(models[3],_testData[4], false);GuiduuidArray1M.AssertModel(models[4],_testData[5], false);GuiduuidArray1M.AssertModel(models[5],_testData[6], false);GuiduuidArray1M.AssertModel(models[6],_testData[7], false);GuiduuidArray1M.AssertModel(models[7],_testData[8], false);GuiduuidArray1M.AssertModel(models[8],_testData[9], false);GuiduuidArray1M.AssertModel(models[9],_testData[10], false);GuiduuidArray1M.AssertModel(models[10],_testData[11], false);GuiduuidArray1M.AssertModel(models[11],_testData[12], false);GuiduuidArray1M.AssertModel(models[12],_testData[13], false);GuiduuidArray1M.AssertModel(models[13],_testData[14], false);GuiduuidArray1M.AssertModel(models[14],_testData[15], false);GuiduuidArray1M.AssertModel(models[15],_testData[16], false);GuiduuidArray1M.AssertModel(models[16],_testData[17], false);GuiduuidArray1M.AssertModel(models[17],_testData[18], false);GuiduuidArray1M.AssertModel(models[18],_testData[19], false);GuiduuidArray1M.AssertModel(models[19],_testData[20], false);GuiduuidArray1M.AssertModel(models[20],_testData[21], false);GuiduuidArray1M.AssertModel(models[21],_testData[22], false);GuiduuidArray1M.AssertModel(models[22],_testData[23], false);GuiduuidArray1M.AssertModel(models[23],_testData[24], false);GuiduuidArray1M.AssertModel(models[24],_testData[25], false);GuiduuidArray1M.AssertModel(models[25],_testData[26], false);GuiduuidArray1M.AssertModel(models[26],_testData[27], false);GuiduuidArray1M.AssertModel(models[27],_testData[28], false);GuiduuidArray1M.AssertModel(models[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
GuiduuidArray1M.AssertModel(models[0],_testData[5], false);GuiduuidArray1M.AssertModel(models[1],_testData[6], false);GuiduuidArray1M.AssertModel(models[2],_testData[7], false);GuiduuidArray1M.AssertModel(models[3],_testData[8], false);GuiduuidArray1M.AssertModel(models[4],_testData[9], false);GuiduuidArray1M.AssertModel(models[5],_testData[10], false);GuiduuidArray1M.AssertModel(models[6],_testData[11], false);GuiduuidArray1M.AssertModel(models[7],_testData[12], false);GuiduuidArray1M.AssertModel(models[8],_testData[13], false);GuiduuidArray1M.AssertModel(models[9],_testData[14], false);GuiduuidArray1M.AssertModel(models[10],_testData[15], false);GuiduuidArray1M.AssertModel(models[11],_testData[16], false);GuiduuidArray1M.AssertModel(models[12],_testData[17], false);GuiduuidArray1M.AssertModel(models[13],_testData[18], false);GuiduuidArray1M.AssertModel(models[14],_testData[19], false);GuiduuidArray1M.AssertModel(models[15],_testData[20], false);GuiduuidArray1M.AssertModel(models[16],_testData[21], false);GuiduuidArray1M.AssertModel(models[17],_testData[22], false);GuiduuidArray1M.AssertModel(models[18],_testData[23], false);GuiduuidArray1M.AssertModel(models[19],_testData[24], false);GuiduuidArray1M.AssertModel(models[20],_testData[25], false);GuiduuidArray1M.AssertModel(models[21],_testData[26], false);GuiduuidArray1M.AssertModel(models[22],_testData[27], false);GuiduuidArray1M.AssertModel(models[23],_testData[28], false);GuiduuidArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
GuiduuidArray1M.AssertModel(models[0],_testData[12], false);GuiduuidArray1M.AssertModel(models[1],_testData[13], false);GuiduuidArray1M.AssertModel(models[2],_testData[14], false);GuiduuidArray1M.AssertModel(models[3],_testData[15], false);GuiduuidArray1M.AssertModel(models[4],_testData[16], false);GuiduuidArray1M.AssertModel(models[5],_testData[17], false);GuiduuidArray1M.AssertModel(models[6],_testData[18], false);GuiduuidArray1M.AssertModel(models[7],_testData[19], false);GuiduuidArray1M.AssertModel(models[8],_testData[20], false);GuiduuidArray1M.AssertModel(models[9],_testData[21], false);GuiduuidArray1M.AssertModel(models[10],_testData[22], false);GuiduuidArray1M.AssertModel(models[11],_testData[23], false);GuiduuidArray1M.AssertModel(models[12],_testData[24], false);GuiduuidArray1M.AssertModel(models[13],_testData[25], false);GuiduuidArray1M.AssertModel(models[14],_testData[26], false);GuiduuidArray1M.AssertModel(models[15],_testData[27], false);GuiduuidArray1M.AssertModel(models[16],_testData[28], false);GuiduuidArray1M.AssertModel(models[17],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 47, query1, 19, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[3], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[4], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[5], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[6], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[23],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[24],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[25],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 43, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IGuidArrayuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 66, 93))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
GuiduuidArray1M.AssertModel(models[0],_testData[12], false);GuiduuidArray1M.AssertModel(models[1],_testData[13], false);GuiduuidArray1M.AssertModel(models[2],_testData[14], false);GuiduuidArray1M.AssertModel(models[3],_testData[15], false);GuiduuidArray1M.AssertModel(models[4],_testData[16], false);GuiduuidArray1M.AssertModel(models[5],_testData[17], false);GuiduuidArray1M.AssertModel(models[6],_testData[18], false);GuiduuidArray1M.AssertModel(models[7],_testData[19], false);GuiduuidArray1M.AssertModel(models[8],_testData[20], false);GuiduuidArray1M.AssertModel(models[9],_testData[21], false);GuiduuidArray1M.AssertModel(models[10],_testData[22], false);GuiduuidArray1M.AssertModel(models[11],_testData[23], false);GuiduuidArray1M.AssertModel(models[12],_testData[24], false);GuiduuidArray1M.AssertModel(models[13],_testData[25], false);GuiduuidArray1M.AssertModel(models[14],_testData[26], false);GuiduuidArray1M.AssertModel(models[15],_testData[27], false);GuiduuidArray1M.AssertModel(models[16],_testData[28], false);GuiduuidArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
GuiduuidArray1M.AssertModel(models[0],_testData[18], false);GuiduuidArray1M.AssertModel(models[1],_testData[19], false);GuiduuidArray1M.AssertModel(models[2],_testData[20], false);GuiduuidArray1M.AssertModel(models[3],_testData[21], false);GuiduuidArray1M.AssertModel(models[4],_testData[22], false);GuiduuidArray1M.AssertModel(models[5],_testData[23], false);GuiduuidArray1M.AssertModel(models[6],_testData[24], false);GuiduuidArray1M.AssertModel(models[7],_testData[25], false);GuiduuidArray1M.AssertModel(models[8],_testData[26], false);GuiduuidArray1M.AssertModel(models[9],_testData[27], false);GuiduuidArray1M.AssertModel(models[10],_testData[28], false);GuiduuidArray1M.AssertModel(models[11],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatch(connection, 66, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
GuiduuidArray1M.AssertModel(models[0],_testData[12], false);GuiduuidArray1M.AssertModel(models[1],_testData[13], false);GuiduuidArray1M.AssertModel(models[2],_testData[14], false);GuiduuidArray1M.AssertModel(models[3],_testData[15], false);GuiduuidArray1M.AssertModel(models[4],_testData[16], false);GuiduuidArray1M.AssertModel(models[5],_testData[17], false);GuiduuidArray1M.AssertModel(models[6],_testData[18], false);GuiduuidArray1M.AssertModel(models[7],_testData[19], false);GuiduuidArray1M.AssertModel(models[8],_testData[20], false);GuiduuidArray1M.AssertModel(models[9],_testData[21], false);GuiduuidArray1M.AssertModel(models[10],_testData[22], false);GuiduuidArray1M.AssertModel(models[11],_testData[23], false);GuiduuidArray1M.AssertModel(models[12],_testData[24], false);GuiduuidArray1M.AssertModel(models[13],_testData[25], false);GuiduuidArray1M.AssertModel(models[14],_testData[26], false);GuiduuidArray1M.AssertModel(models[15],_testData[27], false);GuiduuidArray1M.AssertModel(models[16],_testData[28], false);GuiduuidArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
GuiduuidArray1M.AssertModel(models[0],_testData[8], false);GuiduuidArray1M.AssertModel(models[1],_testData[9], false);GuiduuidArray1M.AssertModel(models[2],_testData[10], false);GuiduuidArray1M.AssertModel(models[3],_testData[11], false);GuiduuidArray1M.AssertModel(models[4],_testData[12], false);GuiduuidArray1M.AssertModel(models[5],_testData[13], false);GuiduuidArray1M.AssertModel(models[6],_testData[14], false);GuiduuidArray1M.AssertModel(models[7],_testData[15], false);GuiduuidArray1M.AssertModel(models[8],_testData[16], false);GuiduuidArray1M.AssertModel(models[9],_testData[17], false);GuiduuidArray1M.AssertModel(models[10],_testData[18], false);GuiduuidArray1M.AssertModel(models[11],_testData[19], false);GuiduuidArray1M.AssertModel(models[12],_testData[20], false);GuiduuidArray1M.AssertModel(models[13],_testData[21], false);GuiduuidArray1M.AssertModel(models[14],_testData[22], false);GuiduuidArray1M.AssertModel(models[15],_testData[23], false);GuiduuidArray1M.AssertModel(models[16],_testData[24], false);GuiduuidArray1M.AssertModel(models[17],_testData[25], false);GuiduuidArray1M.AssertModel(models[18],_testData[26], false);GuiduuidArray1M.AssertModel(models[19],_testData[27], false);GuiduuidArray1M.AssertModel(models[20],_testData[28], false);GuiduuidArray1M.AssertModel(models[21],_testData[29], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 93);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
GuiduuidArray1M.AssertModel(models[0],_testData[18], false);GuiduuidArray1M.AssertModel(models[1],_testData[19], false);GuiduuidArray1M.AssertModel(models[2],_testData[20], false);GuiduuidArray1M.AssertModel(models[3],_testData[21], false);GuiduuidArray1M.AssertModel(models[4],_testData[22], false);GuiduuidArray1M.AssertModel(models[5],_testData[23], false);GuiduuidArray1M.AssertModel(models[6],_testData[24], false);GuiduuidArray1M.AssertModel(models[7],_testData[25], false);GuiduuidArray1M.AssertModel(models[8],_testData[26], false);GuiduuidArray1M.AssertModel(models[9],_testData[27], false);GuiduuidArray1M.AssertModel(models[10],_testData[28], false);GuiduuidArray1M.AssertModel(models[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
GuiduuidArray1M.AssertModel(models[0],_testData[1], false);GuiduuidArray1M.AssertModel(models[1],_testData[2], false);GuiduuidArray1M.AssertModel(models[2],_testData[3], false);GuiduuidArray1M.AssertModel(models[3],_testData[4], false);GuiduuidArray1M.AssertModel(models[4],_testData[5], false);GuiduuidArray1M.AssertModel(models[5],_testData[6], false);GuiduuidArray1M.AssertModel(models[6],_testData[7], false);GuiduuidArray1M.AssertModel(models[7],_testData[8], false);GuiduuidArray1M.AssertModel(models[8],_testData[9], false);GuiduuidArray1M.AssertModel(models[9],_testData[10], false);GuiduuidArray1M.AssertModel(models[10],_testData[11], false);GuiduuidArray1M.AssertModel(models[11],_testData[12], false);GuiduuidArray1M.AssertModel(models[12],_testData[13], false);GuiduuidArray1M.AssertModel(models[13],_testData[14], false);GuiduuidArray1M.AssertModel(models[14],_testData[15], false);GuiduuidArray1M.AssertModel(models[15],_testData[16], false);GuiduuidArray1M.AssertModel(models[16],_testData[17], false);GuiduuidArray1M.AssertModel(models[17],_testData[18], false);GuiduuidArray1M.AssertModel(models[18],_testData[19], false);GuiduuidArray1M.AssertModel(models[19],_testData[20], false);GuiduuidArray1M.AssertModel(models[20],_testData[21], false);GuiduuidArray1M.AssertModel(models[21],_testData[22], false);GuiduuidArray1M.AssertModel(models[22],_testData[23], false);GuiduuidArray1M.AssertModel(models[23],_testData[24], false);GuiduuidArray1M.AssertModel(models[24],_testData[25], false);GuiduuidArray1M.AssertModel(models[25],_testData[26], false);GuiduuidArray1M.AssertModel(models[26],_testData[27], false);GuiduuidArray1M.AssertModel(models[27],_testData[28], false);GuiduuidArray1M.AssertModel(models[28],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
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
        private void ImportModelInnerConfig()
        {
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
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidArrayuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IGuidArrayuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IGuidArrayuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(GuiduuidArray1M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray1M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IGuidArrayuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                GuiduuidArray1M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IGuidArrayuuidArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IGuidArrayuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                GuiduuidArray1M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[14], false);
                GuiduuidArray1M.AssertModel(models[15],_testData[15], false);
                GuiduuidArray1M.AssertModel(models[16],_testData[16], false);
                GuiduuidArray1M.AssertModel(models[17],_testData[17], false);
                GuiduuidArray1M.AssertModel(models[18],_testData[18], false);
                GuiduuidArray1M.AssertModel(models[19],_testData[19], false);
                GuiduuidArray1M.AssertModel(models[20],_testData[20], false);
                GuiduuidArray1M.AssertModel(models[21],_testData[21], false);
                GuiduuidArray1M.AssertModel(models[22],_testData[22], false);
                GuiduuidArray1M.AssertModel(models[23],_testData[23], false);
                GuiduuidArray1M.AssertModel(models[24],_testData[24], false);
                GuiduuidArray1M.AssertModel(models[25],_testData[25], false);
                GuiduuidArray1M.AssertModel(models[26],_testData[26], false);
                GuiduuidArray1M.AssertModel(models[27],_testData[27], false);
                GuiduuidArray1M.AssertModel(models[28],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_guiduuidarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidArrayuuidArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidArrayuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


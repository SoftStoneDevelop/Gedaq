

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
    Id = 1,
    Value = 
new System.Guid[3]
{
Guid.Parse("fd9db740-4ebf-4769-81f9-7a6b06264ff9"),
Guid.Parse("54583984-be61-4073-bd59-9830f0b0190b"),
Guid.Parse("8134e6ca-a1ed-4f12-b1ef-b791328b57a8"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("b091235f-3e82-440e-9365-ebb81975cbdb"),
Guid.Parse("de00ae3c-ee93-4b4d-b473-bc99387e260f"),
Guid.Parse("ec49589a-5ab4-4863-b119-edafd2cc4d9a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 2,
    Value = 
new System.Guid[4]
{
Guid.Parse("c8450a7c-d5db-4cda-a6e2-9b02894daf8b"),
Guid.Parse("2974246d-956f-453a-b8ef-630c7d61fca2"),
Guid.Parse("cd969bbc-dce0-4862-9be3-343603e710f9"),
Guid.Parse("e388be31-6196-4a8f-8b55-a4fc1f256549"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("da18e873-8540-4bd4-8cd4-a7268d6e9114"),
Guid.Parse("82cd2ad6-7405-4faf-becc-424b5fc6b302"),
Guid.Parse("5c933f80-0071-4c4f-a105-6780a8c04b2d"),
},
},
            new GuiduuidArray1M
{
    Id = 9,
    Value = 
new System.Guid[3]
{
Guid.Parse("80416029-426c-4495-88aa-741cf4f3cd59"),
Guid.Parse("fb8bdc8a-fe5e-4e50-b128-c5e1721411d4"),
Guid.Parse("f342d068-1afa-4d6c-a16e-94a537aac114"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 18,
    Value = 
new System.Guid[3]
{
Guid.Parse("3e89147b-ac95-403f-bf3b-c696d54339ec"),
Guid.Parse("9dabf5e8-3d95-4501-a5ec-a6c699400360"),
Guid.Parse("6fd6d938-2032-432c-9fc2-635e0daaa44d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 3,
    Value = 
new System.Guid[3]
{
Guid.Parse("f8fc516b-25bd-4cd4-a35c-fa725fe1708f"),
Guid.Parse("b81d03fb-833e-4d4b-8b6b-4fdd22f8bfd3"),
Guid.Parse("5511ad0e-214c-40ae-ac8c-46ca47752c52"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2149cbd9-d320-42f6-ab5a-26a3c8da96b0"),
Guid.Parse("7f90fd1a-dac5-4cd0-8dc8-cd2f1e6622bd"),
Guid.Parse("41d2725b-1c61-4234-83c2-ed2a671db60c"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5649d93f-087b-4f28-8653-beb1326d51d1"),
Guid.Parse("37237b50-eb94-439d-87d1-e1446dc7cbf1"),
Guid.Parse("ecad41ea-4789-44a0-80e1-7a0d032afe9b"),
Guid.Parse("882ff4c5-3097-4c66-a0d2-b12e934343b5"),
},
},
            new GuiduuidArray1M
{
    Id = 23,
    Value = 
new System.Guid[3]
{
Guid.Parse("071e678f-d2c3-4029-8eb2-92f2a8e610fb"),
Guid.Parse("fe22888b-da8b-4d47-b6dd-9e4cc4ad5112"),
Guid.Parse("ce836b5e-c0b7-49e2-8544-d5b26c69e03a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ca7d36f6-1e38-4a54-b47f-f76a3a1e6108"),
Guid.Parse("926e3793-33ad-4944-825d-4f127c81a5e9"),
Guid.Parse("f86da711-6037-4503-8333-fb4e3e40622c"),
Guid.Parse("2384e77e-1aa0-41dd-98c8-5d60ccd43dce"),
},
},
            new GuiduuidArray1M
{
    Id = 26,
    Value = 
new System.Guid[3]
{
Guid.Parse("f291ef6c-7547-4d0f-a52f-a332a0f7fd44"),
Guid.Parse("b65c6849-740e-4de5-bde4-ad4b093caf88"),
Guid.Parse("ea616313-51cc-4a5b-ad6d-24007cfce380"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 5,
    Value = 
new System.Guid[3]
{
Guid.Parse("2e0966fa-18a3-498c-a16f-6bcf03f0b8a7"),
Guid.Parse("4e52ece1-0047-4c20-aea4-3d4191f91c17"),
Guid.Parse("da19274f-1b53-4f64-82f8-2a5f90131cef"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("319ae55e-57c5-4b74-9c6e-4c1075a7c475"),
Guid.Parse("bed40130-28e2-4738-b5df-d011ab0aaca2"),
Guid.Parse("7da5f1cd-2054-4a68-b77d-a748415f9cb3"),
Guid.Parse("4ecc51b3-415c-423b-ab9d-ac5cc91e6c3d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b5062a3c-5948-456b-aac5-4cb83e9ef796"),
Guid.Parse("360dc32b-98c3-47bc-b8e3-e8358a45116d"),
Guid.Parse("eb5b2e32-d0ce-4b4d-bb8c-b9a881373099"),
},
},
            new GuiduuidArray1M
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("e57bcded-7a75-4a55-9841-d9f1042a3423"),
Guid.Parse("570b279b-b0be-4e75-9da0-8b313f0c678c"),
Guid.Parse("a4b6a3c1-dd7f-44a0-98b0-27770e2ab95c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("10f29550-b43c-42bf-8bbe-173050f68973"),
Guid.Parse("48b7567b-b8f6-44c9-b1c7-603b7d0d32f2"),
Guid.Parse("ed18f28c-055d-49bd-95b9-e5adf32bc8ed"),
Guid.Parse("7746362f-4340-49ed-a599-577c71e80e7b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ab28ea80-ef9d-4a29-a9e3-cb6f082d06b3"),
Guid.Parse("f126165b-99e4-4298-b21c-10248448e65c"),
Guid.Parse("4b3da6ff-a600-4032-a929-0f3012360f93"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 42,
    Value = 
new System.Guid[4]
{
Guid.Parse("c9e3ad0a-e155-4919-b0e3-a8f1a97f91c5"),
Guid.Parse("167c996c-931a-4f8b-b34f-f0f87680376c"),
Guid.Parse("f4d33841-3944-465b-95eb-97f04397ab86"),
Guid.Parse("9f14832d-3ccc-4688-8ab5-143c3b310683"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 46,
    Value = 
new System.Guid[4]
{
Guid.Parse("e5d5f53b-ddbc-402c-bcbd-00dc74c1cc1c"),
Guid.Parse("27b28506-e5ed-4da1-b33e-e48d2b730d85"),
Guid.Parse("7880f325-1630-4c81-8fd8-e5a461b115d9"),
Guid.Parse("34105a02-8cf7-46c2-83e4-40d91f1ba1ce"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 19,
    Value = 
new System.Guid[4]
{
Guid.Parse("4efb7147-2feb-4ddd-a2a3-0870089fc726"),
Guid.Parse("844abb62-3449-4b5a-b93d-8b91475db54e"),
Guid.Parse("d268c18d-0af1-41b9-b2a8-01e48c4c3cbc"),
Guid.Parse("f818a48e-1cfb-4e20-8e9d-de6878f91a18"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("dd0926ae-79f2-4fbb-98df-7a53cb89b78e"),
Guid.Parse("d29ce4d6-6282-408c-a2c4-6f4aa52e4028"),
Guid.Parse("a545a9f4-6012-415f-a2bb-1b58a705819e"),
},
},
            new GuiduuidArray1M
{
    Id = 50,
    Value = 
new System.Guid[3]
{
Guid.Parse("047f82f1-1a0f-4555-81d6-c0452d121a9c"),
Guid.Parse("1ddff3e4-eccc-4ebe-a881-7956b592834f"),
Guid.Parse("14bff81e-bcb0-4319-8074-415b0e660f80"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("7d2f3b32-a0be-4c04-96bf-8b2f99817bdd"),
Guid.Parse("e68a26e0-3f9d-4e7f-be69-12e38f46dabd"),
Guid.Parse("b922f2c9-8545-470f-8ea4-f58f8ff7584e"),
Guid.Parse("f5d704ce-d4fb-4fe6-88e5-d192cf383920"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("33dac38e-6a6c-4120-9916-7202eba76d7e"),
Guid.Parse("e33334c7-d694-4065-bf84-edcb09b65315"),
Guid.Parse("00649e41-05e8-479a-91b0-e22c3e5ec118"),
Guid.Parse("fcef414e-3b5f-4b51-a4b8-322fded77899"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7f24eaf6-e9a4-4b1d-9ff5-e5c1ad331382"),
Guid.Parse("24a27e1d-4bdb-4daf-98c3-9e44c63f6694"),
Guid.Parse("f3b8ca3f-962f-4ba3-99dd-2952cddd280d"),
Guid.Parse("69d76c0c-cd6b-446b-b2c9-1bd609ee8876"),
},
},
            new GuiduuidArray1M
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("cf6777c3-037f-4f11-aa59-785aa24595eb"),
Guid.Parse("c9dbe84a-e164-4a53-8a88-8ba70d6fa109"),
Guid.Parse("900a8032-c970-4edd-bf2b-64fd5badf668"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("24a2a61d-2805-4c13-8212-e30bfdb24e1f"),
Guid.Parse("0d694d01-14b6-47bd-8ba3-ab83abc31da0"),
Guid.Parse("2bcaf59d-bfe9-433d-8248-3456518ecf7d"),
Guid.Parse("ee72c616-ee70-4cb9-b369-6d1706e75d03"),
},
},
            new GuiduuidArray1M
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("117f6dd2-6593-4dc3-b1cd-b78ccc05c110"),
Guid.Parse("3b5f5983-5af0-401a-a562-2bfd64ac83c3"),
Guid.Parse("c43bd1eb-a54e-4bbf-87c0-f16c38d62154"),
Guid.Parse("11d45427-75eb-4b5f-8cdc-6cb40ac20fbc"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 30,
    Value = 
new System.Guid[4]
{
Guid.Parse("d0acbb84-d3d8-494a-aa1f-467cf256df9c"),
Guid.Parse("9ac0aa3b-3ae9-4a63-8ee1-b8b98648572c"),
Guid.Parse("c5421f0c-9f90-4547-beed-c2c12f457f6b"),
Guid.Parse("7d53ff51-60c8-450d-b5a0-60e6f139914b"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 67,
    Value = 
new System.Guid[3]
{
Guid.Parse("862e85b7-3cb0-4e6e-a892-e16a13b09699"),
Guid.Parse("d1739cd0-2adf-4694-94a0-3096f7fa4108"),
Guid.Parse("ec23027e-7f54-4bd8-a663-9baf29d32024"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("afeabe13-8a14-45ed-8aa9-ff0c00f1cb43"),
Guid.Parse("34af3253-05b5-4467-88dd-895c69ca4aaa"),
Guid.Parse("b3dbe87c-c53e-4ad6-b11f-2fb9a719141c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("dbf97e07-7130-4a2b-9472-460d460bfaea"),
Guid.Parse("284e9076-41a8-4131-bec7-680e07dce21e"),
Guid.Parse("774739a0-9a72-4d78-a547-85532f24bf50"),
Guid.Parse("c9c4efbb-18bf-4ddd-82f0-5445c6933c94"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("578c41b2-5c1a-4d1a-ab74-f22710240a6c"),
Guid.Parse("992f0bbd-01f0-4190-9206-0a69e652cc0f"),
Guid.Parse("24d60f05-73c8-401f-8aa2-ad3005ddb839"),
},
},
            new GuiduuidArray1M
{
    Id = 76,
    Value = 
new System.Guid[4]
{
Guid.Parse("83a8e2d2-d7d1-4004-b2d2-d710e97e22c7"),
Guid.Parse("c87f677c-1a52-4e5c-b730-58b76b31336c"),
Guid.Parse("0d37f69d-3bd4-46fd-96bb-93d7e5f1e130"),
Guid.Parse("a37ea4ff-afe2-4eb1-84bf-20b381a547a1"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a51ad72e-17b5-4a4b-b427-3162431437e6"),
Guid.Parse("ac7da690-cb42-4165-be15-ca6e09bc3693"),
Guid.Parse("34be13e0-48db-480c-8073-974e6e90f0dc"),
Guid.Parse("1a070577-a100-4bd7-9832-3f68767332b2"),
},
},
            new GuiduuidArray1M
{
    Id = 80,
    Value = 
new System.Guid[4]
{
Guid.Parse("c67a960b-28f5-4f6b-9c78-9bd8df8bf6f0"),
Guid.Parse("ff979547-a983-44c3-b683-409eeac5f836"),
Guid.Parse("88891de0-3d0b-426a-a37e-d3f035d0511a"),
Guid.Parse("94e528e0-7080-4f5c-bd84-35e47a49b14d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 39,
    Value = 
new System.Guid[4]
{
Guid.Parse("d447a207-f04c-4323-bde0-2d39018588ae"),
Guid.Parse("d8119ef3-b03d-41a4-977a-767bc47147ef"),
Guid.Parse("410c0c1a-1da8-4f4f-9b10-ed79dea4acff"),
Guid.Parse("bc8e8628-4bab-4ab4-b23f-9f14bd4befb7"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("81b0c701-5144-4670-8dd5-cc39ba4fe766"),
Guid.Parse("23e00932-0c49-4c25-beaa-f38466f52cbe"),
Guid.Parse("8d1b42e9-9aaa-4fa4-8b0b-b9f1bacb8326"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 87,
    Value = 
new System.Guid[4]
{
Guid.Parse("362af199-840f-4f31-8745-7b4526a6d745"),
Guid.Parse("2cadaaeb-8754-4216-a08c-88573565e427"),
Guid.Parse("570d7a8c-e9d0-4b24-ba43-fe1130fbc497"),
Guid.Parse("c30a4fe2-a650-4362-84ca-262510650603"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 95,
    Value = 
new System.Guid[4]
{
Guid.Parse("b785672c-070b-4bc1-900a-ad1c7ace7320"),
Guid.Parse("547f4970-9dbe-4fa1-a912-a54cd534d3b2"),
Guid.Parse("2001d197-1a54-42f3-a15d-dc11436130ac"),
Guid.Parse("dfbbcc3e-e4f4-4404-9a11-c88fd62f0798"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 42,
    Value = 
new System.Guid[3]
{
Guid.Parse("d20452cd-2d1f-4f94-ad8b-848c7ed80ae2"),
Guid.Parse("82d2498e-34c6-4bdb-9029-715947faaaa0"),
Guid.Parse("30238b72-f8cc-4a92-af02-eca3a694283b"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 98,
    Value = 
new System.Guid[3]
{
Guid.Parse("1c059208-3b91-4c8b-93ea-13152a870b79"),
Guid.Parse("2e6300de-803c-4af4-8edc-54616af2ed11"),
Guid.Parse("1a44ef7b-9833-43d3-a6f0-dd594a84321f"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 102,
    Value = 
new System.Guid[4]
{
Guid.Parse("85e37427-ade1-4390-8d72-243c8a90d1ca"),
Guid.Parse("6dd579a1-b201-4b94-91a0-6b5295883548"),
Guid.Parse("1bf0348d-2f23-4e58-b6e2-f1f916164e85"),
Guid.Parse("3d00da5c-9ff4-4227-9b32-4f2999ecf124"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 48,
    Value = 
new System.Guid[4]
{
Guid.Parse("9f4f2c33-2e47-4b31-bdf8-c84c361868ab"),
Guid.Parse("9e67b163-ab60-4d50-9d33-678401abc0b9"),
Guid.Parse("82cb8e71-1d28-49e9-9351-ceaa8ae55d7e"),
Guid.Parse("ffb10e72-6faa-40d7-b6cc-3b0d7244af67"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f64c7c4b-f5ab-4f3f-ae32-bca605d6c7b2"),
Guid.Parse("7520f4ef-9258-4d8f-8e35-b0d190cc1533"),
Guid.Parse("146b7110-c9a4-4ae0-b83b-3e784ed044a7"),
Guid.Parse("aa0263e2-8231-4199-8bd2-6ee2082176d4"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ee952ef9-6923-492c-949a-b8428a4bb91d"),
Guid.Parse("2d4e36a2-ad35-45af-9be1-5bfe77531b84"),
Guid.Parse("68f831d3-e95d-440b-b9c4-fcc507e5c671"),
Guid.Parse("a4c0bac8-721f-4015-81d1-703e7e96fd48"),
},
},
            new GuiduuidArray1M
{
    Id = 108,
    Value = 
new System.Guid[4]
{
Guid.Parse("d32be04c-336e-4639-b744-7e8751e3e0d3"),
Guid.Parse("0f67c374-cb3e-4251-99fd-70cde8a8dc1c"),
Guid.Parse("3a95ddc0-0f92-4f66-8452-5e59538ee51e"),
Guid.Parse("8e508a6d-ab15-42d1-90ee-d75abd5b9bd6"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 114,
    Value = 
new System.Guid[4]
{
Guid.Parse("47dd7e8b-5d13-47d3-b090-6e9c85c12001"),
Guid.Parse("6bf998f0-1dbf-4475-a0a6-f874f749cc89"),
Guid.Parse("02aa1e5e-b169-4e51-bc0f-219f92ced5a5"),
Guid.Parse("77e9959d-c298-4822-8a25-e2148a9a23b4"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 56,
    Value = 
new System.Guid[4]
{
Guid.Parse("7d523c9a-b089-40b3-afc6-811a8b53ac59"),
Guid.Parse("72715722-73dc-40c2-8afe-5d36acf28c98"),
Guid.Parse("a9f1dd56-21ff-4dbd-93d1-13621b9472d1"),
Guid.Parse("faf3ef51-b89a-4b0f-9b6a-c0cd607f6cf6"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("18d865f3-fa96-4d43-a52b-1a4d6decd060"),
Guid.Parse("e71e116c-87fd-4703-b861-417f7445e8eb"),
Guid.Parse("bbcf8c88-ca15-42b4-b0c2-f2e4649cfdad"),
Guid.Parse("224a9f12-6e69-49ed-b5a0-7751d7af530d"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("40f9d451-27bd-40bf-8f0d-d0ce1d90ed80"),
Guid.Parse("df56b17c-71db-4a0d-860f-4bc77ad1976a"),
Guid.Parse("76c97968-8eaf-4774-a508-b873c5803b1d"),
},
},
            new GuiduuidArray1M
{
    Id = 120,
    Value = 
new System.Guid[3]
{
Guid.Parse("b332d81f-2f67-48b2-b7a5-cc1975dd1ecc"),
Guid.Parse("19197a4a-17c5-4cd0-bf6d-1f3b09d0f3de"),
Guid.Parse("993535f2-7c5c-47f5-94fd-0c60b5a69c8d"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 121,
    Value = 
new System.Guid[4]
{
Guid.Parse("32f11356-f3f4-42d3-ad33-366571d3b1e6"),
Guid.Parse("6d4eeecf-7b49-4134-b805-a5ee05e74ae3"),
Guid.Parse("08872e5d-87e5-4d64-a4eb-9130a3997bc1"),
Guid.Parse("69225033-3c3e-499e-b3c2-bad8ecc99d4b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 58,
    Value = 
new System.Guid[4]
{
Guid.Parse("0955fb4d-3c56-465d-a021-3f2db050329b"),
Guid.Parse("4c565514-6c2c-4380-a21d-a11b89f57c66"),
Guid.Parse("53c6e731-e0d0-4b6e-859a-8ea844ce8695"),
Guid.Parse("7bcd952c-6e30-481a-8076-6d4e507cc59b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b645e177-16e8-44b0-b392-d880863b38e1"),
Guid.Parse("67be0b03-21eb-455a-9f51-773096bf5039"),
Guid.Parse("a57f5dae-7381-43b1-ba2a-13fba53e90ac"),
},
},
            new GuiduuidArray1M
{
    Id = 122,
    Value = 
new System.Guid[4]
{
Guid.Parse("dc101b5f-91e0-4d99-acde-a59024c8153d"),
Guid.Parse("e596d3fa-a250-4e8f-b00d-bcac902bb5a7"),
Guid.Parse("85921ec9-86a9-489f-8644-2b7b9645a96c"),
Guid.Parse("55e5c9bd-edd7-42b7-b57c-2690b5db77f7"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("94c7f3f4-f21c-41dc-8ef3-a4ce35c7ff5d"),
Guid.Parse("23e7a68c-e012-482d-967f-12c889f947c2"),
Guid.Parse("c7b3a05e-2b72-4eab-811a-60734cd277fa"),
},
},
            new GuiduuidArray1M
{
    Id = 130,
    Value = 
new System.Guid[4]
{
Guid.Parse("f755b299-509a-47fd-b587-a2a94e95e550"),
Guid.Parse("5326f48e-b781-4ec1-bf00-86218a288cfa"),
Guid.Parse("0bff983b-80b2-4b05-9099-407d8382a90f"),
Guid.Parse("69d5ff87-b05b-4e2c-b1ec-58bf40b77741"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 66,
    Value = 
new System.Guid[4]
{
Guid.Parse("d847a85f-7094-4c65-86e1-f9bc149e5431"),
Guid.Parse("dd8ef53f-6f63-4499-9cee-c821fd99518c"),
Guid.Parse("4714b14b-6e80-4e9b-8c0c-42717e059285"),
Guid.Parse("c17a536d-3f4a-4271-a44a-17bbe892451f"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 132,
    Value = 
new System.Guid[3]
{
Guid.Parse("17b33bd5-78c4-4e35-a80b-bb104879bf89"),
Guid.Parse("9de57950-cc21-4409-ae85-3f09f10c0394"),
Guid.Parse("fe332a1e-fddd-42c2-8986-fcefbf051826"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8e0aa03c-7abd-4ca9-9103-3a780ee27754"),
Guid.Parse("77566237-814a-4938-98f0-9260d52abdc8"),
Guid.Parse("e8ed6415-60a1-491d-be06-b5b8116a48d2"),
Guid.Parse("f22262a3-a300-4ce1-9e3c-f89b9be55180"),
},
},
            new GuiduuidArray1M
{
    Id = 134,
    Value = 
new System.Guid[3]
{
Guid.Parse("ab87afdf-da5d-4d76-bc36-b1e9a989440a"),
Guid.Parse("60080c44-f27d-4039-8abd-81cec1e44b82"),
Guid.Parse("2dbc812a-f08f-42b4-8b0d-d8697a75c53a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 71,
    Value = 
new System.Guid[4]
{
Guid.Parse("a80f6abb-a55e-442c-97ea-d62d9c63ceab"),
Guid.Parse("b0663f87-a354-431b-9fa6-f465d0a5db7f"),
Guid.Parse("83f4a93c-216f-41ac-b32f-39f93e37755e"),
Guid.Parse("b394eec9-c4cb-4748-9c40-edf6a0df59a4"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f977467e-ca76-4dd3-991d-93c8f9a30f97"),
Guid.Parse("f9372681-f12a-4e10-a451-b45e044b8dc7"),
Guid.Parse("83e2679d-19fa-4ad6-98fa-21ba619ce5a0"),
Guid.Parse("aa4525aa-7df9-495c-b091-f8531877b867"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e3bc5838-406d-42c8-b837-28c8a834887a"),
Guid.Parse("6d79fc66-0618-4533-981e-01051e268fa9"),
Guid.Parse("36f7115d-e5da-482a-8ab6-11bd4a81fb01"),
Guid.Parse("5dd33b9d-16eb-485d-97b8-dc030e1ad18b"),
},
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
Guid.Parse("ca7d36f6-1e38-4a54-b47f-f76a3a1e6108"),
Guid.Parse("926e3793-33ad-4944-825d-4f127c81a5e9"),
Guid.Parse("f86da711-6037-4503-8333-fb4e3e40622c"),
Guid.Parse("2384e77e-1aa0-41dd-98c8-5d60ccd43dce"),
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
new System.Guid[3]
{
Guid.Parse("b5062a3c-5948-456b-aac5-4cb83e9ef796"),
Guid.Parse("360dc32b-98c3-47bc-b8e3-e8358a45116d"),
Guid.Parse("eb5b2e32-d0ce-4b4d-bb8c-b9a881373099"),
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
Guid.Parse("dd0926ae-79f2-4fbb-98df-7a53cb89b78e"),
Guid.Parse("d29ce4d6-6282-408c-a2c4-6f4aa52e4028"),
Guid.Parse("a545a9f4-6012-415f-a2bb-1b58a705819e"),
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
new System.Guid[4]
{
Guid.Parse("7f24eaf6-e9a4-4b1d-9ff5-e5c1ad331382"),
Guid.Parse("24a27e1d-4bdb-4daf-98c3-9e44c63f6694"),
Guid.Parse("f3b8ca3f-962f-4ba3-99dd-2952cddd280d"),
Guid.Parse("69d76c0c-cd6b-446b-b2c9-1bd609ee8876"),
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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IGuidArrayuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IGuidArrayuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IGuidArrayuuidArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IGuidArrayuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
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
                        Assert.That(models, Has.Count.EqualTo(11));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[6], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[23],_testData[29], false);
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
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
                        Assert.That(models, Has.Count.EqualTo(21));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[29], false);
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

                var models = await ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
GuiduuidArray1M.AssertModel(models[0],_testData[17], false);GuiduuidArray1M.AssertModel(models[1],_testData[18], false);GuiduuidArray1M.AssertModel(models[2],_testData[19], false);GuiduuidArray1M.AssertModel(models[3],_testData[20], false);GuiduuidArray1M.AssertModel(models[4],_testData[21], false);GuiduuidArray1M.AssertModel(models[5],_testData[22], false);GuiduuidArray1M.AssertModel(models[6],_testData[23], false);GuiduuidArray1M.AssertModel(models[7],_testData[24], false);GuiduuidArray1M.AssertModel(models[8],_testData[25], false);GuiduuidArray1M.AssertModel(models[9],_testData[26], false);GuiduuidArray1M.AssertModel(models[10],_testData[27], false);GuiduuidArray1M.AssertModel(models[11],_testData[28], false);GuiduuidArray1M.AssertModel(models[12],_testData[29], false);
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

                var models =  ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(15));
GuiduuidArray1M.AssertModel(models[0],_testData[15], false);GuiduuidArray1M.AssertModel(models[1],_testData[16], false);GuiduuidArray1M.AssertModel(models[2],_testData[17], false);GuiduuidArray1M.AssertModel(models[3],_testData[18], false);GuiduuidArray1M.AssertModel(models[4],_testData[19], false);GuiduuidArray1M.AssertModel(models[5],_testData[20], false);GuiduuidArray1M.AssertModel(models[6],_testData[21], false);GuiduuidArray1M.AssertModel(models[7],_testData[22], false);GuiduuidArray1M.AssertModel(models[8],_testData[23], false);GuiduuidArray1M.AssertModel(models[9],_testData[24], false);GuiduuidArray1M.AssertModel(models[10],_testData[25], false);GuiduuidArray1M.AssertModel(models[11],_testData[26], false);GuiduuidArray1M.AssertModel(models[12],_testData[27], false);GuiduuidArray1M.AssertModel(models[13],_testData[28], false);GuiduuidArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 60, query1, 130, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[29], false);
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 1, query1, 87, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[1], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[2], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[3], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[4], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[5], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[6], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[23],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[24],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[25],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[26],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[27],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[29], false);
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
                var models = await ((IGuidArrayuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 8, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
GuiduuidArray1M.AssertModel(models[0],_testData[2], false);GuiduuidArray1M.AssertModel(models[1],_testData[3], false);GuiduuidArray1M.AssertModel(models[2],_testData[4], false);GuiduuidArray1M.AssertModel(models[3],_testData[5], false);GuiduuidArray1M.AssertModel(models[4],_testData[6], false);GuiduuidArray1M.AssertModel(models[5],_testData[7], false);GuiduuidArray1M.AssertModel(models[6],_testData[8], false);GuiduuidArray1M.AssertModel(models[7],_testData[9], false);GuiduuidArray1M.AssertModel(models[8],_testData[10], false);GuiduuidArray1M.AssertModel(models[9],_testData[11], false);GuiduuidArray1M.AssertModel(models[10],_testData[12], false);GuiduuidArray1M.AssertModel(models[11],_testData[13], false);GuiduuidArray1M.AssertModel(models[12],_testData[14], false);GuiduuidArray1M.AssertModel(models[13],_testData[15], false);GuiduuidArray1M.AssertModel(models[14],_testData[16], false);GuiduuidArray1M.AssertModel(models[15],_testData[17], false);GuiduuidArray1M.AssertModel(models[16],_testData[18], false);GuiduuidArray1M.AssertModel(models[17],_testData[19], false);GuiduuidArray1M.AssertModel(models[18],_testData[20], false);GuiduuidArray1M.AssertModel(models[19],_testData[21], false);GuiduuidArray1M.AssertModel(models[20],_testData[22], false);GuiduuidArray1M.AssertModel(models[21],_testData[23], false);GuiduuidArray1M.AssertModel(models[22],_testData[24], false);GuiduuidArray1M.AssertModel(models[23],_testData[25], false);GuiduuidArray1M.AssertModel(models[24],_testData[26], false);GuiduuidArray1M.AssertModel(models[25],_testData[27], false);GuiduuidArray1M.AssertModel(models[26],_testData[28], false);GuiduuidArray1M.AssertModel(models[27],_testData[29], false);
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
                var models =  ((IGuidArrayuuidArray)this).DbConnectionSelectModel(connection, 0);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatch(connection, 108, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
GuiduuidArray1M.AssertModel(models[0],_testData[23], false);GuiduuidArray1M.AssertModel(models[1],_testData[24], false);GuiduuidArray1M.AssertModel(models[2],_testData[25], false);GuiduuidArray1M.AssertModel(models[3],_testData[26], false);GuiduuidArray1M.AssertModel(models[4],_testData[27], false);GuiduuidArray1M.AssertModel(models[5],_testData[28], false);GuiduuidArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
GuiduuidArray1M.AssertModel(models[0],_testData[28], false);GuiduuidArray1M.AssertModel(models[1],_testData[29], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
GuiduuidArray1M.AssertModel(models[0],_testData[25], false);GuiduuidArray1M.AssertModel(models[1],_testData[26], false);GuiduuidArray1M.AssertModel(models[2],_testData[27], false);GuiduuidArray1M.AssertModel(models[3],_testData[28], false);GuiduuidArray1M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
GuiduuidArray1M.AssertModel(models[0],_testData[21], false);GuiduuidArray1M.AssertModel(models[1],_testData[22], false);GuiduuidArray1M.AssertModel(models[2],_testData[23], false);GuiduuidArray1M.AssertModel(models[3],_testData[24], false);GuiduuidArray1M.AssertModel(models[4],_testData[25], false);GuiduuidArray1M.AssertModel(models[5],_testData[26], false);GuiduuidArray1M.AssertModel(models[6],_testData[27], false);GuiduuidArray1M.AssertModel(models[7],_testData[28], false);GuiduuidArray1M.AssertModel(models[8],_testData[29], false);
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


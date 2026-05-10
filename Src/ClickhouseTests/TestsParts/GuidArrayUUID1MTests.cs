

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
    internal partial interface IGuidArrayArrayUUID
    {
    }
    
    internal partial class GuidArrayArrayUUID : IGuidArrayArrayUUID
    {


#region TestData

        private readonly GuidArrayUUID1M[] _testData = new GuidArrayUUID1M[]
        {
            new GuidArrayUUID1M
{
    Id = 3,
    Value = 
new System.Guid[4]
{
Guid.Parse("ba4937bb-dd12-4777-9ef1-2cfba316a8b8"),
Guid.Parse("363e91c2-695b-48c2-84c4-84cee582c4fb"),
Guid.Parse("d6445af1-c9b7-462c-84bd-637eec2924c2"),
Guid.Parse("f831f4ae-a706-414a-bb48-056a4a7ec451"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 1,
    Value = 
new System.Guid[4]
{
Guid.Parse("319bf268-960e-4c4d-bfb0-e64d62249c26"),
Guid.Parse("514bd6d8-f5a4-4f18-9910-7686337cf36d"),
Guid.Parse("bae64329-1475-4a93-b70b-0c3227cd92cb"),
Guid.Parse("035b01c6-7b14-4b28-85f5-fc5dc19adc00"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 6,
    Value = 
new System.Guid[3]
{
Guid.Parse("b4de2a86-f7ea-44ac-9d03-bebb6896b85e"),
Guid.Parse("1938417c-212b-4e7f-92b3-62011a4258bf"),
Guid.Parse("437d6170-a180-4f0a-8ef0-2ea5fdc0edc4"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("7e9b13a0-a0fb-402e-a9e4-821070bfd7af"),
Guid.Parse("9aad9a89-e407-48d5-9ec5-2862a8e2e8cf"),
Guid.Parse("80e9cf4e-aa70-4b93-a7a7-ff0e15ac1fe8"),
Guid.Parse("155e21ec-4f4d-4ab8-93e8-a625c32c61fe"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 15,
    Value = 
new System.Guid[4]
{
Guid.Parse("dec04b9a-0a4c-47b4-b338-7ab502aaa6a8"),
Guid.Parse("2d65f3a1-091e-4ba6-aa36-95583c2a9345"),
Guid.Parse("b987b569-a53c-4a3e-8532-090a1ddf3f3f"),
Guid.Parse("25ef2b91-a5da-4701-8c33-e8cd0fdc17a0"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 17,
    Value = 
new System.Guid[4]
{
Guid.Parse("7e764ef2-96c9-415e-942c-2058b7d78b8a"),
Guid.Parse("ed8f69ca-c863-44ca-8ce6-338d5d3414f6"),
Guid.Parse("4f937fe2-923d-433b-ac3c-f1a29219e7d7"),
Guid.Parse("1457fa8f-c64f-4de2-bf36-11b8c0e4cbad"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 19,
    Value = 
new System.Guid[4]
{
Guid.Parse("e77240a5-7387-4baa-a343-94ee52cb0858"),
Guid.Parse("1f78f5b6-5bd9-489c-ab79-35dc5d9c2409"),
Guid.Parse("dcb42522-49de-402f-ab3c-e9de088d6a1a"),
Guid.Parse("ffd7d32c-61dc-4835-82a4-a0a877ca1833"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 24,
    Value = 
new System.Guid[4]
{
Guid.Parse("c2eace68-1690-450c-a749-da2392ab7df2"),
Guid.Parse("b19e5c5f-527b-406e-9a95-e349400ce23f"),
Guid.Parse("293a9ac9-3c0a-4c89-a63c-ee4433d7b2db"),
Guid.Parse("243a385d-6142-463d-862d-9e0ed2580387"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("90bc5481-4f32-417a-8a90-cd88cde942df"),
Guid.Parse("608fc3d0-08b1-44e5-b7a4-0a1f78cf2a63"),
Guid.Parse("f6516be0-20dc-4a35-b806-ca1638fb2f1e"),
},
},
            new GuidArrayUUID1M
{
    Id = 26,
    Value = 
new System.Guid[4]
{
Guid.Parse("2e5d5d21-a6db-4386-8c47-531b488c61c0"),
Guid.Parse("1951b8c0-ecd6-4ebf-9cd3-43d502506e8d"),
Guid.Parse("38cb9637-a1d0-4007-88fe-4fb4880e4466"),
Guid.Parse("b681b7f0-6f8f-47c7-b379-49e6df52e57c"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 27,
    Value = 
new System.Guid[4]
{
Guid.Parse("af956504-f136-4965-9d4f-7c89c80d3f94"),
Guid.Parse("5d4be70d-d4c5-4967-b0ed-5b223ffaa5a4"),
Guid.Parse("c437209e-291a-4992-b01f-b125774b562d"),
Guid.Parse("5d9d0fe0-d11d-4f64-a1f0-c6b9752db036"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6a10c6ff-3a7d-40ba-8a86-4ac6a01822ee"),
Guid.Parse("a5c9372b-d015-46f4-84df-d52982b0cb2f"),
Guid.Parse("3b118829-4802-45e3-90a0-ddcd27f10567"),
},
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 32,
    Value = 
new System.Guid[4]
{
Guid.Parse("6d7175c6-0479-4c24-bb36-978a4f5a01ab"),
Guid.Parse("91c3bdd1-19bf-460a-a828-1c196894e742"),
Guid.Parse("adf31653-1ff2-4107-aff1-652a66fb94ab"),
Guid.Parse("12c67aaa-1272-48a3-85e0-41e02284a1b0"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 35,
    Value = 
new System.Guid[4]
{
Guid.Parse("88902272-3dab-4be3-b6e5-e32c386cc9cd"),
Guid.Parse("12521833-5e8c-4f4f-823b-b2bd68c766af"),
Guid.Parse("607bcdae-c338-4b98-a5bb-39c120a0eec4"),
Guid.Parse("ab5ed23c-3322-4a95-b66f-4f615a33d78a"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a69cce84-307b-4467-a246-ccd916aba82e"),
Guid.Parse("d2b45f6e-cda2-40d7-ba3c-7d15f541fa26"),
Guid.Parse("034a8edc-3d2b-4e6a-975f-2d3b181da178"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("af622e73-c8ce-4fdf-9775-e2c7b04c2b37"),
Guid.Parse("59334f81-af82-46ef-a093-879c1cc3530c"),
Guid.Parse("a3edb219-3d5c-4cb0-9fd7-f0f58838567d"),
Guid.Parse("266437df-f708-4544-b421-c4bf96d93aa5"),
},
},
            new GuidArrayUUID1M
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("2c296117-0f11-4d88-bbd4-60ea01dfd6c8"),
Guid.Parse("cdba4855-2b69-4ddb-b5bf-e1edb394dd72"),
Guid.Parse("01cfdc05-1243-47fd-a644-4f61fb3f0b9e"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("54de645b-2e5a-4131-8335-4ccb9b18ebcc"),
Guid.Parse("62337868-3210-4b9e-8c79-d1b32007e6ec"),
Guid.Parse("84633904-6737-47fb-83f8-98985db2a29d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("10ccf90c-38ea-492c-b7f2-07b5c0924fc3"),
Guid.Parse("1c3a9f71-4b7d-4b18-bf80-4bc632d4fbf1"),
Guid.Parse("b19aa03f-7e0f-40ad-9140-6773da82cd9c"),
},
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 38,
    Value = 
new System.Guid[3]
{
Guid.Parse("349a897a-c969-4e9b-b90e-4bb08ae4e232"),
Guid.Parse("a2c3cf3e-e4a2-40c7-b8e6-750cd761ec3a"),
Guid.Parse("12df765f-938d-4b4c-b384-00ffbdb7e9a1"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 45,
    Value = 
new System.Guid[3]
{
Guid.Parse("ff491098-2696-4704-b881-8bf42e252efd"),
Guid.Parse("285b446c-f038-4c2a-a96e-e1d61d6db547"),
Guid.Parse("16b25240-bd3b-405c-9206-0275c0a58c92"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4dffd908-d0d8-4c9e-9595-5fa1d8648c1a"),
Guid.Parse("d152768c-05a8-4400-89ea-49ee9f48d978"),
Guid.Parse("faef8fa9-b8be-4baa-bd2c-653eb87c7793"),
Guid.Parse("92a7d193-0130-4d02-9503-984683b112a8"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("dfc16a4d-8b1a-43ed-87f7-2945149eae06"),
Guid.Parse("6aa39146-6b1c-44f5-b383-de2b0bc01631"),
Guid.Parse("0efe6b75-1d77-429d-81e0-1b6b08d569ae"),
Guid.Parse("0e2312d8-1a43-4710-9aff-88e174da00ff"),
},
},
            new GuidArrayUUID1M
{
    Id = 46,
    Value = 
new System.Guid[3]
{
Guid.Parse("e1850d8c-8574-432f-8936-6726670584e3"),
Guid.Parse("d738fc20-6b8f-4908-879e-fa74b019ed9c"),
Guid.Parse("249bf42e-eb09-4b95-a77b-e10f2d7388a3"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 47,
    Value = 
new System.Guid[4]
{
Guid.Parse("fd134dc5-6a7c-44cd-a444-f39cf1ff2305"),
Guid.Parse("0541b943-9835-484c-adfb-62f6614a9daf"),
Guid.Parse("9f71434d-6b1c-4c04-b3d5-0925ae1364a8"),
Guid.Parse("bfba3b6d-f217-4713-a145-b470c69768b9"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4f946824-96fa-4e51-9b9a-0033643001f2"),
Guid.Parse("e6d5b66b-b920-4c7d-89a0-f757b1a1a330"),
Guid.Parse("1de92935-debd-49ba-abac-8cfbd21a5682"),
Guid.Parse("66ec05d2-c189-4683-9343-fe2f520e6631"),
},
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 53,
    Value = 
new System.Guid[3]
{
Guid.Parse("e5851efe-3229-4a27-9749-46b12972d400"),
Guid.Parse("0311e4d4-b7f8-4073-88a9-db4d917aa03d"),
Guid.Parse("5d35ee56-3a17-42ab-a943-681cbaf13be1"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 51,
    Value = 
new System.Guid[4]
{
Guid.Parse("5d55210f-c0e5-4187-a7b0-e3e9dc1f67c3"),
Guid.Parse("5b5d0e5c-7f2e-4dd9-a72b-6cb19b789d1a"),
Guid.Parse("e9dec074-1e76-42a4-a2eb-31680669d34c"),
Guid.Parse("acb929e1-bb28-423c-99ef-4240f3dc5352"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("74392e9f-65fa-40b3-946a-79581215953c"),
Guid.Parse("0a669b35-e753-43fb-8993-63f6bb759758"),
Guid.Parse("83a69aae-3744-4aef-a22b-42a44d394f43"),
Guid.Parse("d88fa707-fc16-41c0-b32f-050e4ca1d2b3"),
},
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 55,
    Value = 
new System.Guid[3]
{
Guid.Parse("5675e757-f393-4e3b-831d-d04c4661df1d"),
Guid.Parse("82b4675e-e648-475f-a846-308c7649deb9"),
Guid.Parse("2bcf6b4a-4358-4875-89fd-6d62e5e6cfd7"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 58,
    Value = 
new System.Guid[3]
{
Guid.Parse("eb695ba1-44dd-4465-94ca-aa1b8279f995"),
Guid.Parse("4d9ce624-672b-4869-a109-4e326c63aafa"),
Guid.Parse("aba760ab-fe86-4b60-b615-38942ca8fc3c"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("94608575-f70f-4bb1-9373-9466b49a24d8"),
Guid.Parse("d75cd7b2-b2f6-4647-9278-604cf8b04f04"),
Guid.Parse("aae0ad38-2956-42fa-8e94-7afa07656d75"),
Guid.Parse("29d40d15-828b-4c22-9346-f41b21a11c99"),
},
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 58,
    Value = 
new System.Guid[4]
{
Guid.Parse("d0b8bed4-4411-4a06-8f4f-17eb258db233"),
Guid.Parse("82a2507e-f919-4000-9bbc-996cc1f44490"),
Guid.Parse("4b18988d-b5d8-4c2b-901b-32d2322be241"),
Guid.Parse("150f3010-a921-4f89-ad43-c34e1e7bac59"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 59,
    Value = 
new System.Guid[4]
{
Guid.Parse("547ca304-3c7d-478a-81b0-bf6cf2328fa6"),
Guid.Parse("675e935f-e314-43b8-b0d0-92b74c146b48"),
Guid.Parse("be33e234-d9c9-4f8a-b804-161e12b7dc5f"),
Guid.Parse("ec520f7f-2113-49eb-a2f3-f5a0f22807e6"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d9222911-7431-4a6f-aea3-020495c84df3"),
Guid.Parse("57018cb6-6a40-4507-aebc-e80fc4efe281"),
Guid.Parse("da37d02e-8358-4368-8442-35518bc7a19a"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c6a49d5f-84e0-470a-8b60-a45bf8ec675f"),
Guid.Parse("e319048f-0a50-4004-a755-a366ad720a33"),
Guid.Parse("f7648874-40f6-4fbc-b413-8f9d5937a484"),
Guid.Parse("e2075afe-4037-400f-bb62-4a995829bd50"),
},
},
            new GuidArrayUUID1M
{
    Id = 67,
    Value = 
new System.Guid[4]
{
Guid.Parse("f991e7bd-0011-4f56-8f5f-4cc36850c601"),
Guid.Parse("de3f9ad4-c3d9-4d0b-b565-733fe4565ea8"),
Guid.Parse("1d6b8e24-3852-45ee-9a67-217b4125db84"),
Guid.Parse("b7575e49-cf9d-4030-9ab4-f76d35e5c3e3"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 67,
    Value = 
new System.Guid[4]
{
Guid.Parse("4b5289b6-6bdc-42e0-9696-be2bce70c127"),
Guid.Parse("ad9b9f10-29b0-43a4-b8b2-61366b337288"),
Guid.Parse("1c33380c-8940-43a9-bcd1-15ff0c2f6fe1"),
Guid.Parse("09332dfd-88d2-4c22-8e5b-90a2d725fd35"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("59b9b0d0-ad1f-47c7-8578-6a5bda719cb7"),
Guid.Parse("e5986bbb-df76-49f5-a43d-e6649ae1ba30"),
Guid.Parse("744d2baa-6d06-4217-8d1c-d5cb0827028a"),
},
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 74,
    Value = 
new System.Guid[3]
{
Guid.Parse("3398ce57-ae0f-4f81-8def-518f9cef4744"),
Guid.Parse("61f23a43-7bc9-403f-b374-869453c92b29"),
Guid.Parse("fcd10799-8528-45b3-97b6-89716b0359e3"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 70,
    Value = 
new System.Guid[4]
{
Guid.Parse("73a2f8f7-1bb4-48d4-8de4-31d94ee0352b"),
Guid.Parse("7f6d98c7-91c0-4ec8-b337-35bcd160d0fe"),
Guid.Parse("607ee2d1-dcde-4659-a88d-797de4753c95"),
Guid.Parse("27a9ae96-da85-4dfc-b99d-c34b92cfbe91"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("87de0324-1cf9-44ab-87db-ccf7cb7f0d15"),
Guid.Parse("d75ead4b-1947-4867-a2b9-30e97f1ee59b"),
Guid.Parse("ee706a14-a8f3-4cb6-9fc0-7574ec48fcf6"),
},
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 76,
    Value = 
new System.Guid[4]
{
Guid.Parse("26295052-0db4-40ac-8897-b7dfa7c881ea"),
Guid.Parse("cf11df7c-2635-41e2-8301-6bb1a1aa192a"),
Guid.Parse("2d707ff9-cdf5-440a-8906-dcb90c02c6bd"),
Guid.Parse("245a5c6d-3042-4972-b224-0acbdba8579f"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 72,
    Value = 
new System.Guid[3]
{
Guid.Parse("0eadd19b-45d8-49a5-973b-974c4ddc2594"),
Guid.Parse("755e8873-bed8-4b9b-94f5-1c42bf02c862"),
Guid.Parse("5f12f0a3-a941-4659-8720-83d2436f35a0"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 85,
    Value = 
new System.Guid[3]
{
Guid.Parse("3224ebfa-76b7-4ef1-b4a7-5697c78981a7"),
Guid.Parse("d7196b56-8e05-4330-98bb-6c998a526674"),
Guid.Parse("ea9403a0-25f2-4b77-9de6-7305ad6a8f0e"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 78,
    Value = 
new System.Guid[3]
{
Guid.Parse("0f37fafc-224d-4c9f-92a1-8453db679fc9"),
Guid.Parse("68413c11-f66e-47dd-908c-b2eeb264f5d5"),
Guid.Parse("94963a7d-6a0e-4ea4-9ba0-4eb05921f680"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("02e4353d-d281-4975-aea4-8fc1a4dd19bc"),
Guid.Parse("b2573987-844e-4816-b04d-d10c2e73ecbe"),
Guid.Parse("338432d0-9f10-4c56-81c6-065fa5d54c12"),
},
},
            new GuidArrayUUID1M
{
    Id = 86,
    Value = 
new System.Guid[4]
{
Guid.Parse("33e0a5e0-c718-4c82-b65d-f0ce35337262"),
Guid.Parse("c0f07b42-2886-40e5-b830-98d2d29d99a1"),
Guid.Parse("242c9a36-da6c-439e-86e1-73d2dbe0b0a0"),
Guid.Parse("a95834ba-e69c-41b1-a56e-d952ecf88317"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 81,
    Value = 
new System.Guid[3]
{
Guid.Parse("26710fce-6e46-4668-9438-fa5df19ca0f1"),
Guid.Parse("7b921e54-0573-4f58-9ff7-2f7843b96965"),
Guid.Parse("b730575f-445f-46cb-8a16-a065f19804da"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5908c48f-15c5-4ac9-b0e9-ccc939a73dd6"),
Guid.Parse("5b29eb92-625d-4522-9b43-ecdfbb4cda9d"),
Guid.Parse("e59a8fbf-b257-4c6a-8e15-22458fbf4e4b"),
Guid.Parse("bc856a97-62d4-4113-8464-68c996941473"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f4b524d7-9cb1-4c68-b1c0-6c3ca68e4dac"),
Guid.Parse("43a2e7b3-9b4b-488f-b3fe-c6bfa04d1254"),
Guid.Parse("5d0e130b-db62-4260-864c-af2bc80a4ada"),
},
},
            new GuidArrayUUID1M
{
    Id = 95,
    Value = 
new System.Guid[4]
{
Guid.Parse("730c24c7-d4d2-4877-88ab-187627ddb058"),
Guid.Parse("b42a0523-64c2-4606-86d9-d0401ba8f6b0"),
Guid.Parse("e46ce69c-cb7a-4102-863b-9249821223d1"),
Guid.Parse("6f20de4b-5392-4d94-87ec-36903e46ebdd"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 88,
    Value = 
new System.Guid[3]
{
Guid.Parse("656c31ec-7b85-4559-839e-ce0a28ef0e36"),
Guid.Parse("f762739e-fee2-47b9-9ded-fbff04b670bb"),
Guid.Parse("f27c9c67-fa59-43b1-a2c0-06bd55e78af8"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4db56623-9532-40c7-bcc5-c7de37e84af1"),
Guid.Parse("c4fb8b2f-e949-49df-83c0-9c8b2cb2b4a5"),
Guid.Parse("d0b568f3-40f1-45ca-b154-7ad9c1230f5a"),
Guid.Parse("003dc975-6586-4ea7-8509-2d081a1baeea"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8feb0b53-07f2-4a7b-96a9-e61b05a84277"),
Guid.Parse("fe373915-3cd5-4820-becc-af3e2e9901e2"),
Guid.Parse("75968435-7f62-4e52-b6f2-745dd20b2c20"),
},
},
            new GuidArrayUUID1M
{
    Id = 97,
    Value = 
new System.Guid[3]
{
Guid.Parse("7d971fba-815c-433d-bc50-4b41a84c8334"),
Guid.Parse("b3c2b09f-2671-4fbe-9c7c-3068fe8bd2c4"),
Guid.Parse("2c0ea3a5-7d8d-4e75-9006-036dde9916b9"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 93,
    Value = 
new System.Guid[3]
{
Guid.Parse("3911b3b0-cf37-4d05-8540-aa4f1b69ef39"),
Guid.Parse("fdaad8ce-e857-48c5-982b-4935c983b14d"),
Guid.Parse("284edea6-ba4b-4946-a24a-adaf2c2c3582"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("92a55f4e-4114-4ad8-8bf8-9891524c43eb"),
Guid.Parse("209f3f49-2272-4416-87c2-6c521ea7ffca"),
Guid.Parse("0bc4c768-1718-46ab-bdc9-e80528fed877"),
},
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 100,
    Value = 
new System.Guid[3]
{
Guid.Parse("27c2bfa5-61dc-4859-b2bc-ad1ba92890cd"),
Guid.Parse("275e576c-7114-4392-b357-256c53eaec86"),
Guid.Parse("f4a6fa4c-4054-4a44-8861-67bb5064f925"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 97,
    Value = 
new System.Guid[4]
{
Guid.Parse("b6e5030c-7244-48a5-9ba9-cc9da898c1a0"),
Guid.Parse("317e75d7-08ac-4414-ad8f-d16ccf286e7a"),
Guid.Parse("0de1be44-f861-4382-9382-d807bc77e068"),
Guid.Parse("1427be39-b82d-4ed9-ae0a-5d42aed3f15d"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4e74330a-8ed2-4ef1-82a6-110564c6d26b"),
Guid.Parse("36da508e-444f-49cc-a7a3-a0a1512578a1"),
Guid.Parse("97cf22c8-73ed-4c15-9240-32b24d6f79d2"),
Guid.Parse("13b93550-fa77-4c37-94b9-0ac194e80b81"),
},
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("d57802f8-b98b-413e-ad8e-3bc83ceb232e"),
Guid.Parse("0e33f941-23c5-4af7-ad83-dfbfe22f7ec8"),
Guid.Parse("d28b41d0-b5a7-4960-9ac8-409ee78021fc"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 103,
    Value = 
new System.Guid[4]
{
Guid.Parse("080485e0-767e-40c8-9a29-f391f6a9fc47"),
Guid.Parse("2f0f3f2d-10df-4ba3-adab-628d0aa5782f"),
Guid.Parse("e9fa2d89-5b14-4351-93e5-15c0b573b176"),
Guid.Parse("e504067f-d7bb-438a-8168-f0f3072c10c8"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ddb37b2e-24c3-4bdf-8e4f-a2e741e7b811"),
Guid.Parse("c0c4458c-862a-4dde-abba-06a16db94bf9"),
Guid.Parse("095f1175-aa3d-495a-a4e8-14788435fb2f"),
Guid.Parse("cfd277c7-220e-4723-b805-357bc106f215"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("35bf9e9f-49ab-4939-b8db-5ff79d5a4d30"),
Guid.Parse("db0a6b87-cf56-497b-ad9b-576cd192e0a3"),
Guid.Parse("bf1845d0-4925-43c8-97ad-0005dfd854d6"),
Guid.Parse("b8504cb4-ac3c-4c0e-9967-21c07bd537ab"),
},
},
            new GuidArrayUUID1M
{
    Id = 114,
    Value = 
new System.Guid[4]
{
Guid.Parse("35b49f62-95da-4554-9715-9cdddb3be9ad"),
Guid.Parse("2c4f80ba-1e89-40d4-8876-94394873fc5d"),
Guid.Parse("f7e3c900-62a8-44c3-b645-dcc28350ce1c"),
Guid.Parse("9463f77e-42b5-49d0-8dba-2bd3ea3fa7af"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("a0dac8a5-bbd0-4de6-a12b-121a145ab1b7"),
Guid.Parse("e429a39c-c415-4a9b-9c6a-322647f0c635"),
Guid.Parse("dfe960fa-39f4-4418-8141-f233ab2895b1"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fa8561e6-d20a-430c-aeff-3126d9bb1137"),
Guid.Parse("611134d3-4186-448c-9b15-8adfbb3ec1cb"),
Guid.Parse("1f561211-b18c-4ea8-aa16-d281dc989b54"),
},
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 117,
    Value = 
new System.Guid[3]
{
Guid.Parse("3655d9e5-336e-4b17-b2a0-afa94148f7b9"),
Guid.Parse("ade73781-0a3b-4fb0-bea9-69a6e5104a51"),
Guid.Parse("3159e9e6-5400-4ada-a019-ad4dfe953eaa"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 111,
    Value = 
new System.Guid[4]
{
Guid.Parse("efa4882b-fa1a-4c9e-8979-290eece25966"),
Guid.Parse("9fccef34-cd02-4d5c-8343-9b1aedc1ffcb"),
Guid.Parse("9ecfd0ee-89d0-46c5-94d9-8ef9a8a6d63c"),
Guid.Parse("656cebb1-f7a9-4502-86f5-05b794ab4d75"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 124,
    Value = 
new System.Guid[4]
{
Guid.Parse("d0614ab3-7234-42bc-9afa-1b4ffb04babc"),
Guid.Parse("c5e759d9-0ab0-43b3-b927-891a832bcd5c"),
Guid.Parse("c0ff001d-7662-4a3a-8401-2baa8b1f78ae"),
Guid.Parse("154acb43-703d-4acf-a6b0-17f5bd0389a5"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 112,
    Value = 
new System.Guid[3]
{
Guid.Parse("33546e7f-ca21-4266-8bf0-ed8fb2b614fe"),
Guid.Parse("dd9032ec-5d4c-4d82-bd59-da5f751c43dc"),
Guid.Parse("7f19eb8e-2db6-4d7b-9189-6281ada74b4e"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a33cb1e7-92ae-4e7b-badb-a05563c8020a"),
Guid.Parse("1fd33b7b-1cb1-495c-b8f7-d62f634315a9"),
Guid.Parse("378d0fa5-2331-4b02-b84a-439c525338df"),
Guid.Parse("bb03cefe-0d3d-4df4-a6e9-84a2879d4196"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2a520a4f-eba7-46bf-a42e-cc2f8af20899"),
Guid.Parse("e6954c5f-2eb5-4eba-8e6b-5b803ffc10a1"),
Guid.Parse("70835c78-1b46-4ad9-862e-4ce027a1c8ba"),
Guid.Parse("914bc686-c84f-4e78-97cb-9612c95de9b6"),
},
},
            new GuidArrayUUID1M
{
    Id = 127,
    Value = 
new System.Guid[4]
{
Guid.Parse("c9bf1869-9685-497d-a979-3376d06912c6"),
Guid.Parse("6e6286d8-047f-4553-b87b-2a9d733a7ce7"),
Guid.Parse("dd5704d4-47dc-41dc-8d9c-2b2ed1f33ea6"),
Guid.Parse("191ce339-0f3b-4704-b0c5-5fb0cc0b8eca"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 117,
    Value = 
new System.Guid[3]
{
Guid.Parse("12e5d24c-7e93-4d5a-9f08-8ae49cb61ca4"),
Guid.Parse("5f8e904d-5bde-4041-92ad-3abef5befc95"),
Guid.Parse("87717c77-a30f-4d42-9086-7bbdd4fddbfb"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5ea0eb20-d027-4c2b-a177-589a74a3b4dd"),
Guid.Parse("bc3c3c95-a082-4bb5-b6cb-de9819c81c83"),
Guid.Parse("43c82308-3399-495c-a37f-50d71479f543"),
},
},
            new GuidArrayUUID1M
{
    Id = 134,
    Value = 
new System.Guid[3]
{
Guid.Parse("7453f214-6467-4af4-a39b-f8c240c170cf"),
Guid.Parse("c826600e-c9d2-4002-ac75-da06d4955f9d"),
Guid.Parse("e3219f8e-123e-41f9-907d-94ffce24178f"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 121,
    Value = 
new System.Guid[3]
{
Guid.Parse("1e360540-5bd5-483f-a8c3-2ed1144ef895"),
Guid.Parse("a7a3aa33-90d4-4a4c-8d67-607f0c83402e"),
Guid.Parse("467f711d-7ec6-4b42-a819-b77c254b9ab9"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 139,
    Value = 
new System.Guid[4]
{
Guid.Parse("05c16479-6894-4c3f-b0e6-0cb571e2ecbe"),
Guid.Parse("99e1e9ff-f91e-4eb5-ac77-7d3a4c2cac9f"),
Guid.Parse("d34d5f5e-eb16-488d-ae08-6523d230c626"),
Guid.Parse("8cdf4cb2-330b-4ff8-a70a-14f87913cef8"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 128,
    Value = 
new System.Guid[4]
{
Guid.Parse("b6e611cd-7c14-4c52-96d4-1c22740c688c"),
Guid.Parse("6b0baab4-13a6-4993-919e-5505b4185d60"),
Guid.Parse("08f08ec3-1fd1-4d14-99f5-9e1d2f092077"),
Guid.Parse("103286f5-cc41-4a93-b532-dfaac9c840f3"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4b12538c-06ef-423b-8ac5-71ec1dbcecca"),
Guid.Parse("6d9ee642-78c1-486c-8df9-9f11b165fea0"),
Guid.Parse("843d8754-4970-4574-9655-ef755ef26f55"),
},
},
            new GuidArrayUUID1M
{
    Id = 146,
    Value = 
new System.Guid[4]
{
Guid.Parse("7af345e0-45e0-43bf-8db0-a097645f076a"),
Guid.Parse("33ee9df4-04f7-46e7-848a-ab555e9d6385"),
Guid.Parse("e788b165-65d7-45d6-9e5a-9b62055223eb"),
Guid.Parse("9210ddde-ec8d-41f9-865d-adad2a27cd82"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 130,
    Value = 
new System.Guid[4]
{
Guid.Parse("2be51121-bd98-4792-8b99-de866f588310"),
Guid.Parse("59d6a11b-9b36-4c59-81d3-27bf7148923c"),
Guid.Parse("ce153c87-24f5-47c1-a475-651de1e4ebcd"),
Guid.Parse("19e8634b-c32c-4a9e-bb9e-3affa0e5658a"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 147,
    Value = 
new System.Guid[4]
{
Guid.Parse("c07b210e-e45c-42ba-ba39-0e08031a205d"),
Guid.Parse("af0bec63-443d-4a07-9403-bb456e7fb280"),
Guid.Parse("0409a3f6-4109-4b67-be10-e081c5138151"),
Guid.Parse("61d8c7cc-9f65-4516-94e6-d4da3c96dbaa"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 136,
    Value = 
new System.Guid[3]
{
Guid.Parse("ba50ba7f-78d0-493c-80d3-00fec2bb8fbc"),
Guid.Parse("2459b1fa-c2be-4b75-b994-ca942194d3c5"),
Guid.Parse("96cf401a-8c7b-4c00-a102-47094e47c682"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7640b297-84da-41b6-b5e5-5aeead31dd7f"),
Guid.Parse("b52b68cf-92e9-4b56-97a7-61b0de79906b"),
Guid.Parse("3a30c418-5ab4-4d7e-b7d1-d3b0b48b8052"),
Guid.Parse("44cdd987-c545-49c4-b188-a15a819120b3"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c273e81b-e9e4-4107-8ea8-f64f4065d76b"),
Guid.Parse("842f0755-51ad-4ccd-bda7-6392851880c8"),
Guid.Parse("6ccc89ce-89c7-409e-b740-1b51de099cb8"),
},
},
            new GuidArrayUUID1M
{
    Id = 150,
    Value = 
new System.Guid[3]
{
Guid.Parse("7423cad9-158e-4375-bee7-82956795f424"),
Guid.Parse("ce4a9bdc-42a3-4509-a9b9-7a87a34abada"),
Guid.Parse("d01bf75f-46ae-48c9-8ed7-a246ae49ff53"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 140,
    Value = 
new System.Guid[3]
{
Guid.Parse("d1ddc11f-8be0-40e9-9e23-f8267e180a23"),
Guid.Parse("f0986002-ee85-4731-b2a0-ab6dc85a7979"),
Guid.Parse("ef8c8c7a-c39a-41a7-a573-4c0502a80a4e"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("228a401b-bcf7-4110-b29b-ff3ceb3daae2"),
Guid.Parse("654451ba-2c10-459c-ab95-c23622b906e4"),
Guid.Parse("0a26264e-396c-486e-ad7c-6a6db4149fdd"),
},
},
    NullableValue = null,
},
            new GuidArrayUUID1M
{
    Id = 156,
    Value = 
new System.Guid[4]
{
Guid.Parse("60453ee7-5902-4ff9-a0b5-40e38aa01cf1"),
Guid.Parse("16bf8b5e-8d85-4239-b468-307c0d789dea"),
Guid.Parse("5133e206-4c02-43a8-ad52-b5340be035c8"),
Guid.Parse("244c6524-aa66-4bc2-83bb-4fcf00211db0"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 145,
    Value = 
new System.Guid[4]
{
Guid.Parse("8d3db38f-daa8-4e70-8357-f014b29b54d1"),
Guid.Parse("e58519d1-35ad-4ff4-b1f9-0034a92f50d4"),
Guid.Parse("1e69bd52-df8a-4444-b6a2-dcfdedda5198"),
Guid.Parse("a803bf0f-d3b3-48df-aea4-924b3c4676ab"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9feca792-38f5-4129-a008-b6ce1e71c877"),
Guid.Parse("7d15c11c-c5c6-463e-8e0f-d3a1e856f12b"),
Guid.Parse("a7e60c1b-66c2-4c61-b756-f69955f4f987"),
Guid.Parse("ac92da90-f710-4633-929b-80f631041ce8"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0f240762-8327-4f9b-8c9e-ca1a8853b25b"),
Guid.Parse("685d742e-a4cc-409d-870a-373057531c6c"),
Guid.Parse("855bc7ad-e3e3-4458-91bf-20164615452c"),
Guid.Parse("872a69d7-907d-41b3-8ed4-64fa9fdcfe86"),
},
},
            new GuidArrayUUID1M
{
    Id = 161,
    Value = 
new System.Guid[4]
{
Guid.Parse("eabaa4b3-33d3-49e5-a963-715639d04ad2"),
Guid.Parse("3885e2cd-024a-4c58-a351-45a9b9a34ab2"),
Guid.Parse("01e5d767-8fd9-4d49-8af7-2fb4a9842463"),
Guid.Parse("cde1a95e-548e-4c60-aaf9-9d82005bc84e"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 146,
    Value = 
new System.Guid[4]
{
Guid.Parse("33f9e91f-63e8-4d5e-81c6-c2c4b1bb08a4"),
Guid.Parse("49de8237-c86d-4ced-bbc7-39f79deb61ef"),
Guid.Parse("79e42b21-d81f-44e9-a0df-497da05d8435"),
Guid.Parse("b6475e59-6272-4608-aa86-e669c48afc14"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8da70b10-6815-4b81-b7f1-e3513246341e"),
Guid.Parse("d2b49071-00e2-4aa0-b0b8-bb5278dedb77"),
Guid.Parse("214a315b-c6f7-4085-88a8-f82067e4ee8d"),
Guid.Parse("8f16eef1-19ee-4408-b940-05baeb6b4a72"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2d9bb188-137c-43e5-990e-517894add44e"),
Guid.Parse("2fb31d78-9892-441e-b511-3e85b497d993"),
Guid.Parse("9950154c-121d-4108-bf66-c76313611d15"),
},
},
            new GuidArrayUUID1M
{
    Id = 169,
    Value = 
new System.Guid[3]
{
Guid.Parse("1dde1c1b-49d8-4cbe-af91-bd8fd4b86bc4"),
Guid.Parse("4e94c3c1-7714-476f-9cf1-f668bfb4be7a"),
Guid.Parse("e2232f07-ccc0-446b-8afa-c740d96d3109"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 152,
    Value = 
new System.Guid[3]
{
Guid.Parse("f70264b8-78bc-4e29-9573-5bfb64798710"),
Guid.Parse("b423f1f5-acbd-4476-81b0-553809ad7eb9"),
Guid.Parse("fa25b228-ef0a-481f-8e09-54a987e419d4"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("58d2d767-ad7c-4fdd-97af-d28d16a02f8c"),
Guid.Parse("37357097-9d3c-4b1f-9a74-8c9d3ced9dc2"),
Guid.Parse("d4d15812-43cd-41ca-b160-276cbbe7769e"),
Guid.Parse("7ec4dbe5-f6f4-4910-a0be-2f7ed4f83fb7"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e4d2a137-94fb-4a95-bdb6-b170147362a8"),
Guid.Parse("e46815c7-6504-4d53-9803-5732f2a062d2"),
Guid.Parse("76a7d939-2189-431d-b434-bf06daba2b64"),
},
},
            new GuidArrayUUID1M
{
    Id = 177,
    Value = 
new System.Guid[4]
{
Guid.Parse("b0aa8597-55cc-4426-b02f-c89280fc73fd"),
Guid.Parse("170143bf-c8bd-4c8a-9296-e8e22bc2b411"),
Guid.Parse("5ff61047-4a96-454d-b939-f445b59acb80"),
Guid.Parse("6b241cc8-e8d1-400a-ba64-8e91b980d1de"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 153,
    Value = 
new System.Guid[3]
{
Guid.Parse("d95ec6bd-3152-4124-8917-d8e6cb4b7260"),
Guid.Parse("21eb8682-5265-4a38-9df3-f8fe50ea0697"),
Guid.Parse("63220590-e811-4a2f-a4ff-3e3318eb7013"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b05c6127-bc76-41c4-bfdf-703c441f4628"),
Guid.Parse("1f307704-39cc-40dc-ba64-efa485e234a6"),
Guid.Parse("e8341e8f-7df0-4e03-bf6a-8d910dfadd52"),
},
},
            new GuidArrayUUID1M
{
    Id = 180,
    Value = 
new System.Guid[3]
{
Guid.Parse("a7871c00-fc84-4de2-9a53-626ae9b38763"),
Guid.Parse("51bdc9c5-bb4a-4b2f-a8cb-89163e82d044"),
Guid.Parse("0177f1b7-8931-4ecf-938f-43a27acf26b0"),
},
    ModelInner = new GuidArrayUUID1MI
{
    Id = 159,
    Value = 
new System.Guid[3]
{
Guid.Parse("a19c42fa-1352-46de-b609-8d3a486098db"),
Guid.Parse("63ba3ab1-35e4-4e75-bbf3-6a0dea3ef53c"),
Guid.Parse("6e64e605-5511-41d7-8e52-6694003d87f9"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b1e203dc-3ab9-4fcf-b46e-59d6be246e43"),
Guid.Parse("06a75c1d-91b9-46aa-a63d-6eee860dfdc1"),
Guid.Parse("99a5396e-93d1-4fdd-8620-89f6a021dcad"),
Guid.Parse("a7752fb8-f198-46d5-80e1-961e3c65237f"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d486a444-8969-4337-b8e4-c357f71209b0"),
Guid.Parse("15732751-56b1-43f9-80d5-f6622f6694e0"),
Guid.Parse("9a10103f-3830-4ce2-9f97-b1bbc76fa41e"),
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidarrayuuid1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UUID)}, 
    {mi_id:Int32},
    {mi_value:Array(UUID)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayArrayUUID)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
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
                    await ((IGuidArrayArrayUUID)this).InsertModelDbConnectionAsync(
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
                     ((IGuidArrayArrayUUID)this).InsertModelDbConnection(
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
FROM gedaqtests.guidarrayuuid1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidArrayUUID1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayArrayUUID)),
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
                    var models = await ((IGuidArrayArrayUUID)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidArrayUUID1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IGuidArrayArrayUUID)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidArrayUUID1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


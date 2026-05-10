

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
    internal partial interface IGuidArrayUUIDArray
    {
    }
    
    internal partial class GuidArrayUUIDArray : IGuidArrayUUIDArray
    {


#region TestData

        private readonly GuidUUIDArray1M[] _testData = new GuidUUIDArray1M[]
        {
            new GuidUUIDArray1M
{
    Id = 5,
    Value = 
new System.Guid[4]
{
Guid.Parse("c4030b73-7e7c-49e2-a828-5964f58cf4f9"),
Guid.Parse("bedf7883-181b-453d-8609-423b2a672c35"),
Guid.Parse("905f96ad-1bd1-4972-9f19-ee505c65cdbb"),
Guid.Parse("78820a80-4542-4c74-8e60-eac3de74fda5"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 1,
    Value = 
new System.Guid[3]
{
Guid.Parse("f4f53fdf-9f62-4849-a34c-2c3b82a49897"),
Guid.Parse("874884a5-2136-42a3-8776-a7ccdb340720"),
Guid.Parse("3468bf5d-7e05-4931-afd7-5996ccd1ac72"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("82f8aafa-3ca8-439c-bff5-e7d0bf36a562"),
Guid.Parse("7fffc942-ecd7-4dc4-9bd3-7aee2174fb81"),
Guid.Parse("4447ffad-f68e-492d-83df-ecc02622698d"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 6,
    Value = 
new System.Guid[3]
{
Guid.Parse("974957e6-eaf2-4296-beef-1db3b1d014a3"),
Guid.Parse("b40f4aaa-721c-46f3-8e9e-383b282d1d4b"),
Guid.Parse("8f209a08-d0a0-4146-a5f2-e104bf8e7e01"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 2,
    Value = 
new System.Guid[4]
{
Guid.Parse("b34cd95f-08c3-4e81-ac09-61b4c21140d7"),
Guid.Parse("f915ea85-3727-4239-a557-fc26e7aadf5b"),
Guid.Parse("f605158e-892a-4afc-92f0-e51d18c37907"),
Guid.Parse("c25a0449-f3de-42f4-b24f-34de60d5fbde"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 14,
    Value = 
new System.Guid[3]
{
Guid.Parse("8848178b-caf8-4b92-b0aa-e613dcad43c4"),
Guid.Parse("824c6d0e-cb57-466d-bc32-ca9bb0875074"),
Guid.Parse("39e07ed8-469d-4ea4-bd47-0d22dfbceba9"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 9,
    Value = 
new System.Guid[3]
{
Guid.Parse("4425ad57-9402-45bf-b6bf-2c713c3da9cc"),
Guid.Parse("890aa8f3-9441-4c01-b7ae-b73249965f60"),
Guid.Parse("07cb8604-ce30-45bb-b6fd-006483d9b972"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("40721090-341c-4c2c-b6e3-8a72fccfd811"),
Guid.Parse("d2d6f6ab-d7fb-4276-aaba-516162feee0d"),
Guid.Parse("b0cc5dfd-78f6-49a3-bf2b-716d6da1e53e"),
Guid.Parse("9cca3c43-c811-47c3-bf18-fe268b737c2a"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 16,
    Value = 
new System.Guid[4]
{
Guid.Parse("75479bdf-0784-4e77-abdc-eb7ffab0bba4"),
Guid.Parse("d1b01193-7341-432d-b3eb-c08868f76fbd"),
Guid.Parse("1ea8b514-8987-4a3f-b1b8-e206ee856acc"),
Guid.Parse("ac569ef9-5e75-4d7e-b14f-4665ef91cd03"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 10,
    Value = 
new System.Guid[4]
{
Guid.Parse("b7517345-928c-4dc5-8678-e1b58ed0ef70"),
Guid.Parse("a9bedf59-7ecd-4e1f-93bb-d3771e4cd7e7"),
Guid.Parse("e5d055fd-5162-46b8-b6ae-22c44373a716"),
Guid.Parse("fbde9ce9-335d-472a-90ec-405e8707c670"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("83d1abd4-7cde-49f5-972f-6d67cf89816d"),
Guid.Parse("3aacd83d-5979-45c0-a29e-87d74d7c604b"),
Guid.Parse("c2ca9524-e447-40f1-9cb2-5155a37e4009"),
Guid.Parse("1b6bbada-5fc4-438b-afdd-637097b5efbf"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 24,
    Value = 
new System.Guid[4]
{
Guid.Parse("c1df8f4f-0961-4278-a980-62f668b7f816"),
Guid.Parse("ad47a182-4c6a-41f9-98df-1e2281128a04"),
Guid.Parse("faa4f85f-e475-45fa-9fcb-151e821c914e"),
Guid.Parse("2f830b99-ea17-4dbf-99d9-f111d32d967b"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 15,
    Value = 
new System.Guid[3]
{
Guid.Parse("cc711b1c-9e82-430d-81c5-72932e03a675"),
Guid.Parse("f5994b28-bed7-424c-a06c-ac35dfefb989"),
Guid.Parse("8b4b214f-6610-44b7-b424-d4d6c0cad79b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("32ea3b67-c93b-4fbf-906d-388c8db504ce"),
Guid.Parse("7582b849-8cd5-45b1-9578-b2803bd00b29"),
Guid.Parse("21cbcba7-d7a3-4b9f-8594-2d3a2772ff7a"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6b3b7ada-3e7e-4872-a333-12beb8bd57a4"),
Guid.Parse("5fdbaa8d-1497-472b-967c-71af25590e41"),
Guid.Parse("ba885c6d-edf7-4f48-b433-a469644afb58"),
Guid.Parse("eb5759d2-52bd-4665-92dc-22352ebaf309"),
},
},
            new GuidUUIDArray1M
{
    Id = 26,
    Value = 
new System.Guid[4]
{
Guid.Parse("f7d6ad03-cf53-472e-ae08-a094e6179d42"),
Guid.Parse("0aa994ca-c0c0-4450-85e4-85efc7bdf15a"),
Guid.Parse("74a6faf3-744e-4cc7-9b8c-60948588d1ee"),
Guid.Parse("315f9b02-aa51-4954-ba7c-f8b28b18766b"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 24,
    Value = 
new System.Guid[4]
{
Guid.Parse("559d097c-ffbb-407d-97f5-959d47b3989b"),
Guid.Parse("d5d68760-d04f-4ae4-8729-b94014c1a9d5"),
Guid.Parse("7bc19db5-e82f-4603-aaf4-ce04421aa8a6"),
Guid.Parse("8caf86d0-92f1-4f4f-95c2-8b5a9a1192b4"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 35,
    Value = 
new System.Guid[4]
{
Guid.Parse("306e6498-87a5-4140-9a67-15b554e61df2"),
Guid.Parse("2a4187e1-f5c8-4b0c-8455-b0dca37918a5"),
Guid.Parse("0409d66c-728d-415e-ae19-5481afd7f2ae"),
Guid.Parse("b1282467-9f26-4bd8-bda7-98fa01726fd6"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 33,
    Value = 
new System.Guid[4]
{
Guid.Parse("b0544e93-8dd0-4b26-94ea-e2423a081508"),
Guid.Parse("89adf960-7441-4147-b4be-9c5a76e2790a"),
Guid.Parse("d6ad102d-ebab-406f-a538-695b1e1385ff"),
Guid.Parse("e2a7deb7-4074-4fed-87b4-8d29accc6e23"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("50947d9e-8846-46c8-bd25-71054d213eac"),
Guid.Parse("5c3dbf80-6b29-469f-b83a-75c66e0fb9a8"),
Guid.Parse("0d6093b0-f5f7-426f-98ee-a91d0f66bef4"),
Guid.Parse("f0c76e1d-3821-4ee0-b418-ec20d33ec8ed"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8dd4c5c4-c837-4fa5-b6a0-2f26d038fb6e"),
Guid.Parse("ace7b4db-c800-4a48-b2ad-2e93b6d60161"),
Guid.Parse("90b7440e-72b7-4d0c-a0f7-595f19bc1947"),
Guid.Parse("afba3ea3-9b80-4b6f-916e-f435e280d569"),
},
},
            new GuidUUIDArray1M
{
    Id = 38,
    Value = 
new System.Guid[3]
{
Guid.Parse("c70ebaea-1adb-4c15-9ba2-e2aff12a18be"),
Guid.Parse("6e656660-946f-4d3c-9b33-05d7070b3317"),
Guid.Parse("1f2f946d-f516-4bf7-9524-d53c2ee336b4"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 39,
    Value = 
new System.Guid[3]
{
Guid.Parse("3478e461-da54-4afe-9227-e06d500105bd"),
Guid.Parse("ee9d423c-c6c8-42f7-b87b-33ca93d2c9eb"),
Guid.Parse("9512883d-48b5-4f8b-a91a-c6f8f91b67b9"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("906e6b46-b8b2-4b29-a0b7-35164e6982af"),
Guid.Parse("ad2cae08-be77-40ce-a7ab-0077985d4674"),
Guid.Parse("94102427-8df7-4f10-8ff5-9ca63513a7a5"),
Guid.Parse("c8b61754-56b7-4605-9a23-e8a189226098"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 47,
    Value = 
new System.Guid[3]
{
Guid.Parse("a80dc444-603d-48dc-becf-c4fdd41763b9"),
Guid.Parse("ccb0f813-ef6d-455c-9064-7069294a75fe"),
Guid.Parse("28fdb7e0-6c18-4339-bf6b-29dd54e76c32"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 48,
    Value = 
new System.Guid[3]
{
Guid.Parse("9e75e82f-111c-4568-a99d-b00a1b1c2f34"),
Guid.Parse("8b049fd9-bd18-456b-9ee8-e9a1f3f2f4fd"),
Guid.Parse("13c94818-e48b-4eaa-8d03-4c20e0531253"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a327f767-d218-4eb7-9052-3a795f824f2f"),
Guid.Parse("dfade9f0-1f0c-467f-a555-19ae955e86e3"),
Guid.Parse("a42612c3-10a8-4e8c-ad13-aa77b966e710"),
Guid.Parse("f949edc7-4c33-4331-a5e5-76e68ff36461"),
},
},
            new GuidUUIDArray1M
{
    Id = 50,
    Value = 
new System.Guid[3]
{
Guid.Parse("40490a5c-9027-4f6d-814e-db1a37dc2657"),
Guid.Parse("cb411871-6614-4ecd-b79e-ab1c7f44f32e"),
Guid.Parse("f6b63d7f-0e34-4ec9-84ba-2d48583d12be"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("4819b787-a643-46f6-b333-5687b73d5260"),
Guid.Parse("602d2b7c-cf5e-4289-a43a-8e970f49c78a"),
Guid.Parse("53d99b31-ffb2-4275-ba99-9a45c0650b4b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5beff733-a50a-42b3-ae45-c1220b573b47"),
Guid.Parse("af390328-071e-479f-b92d-11fa61b2ba12"),
Guid.Parse("78212c23-56d7-4c3f-8587-8ddcbbf7b960"),
Guid.Parse("8832fedb-5cfb-4d5b-aa47-0f29ac2e7e0e"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 56,
    Value = 
new System.Guid[4]
{
Guid.Parse("d498fd77-34fb-423e-a66e-e2fa740f9dcb"),
Guid.Parse("3b421463-dcd3-4447-9dc4-bbbb640bd15d"),
Guid.Parse("0095d0da-af91-4362-bb62-7fc48feaedc3"),
Guid.Parse("1105f051-f686-452c-93f6-ac2bb4becac6"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 50,
    Value = 
new System.Guid[4]
{
Guid.Parse("bd9b73a9-2ddb-4f59-b93d-580510bd9ea2"),
Guid.Parse("30cbac0a-c626-444a-9feb-f371526a1f84"),
Guid.Parse("66dc02a8-dea9-4765-b799-3ebb8931d595"),
Guid.Parse("a9aef70d-1fff-48d2-af74-a36b6a0491aa"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("27f3f433-897e-4735-b227-a6576f2be0d8"),
Guid.Parse("6d4df09e-0d04-4ecb-963b-e1cda5ac3e75"),
Guid.Parse("e023371a-5bdf-419f-adbe-9f918990b213"),
Guid.Parse("edf414b9-5862-4ad2-bf7b-bf4a7ffd274e"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("325caba7-914e-4e69-aadc-11ae9f4c6235"),
Guid.Parse("f541bdb5-1e46-4237-8047-34737d37b8c4"),
Guid.Parse("4a32d7cb-c6cb-4835-b741-38849fc076ea"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 55,
    Value = 
new System.Guid[3]
{
Guid.Parse("2fc85e13-15b4-4019-a87c-90617d3a8a63"),
Guid.Parse("3a263839-f051-4d1e-ab29-934fbe22aa2a"),
Guid.Parse("89bf6b4d-5914-465f-9c07-fd99e9265164"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c32ff62f-18ad-4ec4-b522-f814eb072f62"),
Guid.Parse("1393b993-522e-425e-8793-67c4a7b0ff75"),
Guid.Parse("6d6b3a1e-462e-4ac1-bde3-eca7eda651b6"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("25284502-ef23-47e5-a270-dcaab8347375"),
Guid.Parse("2c6abf34-2873-4945-9e32-0947d1718231"),
Guid.Parse("e5c39c0b-6c44-40bf-bd0a-9cff49faa2c8"),
},
},
            new GuidUUIDArray1M
{
    Id = 63,
    Value = 
new System.Guid[3]
{
Guid.Parse("0fe50a69-c1b5-467b-96fd-a5b7f02b8922"),
Guid.Parse("ea7842bc-c348-4de4-a234-2c171af8142e"),
Guid.Parse("a46ff07c-1949-422d-8f29-7bc4a60184fe"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 63,
    Value = 
new System.Guid[4]
{
Guid.Parse("ba761808-9ae6-4fac-ac09-e9cd4aeb020b"),
Guid.Parse("e3fa6497-4193-4bb5-ac44-c5550367013b"),
Guid.Parse("9770daef-aa1c-4c58-afe8-07c63429115e"),
Guid.Parse("2f7c8c66-6a60-4bf9-b58b-bb6c852c069e"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c046c60e-0718-4398-a91c-da885fdbafc8"),
Guid.Parse("0d6c6b06-da8b-41cf-835e-7cb60f3ca366"),
Guid.Parse("3de47dd5-6b5c-4582-8540-bbc8da851b89"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 72,
    Value = 
new System.Guid[3]
{
Guid.Parse("60c5550a-d1da-4787-b9d3-1649a854d16c"),
Guid.Parse("44474bdb-3b4f-414a-82a9-7dc1bad288a7"),
Guid.Parse("86ffa908-6639-42cc-b6ed-e84818169742"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 70,
    Value = 
new System.Guid[3]
{
Guid.Parse("ecae23bd-0f04-4e94-9936-65e7d67d48ce"),
Guid.Parse("bb1cb44f-98af-4257-af16-c4ed2369aac0"),
Guid.Parse("855d98d2-3738-45d0-bb9c-af3cd03a2d4b"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("5555d5bd-5266-4d03-afd0-fccd2c8def4e"),
Guid.Parse("c430270a-ce32-4c17-9054-33c8cc568bef"),
Guid.Parse("6a1f05cb-e80e-4fa1-b7dd-f62a2496f130"),
Guid.Parse("2c4d48f4-e6ac-4ed9-bf06-6b90e83feaac"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 73,
    Value = 
new System.Guid[4]
{
Guid.Parse("14b1a6c4-d0f6-43de-8caf-c9622fa0b9c7"),
Guid.Parse("eff72815-814e-4734-ac3c-830b5da15518"),
Guid.Parse("4c46e9aa-8bbf-425c-b040-be43f9ba23b6"),
Guid.Parse("21d5497e-3ac0-43c2-815e-51c05cfbd48d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("de0b5344-0fa1-4e41-95a8-2e88bae0990f"),
Guid.Parse("921f3ccf-f365-469b-af80-8d6aa954cdbe"),
Guid.Parse("81de7824-19ab-4bbd-8b31-e565266a97f4"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 83,
    Value = 
new System.Guid[4]
{
Guid.Parse("70989aa5-d61b-4309-b07e-45cceeb743ef"),
Guid.Parse("aa35d449-90c0-4c61-8dc9-46a61f5d4f2c"),
Guid.Parse("dec7bc86-a277-4ee6-af32-27d3cceb94c7"),
Guid.Parse("b96bdb02-fffc-45d6-a604-45c79dd25158"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 80,
    Value = 
new System.Guid[4]
{
Guid.Parse("59b3a169-2220-4b2c-b1f8-5b4fe5bc9efb"),
Guid.Parse("14f6ac9f-a239-4c57-84a9-b0c54a371713"),
Guid.Parse("a6c7aea0-ce8f-4f6c-845b-33c4a8ed75aa"),
Guid.Parse("89ad9ad7-8a63-4d3f-a9cf-8d2ea9ca12ef"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f576036a-bb19-4945-9ce8-b442fac877c1"),
Guid.Parse("ab445ec1-12d5-4b1d-bbea-16d37d701155"),
Guid.Parse("dea1ad1d-7954-4b58-8541-91dba046d943"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 85,
    Value = 
new System.Guid[4]
{
Guid.Parse("9acb72c3-1d72-455e-9163-e35573a33a5d"),
Guid.Parse("1b3959a4-f0d1-431c-9665-e718238c8758"),
Guid.Parse("f018dd83-1823-4739-8417-28cbb7ac942f"),
Guid.Parse("ab5fa327-79a1-4fe3-a7a8-94979c21b1f9"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 85,
    Value = 
new System.Guid[3]
{
Guid.Parse("a5959fa3-27cd-4d82-8bb2-09212dcfaaf2"),
Guid.Parse("c9a94417-8869-42bf-bb0c-3f10d54dfff6"),
Guid.Parse("f03d3906-7a48-4895-9799-171827b8fd7b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8907e49e-78ad-4900-a090-e18b0857b890"),
Guid.Parse("69636031-7654-49db-832a-53920b4ae23e"),
Guid.Parse("4a25bf4c-ad2e-49e3-ac52-da880b903984"),
},
},
            new GuidUUIDArray1M
{
    Id = 92,
    Value = 
new System.Guid[3]
{
Guid.Parse("2d0c35c5-51dc-4683-bcb4-94323442c5e4"),
Guid.Parse("17347e96-c03c-4736-87e8-a930b8db4922"),
Guid.Parse("74266758-df7c-4059-bf4e-0c4fd8257695"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 87,
    Value = 
new System.Guid[3]
{
Guid.Parse("7c91ff4e-34da-4550-9c15-44c770e4797c"),
Guid.Parse("301027f5-434b-4f95-afca-6e5a91f88a39"),
Guid.Parse("5c2f0da1-d8d8-4c11-b509-f2b845c1956b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ce83282a-b39d-4678-aa19-88fa5dd0c39e"),
Guid.Parse("5bfdc3ab-dbd5-42a0-aac9-c856ee7beda8"),
Guid.Parse("78d95aad-64a9-46cf-9168-ba23a5bf85ff"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 96,
    Value = 
new System.Guid[4]
{
Guid.Parse("f14fcc3b-876d-4fc1-8c99-293df7593355"),
Guid.Parse("4c9300d4-8558-4d74-bfcc-e1c91e8f962e"),
Guid.Parse("0263fd5c-dc7a-48e7-b7c8-85fa2b5b8793"),
Guid.Parse("233b376d-b22a-4be3-ac39-488b1637ab63"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 96,
    Value = 
new System.Guid[4]
{
Guid.Parse("c4e3a02d-bf99-44e5-bff0-5d03ede53eba"),
Guid.Parse("c8d212d1-900c-4675-8d11-1c66e6e0e703"),
Guid.Parse("b519520a-c821-4e78-b0cf-701cd0272703"),
Guid.Parse("42ddfe15-e68f-4a2f-b10b-f5b77285cdc4"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6763934e-228d-4b6a-88a7-34cd70de5fa1"),
Guid.Parse("e0a4b972-170f-4132-bb29-2a9bd92704cf"),
Guid.Parse("ed289502-4393-4cab-9fd5-6fcc152d43f0"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 98,
    Value = 
new System.Guid[3]
{
Guid.Parse("9dc3296f-3592-44a8-9adc-939e6c14264a"),
Guid.Parse("0af54214-0616-4f1e-800e-54d1349ec85a"),
Guid.Parse("37c35d09-ed9d-4b64-9da8-3a813fb4b794"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 104,
    Value = 
new System.Guid[3]
{
Guid.Parse("90fc55bf-d582-4758-baee-a1c0c6e1e4ec"),
Guid.Parse("866c30dd-f5fb-411a-b7a3-841a7af09ec0"),
Guid.Parse("05614459-093e-4132-84c2-8bf530451ad3"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("1305d205-562e-47ba-a554-b64cf3d2af96"),
Guid.Parse("fea14852-58ce-4de0-99b4-a5baa0a8486e"),
Guid.Parse("9032eaf2-d6d7-4600-9ecc-6a9009efd592"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("327f9cdd-e5e7-4363-911a-b7164bd36154"),
Guid.Parse("8d6ab97f-54c1-4434-bc13-aa9ca22b7bea"),
Guid.Parse("635d99cf-1a6a-47a8-afc1-44d8f323c37a"),
},
},
            new GuidUUIDArray1M
{
    Id = 103,
    Value = 
new System.Guid[4]
{
Guid.Parse("d834f08d-6f51-4c6b-9f95-493d38538897"),
Guid.Parse("800225a7-f39b-4c88-8540-e7e9b585b48a"),
Guid.Parse("1fd7e17a-8a1d-42ef-95d7-48d6a9a79520"),
Guid.Parse("4fc2a8f5-bd59-46bc-aff5-6c1196cb9557"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 108,
    Value = 
new System.Guid[4]
{
Guid.Parse("3d3c2791-025b-4111-adaf-0493f263b0e9"),
Guid.Parse("e3d00e0b-c922-4d75-9b29-9681dd63e7ee"),
Guid.Parse("01086af1-d2d8-4fc7-8cc6-042d98965fb7"),
Guid.Parse("6454caac-a36c-4aca-833b-3bfd8131ca47"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("274627fe-bda7-4a30-8db7-db926977909d"),
Guid.Parse("c7e39477-c0cb-4db5-8141-ea32fdcf0cd5"),
Guid.Parse("b2718bbc-5735-4e9f-a3cb-b722a771cc33"),
},
},
            new GuidUUIDArray1M
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("caf1a979-7ace-48cc-8f22-2eb97365a85d"),
Guid.Parse("7bab3641-8cff-4e9a-bfb3-73027a35ea3a"),
Guid.Parse("9aa096a0-15e0-420e-9112-9476a39ecae0"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 109,
    Value = 
new System.Guid[3]
{
Guid.Parse("5c13ff7c-bc3b-46f5-b45b-6ecf7b78e562"),
Guid.Parse("9a8a4622-50f4-4307-a884-826011ace424"),
Guid.Parse("bcf09497-dc3c-46cf-a62a-5f37aeb783e3"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8a05b41c-909c-4a1e-9f5e-e2b9ac5040c7"),
Guid.Parse("de15634d-8ed2-408e-ae60-2b81914c23d6"),
Guid.Parse("800085a8-61d3-45ab-97e6-7549939b1454"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 106,
    Value = 
new System.Guid[3]
{
Guid.Parse("d6f76f2d-ec8a-4d36-b9ba-051c7dddc4fe"),
Guid.Parse("c99d9346-e5cf-48ae-8557-51fe7d8324c4"),
Guid.Parse("c9268a04-3bd0-4b81-a6fa-5b4437a8a526"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 118,
    Value = 
new System.Guid[3]
{
Guid.Parse("6390458e-2978-4dc5-bc54-bf51a7ba028f"),
Guid.Parse("7cfe3ce4-8c3e-4ab0-aecc-8eba02161efc"),
Guid.Parse("98c22a1f-265f-4df3-9971-fd3755ca1c65"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ddcc8f67-e076-4cb1-9e1d-8256d67b59f9"),
Guid.Parse("e8f26f17-1b00-44fb-8021-bda0fbc5fe48"),
Guid.Parse("25a3b908-5dc8-46b6-988e-d36422d4a7bc"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f6b312fa-2872-4b15-9bf3-6c66704cd937"),
Guid.Parse("f96253b9-c5f0-4962-a6e2-69be7cca4f69"),
Guid.Parse("f27b4474-9d10-4231-9568-b9ea4e339291"),
},
},
            new GuidUUIDArray1M
{
    Id = 114,
    Value = 
new System.Guid[4]
{
Guid.Parse("8d565211-075a-4134-a308-31f265301b35"),
Guid.Parse("28636b08-bf2c-4c26-8d4b-c7fb032cfecc"),
Guid.Parse("af0af370-c452-41af-89d8-8760d556995d"),
Guid.Parse("de942944-ed95-469f-b406-50e4062afe9a"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 123,
    Value = 
new System.Guid[4]
{
Guid.Parse("f8667182-c018-4469-ab9f-eba45d1f0d0e"),
Guid.Parse("d867b250-ca84-49ae-8561-f9558d91ef4a"),
Guid.Parse("7a5cba34-361f-485e-86d8-1f09f4a85d76"),
Guid.Parse("63142b6c-e047-47d9-acb1-30943d12af36"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("540761df-f2d4-4020-8204-22098de9db71"),
Guid.Parse("d72829e5-ea94-480e-8e7f-10b859c6337c"),
Guid.Parse("7d5dfd30-59f6-49f2-a332-1d8f9e0fc3c7"),
Guid.Parse("2980ad09-534f-4e47-a4e8-2436757798d6"),
},
},
            new GuidUUIDArray1M
{
    Id = 121,
    Value = 
new System.Guid[3]
{
Guid.Parse("7ca41946-13ad-4c7b-aa6f-f88f5f043b72"),
Guid.Parse("ae8514f7-a208-4c78-a5d8-2606e0347b3b"),
Guid.Parse("e87ba1b6-039d-4347-a2ad-f8a56069bca4"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 124,
    Value = 
new System.Guid[4]
{
Guid.Parse("a0202194-4041-42ca-b857-c2da725bdeba"),
Guid.Parse("cc9c76b6-6d21-42b6-826e-5d1a08f6d411"),
Guid.Parse("42841b74-00ae-4ff3-8b7f-fb8a586afcf5"),
Guid.Parse("af713b54-52d4-4d2d-8599-e52872f9ae62"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 126,
    Value = 
new System.Guid[4]
{
Guid.Parse("12d0ed7a-6329-41e2-9bd7-ff268439c516"),
Guid.Parse("596f1fda-bef9-44bf-a70b-23d87cc90881"),
Guid.Parse("6639bb3d-370a-4676-8d54-5f843e7d425b"),
Guid.Parse("fa99fd55-c5dd-4ae3-b0e0-edff388df7ba"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 126,
    Value = 
new System.Guid[4]
{
Guid.Parse("45f1eb9f-a761-4593-8a77-0db0439dcc7b"),
Guid.Parse("b962612a-550a-4e83-b8c5-e4f0eeca5521"),
Guid.Parse("2731dcf2-c676-4582-aaf1-74ff083f814f"),
Guid.Parse("8cdc83c3-8e86-4499-901e-e9b10cb6edc3"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("30466e5b-b53d-4f29-8d89-c5c41e7bdb39"),
Guid.Parse("01d89a6e-14fd-44b7-b795-cb67029c9f75"),
Guid.Parse("5cc06c3c-3652-4f0b-a938-86ac70f0380d"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1d32e1d8-9236-4a9c-9cf1-7c204df9d403"),
Guid.Parse("0244fb66-3ac7-49c2-bc7c-033c085035ae"),
Guid.Parse("d820ed58-31d1-4a2c-8a12-5d733895ffda"),
Guid.Parse("5ebc6734-659b-4d26-81de-05115a5538a5"),
},
},
            new GuidUUIDArray1M
{
    Id = 132,
    Value = 
new System.Guid[4]
{
Guid.Parse("73ff149c-d463-495b-8650-bbe3f99df626"),
Guid.Parse("21869b6f-8c1d-413b-bf6b-605f461e1505"),
Guid.Parse("21ba97d0-27f8-4d01-ae8b-9ba40dc5b460"),
Guid.Parse("23ebedab-c169-4bb6-abef-f046a485a063"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 135,
    Value = 
new System.Guid[4]
{
Guid.Parse("197b98a7-447d-4e43-b1e2-58560a2c2281"),
Guid.Parse("0008f445-d7ae-4e79-a3b8-2edfb2169af1"),
Guid.Parse("1fe84fcb-5506-4940-bfe8-6fae6db08d2f"),
Guid.Parse("3a26239b-1dea-438c-9820-b2ac1a46740d"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e5f1a531-b726-4eef-8a73-f5749200e269"),
Guid.Parse("2b4281a4-ee23-4f69-b467-5a10e6d90658"),
Guid.Parse("83d17669-59cf-452c-9a6e-cff4d051a2fa"),
Guid.Parse("bc86dccb-f351-4179-add4-16a265999b8e"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 135,
    Value = 
new System.Guid[4]
{
Guid.Parse("546eff5f-41e6-4b0d-820d-c3c189465279"),
Guid.Parse("c8dfc904-3152-4d71-a49b-754f261361a0"),
Guid.Parse("c635332c-3a44-41aa-b590-f32692d2ebb0"),
Guid.Parse("281c7017-547b-4203-aea6-d060d62df52f"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 142,
    Value = 
new System.Guid[3]
{
Guid.Parse("3f3784b3-660f-4f27-806d-b0f6c4b861e9"),
Guid.Parse("2621e1bb-b60b-44ee-9ca4-b6ffbcb7df60"),
Guid.Parse("f1fc9e74-b746-4bf1-b9e8-303dcdab0cd2"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ddf65ee7-0592-4b8d-9236-15bbe30eef09"),
Guid.Parse("2fe5c090-b33d-4720-919a-25e24e6f02c1"),
Guid.Parse("f33ba6af-200e-4736-ad31-75a0b8ef0e8f"),
Guid.Parse("da47eff9-001a-4749-945f-533a834b7fea"),
},
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 137,
    Value = 
new System.Guid[3]
{
Guid.Parse("24a38f38-fce1-447d-bf49-106a1b6181b6"),
Guid.Parse("66378de5-5c28-45ae-aed8-b6ef9be81d41"),
Guid.Parse("d7fc6947-2711-44d0-a555-79bfae8d3d48"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 151,
    Value = 
new System.Guid[4]
{
Guid.Parse("95ff2a2b-f3a8-449d-93ae-352eabfb913d"),
Guid.Parse("a4dc42e2-6ca6-4109-a4c7-519e39e17121"),
Guid.Parse("351764d5-e573-471e-a1ff-8b08e69e2f65"),
Guid.Parse("efb5188b-1378-41ca-bbbb-d99a2d538082"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 139,
    Value = 
new System.Guid[4]
{
Guid.Parse("5dc4c07f-80ef-47dd-8688-9f0a8e30e805"),
Guid.Parse("02bc8af0-e07e-4643-852d-b274b79efff2"),
Guid.Parse("d8eb6804-0739-4e0b-86eb-16a35eef487b"),
Guid.Parse("3ac7705f-c2b5-4511-83e1-e3dba4ef6a40"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 154,
    Value = 
new System.Guid[4]
{
Guid.Parse("3119411f-4d8f-4386-a8a8-723603e19813"),
Guid.Parse("59daa018-ec54-4ab8-8b89-dfe5987dad2e"),
Guid.Parse("a3c673a9-a26a-4373-9b5a-d9489607c10b"),
Guid.Parse("8d029694-42d9-4f01-a645-571291905b1b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("abd6dcfe-8fb3-4128-9d92-4e15181aacea"),
Guid.Parse("7c100207-24fa-4610-87f3-4a2b800f78ac"),
Guid.Parse("95137734-74a7-459f-a9b0-bbcb45efeead"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b8b67782-213b-4692-ade7-d53734d5bfd8"),
Guid.Parse("d342aeb1-5163-4f18-a738-4a7e2fcdc47b"),
Guid.Parse("a36e03c6-69e0-4fb2-ae8f-c9826373b22a"),
Guid.Parse("cf6b9324-3821-4b2d-a9d1-7e4e5d376d79"),
},
},
            new GuidUUIDArray1M
{
    Id = 147,
    Value = 
new System.Guid[4]
{
Guid.Parse("065e4312-d178-474e-ae6c-9cc80ff57a51"),
Guid.Parse("184f07ab-0213-4b1d-9363-fde0693f6309"),
Guid.Parse("8d01a2a8-beed-4501-b0ea-66c248260f26"),
Guid.Parse("48a1cada-74cd-4f91-a320-028d5bf2fb47"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 157,
    Value = 
new System.Guid[3]
{
Guid.Parse("52db85b1-2f95-4867-8620-2ab3902c5df4"),
Guid.Parse("46989186-f105-47e6-b6b6-c5cfa49111f5"),
Guid.Parse("53852388-a017-460b-baa8-92552c261f75"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 154,
    Value = 
new System.Guid[4]
{
Guid.Parse("f5998e9d-de63-4609-bf9f-bcb02d09d27c"),
Guid.Parse("51180e5f-f9cb-4dd0-a383-c2164d4335e9"),
Guid.Parse("84c578ce-1aa8-4958-a206-7304311f0a99"),
Guid.Parse("64ef987f-21ba-4b36-b105-d870659f1224"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 162,
    Value = 
new System.Guid[3]
{
Guid.Parse("c60f0047-be78-447e-814d-96be7a0b12df"),
Guid.Parse("b9584aa7-41a6-4a27-9c93-a53a74eae243"),
Guid.Parse("1338149b-7637-4912-b905-3b1199fbd808"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 156,
    Value = 
new System.Guid[3]
{
Guid.Parse("9065ca7c-d964-4df8-8f86-d892a65f71a9"),
Guid.Parse("dbb9a159-95d3-43ac-b0c7-5e04ca16a0c5"),
Guid.Parse("2c7810c8-5a33-46d2-b341-6aaca8f9db55"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 166,
    Value = 
new System.Guid[4]
{
Guid.Parse("5a87e24d-ff16-42f8-aac3-5239592d881c"),
Guid.Parse("bb96f458-428a-4933-94ab-298f94732aa9"),
Guid.Parse("bd6c162a-1998-40bf-9db8-883e7dcc0715"),
Guid.Parse("24d9e87e-001b-44f4-ac73-57d3cf494169"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b703a888-3d51-4478-bf5c-828fa07fc7ef"),
Guid.Parse("1c6a4d61-eb48-40ec-9682-b60d4d89bc93"),
Guid.Parse("518d3169-3b91-4226-be69-13c9f3fafcdf"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a7c54e20-e01d-4821-87dc-61f3c86ebde1"),
Guid.Parse("daf27861-537c-4329-adb8-e04e84748085"),
Guid.Parse("aebf7dc4-4fcb-47ac-ab60-6a370dfb5545"),
},
},
            new GuidUUIDArray1M
{
    Id = 162,
    Value = 
new System.Guid[3]
{
Guid.Parse("361f42d2-21bb-470c-9cae-a3aaa435da81"),
Guid.Parse("b1cb2dc3-8f02-42cb-8522-37f5e8bc384e"),
Guid.Parse("a678cb6c-e588-496d-834e-028de5024a5e"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 175,
    Value = 
new System.Guid[3]
{
Guid.Parse("48d1bde1-0590-49da-a08d-8a005460e7b9"),
Guid.Parse("24b2a1df-89cc-43e2-b77f-8f492af08c32"),
Guid.Parse("f1fd0ab5-39d2-42c5-a153-4cedb3caf01a"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidUUIDArray1M
{
    Id = 169,
    Value = 
new System.Guid[3]
{
Guid.Parse("5f1b5f25-3641-48ec-bc19-2d2e9ade5cec"),
Guid.Parse("5bbeeba3-c63b-484c-bd91-856492c093f4"),
Guid.Parse("ce5cbaff-23ef-437f-b06d-c3b6197e12d1"),
},
    ModelInner = new GuidUUIDArray1MI
{
    Id = 177,
    Value = 
new System.Guid[3]
{
Guid.Parse("87dd3aa7-7414-48ae-bf7a-d89c29a64cea"),
Guid.Parse("1edd2e48-da84-464a-b887-2a33c4fcacb9"),
Guid.Parse("7973aadb-db91-4ddb-9a76-17f2c172ef80"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ebd4ef76-b0ad-4455-ad15-77c6f1b96b22"),
Guid.Parse("43bab32d-3bb9-47cc-b5d1-9c91f66af08c"),
Guid.Parse("2ac5d384-0e41-4b85-bb5d-7ca85ab17416"),
},
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
INSERT INTO gedaqtests.guiduuidarray1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:UUID[]}, 
    {mi_id:Int32},
    {mi_value:UUID[]}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayUUIDArray)),
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
                    await ((IGuidArrayUUIDArray)this).InsertModelDbConnectionAsync(
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
                     ((IGuidArrayUUIDArray)this).InsertModelDbConnection(
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
FROM gedaqtests.guiduuidarray1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidUUIDArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayUUIDArray)),
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
                    var models = await ((IGuidArrayUUIDArray)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidUUIDArray1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IGuidArrayUUIDArray)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidUUIDArray1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


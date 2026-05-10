

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
    Id = 4,
    Value = 
new System.Guid[3]
{
Guid.Parse("ae577d45-d6f0-4c21-ae1e-b01fc078959b"),
Guid.Parse("5c9c69e6-7f7d-4b17-a705-5aebb943a59b"),
Guid.Parse("57c87ee5-bdb4-497d-9b64-692c897d92ed"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 5,
    Value = 
new System.Guid[4]
{
Guid.Parse("72b5a9bf-7cb4-406d-8c45-935d9d8ad077"),
Guid.Parse("436a8be0-d1aa-41ad-932b-4f4a1d4ce82a"),
Guid.Parse("037471de-3ed0-40ae-a761-8bb725cd0067"),
Guid.Parse("f1c71479-e9bd-4fd7-9c0a-8d06b972026d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("878d9d3a-9f11-4d0f-a171-aeefaebd788f"),
Guid.Parse("6cffeaed-53ea-4405-a8f0-2b6428233a6c"),
Guid.Parse("7b0daede-cdd3-44d5-9ec8-0942b472b1ed"),
Guid.Parse("c47fc1d3-0c11-4ebb-aa49-6314a26e7d53"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("442b6ae6-43b3-40e1-ab8a-588fabe6f3e6"),
Guid.Parse("189d2c73-f30a-4e95-8308-f57de64296ab"),
Guid.Parse("a205505b-1d05-4110-b811-fb123537a68a"),
Guid.Parse("07943c54-579e-42f0-a838-8b583256111c"),
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
Guid.Parse("a9ee5492-e871-46a9-8b76-800410d47c33"),
Guid.Parse("dc54d15b-c08d-483d-95b6-4ba674a8351f"),
Guid.Parse("d29350f8-a71d-4443-832a-4b971727cb0a"),
Guid.Parse("6479c52c-4f9a-47a0-a954-38f0bb62042c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("bafa35e1-832e-4617-9771-9d8b5357108b"),
Guid.Parse("d134d02e-705c-46cd-baff-fd74f277fdb2"),
Guid.Parse("7761e69b-ccdd-45a9-88fc-0ca9ca860ab1"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e9d4aa10-2b9b-4502-a28f-bcb42c375f9b"),
Guid.Parse("ca6e139c-18e3-4244-99e0-e860400846ea"),
Guid.Parse("6bcc3689-edf9-47d5-b6c4-b51f6de1b116"),
Guid.Parse("d39898a6-c5c3-46a2-a61e-b25149aaa7fe"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 19,
    Value = 
new System.Guid[4]
{
Guid.Parse("974c72de-2dcb-4cd6-809c-b9ddee9ec23f"),
Guid.Parse("2de63310-8b48-46cf-97c6-0f174121748e"),
Guid.Parse("cdd354e9-7c6c-4ea5-90c6-e202b3c84cfe"),
Guid.Parse("be4e7095-8ce0-4b95-ace5-0015aa7708ce"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("21c3cd64-5132-45b4-9c79-0addcaf4b750"),
Guid.Parse("2ed5c2db-6d9d-4999-8aee-cf90f4e73ec1"),
Guid.Parse("aed28da9-fd17-46d6-b14b-df00bcadae5a"),
},
},
            new GuiduuidArray1M
{
    Id = 28,
    Value = 
new System.Guid[4]
{
Guid.Parse("641a326c-3b60-4b61-9e3e-a0ad0b9489cd"),
Guid.Parse("24491142-1c62-4a93-9866-0637e6b60001"),
Guid.Parse("b040e844-4f92-4201-ab05-568bc3aa723e"),
Guid.Parse("76f44ee1-e1c5-4b2f-a49c-a1ef0288e598"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 24,
    Value = 
new System.Guid[3]
{
Guid.Parse("6780c63f-c14a-4d21-bb7a-cdeaf7efc376"),
Guid.Parse("f3b4c173-bb85-47c4-a3b0-203a6eec71ec"),
Guid.Parse("f8ef1877-5d34-4982-9319-103a03c33688"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bae87b90-6f7a-4438-abc1-0f4ebef3f300"),
Guid.Parse("82b121d9-01f5-4174-ad75-155128e26741"),
Guid.Parse("a6558c24-8d42-4024-bdec-084896a1410d"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("902b4c31-ae1b-4200-b8df-51ed71d26065"),
Guid.Parse("37117085-8598-4c99-bfe9-71042d580b72"),
Guid.Parse("0b3841d1-6333-44d0-89cf-47b6d9a97912"),
Guid.Parse("1678633a-8f86-4da3-be6f-0055c9764579"),
},
},
            new GuiduuidArray1M
{
    Id = 36,
    Value = 
new System.Guid[4]
{
Guid.Parse("6942789e-f526-48c4-8ea9-b725b2d9af55"),
Guid.Parse("dc7fa0e4-66ce-46a8-a7e6-51227edf2243"),
Guid.Parse("787e8471-6cdd-4528-9393-3743ec9feece"),
Guid.Parse("417516ed-d76b-412c-a835-d0e5bcb0dcca"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 40,
    Value = 
new System.Guid[3]
{
Guid.Parse("fac7cf63-c732-4eed-bba5-db3906c01f6e"),
Guid.Parse("afe3aae7-78a2-4ba4-9b41-0f3521d7fcf0"),
Guid.Parse("121922e4-0c87-40fe-bad5-fbe08e17d30b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 30,
    Value = 
new System.Guid[4]
{
Guid.Parse("b8364208-c0d7-4057-a5f5-d8343265067c"),
Guid.Parse("1746b690-3d07-48e5-b149-728137017717"),
Guid.Parse("896a971e-9a9b-48ad-a080-b5ab8d49df37"),
Guid.Parse("5788dfb1-2b6b-4e01-8c37-9cc964f5d367"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7c09b9b3-9b7b-4da0-a3a9-1e2278c9e904"),
Guid.Parse("44214de6-0d84-4600-a180-17ae76890430"),
Guid.Parse("7499615c-a808-40da-ab10-945ab28aaa2e"),
Guid.Parse("57ad5f5d-0852-4051-baa0-2026c46758c9"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("454a793d-59d1-45bd-a997-f2a3f4cb7615"),
Guid.Parse("df5115e1-df27-4d09-9ccf-3b61bfe38317"),
Guid.Parse("f2472fc9-144e-4f3c-8fd0-ca591947e70b"),
},
},
            new GuiduuidArray1M
{
    Id = 41,
    Value = 
new System.Guid[3]
{
Guid.Parse("7018b6b0-615a-4a84-9f43-041faed55477"),
Guid.Parse("b3a9a9c6-ce89-4628-8d04-c478dcb21091"),
Guid.Parse("cd03c142-5728-4bc3-a3f7-ad149f8b1ca5"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 47,
    Value = 
new System.Guid[3]
{
Guid.Parse("8e7a2783-d9bc-441e-b04b-a2f05226db2f"),
Guid.Parse("214c0f86-c1ee-4787-a768-f241a1fd1a5a"),
Guid.Parse("1102d6af-663d-4971-9410-9ef0fa3b40af"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 33,
    Value = 
new System.Guid[4]
{
Guid.Parse("99faf460-d63a-4b85-97b8-e66cec14a1a0"),
Guid.Parse("4b5106e2-cfde-4357-b606-9c53e539e0f1"),
Guid.Parse("2b996e84-e369-4ea8-8d36-0ba5279981c9"),
Guid.Parse("04730ff4-63b4-48d0-a03e-eb8dfa82b5e8"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c668cbc7-5d79-40bc-8056-d5f425f65e1f"),
Guid.Parse("36df36a9-f3d4-4382-8677-a23394666953"),
Guid.Parse("97e6f051-60ad-4074-bd1c-c7e0a265ee4b"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 48,
    Value = 
new System.Guid[4]
{
Guid.Parse("02553ff9-ef00-4283-a320-f5a06e2e4f50"),
Guid.Parse("1b35238b-bf13-41b7-a330-b183a6ec4bac"),
Guid.Parse("43b3d05d-0f89-4e43-98ec-251b40de8689"),
Guid.Parse("8df6142c-dd1d-47d7-b20e-b65561479bc0"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("20aeeb89-a2b3-421f-8ff4-890478506696"),
Guid.Parse("e9205108-799b-4081-8e30-4673774b5073"),
Guid.Parse("5309ccf2-eb10-46d1-9d1a-b4c7a7964a3a"),
Guid.Parse("5d581515-ed7e-4251-b2de-c10e540d5076"),
},
},
            new GuiduuidArray1M
{
    Id = 55,
    Value = 
new System.Guid[3]
{
Guid.Parse("476583eb-0320-4a90-b4f1-28c6ac63e934"),
Guid.Parse("f3274361-e614-4944-bd61-fb64ef753311"),
Guid.Parse("c2f5a15b-9882-4695-b252-8a42763dcc1e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 40,
    Value = 
new System.Guid[3]
{
Guid.Parse("75708f68-0cda-44a8-9af9-d6c8170d5580"),
Guid.Parse("ed0f4f04-4d25-4d24-8e03-c9d3582da59d"),
Guid.Parse("9ab4333c-f1cc-41e9-be61-b6062292e8c1"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 64,
    Value = 
new System.Guid[3]
{
Guid.Parse("273b91a0-88fa-4a6c-b6b2-29b99884f685"),
Guid.Parse("7b442a73-fe45-4b57-b305-e441f5b68288"),
Guid.Parse("df6e38ef-1f6c-4d32-b4b9-13bf9709d729"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 71,
    Value = 
new System.Guid[3]
{
Guid.Parse("87f00d72-b579-47ba-a2e3-6f20e6a5b290"),
Guid.Parse("5da01381-75c3-460f-b124-73ddd83639e9"),
Guid.Parse("e7c65fdf-1419-4ace-813f-6cb1c185e16c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("1a548aaa-9bd6-4484-afb3-ca276525ff07"),
Guid.Parse("baa04722-5ce6-41d3-bb89-635ad2ffbe28"),
Guid.Parse("e18d1bcf-c820-47bd-9ef3-62dab7125218"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f58b285d-8d9b-4cb0-a374-4a7178cc0c4c"),
Guid.Parse("80a4f80b-0ed2-4354-ae15-722806c6435e"),
Guid.Parse("92351001-e2cd-401f-8e54-137475fb82c7"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("bbd5b5fd-cbf9-4a05-bbb2-93feabee0b68"),
Guid.Parse("c0505775-57cc-4226-a035-6c7b3947d2bf"),
Guid.Parse("8454de75-86b5-4013-8e79-80bff32025fc"),
Guid.Parse("c26e16a5-5b42-4170-bcda-f4722ceb4bdb"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fe6e1162-6486-496a-9fb4-2fed4971776d"),
Guid.Parse("66bd0046-225d-4633-8a14-03f7485babeb"),
Guid.Parse("c6a3145e-e393-4fb0-b270-749d722c9457"),
},
},
            new GuiduuidArray1M
{
    Id = 83,
    Value = 
new System.Guid[4]
{
Guid.Parse("6d3ab382-d540-4c18-83c1-fb8b7029b1a5"),
Guid.Parse("f89525f6-af94-42f6-86ac-b4126aa83f87"),
Guid.Parse("94162ddf-2149-4ddf-9052-9fffe3ff283a"),
Guid.Parse("a47d827a-4a71-4443-8d3f-723a22f606db"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("14df0262-aea2-42f7-ac50-00aba6701dd0"),
Guid.Parse("b4060c46-9261-4573-b6c9-a3134afde854"),
Guid.Parse("6bfe8a15-dafa-42af-9847-c51594a57a35"),
Guid.Parse("87cd5aca-1938-4c48-bb15-73636532e614"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9c813062-e941-4d52-b30a-01e372b1caa8"),
Guid.Parse("e9852820-e809-45dd-a445-88a76dd05541"),
Guid.Parse("c9f4b1df-6740-482d-81cc-6a1201daaeca"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3abbcb5e-a577-4f6a-a510-e213d43e253d"),
Guid.Parse("d663ac58-f7e5-45d5-b8d9-f1acb87820c3"),
Guid.Parse("a662c0ae-0e74-4b32-a241-8e946b6fefaa"),
Guid.Parse("7bd53a2e-9f75-46ce-bde8-124fcddd048f"),
},
},
            new GuiduuidArray1M
{
    Id = 84,
    Value = 
new System.Guid[3]
{
Guid.Parse("a6b404ac-a4dc-4aca-9e8d-8aaed50535f6"),
Guid.Parse("db70f3e8-4bec-4e7e-a5b4-7ba41821d62b"),
Guid.Parse("f0488d7b-23ad-4d57-92d1-73c356b0f40b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("bc72924a-3f69-480b-b0fe-60e85331a5c8"),
Guid.Parse("44f944c6-bec1-45b8-ae48-119b73ddb9d2"),
Guid.Parse("e6adedb4-067e-465a-bff3-c0859ac9ee5d"),
Guid.Parse("4dd61f7f-8390-444a-b3bd-fc38d75a5f10"),
},
},
            new GuiduuidArray1M
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("fa4fe568-f058-4db8-89ee-89ebd6d510da"),
Guid.Parse("84e32857-618d-40db-a096-38fb8c6c60fb"),
Guid.Parse("e3228cd1-3e6f-46f1-978b-4141790a5f7c"),
Guid.Parse("e0079713-ebb0-4d26-8410-a701446d7172"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 60,
    Value = 
new System.Guid[4]
{
Guid.Parse("f34b69bd-ccf9-4b74-b0a1-04e61bf7a143"),
Guid.Parse("7dc05bd3-f45a-4f89-9e20-1a1b21cb88b0"),
Guid.Parse("7851e0a4-a577-494f-a32e-241295f9e266"),
Guid.Parse("5ab2b434-db00-427c-8a46-1dc025c1e3ca"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a2dc9627-61c8-4189-b8c1-3ec707bf8d01"),
Guid.Parse("9879d90b-eae1-4b49-a347-f47e48c3afbf"),
Guid.Parse("36a02840-5b82-48c5-8f37-d567bc32aeb7"),
Guid.Parse("b3e847a9-9de9-4fda-a902-e5851f2d24f9"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 97,
    Value = 
new System.Guid[4]
{
Guid.Parse("a6e5e443-2424-4097-ae2b-496db96af5e0"),
Guid.Parse("323ac36c-a2b8-4fee-a840-fd9ebb578847"),
Guid.Parse("52974fc0-5c96-4a64-8d5d-89ac8976a87f"),
Guid.Parse("e9dbc952-7665-441b-aae8-ca31904f8bdb"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 101,
    Value = 
new System.Guid[3]
{
Guid.Parse("c2c6261b-05c4-476b-9e29-bec044363042"),
Guid.Parse("21c12aba-a802-4b7a-874e-515f8d404857"),
Guid.Parse("7a503c68-327e-4d95-91d7-c826fc6ad6ca"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 61,
    Value = 
new System.Guid[4]
{
Guid.Parse("af4cd0d1-845c-4b21-97c3-4e30b8fa15e8"),
Guid.Parse("bd7905ee-869e-44dc-a6e6-584eed9e5d13"),
Guid.Parse("8d19dae9-da8d-4308-bcdf-91cae7cafc30"),
Guid.Parse("1a87ff4c-9664-4473-a8ee-4954f0fcac8b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("435b1741-6142-43ce-90d6-dd8f65cd2885"),
Guid.Parse("267ef0af-fae0-4550-845c-90b58546f699"),
Guid.Parse("04898c6d-c460-4df1-a758-55ed4d7ca373"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 106,
    Value = 
new System.Guid[4]
{
Guid.Parse("a7be2e90-6160-4ca6-84a0-4409cad86bca"),
Guid.Parse("9261bf73-31d6-44ef-90b6-2e2fe2b3fbdb"),
Guid.Parse("71b94fd3-da74-4cf9-9120-fa0af69ed911"),
Guid.Parse("e9535df1-c117-4762-8f1f-730e511fc576"),
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
Guid.Parse("eb62ecde-f8e3-4cd8-b2f9-5ced04268fe8"),
Guid.Parse("0e03d1a2-a44e-439d-8680-77a1ba093585"),
Guid.Parse("b26147ea-dcbc-4eff-9c26-f4932518f492"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 66,
    Value = 
new System.Guid[4]
{
Guid.Parse("f41eb19b-5f46-4750-b2cd-35f7943cb98a"),
Guid.Parse("770f2b82-e6cb-4902-beff-232b99a755ae"),
Guid.Parse("222b86ed-3178-4c1d-817c-774310177c5b"),
Guid.Parse("d2c4ae59-d3b4-4c85-9b8d-8650f3e016e0"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("cac1f975-32bd-48ec-a081-02e2c9615021"),
Guid.Parse("8720b01f-d848-46f7-9ef8-bc424f10d8ce"),
Guid.Parse("94f56418-8fc0-4060-8e6c-6be763b4578e"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 116,
    Value = 
new System.Guid[3]
{
Guid.Parse("5a022a2c-eb8c-4dda-97e7-035ad971b596"),
Guid.Parse("c902ef02-bdba-42c9-ba4d-f14fc7ab917a"),
Guid.Parse("774256b3-35b0-4678-98ec-73428c554f01"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("eb95187e-0980-4cde-9143-ce0d830a47a3"),
Guid.Parse("fbbe3b33-0cdf-4d34-b3cb-908810fe1c2e"),
Guid.Parse("358cdde7-00a6-48ce-ab57-406d2969765f"),
},
},
            new GuiduuidArray1M
{
    Id = 121,
    Value = 
new System.Guid[4]
{
Guid.Parse("8ce38a3d-b64f-4aef-a99c-97087e1590e6"),
Guid.Parse("79e277d9-011e-48fb-9aec-20a10d61f14c"),
Guid.Parse("ecd52a8c-4891-45bd-9dbe-3333a9b6c1a4"),
Guid.Parse("0a429bdc-acb8-448c-a6f7-f6be3afe48f0"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("9a656518-0c15-4a32-bc2c-168df0ced0de"),
Guid.Parse("2af6e07b-c075-46b2-b687-684ce9949bd5"),
Guid.Parse("710b4550-3a35-41f7-9863-bd63b9460597"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d02540fa-b2b9-42ee-ab2c-1bd9b866685b"),
Guid.Parse("b9711738-d945-465a-b3f4-c23bdb42f86b"),
Guid.Parse("491ed00b-cba4-42a4-8f29-f8c0c441a3db"),
},
},
            new GuiduuidArray1M
{
    Id = 130,
    Value = 
new System.Guid[3]
{
Guid.Parse("769ede67-ddee-4a14-acad-a8098e2abe23"),
Guid.Parse("661862ba-f1bb-46ab-a7da-72a4ba222d21"),
Guid.Parse("eac05d9a-cdf9-45ad-b248-0eb3158bf575"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("96ae9739-dd38-4630-a711-17953d09d2e1"),
Guid.Parse("9bd296e2-b592-42d7-aa20-66e0d2c20e90"),
Guid.Parse("1443199a-4b56-4b35-8b1e-1b677e1ba5ff"),
Guid.Parse("28b0d578-a51b-433c-bbf2-9f757a8f71a5"),
},
},
            new GuiduuidArray1M
{
    Id = 136,
    Value = 
new System.Guid[4]
{
Guid.Parse("2d44f390-6ed9-4df0-b2ca-4025d0503a52"),
Guid.Parse("c697b86a-759d-480b-824e-0e739a39d83a"),
Guid.Parse("2f9a9537-c6e5-4e9c-bcf6-f05b47d4601f"),
Guid.Parse("480dcf06-58d8-4108-abd3-a93c48d9c9e1"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("989759ee-e125-49f2-a228-52ca36b00c3a"),
Guid.Parse("d82cde89-a2e2-4cb8-9542-e12b4071bee7"),
Guid.Parse("abf352e9-d2ba-4b80-bf2a-f113810bb876"),
Guid.Parse("875169f8-6fd8-4dab-8f25-dc469e39e5fd"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 143,
    Value = 
new System.Guid[4]
{
Guid.Parse("301fe447-fea2-4927-814f-2e2b74fc054f"),
Guid.Parse("0a571cb1-ee0d-4a8e-a65a-0f11a11416ee"),
Guid.Parse("a1057d2a-907d-42e3-9400-c36cf8260da1"),
Guid.Parse("89139660-6b93-4658-bce3-7f4ffaefc94a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9794050f-074a-49e7-a3f6-6ad7666eea7c"),
Guid.Parse("308f2388-bdf4-416f-abc1-5fcb766b8f2f"),
Guid.Parse("9ff7c653-4387-4207-a368-d5924121f21f"),
Guid.Parse("a12c9e23-3649-43ff-85cc-0d81a65f97c8"),
},
},
            new GuiduuidArray1M
{
    Id = 152,
    Value = 
new System.Guid[4]
{
Guid.Parse("54c831d4-9a3a-4b36-b549-4d2e6ec6da61"),
Guid.Parse("6efa7c66-4f39-46ac-828a-90f129326fc9"),
Guid.Parse("5aba8b5b-2bbc-4417-b760-5afadc880f7b"),
Guid.Parse("b31aa7e2-e8fb-4263-b20a-15f29c2057e0"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("066d057c-2103-4a78-9706-dc677470692a"),
Guid.Parse("f2573ff2-14f9-47f0-8484-e49888a1a404"),
Guid.Parse("85c60f03-9bcc-4720-a4ac-6125384dcb59"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("98090894-d21d-424d-95d2-74cd8c95e1e4"),
Guid.Parse("ef2f3006-d1c1-4014-aba3-d7ac53337bf1"),
Guid.Parse("2c3dae49-a4af-42bd-8a60-dab8dbc2fb65"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 153,
    Value = 
new System.Guid[3]
{
Guid.Parse("9eeb0f5c-46ed-4823-bcb9-e86b91bbf461"),
Guid.Parse("8b663ccb-a596-4975-ac7f-b677d7b30868"),
Guid.Parse("be32a64c-a3c1-4403-9a69-7d319272d4ed"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bfc29a54-a019-428b-b582-8669792a77d4"),
Guid.Parse("1d79ecbb-5f4b-41bd-8b10-b645f59bc092"),
Guid.Parse("13948a13-a7c5-4230-a7c5-5db27d7ec3df"),
},
},
            new GuiduuidArray1M
{
    Id = 162,
    Value = 
new System.Guid[3]
{
Guid.Parse("7b66ea74-9b5a-4a70-97cb-679ccf87275f"),
Guid.Parse("6ed981d9-c0ad-4de1-a0c0-0a5aa97149c5"),
Guid.Parse("81dab8b9-06bd-4582-be76-29f3f99136a8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 81,
    Value = 
new System.Guid[3]
{
Guid.Parse("6605c1ed-d7d3-48ae-a4bf-cf15d4960d5b"),
Guid.Parse("97e9dc30-3f94-4eb9-9186-f59e3780740d"),
Guid.Parse("3c154cab-f425-468f-95e5-e21b9c5b6252"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b57cdcbb-2fec-41d9-98c2-ee7505b9a53a"),
Guid.Parse("5ded8e53-a6b7-446f-aee1-5550c2d348da"),
Guid.Parse("9bc47b2e-cd23-430b-8c8e-70d28354ebdd"),
},
},
            new GuiduuidArray1M
{
    Id = 170,
    Value = 
new System.Guid[3]
{
Guid.Parse("a01946b4-e8f8-474e-8054-53060e1f8ae2"),
Guid.Parse("6942dfce-e245-4192-93b2-ba884fefb721"),
Guid.Parse("06879bd4-5ae3-413a-b617-b3e340f4356b"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 179,
    Value = 
new System.Guid[3]
{
Guid.Parse("e54f5244-3bad-4587-af3e-8f3f87408b06"),
Guid.Parse("55823bb1-1669-4654-a61e-00c5164b45a5"),
Guid.Parse("e76756d6-5557-4869-b712-a69d4b34111d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 88,
    Value = 
new System.Guid[3]
{
Guid.Parse("619ddb8b-73bc-42c8-93bf-4c93eabbbd2c"),
Guid.Parse("d8cfebc6-5cb4-474d-bcd5-dda657bb6c72"),
Guid.Parse("35c35379-ac1e-4bb5-9cba-9e18de006cf3"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 184,
    Value = 
new System.Guid[4]
{
Guid.Parse("7fac3443-c465-41e6-9474-02ac1d058e4d"),
Guid.Parse("ceb80248-1aba-4fc0-8d94-9144cc4d2520"),
Guid.Parse("6f70ea49-e7a5-4711-b074-5b838e74625b"),
Guid.Parse("d4fe6737-208a-40ef-9725-e4a8ce427d4d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("979166c7-e5cb-48d4-83ab-7987de1f5f52"),
Guid.Parse("a3ca00a8-d342-400d-acef-2a4f76da7ece"),
Guid.Parse("cabdb9fe-2555-4c24-9ad7-4556ee4aa7dc"),
},
},
            new GuiduuidArray1M
{
    Id = 189,
    Value = 
new System.Guid[3]
{
Guid.Parse("c9bdb75b-5175-48ac-85ac-a0d4a29555cd"),
Guid.Parse("656a6a97-fe06-4253-87f9-fb8eb4026c53"),
Guid.Parse("40dd6623-8aed-4b16-bed5-b90764ab15e7"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 91,
    Value = 
new System.Guid[4]
{
Guid.Parse("aaf23ae6-ec62-44b6-9472-79b3b96d0594"),
Guid.Parse("dc58855f-edd0-45e1-9c5d-ff78bbc9475c"),
Guid.Parse("45b6a8f6-4aab-4ee0-ad0d-55db5d0c0ee9"),
Guid.Parse("f4e99ff3-c71e-41c0-b0df-36f251fc37a9"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("064dedd8-0716-4abd-b4c9-be184b37cf04"),
Guid.Parse("002d6910-8ff8-4b23-9a68-1d5e3ac175e2"),
Guid.Parse("85d1e849-34ed-419d-b14d-1838b86b93f2"),
Guid.Parse("1f7157e7-2b5a-4c3a-927e-ad7f977f7142"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d16e05bf-068e-4601-9c27-ef49bb121764"),
Guid.Parse("d28dbea5-0e3a-4423-8b19-643d0d9a74fd"),
Guid.Parse("2dbdc315-c865-4823-b33e-8065ac53cef0"),
Guid.Parse("b9bb99db-3b28-4734-9be2-836128c63dc7"),
},
},
            new GuiduuidArray1M
{
    Id = 194,
    Value = 
new System.Guid[4]
{
Guid.Parse("de0b84e4-e9b8-47aa-97d7-f33a9405587b"),
Guid.Parse("38727463-5649-492a-9ded-8e99315d1fe9"),
Guid.Parse("088b33e1-002f-45d6-961c-092d9f2ae4cb"),
Guid.Parse("483a7612-43ab-4807-95f3-20fe4d85997e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8cfe5152-b60e-484b-b637-a7c24087bd53"),
Guid.Parse("e8249b95-53a7-4183-b3d6-db3470b114a6"),
Guid.Parse("bba1163b-c63b-4d3e-a25d-65bc4350abb9"),
Guid.Parse("38f31a0f-1d12-457a-bf7e-836b73473674"),
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
Guid.Parse("21c3cd64-5132-45b4-9c79-0addcaf4b750"),
Guid.Parse("2ed5c2db-6d9d-4999-8aee-cf90f4e73ec1"),
Guid.Parse("aed28da9-fd17-46d6-b14b-df00bcadae5a"),
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
Guid.Parse("902b4c31-ae1b-4200-b8df-51ed71d26065"),
Guid.Parse("37117085-8598-4c99-bfe9-71042d580b72"),
Guid.Parse("0b3841d1-6333-44d0-89cf-47b6d9a97912"),
Guid.Parse("1678633a-8f86-4da3-be6f-0055c9764579"),
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
                Assert.That(nullable, Is.Null);
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
new System.Guid[3]
{
Guid.Parse("454a793d-59d1-45bd-a997-f2a3f4cb7615"),
Guid.Parse("df5115e1-df27-4d09-9ccf-3b61bfe38317"),
Guid.Parse("f2472fc9-144e-4f3c-8fd0-ca591947e70b"),
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
new System.Guid[4]
{
Guid.Parse("20aeeb89-a2b3-421f-8ff4-890478506696"),
Guid.Parse("e9205108-799b-4081-8e30-4673774b5073"),
Guid.Parse("5309ccf2-eb10-46d1-9d1a-b4c7a7964a3a"),
Guid.Parse("5d581515-ed7e-4251-b2de-c10e540d5076"),
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 4;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidArray1M.AssertModel(models[0],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        GuiduuidArray1M.AssertModel(models[0],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 179;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidArray1M.AssertModel(models[0],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 11, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[30],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 40, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 4, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 130, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 170, query1, 84, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 170, query1, 9, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 41, query1, 19, query2))
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 121, query1, 184, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 40, 170))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        GuiduuidArray1M.AssertModel(models[0],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidArray1M.AssertModel(models[0],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 48, 170))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidArray1M.AssertModel(models[0],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidArray1M.AssertModel(models[0],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[34], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                GuiduuidArray1M.AssertModel(models[0],_testData[25], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[26], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[27], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[29], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[30], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[31], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[32], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 19);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(30));

                GuiduuidArray1M.AssertModel(models[0],_testData[5], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[6], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[7], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[8], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[9], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[10], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[11], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[12], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[13], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[14], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[15], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[16], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[17], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[18], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[19], false);
                GuiduuidArray1M.AssertModel(models[15],_testData[20], false);
                GuiduuidArray1M.AssertModel(models[16],_testData[21], false);
                GuiduuidArray1M.AssertModel(models[17],_testData[22], false);
                GuiduuidArray1M.AssertModel(models[18],_testData[23], false);
                GuiduuidArray1M.AssertModel(models[19],_testData[24], false);
                GuiduuidArray1M.AssertModel(models[20],_testData[25], false);
                GuiduuidArray1M.AssertModel(models[21],_testData[26], false);
                GuiduuidArray1M.AssertModel(models[22],_testData[27], false);
                GuiduuidArray1M.AssertModel(models[23],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[24],_testData[29], false);
                GuiduuidArray1M.AssertModel(models[25],_testData[30], false);
                GuiduuidArray1M.AssertModel(models[26],_testData[31], false);
                GuiduuidArray1M.AssertModel(models[27],_testData[32], false);
                GuiduuidArray1M.AssertModel(models[28],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[29],_testData[34], false);
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




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
    Id = 7,
    Value = 
new System.Guid[3]
{
Guid.Parse("edcd4951-212c-473c-a4ad-d2b5052bf965"),
Guid.Parse("e0fda6d7-7d52-4ec5-9f16-1bc4510ed2cc"),
Guid.Parse("2b20790c-6b9f-4349-9b6e-495599463ca7"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1f1fd335-62fa-4953-be59-aff6a1c3ac7c"),
Guid.Parse("4a1868f4-eb21-49b8-a9ef-db5aa85d95ac"),
Guid.Parse("55560a1b-d068-4412-afbb-f44804907b53"),
Guid.Parse("f763f4fc-a96b-4f30-b2be-b3f46fa445b3"),
},
},
            new GuiduuidArray1M
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("e9d87787-7536-44c2-af69-5aa30d14a903"),
Guid.Parse("3ee705c7-bf2d-4b00-b5ed-549a5a68a2b8"),
Guid.Parse("667f02e5-b3f9-4901-af2b-2eb85b892cc3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 4,
    Value = 
new System.Guid[3]
{
Guid.Parse("c4dbbe96-d73d-4eb2-8926-53e37e4b3deb"),
Guid.Parse("f132f23b-f161-48b9-b76d-c870653b285b"),
Guid.Parse("32124034-98eb-405c-80eb-24f0006f8eeb"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bd5a6edb-7391-4f7e-85bc-cec5f65344d8"),
Guid.Parse("f41b5f20-80cc-4835-9e88-a66392c5a2e0"),
Guid.Parse("7525d519-7da3-4a1e-9a75-6363e696d2d3"),
},
},
            new GuiduuidArray1M
{
    Id = 18,
    Value = 
new System.Guid[4]
{
Guid.Parse("852777b6-5178-432b-b5e1-a1599c067699"),
Guid.Parse("a6e406cb-f7cc-4e79-bce5-03c04ccc7eab"),
Guid.Parse("48a70c66-bd91-4f54-883e-31691edc64cf"),
Guid.Parse("7bd7fefa-78fe-4fb3-9159-6482941602c1"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5fc3feb8-6466-4639-9894-828ea15d9bb8"),
Guid.Parse("c2e4b9a2-8638-4ffc-b1b3-838a44500454"),
Guid.Parse("1780509e-a395-46c4-8a15-ff927d8af387"),
Guid.Parse("8c3569f5-f8c9-44f6-a011-5d8308692094"),
},
},
            new GuiduuidArray1M
{
    Id = 19,
    Value = 
new System.Guid[4]
{
Guid.Parse("31138141-45b0-4499-9211-e3049e52ce86"),
Guid.Parse("bceb2a2c-ea2d-4ed7-9619-341a1f671abe"),
Guid.Parse("270bc303-a44a-451b-97bf-2bc3873ea7e8"),
Guid.Parse("04a43d67-57c1-4890-bc9c-d17a0e58aa55"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 6,
    Value = 
new System.Guid[4]
{
Guid.Parse("d85dfcb4-6d77-46f6-97b3-bf40f68ceefa"),
Guid.Parse("059a459d-9975-4b0b-b734-6ff24311a621"),
Guid.Parse("2f38edbf-a8bd-471f-901e-753e433e1002"),
Guid.Parse("7fb53fa1-51bd-4be4-91e0-a5b4463399ee"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("663722bf-0d17-4c2a-8709-97c31ba38341"),
Guid.Parse("327910aa-a835-425b-84e3-b1fcc2891b4e"),
Guid.Parse("c913167a-f197-4e61-8e38-f67425868eba"),
Guid.Parse("04effc4f-9723-42b9-84e3-2c4740624c5b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6d7a64d5-af9c-46ec-bee9-8eba2770e4cb"),
Guid.Parse("11e42174-a0eb-4d62-9f02-9e9f3db6d9f7"),
Guid.Parse("31d984b0-8354-413b-907b-87588bc44ccb"),
},
},
            new GuiduuidArray1M
{
    Id = 30,
    Value = 
new System.Guid[3]
{
Guid.Parse("0ff10843-6405-4cef-9501-62039c4b435c"),
Guid.Parse("f9896cf1-3c7d-4c5e-b984-6225768b5770"),
Guid.Parse("ec8858b6-6499-4681-b8f5-2e877e5ac592"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 15,
    Value = 
new System.Guid[4]
{
Guid.Parse("b5454bc0-7d0f-4b58-ba9d-297ad1480b41"),
Guid.Parse("5972c3ee-c094-40f6-9391-d52a12aa20e1"),
Guid.Parse("331cef8a-fae5-4feb-9de4-4e5feb24d44c"),
Guid.Parse("12760940-1459-492f-bae8-f0cc41788e3b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a27cb55e-513b-4ba6-b81e-6f26e9c29ede"),
Guid.Parse("fc1a37d5-a6b7-48a4-981f-3e8f0050998e"),
Guid.Parse("57010ef4-0ccd-42c4-9f60-aaf45f96a5e8"),
Guid.Parse("73292a56-9b11-4efa-8d79-d09e897ac7a2"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a216e389-ccfd-498a-8192-cae130c8e9dc"),
Guid.Parse("6946507c-8c1d-4d63-a380-ac290e194f61"),
Guid.Parse("efd2037b-41ef-4704-b590-07dbb6c56334"),
Guid.Parse("8e72f4e7-dbfa-41ed-a178-5186491bd075"),
},
},
            new GuiduuidArray1M
{
    Id = 38,
    Value = 
new System.Guid[3]
{
Guid.Parse("51d25833-c3df-4acb-82a9-e8be2846cbb2"),
Guid.Parse("f6115206-e1ce-4a98-a029-44ab657be15f"),
Guid.Parse("21ec88dc-290f-4f04-aaf6-1e4a613aba84"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 46,
    Value = 
new System.Guid[3]
{
Guid.Parse("0dc6e19c-f1b0-4486-8a14-fde0b5c24ee8"),
Guid.Parse("53010be0-f2c4-4475-9caa-1ae942aa9ba3"),
Guid.Parse("5d7387f0-205d-44d9-9cb7-68f5d9a685b9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 21,
    Value = 
new System.Guid[4]
{
Guid.Parse("4c499aa7-74a7-4a27-9c9b-bd0c62fbae45"),
Guid.Parse("29c0f12a-b0b0-4211-8d8e-df6e235f7e25"),
Guid.Parse("7555377b-66b4-4601-b0f8-bd30f3133f67"),
Guid.Parse("d2b033cd-157a-4995-8e68-649a76b1b603"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e6652239-2656-4cb5-aebd-2267a852db19"),
Guid.Parse("420d8649-bf31-4564-a012-fc08bb32a219"),
Guid.Parse("8d1e2561-b27e-4626-a9bc-f600c95c5bed"),
},
},
            new GuiduuidArray1M
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("5e303e5d-ddd7-4c68-bc33-d9fb9c3e7cca"),
Guid.Parse("a65246fc-11fa-4c86-997e-fe6928b79e17"),
Guid.Parse("0253ff50-2b46-4250-a166-0ca7b05d1dd3"),
Guid.Parse("89716a6a-d181-48dd-bc4a-c40bbbd34ff6"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 64,
    Value = 
new System.Guid[3]
{
Guid.Parse("512febbd-2a54-400e-a9ef-c3c01a846f44"),
Guid.Parse("b7bdbf34-1fb5-4ba6-90a1-c3925b45ca3a"),
Guid.Parse("299a20df-1954-43af-b835-d0b996b92728"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("192024b1-7f48-4e69-92d1-a1085983ba94"),
Guid.Parse("80046573-2b9e-4d7a-bb15-558a6cc99984"),
Guid.Parse("56250920-28ef-4a69-a804-9ef276d8ee5b"),
Guid.Parse("97c2bf8e-97eb-4ebf-b372-135403994430"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("12791f7a-d115-4f99-a44b-3cdd9caa7baf"),
Guid.Parse("a1becb9d-aa9e-42f9-bf1c-b0c9dc8003ae"),
Guid.Parse("ae7a5d71-2407-44db-92e1-c54375ed2b05"),
},
},
            new GuiduuidArray1M
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("5d0e24ae-8b19-4ae1-9e86-c75328415652"),
Guid.Parse("95944a0e-c09d-47fc-b12a-c10fc208c9b0"),
Guid.Parse("60da1afc-1d44-4021-9a20-7cf257bb8128"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f3ca4e10-7e6b-44df-a1cb-522172af78a8"),
Guid.Parse("5e3de7bd-b069-407f-9c77-efff9a43538f"),
Guid.Parse("17a54650-1d6f-4297-9bce-5e873d925198"),
},
},
            new GuiduuidArray1M
{
    Id = 70,
    Value = 
new System.Guid[4]
{
Guid.Parse("4dac4883-0f5c-4be8-81ea-1f5609fd9314"),
Guid.Parse("8acb4bd3-4e05-4878-8988-11bf7de1fc8f"),
Guid.Parse("5734d792-d05c-4bc2-b9f2-33e8721fff34"),
Guid.Parse("30d39676-8abb-45fa-9a41-6aae13836f46"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 27,
    Value = 
new System.Guid[4]
{
Guid.Parse("bdf08769-2e21-40a3-9db5-56fff17072a4"),
Guid.Parse("9e727f44-60bf-4a4e-8e53-18fb597db2f7"),
Guid.Parse("77f2b775-e87c-4f38-a86c-3557b56499a5"),
Guid.Parse("df38bfe2-e432-42a3-8c5f-eee043077989"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 75,
    Value = 
new System.Guid[3]
{
Guid.Parse("d7f5f58b-640b-4f45-8524-437385cd22d4"),
Guid.Parse("3b4b5c32-9391-44fb-a706-227815041f6e"),
Guid.Parse("a5d5faff-fe8a-47e0-9264-38f6677429a2"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a4c4d28f-b1db-435a-b268-889f338fed14"),
Guid.Parse("b5f45c8d-a0cb-4943-83d0-5b2ba16ab7c3"),
Guid.Parse("c33e016d-3099-43fb-a10a-014462450278"),
},
},
            new GuiduuidArray1M
{
    Id = 80,
    Value = 
new System.Guid[4]
{
Guid.Parse("90ac7a2b-4849-402a-8b9d-588ea506cad2"),
Guid.Parse("56fd2772-b5b9-4f50-a9b2-9cce6458ac41"),
Guid.Parse("0a5c005e-696c-4d85-ab48-b9eaffe6725a"),
Guid.Parse("08b54d54-7de9-47bf-a1dd-201fe2d8edf0"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 30,
    Value = 
new System.Guid[3]
{
Guid.Parse("4967fc46-14be-4b00-9756-a93675ec13c2"),
Guid.Parse("974ce7ec-05db-4947-aaaf-d56135e244ef"),
Guid.Parse("cb6de95e-2c4b-49aa-8618-3e1f71944f71"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 82,
    Value = 
new System.Guid[3]
{
Guid.Parse("39a0487a-5299-431c-9e07-ff6453ce79a4"),
Guid.Parse("d9c3cfaa-ec41-48c0-b826-735727a39079"),
Guid.Parse("4324fff3-ca91-4fd3-ac5b-c230255df92c"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7a35f2fc-0bc3-4c1c-9e50-07c6582cc557"),
Guid.Parse("dde8711a-bb9c-49ef-9e10-854e2149a498"),
Guid.Parse("a6728c29-f8fa-47fc-afad-1c64790bb7fb"),
Guid.Parse("62771fe0-9073-4914-a8de-c09bc929b042"),
},
},
            new GuiduuidArray1M
{
    Id = 91,
    Value = 
new System.Guid[4]
{
Guid.Parse("351a5bbe-7513-4f81-9e84-81f6d9ea604e"),
Guid.Parse("b5db9675-5453-41b5-bffd-f429c88fe722"),
Guid.Parse("18f8e1a7-8b6f-48a3-afbc-25bf7ab73307"),
Guid.Parse("b9e8e3ba-bc81-442a-8f91-85e26dc519bd"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("f026f576-9d11-410b-a374-c20e4aa3af7d"),
Guid.Parse("11eed9dc-0da0-428b-86ca-d38bed315bb5"),
Guid.Parse("3a196bba-fa4c-4030-8355-4706453e9d91"),
Guid.Parse("9c2e94b8-e7c9-4379-9c28-78b6d9435529"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("85588e42-f4dd-4d7b-a456-0cb503e53fe7"),
Guid.Parse("214e491f-b20b-4267-ba1e-d55202e47244"),
Guid.Parse("71e6ab08-efee-4d7a-80a2-62f339967fdd"),
Guid.Parse("ea5d0447-9812-4a93-a5f3-25eaa1f16aec"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4879382c-8ddb-4e56-b78d-1bcd6a207486"),
Guid.Parse("696731f3-a27d-405b-8ac4-024c421e8a4f"),
Guid.Parse("ddd374c4-d848-42e7-b697-0424bddaa52c"),
Guid.Parse("75dc0a5f-0417-4237-9e86-f77ff405ea69"),
},
},
            new GuiduuidArray1M
{
    Id = 95,
    Value = 
new System.Guid[4]
{
Guid.Parse("41040e84-96c7-4fef-970a-0231e61d474c"),
Guid.Parse("0834a96a-9b20-4c07-adb5-920d3ac5a1bf"),
Guid.Parse("07a25b33-6a70-4440-bbed-3ae0e4368311"),
Guid.Parse("c5c5aadf-fa92-4940-9c4a-8a8f3d0e511a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7db45ca4-bcbe-4e0e-845a-20c8e48f7781"),
Guid.Parse("057423b1-962e-4da0-abd4-817ec5391dad"),
Guid.Parse("d93596c6-c7d8-40e8-bf41-c98c469dbc3f"),
},
},
            new GuiduuidArray1M
{
    Id = 96,
    Value = 
new System.Guid[4]
{
Guid.Parse("f009e9b9-99f1-428b-a324-2b10c8dfd049"),
Guid.Parse("0e16960d-f77a-4ecd-aebd-4c4d943a6cee"),
Guid.Parse("4efffa88-9539-4f9d-96f9-c4bb03edc341"),
Guid.Parse("78d0bee8-b6d1-4be1-a442-2b6ecc54233e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("4bc81e47-fbd0-4d7a-863f-5248a1d1fc09"),
Guid.Parse("380f2233-cee7-406b-bdf7-7668cb9e9fa9"),
Guid.Parse("c7bb04c7-2f76-4246-ab34-85451055581b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("aa3ca47e-371d-48f6-9fc1-803c27451a14"),
Guid.Parse("e9a9e87f-156d-4f55-b640-65990c4cb332"),
Guid.Parse("a304a714-31fa-4b2b-be7b-e00ac4d53425"),
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
Guid.Parse("d248f0f9-6008-46bf-86af-a0348cd2e4af"),
Guid.Parse("73be7fbd-d284-4a58-b644-947c8094df20"),
Guid.Parse("94b8f919-bb1d-4b78-99cd-68c68ee0a754"),
Guid.Parse("f2550685-2c3c-4ca2-9691-392b4f342163"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 98,
    Value = 
new System.Guid[3]
{
Guid.Parse("ad06a5aa-1ea8-47d2-8b0a-b1d51df33c48"),
Guid.Parse("18ee52fa-b04d-4519-876e-f6091efca8dd"),
Guid.Parse("d6a0abf5-4e23-4d4e-8c53-7d1c02f40a88"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("06bc87c8-37b1-4acd-8138-9dd308ae0911"),
Guid.Parse("e424ba98-cdc2-41e6-80b9-000c6ad29c74"),
Guid.Parse("76ed8b03-05de-4eda-b23d-b3b45317855b"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 107,
    Value = 
new System.Guid[4]
{
Guid.Parse("91212cd3-eba9-4a44-bf93-9225480dd22a"),
Guid.Parse("42a96492-d222-48bf-9c27-d19be0b975d4"),
Guid.Parse("3fcb7d82-1bb6-492d-9f4f-c2a59602a968"),
Guid.Parse("1f866ec2-9ce4-4359-bd27-f581cb298d35"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c09e5cf5-8087-4297-9726-0429b5de02f1"),
Guid.Parse("54e77826-051e-4405-b5c5-b8eb52008e87"),
Guid.Parse("f3b269f9-b51e-44f3-af1c-0979f617c10a"),
Guid.Parse("ae577d79-444e-48bb-9ce9-cae92e27ac2d"),
},
},
            new GuiduuidArray1M
{
    Id = 110,
    Value = 
new System.Guid[4]
{
Guid.Parse("b1ccf3ed-e8a9-4a52-b15c-304d2c69a583"),
Guid.Parse("f1362421-3c7b-49bc-bdca-7444f0afcf00"),
Guid.Parse("b701ae1d-62b8-41dd-8fa7-07c7591369f5"),
Guid.Parse("3cf0bdca-837c-439e-8c83-e367345c2eb4"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 51,
    Value = 
new System.Guid[3]
{
Guid.Parse("97acfc51-961a-4fb9-a3b7-d10e10fb06e2"),
Guid.Parse("59bd2702-7c01-456c-a03d-0c045cb7b41d"),
Guid.Parse("82054788-b147-4560-b704-c91a043665c1"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("313bbef1-29c2-43c4-a6e0-edd117e3d539"),
Guid.Parse("b87a8019-bedf-424b-923a-e997ccc31e91"),
Guid.Parse("70e08355-3b3c-4871-b287-a7506caee0c4"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7baaa574-01e0-4501-a606-d3cb6d1726da"),
Guid.Parse("088b1875-2d3a-496e-a2ad-427c2b620fa7"),
Guid.Parse("e12eae1f-4154-4508-a7ca-f2aabc885252"),
Guid.Parse("4aa621a6-c849-4c69-bffb-7043ec76d424"),
},
},
            new GuiduuidArray1M
{
    Id = 113,
    Value = 
new System.Guid[3]
{
Guid.Parse("6512b004-67a9-4538-9d6d-e32464b7404d"),
Guid.Parse("b7265b9a-b7b1-4f96-9bf1-76e2ca8632cd"),
Guid.Parse("75b8f413-fd57-4ee2-93dd-0a6ec9674f0f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c5945569-fde0-4a6b-a072-89cf5228be58"),
Guid.Parse("6fd1b0ce-add0-4115-9c58-effa01fd2050"),
Guid.Parse("f29d83db-4008-44e0-a536-03e799d7fb4c"),
Guid.Parse("80f238c3-33ff-4e39-9b62-475276d16176"),
},
},
            new GuiduuidArray1M
{
    Id = 120,
    Value = 
new System.Guid[3]
{
Guid.Parse("dc64e31c-eb1c-4ac0-bc19-f65baad1d6b5"),
Guid.Parse("231b0d8b-ce0a-4687-b2c1-f3c4e0f3ab7e"),
Guid.Parse("a2c37a18-0c72-47b3-89bb-acc1e21a26c6"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 56,
    Value = 
new System.Guid[3]
{
Guid.Parse("c5eb25be-e95b-4ae0-a605-023a0e55dd2a"),
Guid.Parse("05a97f76-5669-47b6-8aab-7cdaa6bb9d74"),
Guid.Parse("9b0276a6-4b9b-4c2a-97de-c0fcff2603e4"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("32c8ca5a-13d7-41b1-acae-8b0c9495c302"),
Guid.Parse("9de573f4-2ad7-4aef-9eff-2c17be661599"),
Guid.Parse("14a03844-29bd-4366-9373-3b2ec313594d"),
Guid.Parse("52b3d04f-a067-4f97-b850-0f4d62f61990"),
},
},
            new GuiduuidArray1M
{
    Id = 129,
    Value = 
new System.Guid[3]
{
Guid.Parse("2e12bef2-d8de-4971-8851-809bff5120c8"),
Guid.Parse("1f6a4f17-c82e-42b0-acba-4d770f2edfd1"),
Guid.Parse("3846f0c5-3fce-48fb-979f-39b9a4582507"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("97c2b7a6-a165-4827-913f-c5a0be301f5d"),
Guid.Parse("1ed99e5f-4fc4-4d73-83a9-254760cdbe28"),
Guid.Parse("c988aafa-45f5-42ce-90be-c69931b101f2"),
Guid.Parse("47a88642-37af-4db0-8caa-3d8c8e62daf4"),
},
},
            new GuiduuidArray1M
{
    Id = 138,
    Value = 
new System.Guid[4]
{
Guid.Parse("cf680f31-7796-416f-a1c3-222e55c114c6"),
Guid.Parse("7b87a4e2-a429-41dc-ba3e-52c57d9b5508"),
Guid.Parse("def6a445-3296-4d5a-a4e1-26dd5fefa58b"),
Guid.Parse("6091dafb-6d75-4781-b43f-88098d2943e8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 64,
    Value = 
new System.Guid[3]
{
Guid.Parse("64089f58-439f-4dab-a950-1028c3d3b6ea"),
Guid.Parse("98d9ff4c-1215-44ca-8e4a-e71c01a72eab"),
Guid.Parse("92aaa9da-e88c-4b27-a8a7-8f8324bd347a"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("aab36dc5-68db-4d74-b197-97b099174417"),
Guid.Parse("15874424-e558-4369-911f-7e238b6e6fa9"),
Guid.Parse("23d42968-0938-4cc9-95cc-9c1c5c486254"),
Guid.Parse("19cffadf-c11e-4bca-b51d-227e06f19915"),
},
},
            new GuiduuidArray1M
{
    Id = 147,
    Value = 
new System.Guid[3]
{
Guid.Parse("1b59ff04-eb3e-43d6-ba08-21229aafcaee"),
Guid.Parse("197acee0-7d80-4f4f-a423-e3f8045d0ee8"),
Guid.Parse("dd5782d2-9c9b-4f5c-ae01-8778872d61e0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 152,
    Value = 
new System.Guid[4]
{
Guid.Parse("9125c454-d899-48f4-a50d-ba3259af7867"),
Guid.Parse("c34a1a14-6fe5-4586-b95e-84dd1ad88aaf"),
Guid.Parse("04eab031-d4c4-440b-9704-5f9a749b4c0f"),
Guid.Parse("3d246c73-2081-42cc-99e3-68fc8a4fdc3f"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 65,
    Value = 
new System.Guid[4]
{
Guid.Parse("13d7ef66-692f-4685-90f4-ead3720dffe9"),
Guid.Parse("6898b11c-eeed-4506-bf7d-4b41fb00a452"),
Guid.Parse("0418207c-567f-428b-9268-d099a51b4446"),
Guid.Parse("e55f9404-3201-4b4c-8941-1bf90e5b7e0f"),
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
Guid.Parse("afb4f16e-8067-42b9-817a-a290bd1deeac"),
Guid.Parse("5e3d7f32-ad1f-448d-af91-018d6e56774d"),
Guid.Parse("c0bb9ece-8290-485f-97ad-a15ed2be0596"),
Guid.Parse("4eb5fd94-32fd-4d44-9461-74ae50a4662e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c7b24b92-c40c-45d0-97be-fabac6be4ae0"),
Guid.Parse("ddb65514-9e77-4616-a91f-9b029289c8cd"),
Guid.Parse("8f6b5e7a-ef98-4db1-be13-781bc1c7ac83"),
Guid.Parse("40d30478-ba03-4956-b171-62a1fca340ed"),
},
},
            new GuiduuidArray1M
{
    Id = 163,
    Value = 
new System.Guid[4]
{
Guid.Parse("aab293c8-e566-4ff1-bf26-dbefea0403a0"),
Guid.Parse("9ba3f6a7-4930-4841-85a9-f4e4ef9d7e26"),
Guid.Parse("fe2c4f76-9237-4577-8bb6-11d3730517d7"),
Guid.Parse("5b2cd929-d3c8-4949-942e-6e6b780d8009"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("3d447587-cec4-414f-a459-6c3bdeebd5d6"),
Guid.Parse("6efe8c77-c720-4661-8f36-f3b1986f9b38"),
Guid.Parse("ebb1dd37-dbc1-4d2d-bf80-9a6fd161dd8c"),
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
new System.Guid[3]
{
Guid.Parse("6d7a64d5-af9c-46ec-bee9-8eba2770e4cb"),
Guid.Parse("11e42174-a0eb-4d62-9f02-9e9f3db6d9f7"),
Guid.Parse("31d984b0-8354-413b-907b-87588bc44ccb"),
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
Guid.Parse("a216e389-ccfd-498a-8192-cae130c8e9dc"),
Guid.Parse("6946507c-8c1d-4d63-a380-ac290e194f61"),
Guid.Parse("efd2037b-41ef-4704-b590-07dbb6c56334"),
Guid.Parse("8e72f4e7-dbfa-41ed-a178-5186491bd075"),
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
Guid.Parse("e6652239-2656-4cb5-aebd-2267a852db19"),
Guid.Parse("420d8649-bf31-4564-a012-fc08bb32a219"),
Guid.Parse("8d1e2561-b27e-4626-a9bc-f600c95c5bed"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("12791f7a-d115-4f99-a44b-3cdd9caa7baf"),
Guid.Parse("a1becb9d-aa9e-42f9-bf1c-b0c9dc8003ae"),
Guid.Parse("ae7a5d71-2407-44db-92e1-c54375ed2b05"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("f3ca4e10-7e6b-44df-a1cb-522172af78a8"),
Guid.Parse("5e3de7bd-b069-407f-9c77-efff9a43538f"),
Guid.Parse("17a54650-1d6f-4297-9bce-5e873d925198"),
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
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
                        Assert.That(models, Has.Count.EqualTo(26));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[4], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[5], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[6], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[23],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[24],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[29], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                        Assert.That(models, Has.Count.EqualTo(26));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[4], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[5], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[6], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[23],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[24],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[25],_testData[29], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
GuiduuidArray1M.AssertModel(models[0],_testData[10], false);GuiduuidArray1M.AssertModel(models[1],_testData[11], false);GuiduuidArray1M.AssertModel(models[2],_testData[12], false);GuiduuidArray1M.AssertModel(models[3],_testData[13], false);GuiduuidArray1M.AssertModel(models[4],_testData[14], false);GuiduuidArray1M.AssertModel(models[5],_testData[15], false);GuiduuidArray1M.AssertModel(models[6],_testData[16], false);GuiduuidArray1M.AssertModel(models[7],_testData[17], false);GuiduuidArray1M.AssertModel(models[8],_testData[18], false);GuiduuidArray1M.AssertModel(models[9],_testData[19], false);GuiduuidArray1M.AssertModel(models[10],_testData[20], false);GuiduuidArray1M.AssertModel(models[11],_testData[21], false);GuiduuidArray1M.AssertModel(models[12],_testData[22], false);GuiduuidArray1M.AssertModel(models[13],_testData[23], false);GuiduuidArray1M.AssertModel(models[14],_testData[24], false);GuiduuidArray1M.AssertModel(models[15],_testData[25], false);GuiduuidArray1M.AssertModel(models[16],_testData[26], false);GuiduuidArray1M.AssertModel(models[17],_testData[27], false);GuiduuidArray1M.AssertModel(models[18],_testData[28], false);GuiduuidArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
GuiduuidArray1M.AssertModel(models[0],_testData[13], false);GuiduuidArray1M.AssertModel(models[1],_testData[14], false);GuiduuidArray1M.AssertModel(models[2],_testData[15], false);GuiduuidArray1M.AssertModel(models[3],_testData[16], false);GuiduuidArray1M.AssertModel(models[4],_testData[17], false);GuiduuidArray1M.AssertModel(models[5],_testData[18], false);GuiduuidArray1M.AssertModel(models[6],_testData[19], false);GuiduuidArray1M.AssertModel(models[7],_testData[20], false);GuiduuidArray1M.AssertModel(models[8],_testData[21], false);GuiduuidArray1M.AssertModel(models[9],_testData[22], false);GuiduuidArray1M.AssertModel(models[10],_testData[23], false);GuiduuidArray1M.AssertModel(models[11],_testData[24], false);GuiduuidArray1M.AssertModel(models[12],_testData[25], false);GuiduuidArray1M.AssertModel(models[13],_testData[26], false);GuiduuidArray1M.AssertModel(models[14],_testData[27], false);GuiduuidArray1M.AssertModel(models[15],_testData[28], false);GuiduuidArray1M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
GuiduuidArray1M.AssertModel(models[0],_testData[14], false);GuiduuidArray1M.AssertModel(models[1],_testData[15], false);GuiduuidArray1M.AssertModel(models[2],_testData[16], false);GuiduuidArray1M.AssertModel(models[3],_testData[17], false);GuiduuidArray1M.AssertModel(models[4],_testData[18], false);GuiduuidArray1M.AssertModel(models[5],_testData[19], false);GuiduuidArray1M.AssertModel(models[6],_testData[20], false);GuiduuidArray1M.AssertModel(models[7],_testData[21], false);GuiduuidArray1M.AssertModel(models[8],_testData[22], false);GuiduuidArray1M.AssertModel(models[9],_testData[23], false);GuiduuidArray1M.AssertModel(models[10],_testData[24], false);GuiduuidArray1M.AssertModel(models[11],_testData[25], false);GuiduuidArray1M.AssertModel(models[12],_testData[26], false);GuiduuidArray1M.AssertModel(models[13],_testData[27], false);GuiduuidArray1M.AssertModel(models[14],_testData[28], false);GuiduuidArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
GuiduuidArray1M.AssertModel(models[0],_testData[23], false);GuiduuidArray1M.AssertModel(models[1],_testData[24], false);GuiduuidArray1M.AssertModel(models[2],_testData[25], false);GuiduuidArray1M.AssertModel(models[3],_testData[26], false);GuiduuidArray1M.AssertModel(models[4],_testData[27], false);GuiduuidArray1M.AssertModel(models[5],_testData[28], false);GuiduuidArray1M.AssertModel(models[6],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 16, query1, 138, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[2], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[3], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[4], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[5], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[6], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[23],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[24],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[25],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[26],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[27],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 120, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 70, 64))
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
                        Assert.That(models, Has.Count.EqualTo(20));
GuiduuidArray1M.AssertModel(models[0],_testData[10], false);GuiduuidArray1M.AssertModel(models[1],_testData[11], false);GuiduuidArray1M.AssertModel(models[2],_testData[12], false);GuiduuidArray1M.AssertModel(models[3],_testData[13], false);GuiduuidArray1M.AssertModel(models[4],_testData[14], false);GuiduuidArray1M.AssertModel(models[5],_testData[15], false);GuiduuidArray1M.AssertModel(models[6],_testData[16], false);GuiduuidArray1M.AssertModel(models[7],_testData[17], false);GuiduuidArray1M.AssertModel(models[8],_testData[18], false);GuiduuidArray1M.AssertModel(models[9],_testData[19], false);GuiduuidArray1M.AssertModel(models[10],_testData[20], false);GuiduuidArray1M.AssertModel(models[11],_testData[21], false);GuiduuidArray1M.AssertModel(models[12],_testData[22], false);GuiduuidArray1M.AssertModel(models[13],_testData[23], false);GuiduuidArray1M.AssertModel(models[14],_testData[24], false);GuiduuidArray1M.AssertModel(models[15],_testData[25], false);GuiduuidArray1M.AssertModel(models[16],_testData[26], false);GuiduuidArray1M.AssertModel(models[17],_testData[27], false);GuiduuidArray1M.AssertModel(models[18],_testData[28], false);GuiduuidArray1M.AssertModel(models[19],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatch(connection, 97, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
GuiduuidArray1M.AssertModel(models[0],_testData[19], false);GuiduuidArray1M.AssertModel(models[1],_testData[20], false);GuiduuidArray1M.AssertModel(models[2],_testData[21], false);GuiduuidArray1M.AssertModel(models[3],_testData[22], false);GuiduuidArray1M.AssertModel(models[4],_testData[23], false);GuiduuidArray1M.AssertModel(models[5],_testData[24], false);GuiduuidArray1M.AssertModel(models[6],_testData[25], false);GuiduuidArray1M.AssertModel(models[7],_testData[26], false);GuiduuidArray1M.AssertModel(models[8],_testData[27], false);GuiduuidArray1M.AssertModel(models[9],_testData[28], false);GuiduuidArray1M.AssertModel(models[10],_testData[29], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
GuiduuidArray1M.AssertModel(models[0],_testData[6], false);GuiduuidArray1M.AssertModel(models[1],_testData[7], false);GuiduuidArray1M.AssertModel(models[2],_testData[8], false);GuiduuidArray1M.AssertModel(models[3],_testData[9], false);GuiduuidArray1M.AssertModel(models[4],_testData[10], false);GuiduuidArray1M.AssertModel(models[5],_testData[11], false);GuiduuidArray1M.AssertModel(models[6],_testData[12], false);GuiduuidArray1M.AssertModel(models[7],_testData[13], false);GuiduuidArray1M.AssertModel(models[8],_testData[14], false);GuiduuidArray1M.AssertModel(models[9],_testData[15], false);GuiduuidArray1M.AssertModel(models[10],_testData[16], false);GuiduuidArray1M.AssertModel(models[11],_testData[17], false);GuiduuidArray1M.AssertModel(models[12],_testData[18], false);GuiduuidArray1M.AssertModel(models[13],_testData[19], false);GuiduuidArray1M.AssertModel(models[14],_testData[20], false);GuiduuidArray1M.AssertModel(models[15],_testData[21], false);GuiduuidArray1M.AssertModel(models[16],_testData[22], false);GuiduuidArray1M.AssertModel(models[17],_testData[23], false);GuiduuidArray1M.AssertModel(models[18],_testData[24], false);GuiduuidArray1M.AssertModel(models[19],_testData[25], false);GuiduuidArray1M.AssertModel(models[20],_testData[26], false);GuiduuidArray1M.AssertModel(models[21],_testData[27], false);GuiduuidArray1M.AssertModel(models[22],_testData[28], false);GuiduuidArray1M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 107);
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


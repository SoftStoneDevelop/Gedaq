

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
Guid.Parse("033600cd-072b-46db-9b06-64bfe8f15876"),
Guid.Parse("2022b1f2-a8cf-4bef-a68d-f3070d7b85f4"),
Guid.Parse("0584a6f4-87f1-4d02-96bc-7f295bbc26e0"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("307dd04e-49b4-4777-aea9-5beacdbe8a69"),
Guid.Parse("9bc20e1b-60c1-4fff-8508-d26c55518571"),
Guid.Parse("c5e0e6cc-54cb-47c4-a00f-fa924332bb09"),
},
},
            new GuiduuidArray1M
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("185f64de-55e7-41a1-b072-5cbd5f02952c"),
Guid.Parse("d0a039d1-e173-4f01-8557-84a11c2b52b8"),
Guid.Parse("8aa20f35-ed6c-4e0b-86e8-787d98ebdf5d"),
Guid.Parse("92adbd0f-19fe-4df5-bd73-d7c3c2b939e8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 4,
    Value = 
new System.Guid[3]
{
Guid.Parse("114c8f64-5896-4f5c-b172-091628471207"),
Guid.Parse("53620cfb-bbb7-4ba6-890e-94c1bee6afff"),
Guid.Parse("59bc82fe-b190-4c18-bc80-9245b8077c83"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b383e038-f6df-469e-9cb7-280f3bb25a1c"),
Guid.Parse("9aaec002-953e-4efb-91fd-d2a2075abfa9"),
Guid.Parse("e113a296-e235-4238-832a-075641a9782f"),
Guid.Parse("366b5b98-effb-4a58-82e6-a52f4e6decf9"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e4197ec5-3927-4a1a-a36d-1081214cebcb"),
Guid.Parse("934045c8-4f14-47b0-a433-a7e37e3833d0"),
Guid.Parse("cfea9c06-94c2-490e-bbc9-12111c6fa4df"),
},
},
            new GuiduuidArray1M
{
    Id = 10,
    Value = 
new System.Guid[3]
{
Guid.Parse("b414df05-4920-46df-9f0e-21dd4969af3b"),
Guid.Parse("b853f0f6-4db4-455f-94b0-e67fe0645581"),
Guid.Parse("16c393e1-8dd0-4f6f-b834-4b3fdc5c555e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c012e695-71ea-4cf1-ae84-981ede051ec2"),
Guid.Parse("cea7614b-5788-45af-849c-7d55256ebdbb"),
Guid.Parse("7796158a-175d-4121-8ba1-c71412a34d9a"),
Guid.Parse("00074a11-2bb7-46c2-9d26-a8a18ef88af9"),
},
},
            new GuiduuidArray1M
{
    Id = 18,
    Value = 
new System.Guid[3]
{
Guid.Parse("328aa0bb-84f0-445e-ab92-7742d557c8aa"),
Guid.Parse("c345c86a-f74d-45ee-af4c-b2f03283761b"),
Guid.Parse("2734e849-93ee-4d40-b291-1092701d0a62"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 6,
    Value = 
new System.Guid[4]
{
Guid.Parse("d04a10f4-4e3e-44f3-a73e-38637e640b0d"),
Guid.Parse("e5f4f3ab-a1a5-4250-b7dc-d6fbe6e3e4d5"),
Guid.Parse("7537f831-3b47-4e63-84bc-b8a9c6ae8aee"),
Guid.Parse("20145ded-7dc2-44c3-8148-d6b9d0563440"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 22,
    Value = 
new System.Guid[4]
{
Guid.Parse("79cee3d5-353b-410f-abe6-671a1667d65e"),
Guid.Parse("4ff51324-d82e-4f08-99f0-1123d7f7aeef"),
Guid.Parse("23706dcb-84fd-4f5f-aa48-1963125eb1ce"),
Guid.Parse("a79809bf-3262-42c1-9b3d-5c98d13a63ef"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("75e732ed-b960-43e6-b2d9-1a282755a606"),
Guid.Parse("7520b2b8-2e31-4e90-ab1c-322545d5e5df"),
Guid.Parse("6cbee582-9845-4482-b27d-bafdd5caca37"),
},
},
            new GuiduuidArray1M
{
    Id = 28,
    Value = 
new System.Guid[4]
{
Guid.Parse("17c3221a-f0ac-4440-9c08-dec3afb2b06f"),
Guid.Parse("9687285f-a7b6-4824-af99-8f633b36f84e"),
Guid.Parse("b6ea9c9f-d702-4c6a-8928-c9997ad717db"),
Guid.Parse("21bee813-8226-4646-93b3-634329770b56"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("6eaf9248-1781-4d4c-ae19-5a6eb5a8ba57"),
Guid.Parse("0feea521-4ce5-4aa2-9d91-7850d0cd0bf7"),
Guid.Parse("6582fe00-3f10-46d5-a345-5b996980d923"),
Guid.Parse("2808fb9e-9a01-4a5e-90cb-0664152eddb8"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d3f81190-2ae2-4192-aeea-637bed36acb1"),
Guid.Parse("73b436ba-5922-4590-9924-e58433d68b99"),
Guid.Parse("bc1302b8-e195-4934-aa9d-c79027ed01c2"),
Guid.Parse("0429a8ae-a770-4e5e-8dcc-d4a48b34a16b"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 32,
    Value = 
new System.Guid[4]
{
Guid.Parse("06a577c5-637e-4f40-a8ea-8d7e0a42fd04"),
Guid.Parse("83e4e85a-9f54-4963-87ad-25219aa159d3"),
Guid.Parse("f76660ce-d927-42ca-89a4-510522880933"),
Guid.Parse("8139826b-04c5-48bd-9844-6df3a048a71b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("aad1cbb6-3625-4905-a40e-97210dc64c65"),
Guid.Parse("10895c44-fa05-4f14-b86e-84976785306f"),
Guid.Parse("a37b3ac3-66f5-4dd4-ae4a-87c1ec4cf6c4"),
},
},
            new GuiduuidArray1M
{
    Id = 40,
    Value = 
new System.Guid[4]
{
Guid.Parse("09e4a4b7-eef3-42f8-bdb1-4d00c0b8525d"),
Guid.Parse("b8c6b609-f6ab-4003-a03e-2e5167586b89"),
Guid.Parse("c68cf389-3216-46df-ae08-f81c6d9f3d37"),
Guid.Parse("5e368baa-2333-4bcd-80d7-0df2ebe826c2"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 21,
    Value = 
new System.Guid[4]
{
Guid.Parse("12c7c18a-e2db-41cd-a935-970f2e28cd8e"),
Guid.Parse("b1efeab2-1465-4913-9203-bd6aa4873d9b"),
Guid.Parse("f47999c9-614b-4460-a84e-e3a04b23332e"),
Guid.Parse("4ab02566-91cc-4ffc-ab2a-4374e1d3ebb1"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("48a7845c-ebf4-42f9-9e4d-c73ba8f5e5a9"),
Guid.Parse("b845ba31-365a-42c2-a6dd-f339630987e4"),
Guid.Parse("71604635-14c0-4453-ab93-cbc782025458"),
Guid.Parse("dc469d43-04b9-4540-9298-c29a71dfc16f"),
},
},
            new GuiduuidArray1M
{
    Id = 46,
    Value = 
new System.Guid[3]
{
Guid.Parse("9ca29fd3-9706-4b09-bbbe-b161c4992020"),
Guid.Parse("8256028c-f800-489e-ab85-81315b87d320"),
Guid.Parse("3a632944-3f92-4886-af90-4b227b42d028"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e1d7ac2f-369a-4d1a-889e-6407038a4f4c"),
Guid.Parse("5d076cfe-d786-4f70-a620-bfe5468f22e8"),
Guid.Parse("1174946b-fcae-46cb-a255-09bf59f5475f"),
Guid.Parse("ce947c2c-ac44-4511-a185-1d785a3a3089"),
},
},
            new GuiduuidArray1M
{
    Id = 54,
    Value = 
new System.Guid[4]
{
Guid.Parse("e6ff7a25-a964-4236-ab1e-b2461d8a7cb5"),
Guid.Parse("354e23ce-97ba-41d7-8b52-b5266cf2e2d5"),
Guid.Parse("c61790e4-b203-4a00-9171-6fff4b45915d"),
Guid.Parse("f5722312-1e12-429c-b9b7-05482c803748"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 25,
    Value = 
new System.Guid[3]
{
Guid.Parse("7132ce94-a0a9-4011-8248-7b12e7570725"),
Guid.Parse("c1205434-7053-46b6-9139-e4357d0f0493"),
Guid.Parse("ffe75f0d-918a-4812-920c-073591101860"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2157ebdd-bb13-43f9-80f9-8807863e2b70"),
Guid.Parse("568abab2-2596-4a73-b520-950dab2103b4"),
Guid.Parse("52d5a477-d9e2-4117-9684-c6add829c9ed"),
Guid.Parse("048173c9-0980-4dae-a5b5-35c04acc2df5"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("1b74be8a-6774-4095-9dc5-57dbac95e7c4"),
Guid.Parse("88d8bcd5-00cd-4f65-b1f0-7c630c0adda0"),
Guid.Parse("8f0ba828-cc6c-4b1e-93ac-43a9a929d618"),
Guid.Parse("9d009294-8250-4d6d-8358-69fcc7036923"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("51d99406-b334-4c1c-80e7-5ae4edde0655"),
Guid.Parse("6d841f44-b769-4f1b-a4c5-12b4c52b18cd"),
Guid.Parse("73ee7081-60b7-4e4a-ab04-f041cd0ce062"),
},
},
            new GuiduuidArray1M
{
    Id = 61,
    Value = 
new System.Guid[3]
{
Guid.Parse("20cea465-7b90-427e-9b6e-473532828b60"),
Guid.Parse("2edf6d43-0485-45f5-8496-005e2cbbf1c5"),
Guid.Parse("7afd3cb3-d5e5-4676-a7a2-e8456299364a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 26,
    Value = 
new System.Guid[4]
{
Guid.Parse("8d218cf3-03fa-4d2a-9b33-aa7ac119c54f"),
Guid.Parse("020c6649-3fcd-4fcb-9c8b-14b7ed33fd51"),
Guid.Parse("e0e038b3-1063-4cd4-b3f1-a2bf1cd932de"),
Guid.Parse("a344e10b-0be2-4d13-9a75-e6185020d70b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3a0bf86b-b2b4-432b-8e70-ae6aac42d90b"),
Guid.Parse("d19ba66f-feef-4fe7-b1b4-b1da621382d6"),
Guid.Parse("33fa496a-4d59-441b-a060-e7b989fd6192"),
Guid.Parse("65588c19-c4f2-43db-b4ca-fbaf5afb1d66"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 62,
    Value = 
new System.Guid[3]
{
Guid.Parse("d4ff38b3-dd71-4460-ba7c-32ab494b6cbc"),
Guid.Parse("e9ababef-1e69-4044-bb9a-a56fbb18609c"),
Guid.Parse("de4e189a-e357-4d94-915c-770fb4c14808"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("de247ff7-0f1b-433e-ac76-aec4fa735fef"),
Guid.Parse("6a8d3696-bdd4-48e1-a7c3-8e6ebcf5b12d"),
Guid.Parse("508c3594-9caa-4f3c-b850-321439054a18"),
},
},
            new GuiduuidArray1M
{
    Id = 71,
    Value = 
new System.Guid[4]
{
Guid.Parse("6e44cdec-ac67-435d-8cef-50a3d3ae3672"),
Guid.Parse("8b1a6e69-13b4-4796-a45c-25ab7c00cbda"),
Guid.Parse("6a7fc5b7-2f65-4f1c-93f0-73ae31ab168c"),
Guid.Parse("de14875c-bb64-4393-9bf5-fb14277a8b4b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("2f30d12f-da9e-497f-b56a-b32be5aaa382"),
Guid.Parse("474ba571-6189-476a-acd6-4caf914cd615"),
Guid.Parse("1d01b1df-add4-42c6-81ef-15ac70be7a8e"),
Guid.Parse("2a688ed6-5124-4865-99d1-af65ce0de526"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 77,
    Value = 
new System.Guid[3]
{
Guid.Parse("f75d2860-d27c-4ec5-a61f-e8a16db79dea"),
Guid.Parse("62ebce29-a1bc-4f67-8229-808a69e34ae4"),
Guid.Parse("dbed86d9-e9ca-41bf-990e-400be68f5660"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 80,
    Value = 
new System.Guid[4]
{
Guid.Parse("4f50fbb4-cc49-4087-b6cf-ee02151754af"),
Guid.Parse("1e3d0f64-a792-403a-bbfb-4b72594a6021"),
Guid.Parse("b16ecf6c-a163-4fde-81de-270ee6207c0d"),
Guid.Parse("80d816a6-d12b-4a0c-ad03-92235e2d3779"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 40,
    Value = 
new System.Guid[3]
{
Guid.Parse("4a5eee2f-5e4d-41d8-b8b3-cd964280d117"),
Guid.Parse("fe9c4440-0819-49ec-ae05-f334cccceff1"),
Guid.Parse("5614fca6-e85b-44de-9996-413d52cb7f17"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4e9f89b3-619e-4c12-808d-d7e71bb4311d"),
Guid.Parse("8b12994b-61fa-4e7c-ad63-d30cad1e4e07"),
Guid.Parse("f22de84b-8007-4a71-9baa-9f0c81cd2284"),
Guid.Parse("c4b1acfa-07d4-4cc6-844d-0e3774d588b4"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9d6373ef-06a0-492b-9cbc-4d25689a6ce6"),
Guid.Parse("987e8945-481c-428f-b967-d892f21139c1"),
Guid.Parse("6c97d0c2-f311-4874-8012-64f2223351ae"),
},
},
            new GuiduuidArray1M
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("d33d4c18-2e1f-44ba-bf03-0240cd96cc83"),
Guid.Parse("95e421dd-0d76-41c7-9774-47d2351f4128"),
Guid.Parse("b636abbe-93af-45a0-ab6e-9f0ce16fb9c1"),
Guid.Parse("417a6248-ee5f-49bf-95a9-e31ec1ca0c37"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ed66069d-172d-4f19-a70e-ff70b91b95ed"),
Guid.Parse("0333d717-1907-4e5f-8170-0c67d395c0ff"),
Guid.Parse("89a0ebeb-29f6-4924-85c1-ca95e64873b8"),
Guid.Parse("ac014129-96e6-4f12-978b-699eab4d84db"),
},
},
            new GuiduuidArray1M
{
    Id = 94,
    Value = 
new System.Guid[3]
{
Guid.Parse("a1122837-cc19-44bc-869e-e1ac5430cde7"),
Guid.Parse("2d13f597-9bb8-4a8e-b860-b3b08fc7f09f"),
Guid.Parse("07d467cd-5755-4f7a-a5bf-1a275ec35704"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 44,
    Value = 
new System.Guid[4]
{
Guid.Parse("4f053221-6cf1-4fdc-9d74-375f19b8fed0"),
Guid.Parse("5dba3e85-e2a8-4204-bd1f-1f06d77f6eb6"),
Guid.Parse("861ff540-bd1e-4e28-b2b8-7026fc91ff22"),
Guid.Parse("d3438bc7-4e15-4976-acaf-6e81558f6926"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 97,
    Value = 
new System.Guid[4]
{
Guid.Parse("b936f509-5d98-46d5-af8a-b94bf9f05861"),
Guid.Parse("4803e7ea-2309-4448-bbb2-53b03edb41e2"),
Guid.Parse("072ee812-bff1-4610-8f6f-40a60e57f498"),
Guid.Parse("7e1b5372-13da-455b-8356-245a2ddd173a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("279fd877-852e-47d4-8e81-17f19b863c84"),
Guid.Parse("c0128432-f7ce-4191-a231-8c529c469a10"),
Guid.Parse("be73c852-11ed-4cbe-bdf8-65a613480936"),
Guid.Parse("f68a4a10-ce99-4183-a1b0-8779e752e97b"),
},
},
            new GuiduuidArray1M
{
    Id = 104,
    Value = 
new System.Guid[4]
{
Guid.Parse("316a3cb7-dc8d-4dcc-878b-f5bbee97093e"),
Guid.Parse("643585b4-839b-4f05-b291-f93f15268ea5"),
Guid.Parse("2908b4c3-e943-4426-99b0-662cf70d766c"),
Guid.Parse("32e36e9e-118e-468d-a370-beb57e2ab56e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("3c03b39c-148d-41aa-a568-7ef018069a1e"),
Guid.Parse("6d146188-c15d-4034-8b53-62d9b661fbb8"),
Guid.Parse("4aaa0e98-3ac0-47f5-93ee-1cd2d12b9328"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4c6fd9a4-fa6b-4db1-ab4a-0ece2c452ac4"),
Guid.Parse("30ef3134-940f-4135-97c5-16ee8278b604"),
Guid.Parse("3875faf2-7435-44d7-9477-6d2f85afec4b"),
Guid.Parse("9e524fba-0d74-4a1c-9a77-5821545cbf1c"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("493089cb-01c0-48f6-9139-cca1fe2a3142"),
Guid.Parse("47b5e0cd-ac32-45a1-9e6e-72b1e8dec4b1"),
Guid.Parse("50c90e37-1606-4cf7-89cc-e8cb5fa0fc27"),
Guid.Parse("bdb535e3-11e2-4366-8da5-255890314f21"),
},
},
            new GuiduuidArray1M
{
    Id = 111,
    Value = 
new System.Guid[3]
{
Guid.Parse("c420b555-27b6-4b96-9f52-130a1e2fca6c"),
Guid.Parse("daf2f816-853c-49ee-ba40-4082eee41882"),
Guid.Parse("9a58f29c-9cf8-44cc-8cf2-f33b4acd8c79"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 120,
    Value = 
new System.Guid[4]
{
Guid.Parse("e3d10bcf-9bd7-476f-bd13-eba1a6074211"),
Guid.Parse("ab73dd5d-140f-4f00-8179-bb99bad8ef5e"),
Guid.Parse("b32ed25e-64ae-47c2-aa60-ee8eec384e13"),
Guid.Parse("2551a77b-7c9e-4d42-8ec2-9095a4ec85bb"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 54,
    Value = 
new System.Guid[4]
{
Guid.Parse("8507b1a9-9b4e-4a92-bd8e-4a38fc0c4e81"),
Guid.Parse("06609af8-29f4-44de-ad49-40280da499f3"),
Guid.Parse("19a55e85-2f77-4173-8df5-a98a4eac6f05"),
Guid.Parse("0e37b6b5-2525-44b6-ad96-731da8b3f0cd"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("60acc5bc-b4ef-4bb4-aed4-510f3fe7bf84"),
Guid.Parse("898c4ed8-e077-40a6-840c-b1688474378d"),
Guid.Parse("81bd1501-9448-4bdd-8475-e4a206bc56b6"),
Guid.Parse("75edb87d-6585-4578-bffd-965c8d5de585"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 123,
    Value = 
new System.Guid[3]
{
Guid.Parse("cca0d4f2-026e-4c0a-a2c6-2fb804c2302e"),
Guid.Parse("ee06f570-7681-4f45-a868-31557e09ecde"),
Guid.Parse("acba854a-87a8-4b43-86e4-3ef4a74b6e81"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 128,
    Value = 
new System.Guid[3]
{
Guid.Parse("f61404fc-0075-410d-adc3-dad15e5777a5"),
Guid.Parse("27c5e294-4426-48e6-9966-0a69a52f666c"),
Guid.Parse("d98d6176-fc07-49ec-8f97-715e31d6eb1b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("0fdee248-dd55-4d99-8dfd-d41465d61c79"),
Guid.Parse("26f0270b-783c-45c4-b936-2a86cd575f83"),
Guid.Parse("2362c3f6-6b8c-467b-a4e7-f22aeb40586f"),
Guid.Parse("5fa93213-fddd-4ef6-8a8d-a621fc1189ac"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("87771823-a981-4a6f-bba1-30da35b61ab5"),
Guid.Parse("303ba243-fe70-4dca-9e17-2b31eb41d3c4"),
Guid.Parse("9864bc27-1ca8-44e4-901c-0d922b7a2dab"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9ab1f5cc-6fbe-411d-ae38-943b63d4f6bd"),
Guid.Parse("aee99ce4-24b9-4268-ade8-0c5283f74f75"),
Guid.Parse("9b402d18-d1e5-4135-af96-2b4e1524a65d"),
Guid.Parse("580513f0-34ca-461d-9d38-4969d2672a31"),
},
},
            new GuiduuidArray1M
{
    Id = 133,
    Value = 
new System.Guid[4]
{
Guid.Parse("2483f9c2-939e-478a-a9dc-8730b544f7a8"),
Guid.Parse("cd3f7dfd-ccb7-4291-b824-71b9fc3f5a2f"),
Guid.Parse("1c9d87d2-771e-444b-a704-7ab22bd3ad9d"),
Guid.Parse("2138d2de-bc61-4f26-b228-d479b8823cb4"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 137,
    Value = 
new System.Guid[4]
{
Guid.Parse("1fb851fa-db52-46b3-b525-b4ca478fb5a0"),
Guid.Parse("f0165025-84c3-4683-9986-b23f6c1db7df"),
Guid.Parse("fd1731f4-ec52-4c6d-a5cf-829faa43afb1"),
Guid.Parse("60f63a04-c056-4b8c-af35-7fe3181774fa"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 62,
    Value = 
new System.Guid[3]
{
Guid.Parse("aafd00eb-c0a8-419d-9a93-59772457c5fc"),
Guid.Parse("26726b7c-40b7-40aa-baec-240b1936ed2c"),
Guid.Parse("534b9031-fa52-43db-8f66-ebd38cb7c98d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("508caad4-b45e-4702-b260-f50d12a74526"),
Guid.Parse("4af1823c-7cad-4d7d-a5d0-56a89f6c173b"),
Guid.Parse("36180e97-545c-4c6d-9de8-797a28a00742"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 145,
    Value = 
new System.Guid[3]
{
Guid.Parse("98fb7dc7-aaec-4899-8eba-ddd78ab96ba8"),
Guid.Parse("c954d1f8-5ec5-479a-a8af-7d8f0881399f"),
Guid.Parse("297dd125-4882-4794-8669-d5b5e8a1c92f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4ab98dfa-7a17-4481-a0cb-94ab3dd1d7f7"),
Guid.Parse("7ab97f85-7f7f-48a5-a09a-17fde3a73a88"),
Guid.Parse("ca52f655-db9f-44f1-a664-6005ab57ef1f"),
Guid.Parse("c09dda83-b063-44d0-b123-d870f1f82b57"),
},
},
            new GuiduuidArray1M
{
    Id = 147,
    Value = 
new System.Guid[4]
{
Guid.Parse("4fcdb2f8-21d9-4698-a4d3-76bc46c6308a"),
Guid.Parse("1db042ab-534e-414c-9d6c-69e34b05e512"),
Guid.Parse("63113c3e-ba8c-4533-8c35-3d29f2b07b4b"),
Guid.Parse("f4c6d37e-ea75-4af0-9d7a-f89348527f9f"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 67,
    Value = 
new System.Guid[3]
{
Guid.Parse("07363570-e557-4307-80e4-5b68ca562e5d"),
Guid.Parse("143d6bc2-bca6-4c96-ab23-77e6ab815c99"),
Guid.Parse("6c84d911-8947-40ab-ab08-61cd78f6a221"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("99c66230-0407-4f51-bf59-16eb4174f913"),
Guid.Parse("942b6a09-6829-4632-9fcd-b3f737adaec7"),
Guid.Parse("faec803f-9584-462b-946e-d17f86aecbd6"),
Guid.Parse("deb2c311-064d-4d18-88d6-0baca90e6c0c"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 151,
    Value = 
new System.Guid[4]
{
Guid.Parse("3015fe85-0c7f-432f-a1b0-10043de1e550"),
Guid.Parse("cc86565a-591b-48d5-8b8c-e5a7f7a30bea"),
Guid.Parse("e2588239-9e37-4e5d-85e1-4d9035f027e9"),
Guid.Parse("00980519-7385-40cd-b4d5-3855529fb47b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c403f636-6a86-4129-abb7-4ba7b51d25ff"),
Guid.Parse("af729431-e876-4b61-a0c5-0483391ea8d9"),
Guid.Parse("076fd401-d411-40c7-812f-3263d4a25ed6"),
Guid.Parse("9207a1af-401f-490f-a7b6-988a54c08f30"),
},
},
            new GuiduuidArray1M
{
    Id = 153,
    Value = 
new System.Guid[4]
{
Guid.Parse("e917c88a-20da-409c-a58a-5649aa02d12b"),
Guid.Parse("423c52bd-1c4a-4d48-a910-16f9cbadf3d3"),
Guid.Parse("4bedf1db-0bc5-44c8-80c1-0c2e887263d3"),
Guid.Parse("22118259-f8d5-4dfc-bc97-5a340e1dee12"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 76,
    Value = 
new System.Guid[3]
{
Guid.Parse("56a529ce-7c17-4233-8832-64a67f25b562"),
Guid.Parse("3660772d-355d-468e-9df1-515ec00cb9e2"),
Guid.Parse("f5de9c92-d095-4c00-836b-3816e41d350f"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 157,
    Value = 
new System.Guid[3]
{
Guid.Parse("c18c3a7d-3939-4154-9d2a-1866bfe180ff"),
Guid.Parse("ed906912-8653-458e-b50a-37310d1c077f"),
Guid.Parse("6c1f4997-7c3f-4f32-a5fa-f23f3285bddb"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("09e72e2b-2061-40d5-b46a-5ccd63f4aa11"),
Guid.Parse("c89b808d-ab46-4073-bca1-b496e2d35820"),
Guid.Parse("bc6de527-a5e5-4a09-938b-f11fb56dfd57"),
},
},
            new GuiduuidArray1M
{
    Id = 163,
    Value = 
new System.Guid[3]
{
Guid.Parse("42ad90bf-f33c-427b-aad8-5488b1f70642"),
Guid.Parse("2fef6c27-2627-44f7-95dd-20ff91f68b61"),
Guid.Parse("a4dbfedd-d17c-4d84-91a3-8a98ae83bf1a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 81,
    Value = 
new System.Guid[4]
{
Guid.Parse("64534917-1821-4c97-8dc4-0b594aa7282f"),
Guid.Parse("db941275-61c5-4736-a862-664458ca4f38"),
Guid.Parse("b1790f3a-c19c-49db-8dca-73a9d65e0e68"),
Guid.Parse("3f406500-8657-4acc-a697-2b117c55f6bc"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("dc7d49ad-d694-41a4-b78f-e4ae5d46b51d"),
Guid.Parse("7ace36e4-5b69-422d-bba8-7b6e363d13b4"),
Guid.Parse("718d25f1-52f6-4562-8277-4991143ce3d1"),
},
},
            new GuiduuidArray1M
{
    Id = 169,
    Value = 
new System.Guid[3]
{
Guid.Parse("b6675347-109b-4a86-a470-16f893202aff"),
Guid.Parse("c012bab6-87b4-4c93-b57a-e0625a91f0f9"),
Guid.Parse("244756e8-72df-40d6-a698-99537ce3e056"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 173,
    Value = 
new System.Guid[4]
{
Guid.Parse("f17d2b6a-9aa2-44e2-8497-b8cec3adcb5e"),
Guid.Parse("98ef111a-bd6a-4cc2-9b6b-a71f160957bd"),
Guid.Parse("47bbed3f-fa9b-4651-8dfc-c9eb6b2dbf5a"),
Guid.Parse("7c9861c8-cff9-4fd2-893f-b44644ad3e09"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 82,
    Value = 
new System.Guid[3]
{
Guid.Parse("9aa3c1b7-f01e-4256-8237-3f6b6d7d5b95"),
Guid.Parse("bb2c6f19-1d19-4bfd-a6e8-8b2d6ed69b76"),
Guid.Parse("da25edb8-dbcb-48f6-9b35-9f05d188aebd"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("19be982f-8d48-4ed6-b2bd-20437dcb1465"),
Guid.Parse("4f87db05-a4f5-432b-aa4f-2b2aff6f8c5c"),
Guid.Parse("d200c74d-d97c-4da2-89e2-02005886b0d1"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("95c8aecf-64dc-467e-b321-4b978cd97ed2"),
Guid.Parse("4770ea41-0afa-49fe-8395-eba48afdbf90"),
Guid.Parse("707381e9-71b6-48c8-b3a8-142f69077ea2"),
},
},
            new GuiduuidArray1M
{
    Id = 180,
    Value = 
new System.Guid[4]
{
Guid.Parse("b8314bc4-72af-4e3c-b873-e56b0c89321a"),
Guid.Parse("7b45f785-4542-4fd4-a3d8-0e88ed87617b"),
Guid.Parse("7bb37901-8eb3-4fd8-b1bb-cd9d23e93865"),
Guid.Parse("eefc7a31-339a-400b-84a1-057ea71d0d20"),
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
Guid.Parse("75e732ed-b960-43e6-b2d9-1a282755a606"),
Guid.Parse("7520b2b8-2e31-4e90-ab1c-322545d5e5df"),
Guid.Parse("6cbee582-9845-4482-b27d-bafdd5caca37"),
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
Guid.Parse("aad1cbb6-3625-4905-a40e-97210dc64c65"),
Guid.Parse("10895c44-fa05-4f14-b86e-84976785306f"),
Guid.Parse("a37b3ac3-66f5-4dd4-ae4a-87c1ec4cf6c4"),
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
Guid.Parse("48a7845c-ebf4-42f9-9e4d-c73ba8f5e5a9"),
Guid.Parse("b845ba31-365a-42c2-a6dd-f339630987e4"),
Guid.Parse("71604635-14c0-4453-ab93-cbc782025458"),
Guid.Parse("dc469d43-04b9-4540-9298-c29a71dfc16f"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("e1d7ac2f-369a-4d1a-889e-6407038a4f4c"),
Guid.Parse("5d076cfe-d786-4f70-a620-bfe5468f22e8"),
Guid.Parse("1174946b-fcae-46cb-a255-09bf59f5475f"),
Guid.Parse("ce947c2c-ac44-4511-a185-1d785a3a3089"),
}));
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
Guid.Parse("51d99406-b334-4c1c-80e7-5ae4edde0655"),
Guid.Parse("6d841f44-b769-4f1b-a4c5-12b4c52b18cd"),
Guid.Parse("73ee7081-60b7-4e4a-ab04-f041cd0ce062"),
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[34], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 163;
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
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 153;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[33],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 169;
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
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidArray1M.AssertModel(models[0],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidArray1M.AssertModel(models[0],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidArray1M.AssertModel(models[0],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 123, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 4, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 137, query1, 62, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 123, query1, 151, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 169, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 77, query1, 22, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 123, query1, 9, query2))
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 4, query1, 77, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 94, 111))
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduuidArray1M.AssertModel(models[0],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 4, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        GuiduuidArray1M.AssertModel(models[0],_testData[1], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[2], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[31],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[32],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        GuiduuidArray1M.AssertModel(models[0],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[34], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 157);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                GuiduuidArray1M.AssertModel(models[0],_testData[31], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[32], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                GuiduuidArray1M.AssertModel(models[0],_testData[7], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[8], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[9], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[10], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[11], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[12], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[13], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[14], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[15], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[16], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[17], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[18], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[19], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[20], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[21], false);
                GuiduuidArray1M.AssertModel(models[15],_testData[22], false);
                GuiduuidArray1M.AssertModel(models[16],_testData[23], false);
                GuiduuidArray1M.AssertModel(models[17],_testData[24], false);
                GuiduuidArray1M.AssertModel(models[18],_testData[25], false);
                GuiduuidArray1M.AssertModel(models[19],_testData[26], false);
                GuiduuidArray1M.AssertModel(models[20],_testData[27], false);
                GuiduuidArray1M.AssertModel(models[21],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[22],_testData[29], false);
                GuiduuidArray1M.AssertModel(models[23],_testData[30], false);
                GuiduuidArray1M.AssertModel(models[24],_testData[31], false);
                GuiduuidArray1M.AssertModel(models[25],_testData[32], false);
                GuiduuidArray1M.AssertModel(models[26],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[27],_testData[34], false);
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


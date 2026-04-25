

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
    Id = 2,
    Value = 
new System.Guid[3]
{
Guid.Parse("f5cc3cfd-545e-40d8-b197-28435a5cbaaa"),
Guid.Parse("eb400be8-4fb4-4627-ad69-e20d00869556"),
Guid.Parse("aa60d123-fc60-495e-8e3b-d681ce1747ae"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 10,
    Value = 
new System.Guid[4]
{
Guid.Parse("02387d22-8ff6-4d8f-8d66-a17e8a03e715"),
Guid.Parse("4a46fbfe-0d22-4242-af03-cabbf204d1a4"),
Guid.Parse("87176412-000b-4d21-a715-0bba0b46a6e3"),
Guid.Parse("7b9efb52-6105-47c6-9b9e-6adaecf73ba2"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 3,
    Value = 
new System.Guid[4]
{
Guid.Parse("5f1365da-975d-40db-b0e9-f38df91ae1b5"),
Guid.Parse("b7e9d71e-5e74-4f07-8a0f-430c0c6f5f77"),
Guid.Parse("ed0dd4b2-675b-4ff8-8a1a-a3908180a5a1"),
Guid.Parse("1d944a6a-697b-4d69-a027-08d95cf572d7"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0513dec3-0101-4f9a-b66c-b657659372cc"),
Guid.Parse("c0d9dfbd-5279-43b7-bebb-7a0a215d1e18"),
Guid.Parse("5ac45e99-e785-41ff-9237-4b937ca30134"),
Guid.Parse("10af8d9b-c473-404e-b8ff-3f96e7540996"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("317dea56-2215-4924-82c2-522bfab63a07"),
Guid.Parse("4c8ef75a-8e1e-4163-bd46-ee40b050da59"),
Guid.Parse("2764f0d7-1687-4496-8d87-77abe6c5a550"),
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
Guid.Parse("1d3482f5-10ec-4632-a3b1-bc9e19b4102f"),
Guid.Parse("8ce230f0-16ff-4d92-91ce-b1ec470ee4b1"),
Guid.Parse("960181a3-9df0-40dc-b4a1-ca1d44029e70"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 11,
    Value = 
new System.Guid[3]
{
Guid.Parse("c2fd11f0-f0fb-4d3d-af1e-043d400bec23"),
Guid.Parse("f2480654-9ed7-4792-9897-be13d1a99fd9"),
Guid.Parse("d07588a0-7140-45f5-9892-aff226ca6abc"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("322992bf-4231-4b62-b39e-7aa045c34456"),
Guid.Parse("619ffc70-737d-4182-ac3c-76e8fb980777"),
Guid.Parse("34321bed-bd8a-452f-afb4-0f7fbcde38bd"),
Guid.Parse("407eff4a-8776-450b-b326-646af839c2d7"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("2f13bdf3-8cfa-4f84-86a7-3c925d7470d8"),
Guid.Parse("a9c0a432-4592-4adf-9bec-b0334a5811f0"),
Guid.Parse("557896b9-0537-4b8d-be68-3ebd08322673"),
Guid.Parse("502ee694-2c7d-4901-9e2e-346274b35225"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e6ae727a-f7a6-4411-864c-843eda540400"),
Guid.Parse("29839701-c755-40cf-ac8b-4777eb5f0d6d"),
Guid.Parse("803adf23-a77c-478b-9abe-573fd761c82e"),
Guid.Parse("74d25b46-bced-47d2-8d9b-61e562fdf64c"),
},
},
            new GuiduuidArray1M
{
    Id = 28,
    Value = 
new System.Guid[3]
{
Guid.Parse("80f9e1b4-7ede-4a4a-80b2-5816725b7b62"),
Guid.Parse("424dbf8b-4f9d-45ca-8983-97c856578b2c"),
Guid.Parse("7fee5e78-fb05-4624-b2f2-0900ed34b094"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("12dd14c8-aa13-4645-8337-ff61d3b35570"),
Guid.Parse("4c2010d8-a8ef-495b-ba9f-d72679459605"),
Guid.Parse("c079baa4-306c-446b-8fd5-af19db1bd8f0"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e9473e96-9732-4354-ba7a-a35d5e773799"),
Guid.Parse("2058df15-c3c3-458c-a70c-15a814ef5c2e"),
Guid.Parse("12b6ff8d-8c0e-42ed-acbb-4f10fae7431d"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 33,
    Value = 
new System.Guid[4]
{
Guid.Parse("21037c8b-17f7-4686-821e-909df03e886b"),
Guid.Parse("5afa0ab4-9b79-4225-9ad9-d60ba1568caf"),
Guid.Parse("105101d5-0eb0-48b7-81c3-b2911eec601d"),
Guid.Parse("85fdbc4f-9039-4986-9d37-8e1cd8bcf33c"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4ea5a882-bb03-4f71-9cec-31492d44848b"),
Guid.Parse("230945e9-32e2-497d-8418-a7f8d8a1b2f4"),
Guid.Parse("e3bb6a66-3e24-429f-9ec6-a1b4af347904"),
},
},
            new GuiduuidArray1M
{
    Id = 41,
    Value = 
new System.Guid[3]
{
Guid.Parse("f0c94ed5-9b42-4ab8-a3e5-bc6308c2dfc3"),
Guid.Parse("7c93daa8-b124-43dc-a3ec-019216782714"),
Guid.Parse("54017e56-9b98-4e02-8379-0851a7dceee3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 17,
    Value = 
new System.Guid[3]
{
Guid.Parse("accc0ef2-c90a-4264-a121-1ff71606b6a8"),
Guid.Parse("fa85b619-1c5f-428e-ab5e-8f986c86c981"),
Guid.Parse("4adffe75-a4f5-4165-a91d-2709e42b4ae9"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d88e6075-3e4e-4bfe-97d6-93b71562924b"),
Guid.Parse("b41fb307-2e5a-4605-b500-1b90e533a7fd"),
Guid.Parse("5e1e9198-0507-4cf4-adbe-b6423385fc52"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("20de836e-b353-49a1-9b89-d5df3101eacb"),
Guid.Parse("4656bf55-20ad-40c0-be05-c0f089067591"),
Guid.Parse("01a379b0-7ecb-428d-928c-7654d9339f0e"),
},
},
            new GuiduuidArray1M
{
    Id = 50,
    Value = 
new System.Guid[4]
{
Guid.Parse("20666474-9334-4670-824f-f32f2cf82f56"),
Guid.Parse("e596d756-a710-4a72-ab15-093940b2eeb5"),
Guid.Parse("13a07f9f-998e-427b-a75e-f0ffa455c62a"),
Guid.Parse("acc90623-c242-48c8-ac3b-e6163fae76ec"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 51,
    Value = 
new System.Guid[3]
{
Guid.Parse("9efb2124-9c43-40db-a7df-437bcbd5677a"),
Guid.Parse("872bc0f6-eedf-4cb2-b04c-e219b223b43e"),
Guid.Parse("ad0bd549-452f-46d7-a2f4-b523dd644f0e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("69bcea3e-424a-4657-85d7-0ce8d6b02992"),
Guid.Parse("2a321dac-31d6-4a35-845f-c2e305302204"),
Guid.Parse("c6307e4f-b1d7-4b5f-9a62-38f6d2b01440"),
Guid.Parse("ec56a8be-145d-4124-b097-40ef18416749"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d12971ac-ba6d-4699-a9f0-9bf36d116b00"),
Guid.Parse("d2ecb962-3cce-4d36-9ac9-7c76e5449811"),
Guid.Parse("2ab4a96d-980a-47b9-a6ae-7c7d01e01d70"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("51fd9c96-53fb-4d49-9b7b-587029df546f"),
Guid.Parse("447958a4-2625-44f1-a943-6ac123ea02b9"),
Guid.Parse("302b458a-1a5e-40c2-a1b4-b072fa133d63"),
Guid.Parse("6e0e2318-e0ca-4ea5-a31f-7bd0f737308c"),
},
},
            new GuiduuidArray1M
{
    Id = 56,
    Value = 
new System.Guid[3]
{
Guid.Parse("70a34716-9667-45d5-bd08-e3f22ee488e2"),
Guid.Parse("0b05af23-ee69-4658-9e27-7cb72ca4f387"),
Guid.Parse("58cbc071-227b-4e0a-b315-69cf9d26be79"),
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
Guid.Parse("a7189e01-9ca2-4faf-b39f-a3adebb34ad8"),
Guid.Parse("c3376bd9-4ece-44b9-b4e2-3ee89ec7c6fb"),
Guid.Parse("2bc37f96-9fcd-40f3-abf4-2f3ca727a771"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("cefadf8a-1528-44c6-a181-1747a93750d4"),
Guid.Parse("1582f7a0-5922-4fb4-a594-5d5a9c69bfd8"),
Guid.Parse("045b3d23-648b-4bc6-933f-4e14bb606c96"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c041ca2e-86d2-42fd-beb7-afee5a721ec1"),
Guid.Parse("cf48ba4c-54b3-4330-a22a-db00b429aa88"),
Guid.Parse("a7b232c7-c1cd-4ee0-a972-bde4c582765e"),
},
},
            new GuiduuidArray1M
{
    Id = 69,
    Value = 
new System.Guid[3]
{
Guid.Parse("7ca65e3a-9fdf-49be-837f-65c476bda221"),
Guid.Parse("da0c7074-b9fb-42d9-993d-c72a8999f3ea"),
Guid.Parse("1c84a46d-0d71-41ac-b8b6-f18460fab1ab"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("1f733f44-c58d-4e96-8acf-a4f6cca00975"),
Guid.Parse("443dbb51-83af-40d5-9ff1-f2a2b171a753"),
Guid.Parse("ee121751-8161-4bcb-9241-122ddcbea471"),
},
},
            new GuiduuidArray1M
{
    Id = 78,
    Value = 
new System.Guid[3]
{
Guid.Parse("d5d261c7-2ce2-42dd-929a-45a19fea0e0a"),
Guid.Parse("bee8594e-e3ff-4f8f-932d-75b0b4a17736"),
Guid.Parse("8d2e0907-a908-4d6a-b156-93f77a694a38"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 37,
    Value = 
new System.Guid[4]
{
Guid.Parse("8c04d1f9-eebf-484f-87e4-ae710231e0df"),
Guid.Parse("893a5814-88ca-4444-bdd8-5e00f1c8ceb7"),
Guid.Parse("c15d4ae0-e29c-4bb1-9e69-fb4c8a676202"),
Guid.Parse("e0c71c65-e083-4ceb-a180-27814eed5c42"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0fcadcaf-8d36-47e4-ac4c-862532a85dd0"),
Guid.Parse("7b485823-e4b2-400c-80af-e1ad8ebd8d2a"),
Guid.Parse("9ff96cbc-9573-4403-bd7c-084e782da21e"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bbf73989-71b6-4d80-820c-fbed725c02f1"),
Guid.Parse("cd3c62f5-ac56-4284-a6d9-bdb4acdee2b6"),
Guid.Parse("193ee3c6-d99e-4897-8366-19fde76a9409"),
},
},
            new GuiduuidArray1M
{
    Id = 79,
    Value = 
new System.Guid[4]
{
Guid.Parse("e5c0f9b5-b862-4fa0-9e3c-8c963c9fa721"),
Guid.Parse("baaf5d24-589e-4cff-a0fd-610ca3a900c8"),
Guid.Parse("53cca6c3-bbcd-48cf-833c-feec400a2300"),
Guid.Parse("9c2c31ae-6516-4f2c-98de-60582a2ae52d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d7aa067b-96c2-47dd-950e-48e7582f6118"),
Guid.Parse("5ada4df9-f9c1-4de4-abe6-675c0d273c18"),
Guid.Parse("9f7c3666-e21a-4c84-967a-e3328f63c22c"),
},
},
            new GuiduuidArray1M
{
    Id = 81,
    Value = 
new System.Guid[4]
{
Guid.Parse("66d9a766-81ab-48f4-9fff-0ebc909e3621"),
Guid.Parse("ceb09359-9736-40e3-a43f-be5a760768ea"),
Guid.Parse("e448e118-e58f-474d-88b4-b381a66a4ed7"),
Guid.Parse("725e5e97-b6c5-4763-89ab-db50f4b9ef9d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 46,
    Value = 
new System.Guid[3]
{
Guid.Parse("c7b36faf-6c8c-47ca-9ffc-85f59ff532ee"),
Guid.Parse("bce6b221-af0c-446b-bf0c-0fdb7c4d9bc1"),
Guid.Parse("954b3681-6540-4267-8529-be8fe0c4c18d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d35d7825-35fe-4a51-ac57-10fdde32ab95"),
Guid.Parse("2194248f-47b6-4ae0-9be6-3fc9818a9492"),
Guid.Parse("4521b2b0-3629-479b-8f8c-c15aa3fa8fa2"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("641cf5ab-7d23-4108-adc0-c5148957ec89"),
Guid.Parse("fdaa00a8-ad3d-4fb9-9ef2-bbee1e91e8f1"),
Guid.Parse("9d9a502b-48a8-4807-82ef-8cac566a7a76"),
},
},
            new GuiduuidArray1M
{
    Id = 88,
    Value = 
new System.Guid[3]
{
Guid.Parse("b78bf899-691b-4937-a817-e262b6c5d7e2"),
Guid.Parse("107178b8-aeb6-48fb-92fd-ab103d5d2433"),
Guid.Parse("a75b1ca0-d8d5-4695-bc80-8637b3b48369"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 96,
    Value = 
new System.Guid[3]
{
Guid.Parse("4c326e33-889c-4899-b175-75671dbc5e92"),
Guid.Parse("7feb83e6-6378-47d3-b8b4-f532fb5d568b"),
Guid.Parse("1dee70a2-13ff-4f5e-8690-07d5e784c764"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 48,
    Value = 
new System.Guid[3]
{
Guid.Parse("3e2f2fad-a0d0-4b03-af22-cafc7e71e716"),
Guid.Parse("542467d0-1196-4e5e-91d3-0e59fcf3c96a"),
Guid.Parse("0f4a4e73-ce6e-4f71-af97-423a6ac8beb8"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 105,
    Value = 
new System.Guid[4]
{
Guid.Parse("1535a734-fd3a-46cd-ae72-728ba4604e9c"),
Guid.Parse("31abd22f-e24f-4c07-b516-427921d92a85"),
Guid.Parse("77ae8ecd-6a59-45e9-afd9-3d113f6b32a6"),
Guid.Parse("bc217b5d-e60f-48a1-ae52-78d0eb4ef70b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8f2a7f3d-38c5-4082-bef3-250e25b5b997"),
Guid.Parse("a538ab14-cd52-49ff-9658-1810984f6457"),
Guid.Parse("ec891efb-b7bb-4df1-a2e9-e72f87ff4fc4"),
Guid.Parse("e891e032-7ef1-43c4-97cb-82110dbdc909"),
},
},
            new GuiduuidArray1M
{
    Id = 112,
    Value = 
new System.Guid[3]
{
Guid.Parse("d9d4a81a-0ceb-481e-8da4-4d4d9e028a87"),
Guid.Parse("2b18b376-0dcc-4b04-883d-363ea621691a"),
Guid.Parse("aca79efb-ce49-49b2-86fc-40662fbb66b3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 57,
    Value = 
new System.Guid[4]
{
Guid.Parse("8fd394fa-3a45-402f-972d-00d43ade5fa5"),
Guid.Parse("703515c8-b8c8-4291-bc14-22bf8c155c6b"),
Guid.Parse("4a13d5f4-0dbd-47f5-9384-4388f004e9c1"),
Guid.Parse("57c7db2d-6898-4782-9b32-01d0c5eca068"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 120,
    Value = 
new System.Guid[4]
{
Guid.Parse("7daecb4c-3ed0-4399-a61f-96039654fa2a"),
Guid.Parse("8a409f0f-16bc-438a-b252-b3789456b802"),
Guid.Parse("bf54e148-5615-40eb-922b-2087ad697b7e"),
Guid.Parse("fbf8f13c-68ab-4c17-a9f8-b4f30e138d2a"),
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
Guid.Parse("398c41cd-fb4c-4982-b60b-c0ba7a279907"),
Guid.Parse("b9172eb1-9809-417b-adf8-eb7ab87c2c35"),
Guid.Parse("9c2731a5-8a64-45b1-b3d7-7c2afd67b056"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("660a7ff9-1db8-45c5-87a1-241fa2ea9677"),
Guid.Parse("182f08c7-8936-4966-a9cc-16a93176d685"),
Guid.Parse("9441ed61-6a2b-4b70-a48e-07035d2cd885"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("222e5020-b30a-4f1e-85d8-ef948a84a25c"),
Guid.Parse("eb294734-908c-4e99-a53b-c33d8c79b23b"),
Guid.Parse("cc1bd666-5c85-4078-8ebb-570a4375ed14"),
Guid.Parse("95763b35-2afd-406f-a99e-e0637bba38aa"),
},
},
            new GuiduuidArray1M
{
    Id = 129,
    Value = 
new System.Guid[4]
{
Guid.Parse("33d59350-66af-41e6-b8be-b802bf42bbb4"),
Guid.Parse("a6416773-17ef-40b7-b9b9-e5932bc47cb6"),
Guid.Parse("86bc2b79-078c-4b82-b4d6-057c462f4b96"),
Guid.Parse("db1b8ee8-591e-4e4a-b022-1e3d732208d6"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c81ec2fe-d2e9-490d-b1e4-adbd3ade2719"),
Guid.Parse("3448878f-1656-4c4f-be20-8ab3992c39e4"),
Guid.Parse("3d655395-85c6-4150-ae8f-316ab371b724"),
Guid.Parse("08e2ca7f-f4e0-4b30-aeaf-d03f4cb49751"),
},
},
            new GuiduuidArray1M
{
    Id = 137,
    Value = 
new System.Guid[3]
{
Guid.Parse("c88e0333-4a70-45aa-9b7c-e6d9356c5334"),
Guid.Parse("9a491b1e-5708-4bc9-b723-690ba99e1fcf"),
Guid.Parse("9c81c612-90a9-4989-924a-efb8b3c36d9c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 65,
    Value = 
new System.Guid[4]
{
Guid.Parse("77c0e07b-0e7e-4211-a7ef-a8104164c4a0"),
Guid.Parse("c60669c7-1520-4540-9a60-0cba9b2302ec"),
Guid.Parse("6452abcb-8d68-4bc5-b7a8-f05578aa974d"),
Guid.Parse("04a6cf5d-b750-47c1-9cd8-9d213e0eb10a"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 140,
    Value = 
new System.Guid[3]
{
Guid.Parse("8a28cf58-2cdc-4167-a1f1-01613e5c2064"),
Guid.Parse("70160cc5-3122-41eb-aeb4-35537a4dd5aa"),
Guid.Parse("2bc8ec15-7877-44fc-b899-c62edf1839ad"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 142,
    Value = 
new System.Guid[3]
{
Guid.Parse("69eaa360-95e4-4339-bfd0-893c5e3edf74"),
Guid.Parse("9c6dc7c9-110c-4b0e-a3ca-62f680d0a682"),
Guid.Parse("9c9c21f3-9bf9-4cdd-a672-4f3f9a57586a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("542813f6-6a59-4bd4-9859-c4faf3628b5b"),
Guid.Parse("8c94ddc0-2134-487f-9bc7-4c01a0d0d4c1"),
Guid.Parse("2951a7d5-f0e2-48b4-b01b-33bfdc251afe"),
Guid.Parse("e0c685bc-2895-4964-a2b4-80371e78c742"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b09a44ce-ec38-4968-99da-9d116c6f333d"),
Guid.Parse("d469b478-892e-4a76-9cf7-1f825dc8adc9"),
Guid.Parse("6c2befe1-7a47-492b-9913-5b1cc606846a"),
Guid.Parse("211178f9-7ea3-434c-a983-a1f7b269acf1"),
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
Guid.Parse("2d502ac1-ef81-4ef2-a483-4e2bf2a749a4"),
Guid.Parse("ccfe4b98-7299-47e1-a241-44f6250d3037"),
Guid.Parse("c6d5d1c5-8c6c-4368-a5b0-a7c1021f7664"),
Guid.Parse("6c35e56f-a7cb-4487-8629-ca150fa80a94"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 158,
    Value = 
new System.Guid[3]
{
Guid.Parse("958bb1d4-0bef-4939-aa9c-d394cffb5f13"),
Guid.Parse("f880c17e-3d52-4370-9417-1a506f793147"),
Guid.Parse("3845d194-089f-4656-b813-ab20b471c22b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 82,
    Value = 
new System.Guid[4]
{
Guid.Parse("c1836824-8929-43d5-82f8-86b253ef58b4"),
Guid.Parse("0cb4aebd-24e0-4ee9-9903-2c439169ca14"),
Guid.Parse("a2c9b0d7-6c24-4089-bb33-c0f3f75df979"),
Guid.Parse("7ed64b3a-dbd8-4d49-b661-0e812f1f489b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fe9b1864-193a-49ad-aa06-f7cf49d1ea34"),
Guid.Parse("483e3cce-c6c5-4657-9fae-65b63234057f"),
Guid.Parse("77498d97-2bc3-4d31-9570-fc3330f3b0bc"),
Guid.Parse("b2f1fe49-9557-4893-bc93-b0f844157455"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("71b7d2ba-967a-4aed-93bf-032861d15d09"),
Guid.Parse("5070a177-6084-4b40-90a4-79a2c459ad51"),
Guid.Parse("37d70668-b81f-4927-8369-1f2a5fbd2767"),
Guid.Parse("d9eaf643-8276-4d3a-af04-33d8706d6bc3"),
},
},
            new GuiduuidArray1M
{
    Id = 159,
    Value = 
new System.Guid[4]
{
Guid.Parse("e1779a8c-0bca-4a33-9c03-3045d45a260e"),
Guid.Parse("b322c9fe-a834-48be-8af6-0dedea47f16e"),
Guid.Parse("44b6c0a5-d77a-4ea0-9547-0ee9731cfaa9"),
Guid.Parse("16d656cd-8a56-4d52-b9e3-f1274dc74032"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 162,
    Value = 
new System.Guid[4]
{
Guid.Parse("36351d18-57b4-42ab-9568-ca4bb3348a90"),
Guid.Parse("9f20e015-c62c-4c56-8c01-fffbba1c4018"),
Guid.Parse("8b56dc4e-6a36-49c8-9988-6c0c09630b81"),
Guid.Parse("8706567a-a1a3-445c-a1ef-07607cc5dfbb"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 85,
    Value = 
new System.Guid[4]
{
Guid.Parse("da2dbe31-1f00-4fbe-ad73-7ed487a40166"),
Guid.Parse("ffa0d9b7-79cd-4a38-b18e-9e5f12c2c21c"),
Guid.Parse("4ba9e471-b60d-4e69-bfd1-a7db83fe305b"),
Guid.Parse("f4690a55-739e-44d5-8fdf-288c264c6059"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e2e1537a-d4bf-4d4c-b96a-c2775a6c5967"),
Guid.Parse("9f9e3914-5505-4f10-b8e0-a286cc4885de"),
Guid.Parse("e5bcfe29-fc83-4887-b3ed-2b88eeee933c"),
},
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
Guid.Parse("e6ae727a-f7a6-4411-864c-843eda540400"),
Guid.Parse("29839701-c755-40cf-ac8b-4777eb5f0d6d"),
Guid.Parse("803adf23-a77c-478b-9abe-573fd761c82e"),
Guid.Parse("74d25b46-bced-47d2-8d9b-61e562fdf64c"),
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
Guid.Parse("4ea5a882-bb03-4f71-9cec-31492d44848b"),
Guid.Parse("230945e9-32e2-497d-8418-a7f8d8a1b2f4"),
Guid.Parse("e3bb6a66-3e24-429f-9ec6-a1b4af347904"),
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
new System.Guid[3]
{
Guid.Parse("20de836e-b353-49a1-9b89-d5df3101eacb"),
Guid.Parse("4656bf55-20ad-40c0-be05-c0f089067591"),
Guid.Parse("01a379b0-7ecb-428d-928c-7654d9339f0e"),
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
new System.Guid[4]
{
Guid.Parse("51fd9c96-53fb-4d49-9b7b-587029df546f"),
Guid.Parse("447958a4-2625-44f1-a943-6ac123ea02b9"),
Guid.Parse("302b458a-1a5e-40c2-a1b4-b072fa133d63"),
Guid.Parse("6e0e2318-e0ca-4ea5-a31f-7bd0f737308c"),
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
Guid.Parse("c041ca2e-86d2-42fd-beb7-afee5a721ec1"),
Guid.Parse("cf48ba4c-54b3-4330-a22a-db00b429aa88"),
Guid.Parse("a7b232c7-c1cd-4ee0-a972-bde4c582765e"),
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
                        Assert.That(models, Has.Count.EqualTo(7));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                        Assert.That(models, Has.Count.EqualTo(16));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[29], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
GuiduuidArray1M.AssertModel(models[0],_testData[15], false);GuiduuidArray1M.AssertModel(models[1],_testData[16], false);GuiduuidArray1M.AssertModel(models[2],_testData[17], false);GuiduuidArray1M.AssertModel(models[3],_testData[18], false);GuiduuidArray1M.AssertModel(models[4],_testData[19], false);GuiduuidArray1M.AssertModel(models[5],_testData[20], false);GuiduuidArray1M.AssertModel(models[6],_testData[21], false);GuiduuidArray1M.AssertModel(models[7],_testData[22], false);GuiduuidArray1M.AssertModel(models[8],_testData[23], false);GuiduuidArray1M.AssertModel(models[9],_testData[24], false);GuiduuidArray1M.AssertModel(models[10],_testData[25], false);GuiduuidArray1M.AssertModel(models[11],_testData[26], false);GuiduuidArray1M.AssertModel(models[12],_testData[27], false);GuiduuidArray1M.AssertModel(models[13],_testData[28], false);GuiduuidArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
GuiduuidArray1M.AssertModel(models[0],_testData[3], false);GuiduuidArray1M.AssertModel(models[1],_testData[4], false);GuiduuidArray1M.AssertModel(models[2],_testData[5], false);GuiduuidArray1M.AssertModel(models[3],_testData[6], false);GuiduuidArray1M.AssertModel(models[4],_testData[7], false);GuiduuidArray1M.AssertModel(models[5],_testData[8], false);GuiduuidArray1M.AssertModel(models[6],_testData[9], false);GuiduuidArray1M.AssertModel(models[7],_testData[10], false);GuiduuidArray1M.AssertModel(models[8],_testData[11], false);GuiduuidArray1M.AssertModel(models[9],_testData[12], false);GuiduuidArray1M.AssertModel(models[10],_testData[13], false);GuiduuidArray1M.AssertModel(models[11],_testData[14], false);GuiduuidArray1M.AssertModel(models[12],_testData[15], false);GuiduuidArray1M.AssertModel(models[13],_testData[16], false);GuiduuidArray1M.AssertModel(models[14],_testData[17], false);GuiduuidArray1M.AssertModel(models[15],_testData[18], false);GuiduuidArray1M.AssertModel(models[16],_testData[19], false);GuiduuidArray1M.AssertModel(models[17],_testData[20], false);GuiduuidArray1M.AssertModel(models[18],_testData[21], false);GuiduuidArray1M.AssertModel(models[19],_testData[22], false);GuiduuidArray1M.AssertModel(models[20],_testData[23], false);GuiduuidArray1M.AssertModel(models[21],_testData[24], false);GuiduuidArray1M.AssertModel(models[22],_testData[25], false);GuiduuidArray1M.AssertModel(models[23],_testData[26], false);GuiduuidArray1M.AssertModel(models[24],_testData[27], false);GuiduuidArray1M.AssertModel(models[25],_testData[28], false);GuiduuidArray1M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(19));
GuiduuidArray1M.AssertModel(models[0],_testData[11], false);GuiduuidArray1M.AssertModel(models[1],_testData[12], false);GuiduuidArray1M.AssertModel(models[2],_testData[13], false);GuiduuidArray1M.AssertModel(models[3],_testData[14], false);GuiduuidArray1M.AssertModel(models[4],_testData[15], false);GuiduuidArray1M.AssertModel(models[5],_testData[16], false);GuiduuidArray1M.AssertModel(models[6],_testData[17], false);GuiduuidArray1M.AssertModel(models[7],_testData[18], false);GuiduuidArray1M.AssertModel(models[8],_testData[19], false);GuiduuidArray1M.AssertModel(models[9],_testData[20], false);GuiduuidArray1M.AssertModel(models[10],_testData[21], false);GuiduuidArray1M.AssertModel(models[11],_testData[22], false);GuiduuidArray1M.AssertModel(models[12],_testData[23], false);GuiduuidArray1M.AssertModel(models[13],_testData[24], false);GuiduuidArray1M.AssertModel(models[14],_testData[25], false);GuiduuidArray1M.AssertModel(models[15],_testData[26], false);GuiduuidArray1M.AssertModel(models[16],_testData[27], false);GuiduuidArray1M.AssertModel(models[17],_testData[28], false);GuiduuidArray1M.AssertModel(models[18],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 33, query1, 64, query2))
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
                        Assert.That(models, Has.Count.EqualTo(18));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 122, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[4], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[5], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[6], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[23],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[24],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[25],_testData[29], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 51, 112))
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
                        Assert.That(models, Has.Count.EqualTo(10));
GuiduuidArray1M.AssertModel(models[0],_testData[20], false);GuiduuidArray1M.AssertModel(models[1],_testData[21], false);GuiduuidArray1M.AssertModel(models[2],_testData[22], false);GuiduuidArray1M.AssertModel(models[3],_testData[23], false);GuiduuidArray1M.AssertModel(models[4],_testData[24], false);GuiduuidArray1M.AssertModel(models[5],_testData[25], false);GuiduuidArray1M.AssertModel(models[6],_testData[26], false);GuiduuidArray1M.AssertModel(models[7],_testData[27], false);GuiduuidArray1M.AssertModel(models[8],_testData[28], false);GuiduuidArray1M.AssertModel(models[9],_testData[29], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatch(connection, 96, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
GuiduuidArray1M.AssertModel(models[0],_testData[18], false);GuiduuidArray1M.AssertModel(models[1],_testData[19], false);GuiduuidArray1M.AssertModel(models[2],_testData[20], false);GuiduuidArray1M.AssertModel(models[3],_testData[21], false);GuiduuidArray1M.AssertModel(models[4],_testData[22], false);GuiduuidArray1M.AssertModel(models[5],_testData[23], false);GuiduuidArray1M.AssertModel(models[6],_testData[24], false);GuiduuidArray1M.AssertModel(models[7],_testData[25], false);GuiduuidArray1M.AssertModel(models[8],_testData[26], false);GuiduuidArray1M.AssertModel(models[9],_testData[27], false);GuiduuidArray1M.AssertModel(models[10],_testData[28], false);GuiduuidArray1M.AssertModel(models[11],_testData[29], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 88);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
GuiduuidArray1M.AssertModel(models[0],_testData[17], false);GuiduuidArray1M.AssertModel(models[1],_testData[18], false);GuiduuidArray1M.AssertModel(models[2],_testData[19], false);GuiduuidArray1M.AssertModel(models[3],_testData[20], false);GuiduuidArray1M.AssertModel(models[4],_testData[21], false);GuiduuidArray1M.AssertModel(models[5],_testData[22], false);GuiduuidArray1M.AssertModel(models[6],_testData[23], false);GuiduuidArray1M.AssertModel(models[7],_testData[24], false);GuiduuidArray1M.AssertModel(models[8],_testData[25], false);GuiduuidArray1M.AssertModel(models[9],_testData[26], false);GuiduuidArray1M.AssertModel(models[10],_testData[27], false);GuiduuidArray1M.AssertModel(models[11],_testData[28], false);GuiduuidArray1M.AssertModel(models[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 18);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
GuiduuidArray1M.AssertModel(models[0],_testData[4], false);GuiduuidArray1M.AssertModel(models[1],_testData[5], false);GuiduuidArray1M.AssertModel(models[2],_testData[6], false);GuiduuidArray1M.AssertModel(models[3],_testData[7], false);GuiduuidArray1M.AssertModel(models[4],_testData[8], false);GuiduuidArray1M.AssertModel(models[5],_testData[9], false);GuiduuidArray1M.AssertModel(models[6],_testData[10], false);GuiduuidArray1M.AssertModel(models[7],_testData[11], false);GuiduuidArray1M.AssertModel(models[8],_testData[12], false);GuiduuidArray1M.AssertModel(models[9],_testData[13], false);GuiduuidArray1M.AssertModel(models[10],_testData[14], false);GuiduuidArray1M.AssertModel(models[11],_testData[15], false);GuiduuidArray1M.AssertModel(models[12],_testData[16], false);GuiduuidArray1M.AssertModel(models[13],_testData[17], false);GuiduuidArray1M.AssertModel(models[14],_testData[18], false);GuiduuidArray1M.AssertModel(models[15],_testData[19], false);GuiduuidArray1M.AssertModel(models[16],_testData[20], false);GuiduuidArray1M.AssertModel(models[17],_testData[21], false);GuiduuidArray1M.AssertModel(models[18],_testData[22], false);GuiduuidArray1M.AssertModel(models[19],_testData[23], false);GuiduuidArray1M.AssertModel(models[20],_testData[24], false);GuiduuidArray1M.AssertModel(models[21],_testData[25], false);GuiduuidArray1M.AssertModel(models[22],_testData[26], false);GuiduuidArray1M.AssertModel(models[23],_testData[27], false);GuiduuidArray1M.AssertModel(models[24],_testData[28], false);GuiduuidArray1M.AssertModel(models[25],_testData[29], false);
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


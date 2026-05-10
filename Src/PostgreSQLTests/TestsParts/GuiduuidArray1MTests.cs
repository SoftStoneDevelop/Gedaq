

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
    Id = 8,
    Value = 
new System.Guid[4]
{
Guid.Parse("799daee3-67b9-4cc7-a522-6ec083ac0055"),
Guid.Parse("e9a161f3-a658-4aa7-94ba-99bf41c58951"),
Guid.Parse("6fbfbdb9-0116-4970-a8e5-bf766ce1573c"),
Guid.Parse("6f6ff40d-1e68-4b15-9502-eca6e7c02783"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 11,
    Value = 
new System.Guid[3]
{
Guid.Parse("0379422a-2661-4906-8924-e4f3b8d0c604"),
Guid.Parse("2840169f-eb75-46ef-a486-c850875b0b86"),
Guid.Parse("b85a13af-f3fc-4040-bd05-9300aa246e43"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("e40d5d6f-a0e2-4032-9d99-a47cbb03506b"),
Guid.Parse("58e6679b-5f9c-49dd-bb0d-147c376a3f0b"),
Guid.Parse("83fdf7ac-edc1-4e99-a093-001fd602ed65"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 13,
    Value = 
new System.Guid[4]
{
Guid.Parse("2e6d1715-8aad-413e-9ffb-d7a6c5a387af"),
Guid.Parse("b85faea0-378d-4f83-b681-91d57105e818"),
Guid.Parse("98c6ce85-b2a5-46cd-87e2-0a9fc5214249"),
Guid.Parse("f3aa8ab6-e789-499d-985a-c3a4f73d2c9b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("88940d40-c2e4-48bb-8975-73bfa1f3df09"),
Guid.Parse("906ae3e9-d0b1-45f8-b873-62bbe7fdc118"),
Guid.Parse("2ef18820-d789-43e2-8d1c-a8ac4371eddd"),
Guid.Parse("574086cd-6f7a-4596-b200-b8fccf84dc51"),
},
},
            new GuiduuidArray1M
{
    Id = 18,
    Value = 
new System.Guid[4]
{
Guid.Parse("3c0dea36-c722-4985-b343-8c0944b048db"),
Guid.Parse("04005b29-5604-4a24-b8a7-c791151971af"),
Guid.Parse("d8040957-4906-4f33-b60a-1c1201a7c370"),
Guid.Parse("c1c3776b-be58-47b9-9089-20e11a60be4d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("725e5790-7ea2-48e7-8449-3c47bd94d62e"),
Guid.Parse("a5411b02-e61d-4732-bc70-61ec7e4f6234"),
Guid.Parse("aa7a5417-89c3-4969-ba76-a0e311a1feaa"),
Guid.Parse("4f8aebb7-3970-4306-9eb2-dec49d4c950e"),
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
Guid.Parse("5ba7fac6-d795-4ef5-854e-e6fc6d35fc21"),
Guid.Parse("f89bef2e-d02a-4add-b2b7-9f7c937bf990"),
Guid.Parse("d6d228de-4b1e-4b09-98c1-42fbd033d7c3"),
Guid.Parse("d67df2a9-df5c-4332-993f-e3ca2de67bbb"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6f4935c1-a5a0-49b5-b674-1888a2670a66"),
Guid.Parse("7e4f1526-49fe-49d1-a1ba-3f37a8f75fbc"),
Guid.Parse("e18947a4-f2c1-4d6b-9234-27a168c833cd"),
Guid.Parse("bf687854-fe74-4d48-8768-7288c7288eec"),
},
},
            new GuiduuidArray1M
{
    Id = 30,
    Value = 
new System.Guid[4]
{
Guid.Parse("f382d156-9fb8-4826-9e3c-5d768dfdeaae"),
Guid.Parse("d7a5286e-5775-4562-af31-cf0276c6b6a8"),
Guid.Parse("89614186-62da-4b16-a039-3c7b4ec9018c"),
Guid.Parse("5e3fe910-25df-42fa-b59e-d2384be8747e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 15,
    Value = 
new System.Guid[3]
{
Guid.Parse("e3215962-7571-45f7-b5e9-61b590e2b230"),
Guid.Parse("2a944d84-6a7c-40e8-95e1-df55f1cc54b4"),
Guid.Parse("0b36e395-3322-4055-83ea-ea6752112d0c"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 31,
    Value = 
new System.Guid[3]
{
Guid.Parse("a3040a44-cd01-446e-ba36-ed19851ae4aa"),
Guid.Parse("7f303133-e810-44d0-a2ed-5fade873b7fd"),
Guid.Parse("f0162e0d-8302-43f2-934e-618615133488"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 34,
    Value = 
new System.Guid[3]
{
Guid.Parse("4942fc4c-844f-465a-be4d-09ae9233e972"),
Guid.Parse("79ebcfb6-02f2-47fa-830b-941677587cf7"),
Guid.Parse("3732ee7f-3557-42ec-91b4-583117180db1"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 22,
    Value = 
new System.Guid[3]
{
Guid.Parse("05b8add2-9e99-4314-b574-1f6042a003a8"),
Guid.Parse("a4218ea2-e7d4-4e2e-b04b-52019cda0d56"),
Guid.Parse("6710e68e-da7b-4747-b13a-09ffbdd9b46b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d8767ba9-462c-426e-8436-fc98a49af905"),
Guid.Parse("6406d205-df31-49d3-b99a-9a4e7f4ba26a"),
Guid.Parse("153efea1-a8e3-494c-b3d7-dc5bce8b0d48"),
Guid.Parse("121d820d-9383-46c9-9404-7ab356c1c33d"),
},
},
            new GuiduuidArray1M
{
    Id = 43,
    Value = 
new System.Guid[4]
{
Guid.Parse("87e54ab4-7037-4b4b-9cf8-7c104db729e2"),
Guid.Parse("23cfe1a4-18bf-4bf6-98d7-155ec3ab46d7"),
Guid.Parse("43437a37-ff41-42ae-b198-551c553a5200"),
Guid.Parse("1a389267-f681-4dcf-9e31-ee34cc006484"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("cdf3fe88-9948-4c8c-bb86-7f1d617542cc"),
Guid.Parse("217f59f6-94c3-49e8-9b35-596a9f1f7317"),
Guid.Parse("5edcaed2-ce03-4652-9797-004ad40b1679"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 27,
    Value = 
new System.Guid[3]
{
Guid.Parse("52ac5d32-468f-46a1-a98c-8b766a05d594"),
Guid.Parse("2a64430b-8a9c-4b2a-91fd-02ea7a1bc6c1"),
Guid.Parse("d7bf06ed-6d01-4d93-8e92-731c297686ce"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 51,
    Value = 
new System.Guid[4]
{
Guid.Parse("44aa1a40-f2bc-46c3-a1b3-d5a6e7115af7"),
Guid.Parse("f43b7a17-f5ec-45a6-9d01-8af854e7c090"),
Guid.Parse("b4913209-71d0-4957-9dcc-6416bda9aea5"),
Guid.Parse("e995ecb3-b5b6-428b-a3d5-229bc5cd4e1f"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 54,
    Value = 
new System.Guid[4]
{
Guid.Parse("71af0de8-73e5-4e7d-a133-2f7ef2ef92d7"),
Guid.Parse("1d4fa0e2-ad9b-4e64-8ace-4c31d70d7e8e"),
Guid.Parse("be4b0c12-b75b-488e-afe7-fa5b6a6df7d8"),
Guid.Parse("544ddc7e-aed2-4bd0-8f5d-c0afc8586bd2"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 31,
    Value = 
new System.Guid[3]
{
Guid.Parse("786c51e7-3d58-4ec9-96be-b01b5c31480c"),
Guid.Parse("3b9d6b5e-c46b-48fa-b394-562bc9f84f14"),
Guid.Parse("fb9b760f-6452-40e8-9c75-24b8f750d2aa"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("20079a2f-eb5c-46f4-83b6-04516057b5cf"),
Guid.Parse("d5a4ca87-c99d-4f77-b1af-afbfd8cec441"),
Guid.Parse("775e111d-6985-41b8-94f5-f5e5a516f268"),
Guid.Parse("8b6e0375-8197-4567-8cfb-ee1bcadf5d6a"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("55f5af15-a468-4483-9b08-9ae8bc41502e"),
Guid.Parse("1fa7dc1d-3232-4ed7-8ba1-76d7973b483a"),
Guid.Parse("aa16890f-fd3c-4ba5-8820-9f60709416e9"),
Guid.Parse("7a6f5269-37d6-4eda-8c3d-b7e60f9a1646"),
},
},
            new GuiduuidArray1M
{
    Id = 61,
    Value = 
new System.Guid[4]
{
Guid.Parse("b86f7bb4-ca6e-4efd-a2d0-50f68d757379"),
Guid.Parse("f76b7817-b9fd-4e01-95c9-2c29a4bef846"),
Guid.Parse("13545fcd-eda1-4fdc-91d1-e8c40fc5387a"),
Guid.Parse("9754bc8a-4aa0-4491-9c5d-c9f5a739c905"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f9f7105c-1e07-431f-a7d5-d5451b7bf050"),
Guid.Parse("cc623490-0504-4ef9-bf12-b200317676e8"),
Guid.Parse("2f9f7d39-db0d-421b-ade8-bddb7c7ae01b"),
Guid.Parse("ecbb6d6e-9e14-4b2c-b138-541776b82209"),
},
},
            new GuiduuidArray1M
{
    Id = 70,
    Value = 
new System.Guid[4]
{
Guid.Parse("517784b6-d78c-4bb9-a25e-4eae53af20ab"),
Guid.Parse("d3063934-0e75-4ce5-a81f-465bdc435f61"),
Guid.Parse("7faebb33-6192-4aae-bcf0-f1a72e4f7597"),
Guid.Parse("722fd9e9-aecf-47cb-9344-ec4138b25059"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("07420213-91b9-4e90-99f7-82d19a1a751b"),
Guid.Parse("05c8c1a9-07c2-48b0-bcef-329c9daba12a"),
Guid.Parse("837395fe-765b-453e-b154-d80928d54013"),
Guid.Parse("cccc705c-073a-40a1-a977-bc496baa1511"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("db52b594-2632-4f3e-b171-2fb1c802a1b4"),
Guid.Parse("b8b84f0e-50d5-4fa2-b896-8e0271801acd"),
Guid.Parse("dca215ad-d0c4-4c3c-92d5-8654b4497bee"),
Guid.Parse("a44e36b1-61d5-4185-97ad-ad7fda350736"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d6568e89-8ee5-4b3f-9486-74dcb80f57f8"),
Guid.Parse("64413ab8-63de-4224-834d-1792c10edd0a"),
Guid.Parse("51ab10e3-c4e3-42df-96ae-9308e6583767"),
},
},
            new GuiduuidArray1M
{
    Id = 78,
    Value = 
new System.Guid[3]
{
Guid.Parse("54f86a3e-3870-4dce-a615-2516479c2c9a"),
Guid.Parse("872bd4b3-fd36-4c04-a2ac-48edb0af1d6a"),
Guid.Parse("d6544648-2f40-4b81-b0c8-7751fec62670"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 85,
    Value = 
new System.Guid[3]
{
Guid.Parse("fd9d22cd-b44c-488d-a93f-3217ec31ded9"),
Guid.Parse("49513a62-5238-4dad-81b9-6ad979db9e8e"),
Guid.Parse("b93f48df-2fac-4904-97a3-f78792b4d6d6"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 42,
    Value = 
new System.Guid[3]
{
Guid.Parse("61d56fd5-22f9-410f-a5e0-18a52697843e"),
Guid.Parse("1488bef0-ad28-4df1-99ba-d649a05bb344"),
Guid.Parse("5c2119dc-1dc0-481e-8a8e-d9ca6af80f31"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 93,
    Value = 
new System.Guid[3]
{
Guid.Parse("6851578e-beca-4087-ba62-f323130df2af"),
Guid.Parse("abb38d1a-71ba-4cd7-8a8b-e660174c6d92"),
Guid.Parse("84ca7450-f408-4cbb-8594-826e35ebbc17"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 97,
    Value = 
new System.Guid[3]
{
Guid.Parse("c01d3a1a-5ed7-4989-a698-97ab535f7408"),
Guid.Parse("6f435dff-dd3a-46c8-8955-3a39ec1b778c"),
Guid.Parse("c8c8665c-af2e-49de-8953-37d602bce19e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 51,
    Value = 
new System.Guid[4]
{
Guid.Parse("858b2f5c-b412-4693-99ac-d57f3d5a86a4"),
Guid.Parse("ebfb1dfc-6f01-429e-80b6-609fb6ceb1fb"),
Guid.Parse("8e80a20b-3378-4dd6-87d8-d879f22dc671"),
Guid.Parse("5e2d0230-e7d6-4c77-a253-c9c016e386a6"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("42c9c9cd-c1e4-4967-9848-4e538308a6de"),
Guid.Parse("72c421f5-99ac-4626-ad22-1a3df9680ea4"),
Guid.Parse("b13d7e63-c81e-4913-a759-734732458c2f"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2ba8ea96-45ef-4b99-b5aa-e023be460bb6"),
Guid.Parse("eb15717c-6339-4c2f-ab0c-45514de79f34"),
Guid.Parse("f2c6410d-ee32-4fa7-bba8-0e68459f3577"),
},
},
            new GuiduuidArray1M
{
    Id = 104,
    Value = 
new System.Guid[3]
{
Guid.Parse("73bc3f87-07f1-4230-90d3-1c44270d2164"),
Guid.Parse("6b65a9cc-a822-4908-81b1-df4cb101cd36"),
Guid.Parse("a93452eb-7125-4534-91af-94f1ef41c9b3"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a151ce28-60a1-4127-9459-8f1bad4b4612"),
Guid.Parse("09f93a5b-f621-4baa-b33e-27b43c2e8711"),
Guid.Parse("30178961-e377-4632-b324-ea103d3211d3"),
},
},
            new GuiduuidArray1M
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("8ad2713d-55a4-40d3-98f4-9a1a1ee55af8"),
Guid.Parse("9a13b755-1796-4ecc-b7a9-f94a167fd730"),
Guid.Parse("4589169a-ff42-464a-9dbb-f0133696f47d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 57,
    Value = 
new System.Guid[4]
{
Guid.Parse("235ffb5c-9733-468a-9a51-722ae974dda7"),
Guid.Parse("5e10ac6b-7b2b-4e31-bcd7-49f8c734eb97"),
Guid.Parse("8e2a45bb-09bd-4bd0-b8dd-acbbf7e12eee"),
Guid.Parse("5c2b0ece-0c10-46e5-bc7d-c7a68822a7fc"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8de63f79-3177-4b8a-b66f-796b2f045eff"),
Guid.Parse("d13d6c7c-0bdd-4b06-9ac9-7d0354c303d2"),
Guid.Parse("2cd575f2-8313-46fc-b45e-5eb92b6afb08"),
Guid.Parse("59c200f4-9baa-4bfc-9525-f92891c8da80"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1703f083-936d-4921-aa51-1bee2cb582f8"),
Guid.Parse("0a50522e-5d95-465f-b53f-8d3f76a7261b"),
Guid.Parse("fd3b5b58-a46f-49f7-b695-1203e12489a1"),
Guid.Parse("d97aae21-054d-425a-a409-1dec3148f86b"),
},
},
            new GuiduuidArray1M
{
    Id = 112,
    Value = 
new System.Guid[4]
{
Guid.Parse("33541d94-896b-4180-b829-a9bfe4bb065f"),
Guid.Parse("a6ec1baa-7a81-4dd5-8aba-090b9a61a3e3"),
Guid.Parse("fea831b9-b4fd-4d68-919d-638edcec4ffa"),
Guid.Parse("693d3abe-e2cd-445f-9178-ac9034eaef56"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c2bc39a7-4c47-4084-be6f-e1530aa28f1e"),
Guid.Parse("a4577dbf-d419-482c-a076-fb6f75743944"),
Guid.Parse("85237318-4680-4ce5-83bc-1bf937e0be3b"),
Guid.Parse("c139c6e2-be37-4e0f-8f37-c567b3ca1d6b"),
},
},
            new GuiduuidArray1M
{
    Id = 115,
    Value = 
new System.Guid[3]
{
Guid.Parse("1e59161e-8fd8-451b-8aac-fbefff33d273"),
Guid.Parse("0a2ea23a-fcab-47ac-80f1-3e3639dc26b6"),
Guid.Parse("55224802-497a-49f9-82d3-f38def59a9aa"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 59,
    Value = 
new System.Guid[3]
{
Guid.Parse("b6fe8f31-8589-4906-ab82-c1a72be02260"),
Guid.Parse("a7cc4307-ccb5-42ba-a35c-117566b3db5e"),
Guid.Parse("89691d67-4592-499b-ade8-169aa28dd253"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d0996196-8b30-46f2-a822-fca3e396ddce"),
Guid.Parse("8e1cada6-8882-473a-a1dc-f50ede2d6231"),
Guid.Parse("ac7e31cf-2a08-4d72-9848-11168ac7731a"),
Guid.Parse("eb85dd2f-dd3f-46c5-9ca8-18734f03a70c"),
},
},
            new GuiduuidArray1M
{
    Id = 116,
    Value = 
new System.Guid[3]
{
Guid.Parse("d39cceca-306d-4fcf-ae28-6cf803063871"),
Guid.Parse("2fe4c173-337f-496b-96e6-75024e58d0d2"),
Guid.Parse("8e220d20-a2fe-4bda-95ac-09c05e4dfd6b"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 121,
    Value = 
new System.Guid[3]
{
Guid.Parse("715ddec0-7ff4-49ab-9f68-f9a4da6ec5f3"),
Guid.Parse("d70acceb-b0d7-47b4-9f48-b3c1247f5715"),
Guid.Parse("57167997-4258-40ed-9714-b245c1defe3c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 64,
    Value = 
new System.Guid[4]
{
Guid.Parse("307be2b0-935b-43aa-81ca-b0d73481206e"),
Guid.Parse("b1f35427-b89c-4ef7-a125-407c96df90e5"),
Guid.Parse("af17e40c-531c-4f86-b6ce-9555b2be808f"),
Guid.Parse("aa7d5990-d71f-4ae0-9bce-ad4130a47fde"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a930fc42-55d2-4c7e-87c1-68e12eedf337"),
Guid.Parse("766911a5-4f24-4d6b-b7d0-26d210501299"),
Guid.Parse("dd98f492-8a2d-49f1-90df-1d7e3a9fa50a"),
Guid.Parse("6a7fa1d2-0c8f-40ec-a295-8f1422dbd516"),
},
},
            new GuiduuidArray1M
{
    Id = 128,
    Value = 
new System.Guid[4]
{
Guid.Parse("d9ce8e41-5abc-43d7-a046-2fb30e1881b5"),
Guid.Parse("f6eeb6e7-c740-4967-a561-20593681f4e9"),
Guid.Parse("b797c054-9fd0-40ae-84e9-7eab706dbc54"),
Guid.Parse("a6f6d508-b936-4150-91d6-7c3486c30459"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("adf6de61-386f-4d73-abbc-905e0360a991"),
Guid.Parse("cd64d035-505e-4a8a-88bd-b4ef285890b8"),
Guid.Parse("0040df3a-d343-47f9-b385-eba8047e2c1d"),
Guid.Parse("5f9bf613-79a4-4b24-97b3-5658b3955193"),
},
},
            new GuiduuidArray1M
{
    Id = 129,
    Value = 
new System.Guid[3]
{
Guid.Parse("e136574d-7b1d-4ad5-8047-bb761e9ac757"),
Guid.Parse("3b5efd0b-c008-4cb3-b41e-34898dab541a"),
Guid.Parse("e50c303d-9fbe-4c19-b8e7-3211a388ee33"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 73,
    Value = 
new System.Guid[4]
{
Guid.Parse("e9431d92-f3ca-497d-b6b0-3e5ed76615e3"),
Guid.Parse("f1a0d2c1-29b4-4ccf-9121-7ffe03ba6368"),
Guid.Parse("d5e56b0b-cbc5-44d4-b194-b9a0b207f729"),
Guid.Parse("db3166bd-44ab-40cc-b02d-28c703547ee0"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f0fcc47f-ba8a-4374-b517-3f3ab581903f"),
Guid.Parse("abe5e622-0bde-49c9-95f3-00d72b43f35a"),
Guid.Parse("9276f3bb-bf55-4c1e-92b6-4defafdbbe02"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 130,
    Value = 
new System.Guid[4]
{
Guid.Parse("d3bb208b-7992-434e-8ffd-abab83b43e29"),
Guid.Parse("ac92f32f-f58b-4afe-b26c-8f148f926d43"),
Guid.Parse("28b3d0af-99be-4e14-b7b5-b6b57ee8cac7"),
Guid.Parse("7a234a25-56bb-440e-b2af-cbdfa75a1142"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5e2bcb80-36af-43c7-abfc-5c692848d683"),
Guid.Parse("82ff28eb-f2e9-435b-899f-44eb95405916"),
Guid.Parse("0e660b3f-e9f3-4cf5-b38c-5d7f29ceeea6"),
},
},
            new GuiduuidArray1M
{
    Id = 134,
    Value = 
new System.Guid[3]
{
Guid.Parse("50a14813-4fd6-4b6e-a787-aaed3848a5c3"),
Guid.Parse("f51f90fd-1dae-4bcf-92ae-323d93702893"),
Guid.Parse("1bac55af-0265-410e-9776-9237d3e1ca63"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 81,
    Value = 
new System.Guid[3]
{
Guid.Parse("668cde97-dcc9-47d1-a74a-fe0a42998a52"),
Guid.Parse("c2a967d2-d182-4bb9-a994-760fc634abc7"),
Guid.Parse("3f62249d-fc78-41ff-b0ca-a8cc4072882b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fa29bf94-9f0d-4fcb-87d8-2c8e10d50db2"),
Guid.Parse("68a2e7bd-0ea7-48e5-86d2-0af79b06f63f"),
Guid.Parse("f8d2d0c2-d494-409d-b369-232bd72a7c3d"),
Guid.Parse("513c22fa-fc8a-4e22-adf1-e16eec626c04"),
},
},
            new GuiduuidArray1M
{
    Id = 140,
    Value = 
new System.Guid[4]
{
Guid.Parse("a971e608-c619-46d9-bdb9-e13c69fb5b82"),
Guid.Parse("1eb03275-bb4f-465d-92bd-597fadc4f99e"),
Guid.Parse("47df5680-9422-48ce-ab56-9b556a8963c4"),
Guid.Parse("92daf472-fc9f-486d-b022-edb16e4f84a2"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 144,
    Value = 
new System.Guid[4]
{
Guid.Parse("e0a9e447-8fa1-4c92-9d0f-e969339c0ac7"),
Guid.Parse("fd17a640-841f-44d1-aa52-15daf54ef83a"),
Guid.Parse("7cf9e810-89a1-42d4-9d46-99e834de55b1"),
Guid.Parse("061ea194-b015-479a-8540-e35014c93306"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 88,
    Value = 
new System.Guid[4]
{
Guid.Parse("1d8f189c-046e-482a-92fd-a7910eeae20d"),
Guid.Parse("18903b75-4871-4361-a39c-341e0424d7b4"),
Guid.Parse("87aa624e-2090-494e-a20a-8fd20e85edfb"),
Guid.Parse("5e6b4bd2-fb18-4713-99a5-75ee2def6fde"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("acb14ec8-9c0c-4a24-a98b-1bc39a15fedd"),
Guid.Parse("21bb8133-3d5c-470f-bc4f-0debac6bce54"),
Guid.Parse("4c0a1efd-ef6e-48da-af50-7b366e851be3"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 150,
    Value = 
new System.Guid[3]
{
Guid.Parse("483e9789-ca53-4393-a90d-5c3bb09d5141"),
Guid.Parse("0d6aba8d-f542-4941-879e-73d05017ff21"),
Guid.Parse("f6899343-f547-4abd-90a2-6792d474554e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("35e4a434-bd0a-4fa6-9feb-5c9b9628f329"),
Guid.Parse("c9a464f4-4d79-42fe-ac5f-cad60dec91d0"),
Guid.Parse("8d72ba49-04c7-4c05-ae84-2c03b8a659ad"),
Guid.Parse("c1982fb3-d1b1-4aec-afb2-950f4c7ca953"),
},
},
            new GuiduuidArray1M
{
    Id = 157,
    Value = 
new System.Guid[4]
{
Guid.Parse("6617ed40-fdaa-46ea-a674-f44838746f91"),
Guid.Parse("458926c0-1ac1-47ea-aca1-a47a4cf2845a"),
Guid.Parse("778109ff-0f19-4be3-9920-f03d94a60b99"),
Guid.Parse("00faba64-9512-4f57-9fa6-30958e42a901"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 95,
    Value = 
new System.Guid[4]
{
Guid.Parse("b96043b9-58b6-494c-a8e9-ab9733f216bd"),
Guid.Parse("80c60f35-a754-4e10-a411-24e1c7835987"),
Guid.Parse("6b8ca64c-9cda-4066-8bba-b517336c07b0"),
Guid.Parse("fdec6ad7-8272-40fc-ae2f-d3b31584035b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9af61cd8-216d-430f-ade5-a0ba4e92196e"),
Guid.Parse("483e0f76-dd36-4f06-bec9-ce170472924e"),
Guid.Parse("631da591-b4af-45f8-b488-9a460949388a"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 164,
    Value = 
new System.Guid[4]
{
Guid.Parse("f585235d-3fae-48fe-b180-8ea18056dbc0"),
Guid.Parse("4e941d22-c608-44ee-a05c-86eb69183431"),
Guid.Parse("bf5b66ca-c6ac-4fcd-ba34-f4599b0dbdf6"),
Guid.Parse("35d0dfee-afce-4387-b034-c0d21a4b199f"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 172,
    Value = 
new System.Guid[3]
{
Guid.Parse("00f27e99-050f-4b62-83e1-5e169b76ca63"),
Guid.Parse("a158c054-2ab4-4a3c-bfa6-21003609b7bc"),
Guid.Parse("3329dca2-ab05-4876-b5f2-91560c838f7a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 101,
    Value = 
new System.Guid[4]
{
Guid.Parse("67d79994-28e3-44c7-88ac-753188372dd1"),
Guid.Parse("a0bbe5af-9fa3-4bfb-81cb-3c739b9d40e9"),
Guid.Parse("7eb6bf41-7a71-4919-8b66-0e2dd379d0c2"),
Guid.Parse("159bce8a-25b2-4864-89ef-d6b8ac802a91"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 177,
    Value = 
new System.Guid[3]
{
Guid.Parse("9db347be-c99a-41ab-9507-199e777f49fa"),
Guid.Parse("8aa3896a-6c24-4399-a625-96dc5b3bc799"),
Guid.Parse("eabf2d97-1870-431c-86fb-63f68958b81f"),
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
new System.Guid[4]
{
Guid.Parse("6f4935c1-a5a0-49b5-b674-1888a2670a66"),
Guid.Parse("7e4f1526-49fe-49d1-a1ba-3f37a8f75fbc"),
Guid.Parse("e18947a4-f2c1-4d6b-9234-27a168c833cd"),
Guid.Parse("bf687854-fe74-4d48-8768-7288c7288eec"),
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
new System.Guid[4]
{
Guid.Parse("d8767ba9-462c-426e-8436-fc98a49af905"),
Guid.Parse("6406d205-df31-49d3-b99a-9a4e7f4ba26a"),
Guid.Parse("153efea1-a8e3-494c-b3d7-dc5bce8b0d48"),
Guid.Parse("121d820d-9383-46c9-9404-7ab356c1c33d"),
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
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("55f5af15-a468-4483-9b08-9ae8bc41502e"),
Guid.Parse("1fa7dc1d-3232-4ed7-8ba1-76d7973b483a"),
Guid.Parse("aa16890f-fd3c-4ba5-8820-9f60709416e9"),
Guid.Parse("7a6f5269-37d6-4eda-8c3d-b7e60f9a1646"),
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[34], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 97;
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
                parametr1.Value = 144;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[34], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidArray1M.AssertModel(models[0],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidArray1M.AssertModel(models[0],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 150;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidArray1M.AssertModel(models[0],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        GuiduuidArray1M.AssertModel(models[0],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 70, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 93, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 157, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 30, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 30, query1, 164, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 115, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 104, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 8, query1, 93, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 129, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidArray1M.AssertModel(models[0],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 93, 31))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 54);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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


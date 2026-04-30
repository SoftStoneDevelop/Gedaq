

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
Guid.Parse("dc42ee51-37fc-4b3f-aacc-859d80ca7ffc"),
Guid.Parse("6783d0d6-989f-4a7a-a2cb-b9d8de3c4faf"),
Guid.Parse("a3325885-a4bc-4cf3-8ec1-85c8863d2494"),
Guid.Parse("34042a2d-48cb-4299-87e9-da24650c4a7f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("dd8e7c43-4410-4721-94c9-7babdf2afce7"),
Guid.Parse("2a23a2ab-2c43-4efe-bb28-f6b6e8949971"),
Guid.Parse("68ed51ab-951a-44bc-b5f6-6dfd150a012e"),
},
},
            new GuiduuidArray1M
{
    Id = 6,
    Value = 
new System.Guid[3]
{
Guid.Parse("6f3ced52-c4fe-4c6d-a2c9-4afa06521aaf"),
Guid.Parse("be537dee-058a-4fab-9c43-afc3947f6577"),
Guid.Parse("74f9dca2-c122-480e-a01c-13f7944175c0"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 4,
    Value = 
new System.Guid[3]
{
Guid.Parse("499bc3b7-6c2b-4444-94b2-47f0c7b46a24"),
Guid.Parse("7632d1e7-48c0-44e9-8ce0-ac41c91cbad0"),
Guid.Parse("d35b6a25-942b-4ebf-9e13-b8c974bb677c"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("be7b995e-8ede-436f-887e-7d2150bbbcd9"),
Guid.Parse("6b63a23d-23da-484c-894c-2100627eab61"),
Guid.Parse("c3507a67-b552-4895-8975-57a5a5f4e966"),
Guid.Parse("872e96f4-a27e-4322-8fa7-8d6c2c85e8cb"),
},
},
            new GuiduuidArray1M
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("fbb962c2-fa5b-4500-8688-3917c82d042c"),
Guid.Parse("ae7f0674-3b24-4b74-86e0-6f2cda1130bd"),
Guid.Parse("69185111-d47f-4db8-af06-2fdddbd97f57"),
Guid.Parse("0efdf1e2-28ce-4091-b787-dc3472dc8cf1"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f7998ee0-c900-46db-b21f-d1b1be6e37a0"),
Guid.Parse("c1d03a79-0b90-455b-ad9c-eda03ab53dfd"),
Guid.Parse("63c5259c-13ac-45fc-b8d4-a7fe9bec10ad"),
Guid.Parse("0fb3ea87-5e4e-4ae1-b014-ddf7375ceef3"),
},
},
            new GuiduuidArray1M
{
    Id = 10,
    Value = 
new System.Guid[4]
{
Guid.Parse("083bf5e9-e27d-4610-b6b2-804d88dfb491"),
Guid.Parse("fa21a742-1b1a-4fe6-b037-a47560e698a3"),
Guid.Parse("4dfc5762-00eb-428e-80d5-596e5d523b2e"),
Guid.Parse("aa76ce53-f56f-4281-8eb2-a07978f52423"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 9,
    Value = 
new System.Guid[3]
{
Guid.Parse("42ae5914-d011-4ede-a25b-45d7af9c2501"),
Guid.Parse("973f8438-b729-4cf7-809d-efa270832991"),
Guid.Parse("4baa6b0b-e880-40eb-9f51-8bc499715e93"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 17,
    Value = 
new System.Guid[4]
{
Guid.Parse("ae7f5017-db02-48be-8141-4b4657b10a93"),
Guid.Parse("689eb996-e7ed-4158-8c57-e94c83d6ea4c"),
Guid.Parse("34963f50-614c-4ae4-94ab-5571c3a402dd"),
Guid.Parse("faf59780-381a-4c56-9af8-33291fdbb1a7"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 21,
    Value = 
new System.Guid[4]
{
Guid.Parse("11071811-e8a3-48e0-a84d-ae00685e2f58"),
Guid.Parse("39897044-d60d-48c2-a0bc-5c02406beb26"),
Guid.Parse("d69b6785-3ea6-4169-847f-88d84e73dae6"),
Guid.Parse("b25616cd-63bf-4604-8339-a6a162485bf3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("73b2a105-5232-49f5-bb62-33a8e25b192b"),
Guid.Parse("8c6f62ec-0be5-46fc-ab59-c11cf89c664b"),
Guid.Parse("06f464eb-65e3-4944-bfa9-0dc5f9bebc94"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8a914c1b-beef-420d-ae3f-5bfcd4db8d5b"),
Guid.Parse("d4d59c3f-8fd6-456a-8532-693ccc1e3b9a"),
Guid.Parse("3150fc17-97bc-44f5-ad06-d5359d0372de"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 27,
    Value = 
new System.Guid[4]
{
Guid.Parse("3f3d1141-22d2-416e-84c3-fcf810f527c7"),
Guid.Parse("f9dcf5fc-6fdf-40fd-8bf3-cb9bc75fd741"),
Guid.Parse("1079660f-d022-4f50-9acd-0284fc6bca00"),
Guid.Parse("93cc29f1-9abe-4327-92f1-2011bc647dda"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("bd7c69a9-3ae5-413c-94ae-2b19a57005f8"),
Guid.Parse("dc229b49-bceb-4ea2-9a87-af5df93967de"),
Guid.Parse("3addc5c8-6019-4b3a-a15f-be578bd65ec5"),
Guid.Parse("81557153-8559-4b14-a9d8-d9567778773e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("e2aaf00a-91f3-49ff-bf76-191037f2d059"),
Guid.Parse("f1070e75-f9b0-483f-8312-1f24dd198893"),
Guid.Parse("abc4d0c1-bfb0-4dee-ac8f-c3b9d2f8aaa8"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4357652b-bb55-40c7-8b94-3da75de3fd2e"),
Guid.Parse("ffb2902a-b35f-43d1-a005-2b343f5a5a2f"),
Guid.Parse("39ba0e92-ccd5-47bb-9f3e-e0df039516d7"),
Guid.Parse("48c1cbc5-012e-47eb-91d1-c6ad89923c41"),
},
},
            new GuiduuidArray1M
{
    Id = 42,
    Value = 
new System.Guid[4]
{
Guid.Parse("9e86fa98-dbc0-4455-9928-a17dd99a4f22"),
Guid.Parse("19b61a5c-6a20-402b-af55-88fca62897fd"),
Guid.Parse("959af07d-f204-40dd-88db-63a931ceb806"),
Guid.Parse("e2a1db59-08d8-4cc2-8aaf-d529caaf9a35"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 44,
    Value = 
new System.Guid[3]
{
Guid.Parse("4f0d6e95-a793-4ce8-92da-b0bffe26f067"),
Guid.Parse("7e5c2f91-6620-4358-9cc9-a0c9e1f13405"),
Guid.Parse("7a25585c-7910-47d7-8549-bd0435e5f52c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 20,
    Value = 
new System.Guid[4]
{
Guid.Parse("858a8cc5-6623-42df-8af3-35dadb3211c5"),
Guid.Parse("9afb9893-3dd8-461e-9041-439b4eb82775"),
Guid.Parse("466e9b60-5c49-46ed-83bc-4183391e0175"),
Guid.Parse("4cded3cc-ffd2-480b-a7bc-fc0b60519e13"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("1c4cb260-c188-4152-888f-8cd557061248"),
Guid.Parse("bb2056d7-343a-42e8-a9e7-9e1819e1ca61"),
Guid.Parse("e99391f4-756f-4c2a-a118-96ff33fda97d"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("01b20e66-3c50-4153-bec5-7c9229fa8820"),
Guid.Parse("9e4d234c-9ca0-487b-a29d-1bd00c5c1da1"),
Guid.Parse("4cc1e3bb-906c-4d0e-9df2-6cde4b1ad5f5"),
Guid.Parse("b17416c4-e508-463a-bc09-65f819dfe1d2"),
},
},
            new GuiduuidArray1M
{
    Id = 52,
    Value = 
new System.Guid[3]
{
Guid.Parse("4dcb97e3-9b79-48a6-bfd8-d08fb801615f"),
Guid.Parse("e71ccea4-9250-48f8-94eb-708639798fcf"),
Guid.Parse("52363d30-f30e-4ed9-8c94-cefb76cd4bcd"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5480d632-b56a-4fd4-b695-64c897b175a1"),
Guid.Parse("262d9765-e00d-4217-bee2-a838b3c36285"),
Guid.Parse("b659f076-3c2a-4bc7-9e87-d9650c0b63d9"),
},
},
            new GuiduuidArray1M
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("73ee6b96-43c0-4951-ac90-518813f59fe9"),
Guid.Parse("b645e00a-76b1-4995-9bfc-4573846d9251"),
Guid.Parse("fbaf2d47-34b6-42be-93a0-85a3f426316a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 22,
    Value = 
new System.Guid[4]
{
Guid.Parse("b33f583d-cc63-4f0b-a65c-c7dbaeedf52c"),
Guid.Parse("5f684b14-ecd5-45f1-9320-ad9bdc4cc537"),
Guid.Parse("ceb4b166-c262-4688-8c83-4badfe2aba0f"),
Guid.Parse("2f7124b3-c5f2-4bb7-a08b-c4380a1bc914"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d5f2b4aa-e54a-408d-871d-1fc3ecb922ad"),
Guid.Parse("5a6a207e-1514-4872-957b-2a36f1731119"),
Guid.Parse("1da6b28f-1e91-4c79-8dc5-c821df421d26"),
Guid.Parse("bff4637a-5f42-4971-8ea4-6d55aefe56ef"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9b10e355-4902-43dd-8e72-810525fa11cf"),
Guid.Parse("4b568367-1ea6-4cfb-95b1-e3ec88dcc52c"),
Guid.Parse("e302f91a-8392-4668-a1a8-627157b14d02"),
Guid.Parse("49a86265-42c7-4788-9a81-9c879f364a7c"),
},
},
            new GuiduuidArray1M
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("e6aeef12-ee05-412c-acb0-e68f1bac266c"),
Guid.Parse("25aa6b26-e7e3-4af3-851d-e8d41b375c31"),
Guid.Parse("df50f3c3-7fda-46ad-88e8-9ef228545c74"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 76,
    Value = 
new System.Guid[4]
{
Guid.Parse("cddfb3e7-09ca-45ad-a11e-806ebad210f5"),
Guid.Parse("2fdbbcd8-deb5-4f88-9142-c3a9afc96e4b"),
Guid.Parse("ea09bbb7-4937-498f-95da-570c50f0367b"),
Guid.Parse("31c4b50e-3370-4e19-a950-bbbd32c61c6d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("9b5a6aad-c7a2-4011-aeaa-c5d2bb4aab42"),
Guid.Parse("8c81b5ee-e6da-476e-a773-ac9b90c6a015"),
Guid.Parse("ae5117f2-697c-45ff-a3b4-1027d57f1746"),
Guid.Parse("6a36e537-9b02-408d-bfb7-74c0e64eacd1"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0e544af3-37dc-4a49-a9fc-50503d702a44"),
Guid.Parse("bf5bba44-0217-4a5e-93e2-d53ba995d888"),
Guid.Parse("98acf7df-6aac-48da-98b0-9d4088e291cb"),
},
},
            new GuiduuidArray1M
{
    Id = 83,
    Value = 
new System.Guid[3]
{
Guid.Parse("b38748a3-f822-42dc-865d-eb76e4f50dab"),
Guid.Parse("02b7e18a-bcca-4df3-a377-173e8c261695"),
Guid.Parse("c53b2264-ecbf-46c6-b7b7-6fcfe8bbc407"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b8aa47f2-5011-4ba0-9505-2524c3c84fb2"),
Guid.Parse("88507ec4-74ed-4d68-bcfb-42ced2a84b80"),
Guid.Parse("e4b74892-51e5-4cd1-9c26-f75a4e56dbce"),
Guid.Parse("2710fe99-9109-4588-806c-9f700fae66ff"),
},
},
            new GuiduuidArray1M
{
    Id = 85,
    Value = 
new System.Guid[4]
{
Guid.Parse("ca11c1bd-4ca8-4590-8b34-b01700c9ba63"),
Guid.Parse("b525c874-3257-4ea8-abe5-b938439820c4"),
Guid.Parse("a9093044-b566-4536-89d6-32eb5b3786bb"),
Guid.Parse("c0d04ca9-41b5-499d-ac14-fc6939b3fb72"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("85292dde-9008-4cd9-93ee-f11d92537d42"),
Guid.Parse("9d9074d5-1f3a-4d81-af4c-bfad98da3415"),
Guid.Parse("1275ae2c-da82-461b-bde5-c5b0c516d1e7"),
Guid.Parse("4d721613-f76c-468f-813f-1231261122a7"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("18243d94-32e8-425c-a4dd-631f91f0c3b0"),
Guid.Parse("d4bc5cae-2fd2-4357-9044-d887f4f2ccfc"),
Guid.Parse("af7d9cb5-3827-4ef4-9e1a-74e21c476bf5"),
Guid.Parse("de9b0697-6b8b-42de-b945-4bc808efd5cc"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 93,
    Value = 
new System.Guid[3]
{
Guid.Parse("39cf5ca5-bb35-4a65-8dca-5dc1f7424cf8"),
Guid.Parse("8acf7fdf-a642-4402-9c3b-631924a20469"),
Guid.Parse("7ad55192-dca3-4941-b57d-f761f751d3d4"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 94,
    Value = 
new System.Guid[4]
{
Guid.Parse("d5fe3ba0-3ab9-4eda-9878-0b5ca9b11fb7"),
Guid.Parse("42694a71-783c-45c3-a61c-4326bf62a919"),
Guid.Parse("bf74feae-1b8f-4538-ad7c-a18a42a0f719"),
Guid.Parse("130a77a9-9eff-477c-9b26-a487b3eaf8a0"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 36,
    Value = 
new System.Guid[3]
{
Guid.Parse("392d7313-805d-40d5-a9b8-cdfe4d315ffc"),
Guid.Parse("8b2b58f4-837d-40ee-9463-d157a005e4c2"),
Guid.Parse("923e1019-0634-4d93-a00e-dfa03e4e19c5"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0493d03b-94b0-4648-a9ea-bd368aba949d"),
Guid.Parse("f8c234d2-f5b4-4f96-b765-332c57d8c807"),
Guid.Parse("82272543-e333-465d-91a0-eb0cdc49891d"),
Guid.Parse("27c907ae-01e3-4aaf-bfd8-6da3997f055f"),
},
},
            new GuiduuidArray1M
{
    Id = 101,
    Value = 
new System.Guid[3]
{
Guid.Parse("fe7c242f-a943-4532-892c-8f541de9586f"),
Guid.Parse("530a13f8-c2e8-4121-b576-6c3c3ebfaedd"),
Guid.Parse("b1ff0d4b-8bfd-4270-8e21-8ba109281363"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 110,
    Value = 
new System.Guid[4]
{
Guid.Parse("dc53bdd8-74fa-4b63-9c49-8386d3d22df0"),
Guid.Parse("f6d87ac9-69b1-4a3f-b204-70c25e998a5b"),
Guid.Parse("0f2113f1-6b00-448a-912f-3341005fa6ac"),
Guid.Parse("32674862-b4d0-40dd-bb81-0d818a1229d1"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 42,
    Value = 
new System.Guid[4]
{
Guid.Parse("f43f7e69-d59e-4236-a4fa-9a4053f0e229"),
Guid.Parse("29cda1a8-227f-4757-a4fa-9843e5d4e991"),
Guid.Parse("63a4a127-e010-4ed7-9a41-2a05375f71ce"),
Guid.Parse("b10d2d24-2ecc-4acc-b3d9-cec2fac4d8f5"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e7104f02-aa81-483c-883d-91e4dc7b1731"),
Guid.Parse("43f38308-b81c-4650-95a7-61a2e06849ba"),
Guid.Parse("8db8614a-b989-417e-b4a5-56492ebc8a9f"),
Guid.Parse("96e2066b-6db9-4895-9ce7-436e5f078450"),
},
},
            new GuiduuidArray1M
{
    Id = 112,
    Value = 
new System.Guid[4]
{
Guid.Parse("87450c05-576b-4843-ab18-e01b3c2165b8"),
Guid.Parse("505fdabf-0a90-4c44-8e89-b55eef26adee"),
Guid.Parse("e19c2ed1-74ff-4223-919b-945844b3bfc8"),
Guid.Parse("96939a82-07d6-463e-8bd0-309ec03cb052"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3cbab16f-b071-422f-be6c-f9466595be9a"),
Guid.Parse("e81e9e97-7804-4a01-a3de-8e6a68a1a8b5"),
Guid.Parse("cf00dd44-b555-4222-8008-56ecd31b8e59"),
Guid.Parse("20db8e60-4c56-47eb-a826-bd1f6960552f"),
},
},
            new GuiduuidArray1M
{
    Id = 114,
    Value = 
new System.Guid[4]
{
Guid.Parse("c9092c7c-0123-46db-8301-ef82f57c058c"),
Guid.Parse("0242a0e2-1da0-4f43-82e0-8237edf1548c"),
Guid.Parse("5ab51670-7775-436f-860f-3d29780b239d"),
Guid.Parse("05fca311-d9ad-4bb6-a782-97ee93623aa4"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 51,
    Value = 
new System.Guid[3]
{
Guid.Parse("376c15fa-47cc-40bd-813e-9b59e98a1b01"),
Guid.Parse("7ca665e0-5dd9-49dd-abad-884d2bcc842c"),
Guid.Parse("cf5c0acb-0639-422f-bfa5-ce701cd2c42a"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ff7eb296-ebd4-4de2-9704-99015abfe118"),
Guid.Parse("1cc061d0-baa5-4fcb-8998-18b51229729e"),
Guid.Parse("f1e09c9d-1b7d-432c-9282-20856a8eca5d"),
Guid.Parse("32cbb302-ab42-40af-84a9-3ab60ce08eea"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ceabdb67-1afc-4833-a0a3-4ceb8ea5fa20"),
Guid.Parse("ea24bd59-3b9c-496d-ac1e-578d320217ae"),
Guid.Parse("7a797d82-4d59-48f6-b00d-52b139db6fee"),
Guid.Parse("9504b661-eb27-415a-927b-e78c0f786902"),
},
},
            new GuiduuidArray1M
{
    Id = 121,
    Value = 
new System.Guid[4]
{
Guid.Parse("68b62aa7-b78f-4051-bf42-df234c0654a9"),
Guid.Parse("fbb7565d-5099-47f4-ad8f-6396f83840d1"),
Guid.Parse("b9aaf448-9854-4cb0-9f22-a9f26d4c9ae3"),
Guid.Parse("7ecc788e-9f86-435d-aa96-69e4a40d7e6a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6640ccf4-811b-48f5-85bc-0bdc481a5ca2"),
Guid.Parse("b52da448-9ee0-44a6-953a-144e743b2979"),
Guid.Parse("6989cd58-ab73-4bd0-a449-e9b991efb5f0"),
Guid.Parse("22187d20-6254-4205-9dd0-808af0cc7da0"),
},
},
            new GuiduuidArray1M
{
    Id = 129,
    Value = 
new System.Guid[4]
{
Guid.Parse("dc251d6a-7ea3-46b1-9a65-7abefc203caf"),
Guid.Parse("54283b21-bfd1-4f22-949b-6c9d969020c4"),
Guid.Parse("69096382-5e90-4565-a54a-215ef2c7c044"),
Guid.Parse("5b2c3239-cd89-405b-b2e4-975e8d493ed5"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 58,
    Value = 
new System.Guid[4]
{
Guid.Parse("e124edcf-bb11-4745-9557-4ceb443a4330"),
Guid.Parse("1ffe4859-f152-4be2-8a15-01a6e6cf3064"),
Guid.Parse("ffcf1b2f-c39f-4517-b618-a6003c169bad"),
Guid.Parse("2bfb49b1-ae55-48d9-ad8a-5e1c54e8a612"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a1e4dac7-792f-4cf6-94fa-3167a0680646"),
Guid.Parse("e72891a7-d9ee-440d-8427-5e7fc71254c2"),
Guid.Parse("78aa111d-2d7d-41f9-816f-7177507b9345"),
Guid.Parse("16649d0f-8fec-4559-919d-232427d50718"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("69bdd7a4-043a-47c4-9ff3-a81439326929"),
Guid.Parse("af5afe31-873a-4c71-809a-7fe9cc496184"),
Guid.Parse("46d05336-135d-4eb8-b302-7291b7577910"),
Guid.Parse("61e6c6cd-94d1-4d36-a38f-f21c1279ed35"),
},
},
            new GuiduuidArray1M
{
    Id = 138,
    Value = 
new System.Guid[4]
{
Guid.Parse("c6f64225-ab74-4429-a053-1bf7511a9ecd"),
Guid.Parse("39b1c0b6-a6ae-4628-878d-898d3d1ecc2d"),
Guid.Parse("c24d0996-af54-4c1e-8af9-d46017e1f016"),
Guid.Parse("f5f414f2-1bae-4689-802a-618f628b5898"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("844d90db-f655-4bc0-af71-6bb12053a340"),
Guid.Parse("03adec9f-ed90-4716-af6a-15f67f9bfdb2"),
Guid.Parse("c4b8da4e-a2f5-46f2-a972-cfa6b8966166"),
},
},
            new GuiduuidArray1M
{
    Id = 145,
    Value = 
new System.Guid[4]
{
Guid.Parse("79c2dc8f-7a80-4b9b-86e1-5c6bcfdb131f"),
Guid.Parse("27eaa48a-36c8-4d25-8c15-6b729f0cce58"),
Guid.Parse("2451a37d-bd12-45e7-bbfa-62c598ad28b2"),
Guid.Parse("1107072f-8b4e-483f-ad13-7e5c9b03df9f"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 64,
    Value = 
new System.Guid[3]
{
Guid.Parse("d44fb483-aa5a-4682-b179-411764798b4b"),
Guid.Parse("2279ad41-ff69-4099-9181-d1677fbb0086"),
Guid.Parse("f7888ab1-987d-43cf-8ca8-46147f92568c"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("37767671-c8b9-4da9-8f58-57452965c9f0"),
Guid.Parse("6c69ff0f-12cd-4547-854b-c2a4e3ec6e9b"),
Guid.Parse("af9e33e6-f5d3-4164-9311-ec91adc97305"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 147,
    Value = 
new System.Guid[4]
{
Guid.Parse("47e07fb9-46c0-43fb-920b-a806ee0c710c"),
Guid.Parse("3fec1728-9f21-4925-840a-334835c7c0f7"),
Guid.Parse("73d21951-fd80-43bc-808e-dab1df7bdf88"),
Guid.Parse("cfdb4cd8-f856-4fa1-9ba0-5d72be190c0d"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 150,
    Value = 
new System.Guid[3]
{
Guid.Parse("9579e9e9-c2a2-45e6-bc32-22fe6eb19b1a"),
Guid.Parse("a43a6f2c-dd5b-4318-b61f-88429b6512cb"),
Guid.Parse("7ca70435-4803-4452-944a-85f9232c49d3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("4521bed7-ca40-4f23-a1ee-4f4172695df1"),
Guid.Parse("be039ec6-2645-47f7-b07d-a52618472aa0"),
Guid.Parse("23a2de3e-d709-4bd5-a7b2-75421dae6897"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8b424f3b-e06f-419f-958a-9ce458430a56"),
Guid.Parse("54458ddc-23b5-4f38-a625-a9166ab70d02"),
Guid.Parse("fe45d413-f6cf-4779-bd46-5b09ebd9143d"),
Guid.Parse("205bb6f0-8551-41bd-b4a6-ce523aa86033"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0b095cb1-e805-4446-b1d2-2267847953ba"),
Guid.Parse("cad1494c-09f0-4869-b828-800883b33e5e"),
Guid.Parse("1d1690fa-b92a-4a69-bd99-2e1a0d505893"),
},
},
            new GuiduuidArray1M
{
    Id = 156,
    Value = 
new System.Guid[4]
{
Guid.Parse("58eae3ef-dd79-4d40-9ee3-6b7e225393e3"),
Guid.Parse("08269ecf-70e6-4728-9121-7e2d73488f7e"),
Guid.Parse("11af00ed-16f8-49c0-8657-1c49f5232156"),
Guid.Parse("f6caa1f2-6772-46e1-ada2-15c5debd0618"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("287d4b48-5df2-48c2-8750-ea459b7360a2"),
Guid.Parse("29318f99-63f5-4225-b806-4aa114740248"),
Guid.Parse("52f9e541-fbbd-4934-a244-d539709fb52f"),
},
},
            new GuiduuidArray1M
{
    Id = 165,
    Value = 
new System.Guid[3]
{
Guid.Parse("c5ea8a82-b7f2-449e-9c13-d538eab64067"),
Guid.Parse("9b25c691-5aa2-4fd5-a15c-0336ce3eec33"),
Guid.Parse("593fba67-6c57-43b8-b119-746c299288a9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 69,
    Value = 
new System.Guid[4]
{
Guid.Parse("e141b0be-00c9-4a8b-aa9d-c5d428388f06"),
Guid.Parse("fc3db1a0-8dbd-4977-b5cb-b50e534ec399"),
Guid.Parse("53c8e321-fba5-4e38-8daf-22ec41c69b0b"),
Guid.Parse("099a1056-a7ce-44c4-ba6c-d9d1ace62b9e"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("346875a8-6887-486f-be16-55676fae1844"),
Guid.Parse("5a4552b7-0d4c-4c95-b553-7961af1322e7"),
Guid.Parse("3100d2a2-01ad-4fca-b086-e4bb988197ac"),
},
},
            new GuiduuidArray1M
{
    Id = 167,
    Value = 
new System.Guid[4]
{
Guid.Parse("969a707a-3c1b-4980-9353-053e1e3e6224"),
Guid.Parse("3268123f-9528-428f-954e-f31a19887056"),
Guid.Parse("8e087cd5-3e54-4ae7-8adc-d96b054a4612"),
Guid.Parse("c87a802f-1960-4dea-a7d7-1d624bf310cd"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("548ddb53-2b1a-40ef-8053-90b66873af56"),
Guid.Parse("9046f631-6e88-4b6c-a181-c05104e4efd2"),
Guid.Parse("b55da37f-6b41-4ca9-996e-8e5e100dd4d6"),
},
},
            new GuiduuidArray1M
{
    Id = 174,
    Value = 
new System.Guid[3]
{
Guid.Parse("c3f5b813-93ad-49c1-a095-8cd90fd70ca9"),
Guid.Parse("00ce60d5-b444-4919-b6ab-66d552c94728"),
Guid.Parse("c2a677ee-6ca7-4665-847a-f8107cec5f4e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 71,
    Value = 
new System.Guid[3]
{
Guid.Parse("f8e51dbe-c0e5-4438-a356-500eeff3e03a"),
Guid.Parse("17961d4b-fc97-4b23-bf4b-22def883b05f"),
Guid.Parse("47f6164d-3186-48b8-b835-d786f3242fec"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2803d928-686f-494c-9738-9b89e1503653"),
Guid.Parse("e15c3768-a5df-48ec-8da3-64fc1ee75d98"),
Guid.Parse("03653017-b573-46b0-a225-8d04bc40dbcd"),
Guid.Parse("d5604162-1d08-4fc6-882d-97f4ef372171"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ad7e05d2-c033-41b2-8e3d-fec5a03819e8"),
Guid.Parse("9e2079ed-a2c2-4291-b50a-646299350acb"),
Guid.Parse("6ba6a6d9-d41f-4a35-a197-c8e4ea7bb0d6"),
},
},
            new GuiduuidArray1M
{
    Id = 180,
    Value = 
new System.Guid[4]
{
Guid.Parse("4d82ae96-1ac5-4a25-a7a9-800e698d32e7"),
Guid.Parse("6ab5d250-e3b7-4ed6-8922-4c25fd6c52ac"),
Guid.Parse("211bc906-8e26-4284-8294-78f2ac57b998"),
Guid.Parse("780bb320-7029-40e8-8f4b-400d315f0c0c"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 186,
    Value = 
new System.Guid[4]
{
Guid.Parse("9228258f-7ee3-4216-92a2-18f95a925186"),
Guid.Parse("1ff7dbb8-df54-4b36-9736-a2f737faf0c2"),
Guid.Parse("d0db056b-7d6e-4720-8ce2-9bcff892ee8e"),
Guid.Parse("157fbfe9-09a6-435d-bc5f-add873c940a9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 80,
    Value = 
new System.Guid[4]
{
Guid.Parse("bf956825-bda8-480a-b590-8fab39b783f7"),
Guid.Parse("70b09b0b-0119-4d7b-8295-61a4a6846633"),
Guid.Parse("78d0a0c4-0a5f-4cb1-b987-b8d8ce2c9a8b"),
Guid.Parse("893a1c7a-419a-4004-9433-9b387f15000c"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 193,
    Value = 
new System.Guid[4]
{
Guid.Parse("df7debf7-45cb-4d6c-a993-31605dc4a564"),
Guid.Parse("47fe15f0-9972-43f6-a9aa-a4651a02d05e"),
Guid.Parse("2fc10946-f64e-4c02-a33d-b4ac7588fa92"),
Guid.Parse("31175b01-6bb1-4f7e-b35d-8d35ee88931c"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bb76826a-471b-4d10-9bc8-a8ae5181d01e"),
Guid.Parse("c6f14fe6-cb9d-4b6c-bb87-ffc28c7976e6"),
Guid.Parse("b5ce46f6-1195-4c14-9707-d27a76564454"),
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
                Assert.That(nullable, Is.Null);
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
Guid.Parse("4357652b-bb55-40c7-8b94-3da75de3fd2e"),
Guid.Parse("ffb2902a-b35f-43d1-a005-2b343f5a5a2f"),
Guid.Parse("39ba0e92-ccd5-47bb-9f3e-e0df039516d7"),
Guid.Parse("48c1cbc5-012e-47eb-91d1-c6ad89923c41"),
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
Guid.Parse("01b20e66-3c50-4153-bec5-7c9229fa8820"),
Guid.Parse("9e4d234c-9ca0-487b-a29d-1bd00c5c1da1"),
Guid.Parse("4cc1e3bb-906c-4d0e-9df2-6cde4b1ad5f5"),
Guid.Parse("b17416c4-e508-463a-bc09-65f819dfe1d2"),
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
Guid.Parse("5480d632-b56a-4fd4-b695-64c897b175a1"),
Guid.Parse("262d9765-e00d-4217-bee2-a838b3c36285"),
Guid.Parse("b659f076-3c2a-4bc7-9e87-d9650c0b63d9"),
}));
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("9b10e355-4902-43dd-8e72-810525fa11cf"),
Guid.Parse("4b568367-1ea6-4cfb-95b1-e3ec88dcc52c"),
Guid.Parse("e302f91a-8392-4668-a1a8-627157b14d02"),
Guid.Parse("49a86265-42c7-4788-9a81-9c879f364a7c"),
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 9;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[34], false);
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
                parametr1.Value = 180;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(11));

                        GuiduuidArray1M.AssertModel(models[0],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduuidArray1M.AssertModel(models[0],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 68, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 110, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 150, query1, 138, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 9, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 52, query1, 180, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 101, query1, 114, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 101, query1, 101, query2))
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 34, query1, 165, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 60, 85))
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        GuiduuidArray1M.AssertModel(models[0],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 174, 52))
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 145);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
GuiduuidArray1M.AssertModel(models[0],_testData[26], false);GuiduuidArray1M.AssertModel(models[1],_testData[27], false);GuiduuidArray1M.AssertModel(models[2],_testData[28], false);GuiduuidArray1M.AssertModel(models[3],_testData[29], false);GuiduuidArray1M.AssertModel(models[4],_testData[30], false);GuiduuidArray1M.AssertModel(models[5],_testData[31], false);GuiduuidArray1M.AssertModel(models[6],_testData[32], false);GuiduuidArray1M.AssertModel(models[7],_testData[33], false);GuiduuidArray1M.AssertModel(models[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
GuiduuidArray1M.AssertModel(models[0],_testData[18], false);GuiduuidArray1M.AssertModel(models[1],_testData[19], false);GuiduuidArray1M.AssertModel(models[2],_testData[20], false);GuiduuidArray1M.AssertModel(models[3],_testData[21], false);GuiduuidArray1M.AssertModel(models[4],_testData[22], false);GuiduuidArray1M.AssertModel(models[5],_testData[23], false);GuiduuidArray1M.AssertModel(models[6],_testData[24], false);GuiduuidArray1M.AssertModel(models[7],_testData[25], false);GuiduuidArray1M.AssertModel(models[8],_testData[26], false);GuiduuidArray1M.AssertModel(models[9],_testData[27], false);GuiduuidArray1M.AssertModel(models[10],_testData[28], false);GuiduuidArray1M.AssertModel(models[11],_testData[29], false);GuiduuidArray1M.AssertModel(models[12],_testData[30], false);GuiduuidArray1M.AssertModel(models[13],_testData[31], false);GuiduuidArray1M.AssertModel(models[14],_testData[32], false);GuiduuidArray1M.AssertModel(models[15],_testData[33], false);GuiduuidArray1M.AssertModel(models[16],_testData[34], false);
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


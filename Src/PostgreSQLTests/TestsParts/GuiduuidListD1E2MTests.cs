

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
    internal partial interface IGuidListuuidListD1
    {
    }
    
    internal partial class GuidListuuidListD1 : IGuidListuuidListD1
    {


#region TestData

        private readonly GuiduuidListD1E2M[] _testData = new GuiduuidListD1E2M[]
        {
            new GuiduuidListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5e34bb7c-4185-4a57-b52d-fd1e4c88398b"),

Guid.Parse("06f346bb-8a71-4f66-a39a-76ba278b4df3"),

Guid.Parse("56b0761f-ead0-4577-9522-896fec65e0c8"),

Guid.Parse("dffa11a9-a35e-4906-a3b4-e420843d08d3"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1ad8160b-c416-4de0-94b3-2aee49c4c992"),

Guid.Parse("40a7b367-1f40-4d0a-bdba-12a6b4c03d9f"),

Guid.Parse("df3e7798-3cf4-4adb-ad7b-e0820bfd9af3"),

},
},
            new GuiduuidListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bbc5a30f-f828-4261-967f-abd3945bec8a"),

Guid.Parse("da4e9409-43a3-4c08-a426-e7ac8a5f60fb"),

Guid.Parse("1c9f8612-b3a0-474a-afeb-d2eb67123b45"),

Guid.Parse("e65fe3d9-4ac5-44a2-8a81-54374cde1874"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a474e27d-25fe-4915-9d1b-962539d3b21a"),

Guid.Parse("f8e780c1-3132-490c-93e3-10345d5640a8"),

Guid.Parse("ae0d450a-65f2-4b4d-b2a9-0ad9003bd883"),

Guid.Parse("b157c3de-0bd8-4822-8582-8c9b92b136c4"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f6a73737-5a91-4a7c-b90a-94e4d3c8dd26"),

Guid.Parse("c38e2f4e-66ef-4022-b62c-a90850b0c668"),

Guid.Parse("3feb1b5a-e350-436e-b13e-1a3eb8e75289"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e35f948c-778d-4e2b-bff1-ec860c50cc0a"),

Guid.Parse("1c571965-642e-4d9f-a4d0-c7b4439fc6aa"),

Guid.Parse("742451c1-323a-4e94-bd8d-6e464c262f02"),

Guid.Parse("9c18a490-46cc-4b03-b6d0-3da07a9bdf06"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0e31d85-4219-4fb4-aa73-5b200b2f3c2f"),

Guid.Parse("0f3ae4bf-c8d2-4e08-9f00-c60d7595d2d7"),

Guid.Parse("a8f0c77d-b346-40f4-bf2d-3f932dc7b4a2"),

},
},
            new GuiduuidListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("300ddb18-f34e-418f-8b40-4658d436ed43"),

Guid.Parse("dbd4fdea-b32e-4edf-a66c-11d996fbba1c"),

Guid.Parse("0493fdb5-4188-43af-8820-b2a856adc3ff"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7fd83db2-f544-4c62-b839-d9e766a7372b"),

Guid.Parse("fb14d120-2ba0-41ea-ac06-b3b9c5648086"),

Guid.Parse("1d3531cb-2940-4050-bffc-70f9a2b8a3f3"),

Guid.Parse("4f4f47b1-5501-4d56-bd02-aed399d71b92"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b22b0071-be78-445a-a2cd-76b9a4009662"),

Guid.Parse("b3fb7b52-634d-430b-b557-0c0980116307"),

Guid.Parse("12af0ca6-f3c9-489c-824c-e0df255fc14e"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("939c8071-708e-49cf-af76-004f3c825c31"),

Guid.Parse("f9099dfa-7d8f-43f1-aec7-5e3a60d5b0d9"),

Guid.Parse("a9a24f89-199e-4283-854f-3c215340314f"),

Guid.Parse("bd40e2e9-fdd7-4fad-a71a-04da4c9637c2"),

},
},
            new GuiduuidListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("874e7154-b50b-428e-ae00-094e77692842"),

Guid.Parse("98fe32ea-0292-4b06-9136-01bf315beaa5"),

Guid.Parse("3c9d94b4-efc6-4be4-97a6-2afbfa640934"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a9c17867-c9c0-4c7d-a430-16dabb9d8e20"),

Guid.Parse("968ac21c-d0b7-40b0-ab7d-11aa047dbfb1"),

Guid.Parse("b1f4d8c5-7a26-43b9-8b0c-a26ed2bc1168"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("34825702-d94f-4865-b4bd-78d5fe00ae9d"),

Guid.Parse("eb553b67-627a-43a0-8b9d-1aa445720ddc"),

Guid.Parse("a0480732-68ef-4336-8040-0ff5c5edbd94"),

Guid.Parse("99d27db9-6340-48f3-8387-a52c22207790"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("14ddb62c-b7d8-45f3-bc43-181bf0439cf4"),

Guid.Parse("1ce94ce6-6532-46e1-a446-3c30cf6dc780"),

Guid.Parse("c0a80405-1515-47e8-9d39-a98509e639b5"),

Guid.Parse("3421e02e-dd90-44ad-a01e-e1b3184e0d76"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f5a07030-8143-4633-9c6e-537d1e804b9b"),

Guid.Parse("3652d7f2-2d7f-4217-952b-3aabc414a6ed"),

Guid.Parse("ce801e34-07bf-4650-a0d1-db9116aa35d5"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ef4e96cf-b997-4c36-b104-3a1195e29015"),

Guid.Parse("0fcf5398-8bdf-4633-a340-49e48595cb6f"),

Guid.Parse("9cebf774-a9a3-4d54-9e7c-14e0bbe8e79e"),

},
},
            new GuiduuidListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cecfa322-b6bc-4c22-adfe-3b2d17dd2a66"),

Guid.Parse("1a15dfab-2580-4a53-a889-444279be28b2"),

Guid.Parse("1bfe4de0-e5a7-4e65-81f8-ddd7841fc50f"),

Guid.Parse("c666cf1b-0165-4293-a23c-50d167e4134c"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("af0eac74-6c2b-4f92-8bdd-359f64c82465"),

Guid.Parse("28bd0b33-028e-41ce-a2f9-b4bc933d50b0"),

Guid.Parse("c11f5074-d46b-426f-83eb-16c082ba87fd"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a53db840-3afe-4ae5-8bfc-27a044f703c3"),

Guid.Parse("cbf29ca1-2e56-4226-a659-4d39f8788030"),

Guid.Parse("d73350f7-3310-4d6a-a059-1892ea7b5576"),

Guid.Parse("c5bcd085-e3ba-4e11-b5a0-0a813f1175d8"),

},
},
            new GuiduuidListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("69ff9746-ad4c-4414-b030-48423499b1c0"),

Guid.Parse("cb9352ff-3e6d-44ee-9d55-d3e4a82a883e"),

Guid.Parse("8ff69eb6-2bfe-4eae-89b8-3bf91910ae53"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("461e486c-c9aa-481e-9a54-5d2c755349d1"),

Guid.Parse("51fa87e5-f87a-4640-b3fe-b5aff9f7dca1"),

Guid.Parse("b456bf44-7cac-4040-a243-99f833242056"),

},
},
            new GuiduuidListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("85bdd237-d55f-414e-998b-5330dd493153"),

Guid.Parse("536d7f78-44db-453c-bedd-ac2f92526f4a"),

Guid.Parse("e92b28f1-0c5f-47d7-9584-d0c7c095a229"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("99b479c7-cf94-415e-9d76-87392fb5bf64"),

Guid.Parse("4851bbf6-180b-4bf2-bfe4-b76be310d110"),

Guid.Parse("e96462d9-1141-48b3-9747-1ef4130b282b"),

Guid.Parse("1701e902-c1d1-4ad1-a838-ab1a48593ae7"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("14bc31e9-63e6-4ed8-b09a-72f5e5b7d7ac"),

Guid.Parse("6a5dc25b-278a-44ff-9ab9-90a957dab1e9"),

Guid.Parse("e4bbea9e-5ad8-44e8-b77b-f544dec8a9e3"),

Guid.Parse("4b4b4fa4-21b2-4e09-a16d-00fd343c8ac2"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ae5d0a59-edc9-420c-833a-c2954de32a38"),

Guid.Parse("88835c67-a070-4c93-9a98-368f75f93da2"),

Guid.Parse("d7932809-a3cc-4d9c-bbca-cae00c02b39b"),

},
},
            new GuiduuidListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9726e3ec-b452-422c-b85c-30feb55c63d5"),

Guid.Parse("4954cdcb-fc81-4da5-ac2e-39210266dae3"),

Guid.Parse("c1ddd1ca-7dbf-47b0-a590-a20d9f47f0f4"),

Guid.Parse("21ad5dd4-f0b8-4368-bb0d-b7c7a15fc3eb"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("21330e2b-7e7d-4888-830c-3fe8a42ea3dd"),

Guid.Parse("5b045319-8f01-4e2d-93d2-501e25f78f60"),

Guid.Parse("1b050b57-1d1d-41a7-8143-907b82abbc07"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("df40d8c6-1748-40d4-8600-8d3d2865bad5"),

Guid.Parse("fe7324b3-f0fb-41e0-bc9b-1cdde2930fc6"),

Guid.Parse("2ffa660d-9ae4-47ff-bb5c-a5a9ab42698f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a0625a2-5fcb-43ff-910d-e3c712dbc8c2"),

Guid.Parse("19de1379-4b6b-4f89-96b5-2e46852bf2fe"),

Guid.Parse("c76e313a-43db-4a84-b968-0941b689fc37"),

Guid.Parse("bcea0ef1-f46a-49ad-b29f-4f727bdb6a66"),

},
},
            new GuiduuidListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccb854a3-2195-44df-8e24-966185e93019"),

Guid.Parse("b2b38817-8e59-4ce9-a407-5b0b11083d9e"),

Guid.Parse("553a0755-82d1-4de6-aa9a-426b025cb479"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0a18b0e3-6520-444b-8c4d-6f137b97ab03"),

Guid.Parse("4229d34c-d132-43bf-a4b7-297f3cc7c5ba"),

Guid.Parse("83cac134-efb8-4a99-addf-4154b6f16e6e"),

Guid.Parse("3619294c-1845-4521-afe6-b80947f2e412"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("862e8ad9-36f5-409d-8d6c-cf4a90bbf0e2"),

Guid.Parse("923eb9d3-8604-4a14-941b-4f9ad7d379e5"),

Guid.Parse("3dfe2a9e-009b-402c-95fe-ea823b2db80b"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ac69aa8e-eafd-43ee-ae8b-d0ac3a50481a"),

Guid.Parse("62985a3e-746f-4e6c-9cb7-7124beef757c"),

Guid.Parse("2aaefa74-6d01-40e5-a08e-cdd70e7afa7c"),

Guid.Parse("ad0a3ce0-27b1-4645-acb5-f65d3b43e7d2"),

},
},
            new GuiduuidListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("64acfcd2-0535-4888-8289-b74a30b636f5"),

Guid.Parse("5c632468-5e9c-43ea-a048-45e7f93944f1"),

Guid.Parse("0799eed5-b0ed-4779-834b-7a23453445ed"),

Guid.Parse("6594d9c7-6039-4e95-942f-a632fb656881"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("681bf839-02cc-4532-b1d1-50aab1c08cc9"),

Guid.Parse("a1de5ec2-eb28-4654-9502-4130c689a7e1"),

Guid.Parse("fd5f52f7-4706-46dd-a6dd-570a3e237cad"),

Guid.Parse("ce92da69-5e89-4bf0-bed9-2b2f4ebfc448"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("42b6ffb0-b894-40a4-af78-419440fc04ec"),

Guid.Parse("eb304f6c-df19-4a73-814c-11b9adbbd043"),

Guid.Parse("4505991f-325e-4f91-8746-2a92ffd6e26a"),

Guid.Parse("1d28c53a-5bfc-4077-85cf-ac2967d5d0a0"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("45f46bea-890d-4e4c-8492-471effa5af5e"),

Guid.Parse("2f621f57-e6a3-498f-97c1-dcd2433e7f57"),

Guid.Parse("a20f8721-a805-4ce0-8ffa-99000237cb7a"),

Guid.Parse("3a34c70b-4ddb-42f5-8355-2eb5454dd39c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4a93ea9b-6af1-4be6-a93f-4f5101297066"),

Guid.Parse("55929452-24bb-42f3-a008-8e19603e81c8"),

Guid.Parse("6d7bb96e-40ec-4214-b7a9-928b892e230f"),

},
},
            new GuiduuidListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("89dfee88-4646-4586-9478-7d3b62eb9959"),

Guid.Parse("51959a08-7061-4760-b916-fb9d25ebaeaa"),

Guid.Parse("57fb92ab-d264-4f5e-9a88-fc434433e1ee"),

Guid.Parse("ee60834e-6608-477e-a9ae-beb7a637520f"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("38d840ef-1d0c-4374-ad15-fb2e4b72deb9"),

Guid.Parse("1b7e4263-6b7f-4721-8a18-eeac38a4f7d0"),

Guid.Parse("84a1d86c-3835-4bc8-a011-b3435907c7dc"),

Guid.Parse("3c46aafa-add4-4bbb-979e-70d54d670c9d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ed80107b-fa47-410d-91fa-67e93d29e7f8"),

Guid.Parse("d8424112-815b-4c57-9481-7bc9e898b851"),

Guid.Parse("80174a64-d131-4902-afac-9504352a04f7"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("31649170-af90-4160-bbda-19a2946e4c7f"),

Guid.Parse("f04f7b46-28b6-46a4-9166-0b589b2a3894"),

Guid.Parse("faa00d41-b07e-4084-81e4-1da47db4a707"),

Guid.Parse("34a28f12-8e1f-4ec7-96bf-0dbfd49bf69b"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("198fcd95-570f-43aa-a7a0-3b8166ac877a"),

Guid.Parse("98bd31e8-c628-4063-b374-998b15b4a0d5"),

Guid.Parse("e86326c4-7aca-4feb-8d27-9c0858aac60e"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9afa679b-4f5e-4337-a293-2dc6726aeb43"),

Guid.Parse("4388f3a0-52ec-457a-b50e-b5f568c48b98"),

Guid.Parse("b48d6e6c-99a5-4bb2-a1fc-05464ed6ab7c"),

Guid.Parse("037dd9bd-d1b0-4849-aa4b-148743d68d19"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7590cfa4-fb6c-4f84-a6af-70a068ceb4f8"),

Guid.Parse("c516cf9e-d878-44d9-b6ae-9386189735d4"),

Guid.Parse("d3b2668d-f799-48ea-ac76-583bc5ddbb10"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b0bee45b-91b6-4bbb-a463-0f8fc4a39c5e"),

Guid.Parse("aef71512-7c1a-447c-8283-0281b5f6c9b8"),

Guid.Parse("aff0f708-78f3-4028-8c1b-cfd8e4a33423"),

Guid.Parse("8a574b41-0d76-4d37-a6f6-18053553e6f3"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7c00f569-b2a7-4fc5-b1c8-8f4d0a28bd7c"),

Guid.Parse("ee365f35-db9a-4867-a0bd-a0f00c9c8eb4"),

Guid.Parse("f17c5718-6b3a-48f1-8479-838133d5fd18"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ffdf8780-ef5f-4860-857d-c4cd4815d417"),

Guid.Parse("913c2c6f-9d6a-40ed-bff4-fb6ccb0cf24e"),

Guid.Parse("117cbf11-20d6-4b44-a908-ae8960ce89c9"),

Guid.Parse("58c74e96-e3a2-4749-90f3-47b8f9b79d0c"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e6b718ea-fb7c-4ed9-a715-448b46d43122"),

Guid.Parse("b686c8aa-0595-40de-a901-05bc072effc9"),

Guid.Parse("c5dfede8-04c7-45fb-a9cb-76cddf8d242d"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb834fee-7165-46df-9379-097a72437236"),

Guid.Parse("3c4a6588-8e7f-4166-b075-ddfcdd574430"),

Guid.Parse("205613a5-1ef7-40bf-96a1-093556ca2a10"),

Guid.Parse("c9a8d09e-af16-49ba-8924-6b2019814989"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8e4d3965-b17a-46fb-b33b-7f5af53687fc"),

Guid.Parse("f3cc8384-b798-4ad4-8b72-f9146af94706"),

Guid.Parse("3baf532f-c7f1-4aa7-9a71-9efbe4df7a6d"),

},
},
            new GuiduuidListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853549a7-c1b9-446b-8460-ddeed44f64c8"),

Guid.Parse("bbd76f10-3123-4261-83c1-759a8d856728"),

Guid.Parse("47ff6b75-d976-4cae-85f5-efed4979702c"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f5f23275-69f3-4e6f-9dc8-195375405074"),

Guid.Parse("7019f927-c698-486b-b045-2beeb841a055"),

Guid.Parse("68803bba-bcd6-4b79-9e97-92b2bf4c2eae"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cf50a4ef-064e-4d27-aabe-c6bf0ec2a728"),

Guid.Parse("6ddbbb36-88eb-4c40-87cf-0980d6a407d5"),

Guid.Parse("46c8e9cf-62ac-4220-9059-53dfc6ad6016"),

Guid.Parse("15cb50ec-6523-4895-93d4-823f7bef1233"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0ffb001d-b456-4de2-b7ff-0392f76a182e"),

Guid.Parse("c32661b2-2c86-4af1-9c63-4725067182ae"),

Guid.Parse("5b9e9fa7-e188-4a57-a9a0-cdc7aae6e06b"),

Guid.Parse("d7776e48-8efe-46cc-a8a7-ea2606b357cf"),

},
},
            new GuiduuidListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("79faaaac-1c1e-4b84-a8fd-0b9fe01ca02b"),

Guid.Parse("f5cc9ac1-04d4-4a9d-9dae-b2d00d1e4d6b"),

Guid.Parse("d9ac8bbc-5e0f-47ca-9764-6b48e7ac0203"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1070f588-9fed-4b03-9b85-5ef82864e263"),

Guid.Parse("2be75bcd-390a-4094-a8e4-f9c1eb78ad43"),

Guid.Parse("3b22808a-6105-4679-ac08-e3031aa6984e"),

Guid.Parse("88523722-6db3-4e82-a42c-7d597797020c"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("60ba76e6-6745-450c-a571-e8a3310c68fc"),

Guid.Parse("21ccafee-2f17-4554-8a61-a1d4c46e5253"),

Guid.Parse("4220afff-dcfa-4030-a9e3-fabff186da64"),

},
},
            new GuiduuidListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6095daa1-3095-4d89-8924-b2923f953ec9"),

Guid.Parse("34a4b105-edd2-44e0-91d5-1fcf8228dd94"),

Guid.Parse("e327a958-064a-4abb-bca1-f39df4ef2883"),

Guid.Parse("be472a42-6f17-4881-9d20-f39908997968"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8daa4b34-e747-439b-af83-747394e8af6c"),

Guid.Parse("3620b0f7-cbfd-4b38-8dd6-6244cc7e2ac4"),

Guid.Parse("e4d49026-cc26-47a9-8ea3-4a7c84d7a9b4"),

Guid.Parse("26a837cb-de82-4cd6-9f5a-d7ed0af5837d"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72a2b4b3-dd4d-4af9-bf01-9c6f29274f91"),

Guid.Parse("abc69a8f-76a1-43a4-bdef-4d0bada2db1f"),

Guid.Parse("16f1f491-a4bf-4bfd-9a97-4ab8ff96a1b6"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aa96a45-5cd5-49fa-9562-c47bb6161553"),

Guid.Parse("17fff417-56c8-4c14-bbcd-8e55d2a832a8"),

Guid.Parse("5195a440-c248-4428-849e-2ec22b8e44e3"),

Guid.Parse("46d167ad-49f5-495e-aa5f-03be055f63b1"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e7a17b46-2e08-419e-997f-d323b00c752c"),

Guid.Parse("b2adb185-47c6-471c-a30a-3eb8a07388cc"),

Guid.Parse("91c28f50-e88c-4c22-85d1-4b363aee1056"),

},
},
            new GuiduuidListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5a2547d4-eef2-40b1-8db8-71a6b7e3c33f"),

Guid.Parse("35c7fad0-f8fe-4d4c-9f32-e579366bf085"),

Guid.Parse("f896cbb7-6981-4152-a4ea-2b314ccc1db2"),

Guid.Parse("b80d163f-9147-4e86-8bb3-3b8526a99ce4"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4ea56e17-067b-4fe9-98c5-cdcf121bdda2"),

Guid.Parse("e4faaf9c-311c-4227-b65c-a14acdda1668"),

Guid.Parse("c6ef0904-80be-4e7e-a812-c61686d76f7d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dc874009-65fd-4d4a-be27-adad26257219"),

Guid.Parse("444357b1-a9a4-429f-b2ae-9de4d7e56206"),

Guid.Parse("662e49aa-6233-4197-ab77-22993ba72320"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e0115d42-b8fd-443e-9e2b-9fdbc5174dfd"),

Guid.Parse("71bdd181-70c2-4de8-a827-975195e234f1"),

Guid.Parse("8b2fd588-9260-4e6e-ab83-042f0f419146"),

Guid.Parse("ef714267-eaf3-492b-a66b-80701291245b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1fae3458-d8d5-4275-80a9-54584d23581e"),

Guid.Parse("d07e7028-0c59-440c-a019-136a90bb7e60"),

Guid.Parse("a35c013b-8038-4194-81ad-224ca81f04bb"),

},
},
            new GuiduuidListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6b3372b2-796b-438a-9c88-f16fc27840ec"),

Guid.Parse("fafd72f7-ca4e-4651-b0bb-b8a9e504422a"),

Guid.Parse("65b3dba0-7534-4f1c-8f7a-583e8aed7de6"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("75dcda4d-a745-4935-bca2-ea4cf5c1ba59"),

Guid.Parse("6cf97008-4e8a-4dc1-b27c-fda2612cb2c2"),

Guid.Parse("1a3df5e1-67e5-49fb-8a13-66f363b3386c"),

Guid.Parse("566367b2-afaf-4262-8966-3a6a10804494"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("39eb6082-f70c-4216-b2fb-5c9234f3b5a3"),

Guid.Parse("65c9e1c1-8ce6-49a5-b0b5-776a7730cbf8"),

Guid.Parse("76a69fe0-bc7b-453a-935c-b7b4a1ad79a9"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9233edf5-eecc-4222-a616-f632013e5a26"),

Guid.Parse("c998d51c-e82f-458a-a3b9-eeb26de28ccc"),

Guid.Parse("84b35415-86e3-49fa-9a75-1347e3f179d8"),

Guid.Parse("8119ba0d-e8e0-4143-88ff-361d74e7888c"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a9b198ba-6afd-488b-adc2-075d3891e95a"),

Guid.Parse("fb1df7ee-7eca-438b-a364-2de846bd4b12"),

Guid.Parse("f6cf36e4-5fe7-420c-ad4d-8befd4d8f65b"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("32577799-3912-4a88-a573-59b4565e4953"),

Guid.Parse("1ee2c187-aab6-4b3e-bb8e-3adfce6f060c"),

Guid.Parse("0fd5a81d-e935-4508-8ed6-d6630ce75088"),

Guid.Parse("79eb6cd7-7699-43e5-9944-4ae138d59206"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("898aecaf-1e1e-40cb-ac01-15ba77511574"),

Guid.Parse("48069d44-966c-4b35-9b78-bcc9f2ae0904"),

Guid.Parse("92936e03-122f-4d81-b616-da24767ef18e"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e2919db9-0bd3-4387-8289-fa3c4ced3b5b"),

Guid.Parse("5f66373a-3048-4874-834b-67e6637bb0fa"),

Guid.Parse("c6a6385d-4d91-495a-a80f-acc2237959e2"),

Guid.Parse("db85886c-411b-4594-95f7-032feeaf1c57"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a767e95e-c3f4-4ccc-8bbb-eccb22a071b4"),

Guid.Parse("6b966455-3d27-4ae0-baa7-b14d1cf2f9e0"),

Guid.Parse("a63aae6a-a53e-4652-bdbb-be9ee4d07046"),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2mi(
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
            asPartInterface: typeof(IGuidListuuidListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2mi(
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
            queryMapTypes: [typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
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

                changedRows =  ((IGuidListuuidListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidListuuidListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidListuuidListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidListuuidListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidListuuidListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidListuuidListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guiduuidlistd1e2mi_id
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
            asPartInterface: typeof(IGuidListuuidListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidlistd1e2mi_id", 
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
                changedRows =  ((IGuidListuuidListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidListuuidListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidListuuidListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidListuuidListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guiduuidlistd1e2mi_id
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
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guiduuidlistd1e2mi_id
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
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidlistd1e2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidListD1E2M> models = null;

                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidListD1E2M> models = null;

                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidListuuidListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidListuuidListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidListuuidListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 131;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 11;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[34], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await((IGuidListuuidListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IGuidListuuidListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[6], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[7], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[8], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[9], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[10], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[24],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[25],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[26],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[27],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 129, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 120, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 96, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 104, query1, 106, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 42, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 118, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 92, query1, 51, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 68, query1, 122, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await((IGuidListuuidListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 23, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[5], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[6], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[7], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[8], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[9], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[10], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[24],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[25],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[26],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[27],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[28],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[3], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[4], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[5], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[6], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[7], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[8], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[9], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[10], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[24],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[25],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[26],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[27],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[28],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[29],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[30],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[31],_testData[34], false);
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
                var models = ((IGuidListuuidListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatch(connection, 131, 101))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 85);
                var models = await ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                GuiduuidListD1E2M.AssertModel(models[0],_testData[18], false);
                GuiduuidListD1E2M.AssertModel(models[1],_testData[19], false);
                GuiduuidListD1E2M.AssertModel(models[2],_testData[20], false);
                GuiduuidListD1E2M.AssertModel(models[3],_testData[21], false);
                GuiduuidListD1E2M.AssertModel(models[4],_testData[22], false);
                GuiduuidListD1E2M.AssertModel(models[5],_testData[23], false);
                GuiduuidListD1E2M.AssertModel(models[6],_testData[24], false);
                GuiduuidListD1E2M.AssertModel(models[7],_testData[25], false);
                GuiduuidListD1E2M.AssertModel(models[8],_testData[26], false);
                GuiduuidListD1E2M.AssertModel(models[9],_testData[27], false);
                GuiduuidListD1E2M.AssertModel(models[10],_testData[28], false);
                GuiduuidListD1E2M.AssertModel(models[11],_testData[29], false);
                GuiduuidListD1E2M.AssertModel(models[12],_testData[30], false);
                GuiduuidListD1E2M.AssertModel(models[13],_testData[31], false);
                GuiduuidListD1E2M.AssertModel(models[14],_testData[32], false);
                GuiduuidListD1E2M.AssertModel(models[15],_testData[33], false);
                GuiduuidListD1E2M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models =  ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                GuiduuidListD1E2M.AssertModel(models[0],_testData[3], false);
                GuiduuidListD1E2M.AssertModel(models[1],_testData[4], false);
                GuiduuidListD1E2M.AssertModel(models[2],_testData[5], false);
                GuiduuidListD1E2M.AssertModel(models[3],_testData[6], false);
                GuiduuidListD1E2M.AssertModel(models[4],_testData[7], false);
                GuiduuidListD1E2M.AssertModel(models[5],_testData[8], false);
                GuiduuidListD1E2M.AssertModel(models[6],_testData[9], false);
                GuiduuidListD1E2M.AssertModel(models[7],_testData[10], false);
                GuiduuidListD1E2M.AssertModel(models[8],_testData[11], false);
                GuiduuidListD1E2M.AssertModel(models[9],_testData[12], false);
                GuiduuidListD1E2M.AssertModel(models[10],_testData[13], false);
                GuiduuidListD1E2M.AssertModel(models[11],_testData[14], false);
                GuiduuidListD1E2M.AssertModel(models[12],_testData[15], false);
                GuiduuidListD1E2M.AssertModel(models[13],_testData[16], false);
                GuiduuidListD1E2M.AssertModel(models[14],_testData[17], false);
                GuiduuidListD1E2M.AssertModel(models[15],_testData[18], false);
                GuiduuidListD1E2M.AssertModel(models[16],_testData[19], false);
                GuiduuidListD1E2M.AssertModel(models[17],_testData[20], false);
                GuiduuidListD1E2M.AssertModel(models[18],_testData[21], false);
                GuiduuidListD1E2M.AssertModel(models[19],_testData[22], false);
                GuiduuidListD1E2M.AssertModel(models[20],_testData[23], false);
                GuiduuidListD1E2M.AssertModel(models[21],_testData[24], false);
                GuiduuidListD1E2M.AssertModel(models[22],_testData[25], false);
                GuiduuidListD1E2M.AssertModel(models[23],_testData[26], false);
                GuiduuidListD1E2M.AssertModel(models[24],_testData[27], false);
                GuiduuidListD1E2M.AssertModel(models[25],_testData[28], false);
                GuiduuidListD1E2M.AssertModel(models[26],_testData[29], false);
                GuiduuidListD1E2M.AssertModel(models[27],_testData[30], false);
                GuiduuidListD1E2M.AssertModel(models[28],_testData[31], false);
                GuiduuidListD1E2M.AssertModel(models[29],_testData[32], false);
                GuiduuidListD1E2M.AssertModel(models[30],_testData[33], false);
                GuiduuidListD1E2M.AssertModel(models[31],_testData[34], false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MIWA),
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
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MI),
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
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidListuuidListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidListD1E2M),
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
            asPartInterface: typeof(IGuidListuuidListD1))]
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
FROM public.binary_guiduuidlistd1e2m m
LEFT JOIN public.binary_guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidListuuidListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidListuuidListD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models =  ((IGuidListuuidListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA), typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                await ((IGuidListuuidListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                ((IGuidListuuidListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA), typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                await ((IGuidListuuidListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                ((IGuidListuuidListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models = await ((IGuidListuuidListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MI), typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models1 = new List<GuiduuidListD1E2MI>();
                var models2 = new List<GuiduuidListD1E2MI>();
                await ((IGuidListuuidListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MI>();
                var models2 = new List<GuiduuidListD1E2MI>();
                ((IGuidListuuidListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA), typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                await ((IGuidListuuidListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                ((IGuidListuuidListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models = await ((IGuidListuuidListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


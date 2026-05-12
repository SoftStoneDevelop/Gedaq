

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2074d641-c815-4dc5-bc5b-04b97b8903f4"),

Guid.Parse("6dc230f2-2911-446b-a51a-b7635b3c2237"),

Guid.Parse("cb6fe16d-4b1f-42dc-b942-704ac078b054"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("db9c9620-93e5-489f-84e6-d2860a8c30bd"),

Guid.Parse("e4ffc423-ef43-48e0-994f-8e83c6a75598"),

Guid.Parse("823bea31-ce93-4cf7-b203-b681370a7464"),

},
},
            new GuiduuidListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("045e5398-857f-422b-84f9-dd4353cb0ce4"),

Guid.Parse("bbe54af4-3a7d-49d5-b277-e35fe8e582ca"),

Guid.Parse("3ed1b123-533b-47f6-bca5-b2fa4cf28b8e"),

Guid.Parse("8c97e7b7-0c79-4c14-af7e-7d31df41d9f8"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c9931f10-90ff-428d-9ef7-755d35426c16"),

Guid.Parse("4498fe1a-6956-427b-a4fc-2582e75b6b05"),

Guid.Parse("832bf1db-cddc-4206-bf8b-291d5430fe1f"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("38f952a6-e204-493c-a626-aa9f7eff2842"),

Guid.Parse("60a0a99e-6a9e-4656-bbaa-8a2d0598781c"),

Guid.Parse("0ecbd6f6-1287-4c17-8abf-59ea0fe81e7e"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6ce6d7bc-6b75-470a-9f22-f764c1852e4f"),

Guid.Parse("32259545-b56d-420b-a382-cca471adcf30"),

Guid.Parse("9be4f9c3-3dec-45c4-9a70-0f088e4f892d"),

Guid.Parse("e56aeba9-be4c-4dfe-95ea-0ffe8e9b89d5"),

},
},
            new GuiduuidListD1E2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c318a4f3-6876-4780-8b1c-02f7c0a74923"),

Guid.Parse("ce9c91f4-45e3-4e4e-bd87-ec5cfe9821b8"),

Guid.Parse("0faffcb4-aaae-4a7a-beaf-5a9eff655657"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("863532c2-72bf-4253-977a-7bfb1c63f500"),

Guid.Parse("2ee3992f-f61f-4c6e-87b7-8a89bd9005e4"),

Guid.Parse("93a136f5-089a-4cde-8cfa-f7c16d2a3326"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bbec67fa-16d4-49e6-b5ec-91fca46b70bc"),

Guid.Parse("15dcdd33-f21e-46ba-b5df-53c637f8b756"),

Guid.Parse("3a050801-f961-4365-ab1b-cf242a4262e5"),

Guid.Parse("54364cae-455d-49a1-96d8-4e063b556cdd"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0a3ba624-b582-42dd-8383-fdd7bdac7eb8"),

Guid.Parse("7e772fc0-4f21-4970-9001-9582e8eceedd"),

Guid.Parse("a1432627-ff21-47ee-87b7-e874adc9df8d"),

},
},
            new GuiduuidListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("19c303ff-d7f1-40f0-bf5d-b5b381529589"),

Guid.Parse("0da74d53-cd2e-4cbf-98c3-8b3d12c254a9"),

Guid.Parse("9a02646b-8960-4e1a-90d4-c757526dcd47"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d9593665-5697-4f3f-b616-8dc9b39b1fe8"),

Guid.Parse("62127248-9ad6-44f9-8b89-d6d9806b1ac1"),

Guid.Parse("f8d1db16-837c-409a-832c-21d0ec747a10"),

},
},
            new GuiduuidListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edf3ac84-ed48-4b0e-a8d4-c86bd77758a3"),

Guid.Parse("2c89e926-9894-418f-a65d-285ade9ce6de"),

Guid.Parse("47b15cf8-7f84-41bd-972c-77e112f0d7e2"),

Guid.Parse("e032349f-b46c-424a-b3d7-3675e5558fb3"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("54f89d07-de99-430a-8285-b987f3d81503"),

Guid.Parse("5a691318-b6ae-4307-b9f1-912f299d13e1"),

Guid.Parse("3e0d380b-6e79-4ac1-af3a-20339854f502"),

Guid.Parse("ad3db7ba-5fad-4f2d-96b8-6f2d536143a7"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3ffa9e56-1894-4bac-a663-c0b88af84259"),

Guid.Parse("04ad66ec-2a34-45f5-8dc3-bfbd6d7d99d0"),

Guid.Parse("0f1849c5-44ae-48ff-be20-03dbc0651ff4"),

},
},
            new GuiduuidListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0bd5e60e-986b-4292-8b80-ad7861c36b3f"),

Guid.Parse("b86796f5-1a5d-4703-9389-d6cf173969b1"),

Guid.Parse("267b2366-b989-4a86-8fec-9c62b7ba1467"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ac77faa6-d3ec-43b4-a584-9f27292ebfbe"),

Guid.Parse("160d40d9-879a-4c71-a122-3bdf2ae346eb"),

Guid.Parse("961a5195-78be-4634-885b-f07511fe2c00"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bda905b4-f076-4ba1-8cf9-045c72cc113a"),

Guid.Parse("f2d28624-143a-48b2-8def-e059541a03aa"),

Guid.Parse("71fd9b0c-2432-469a-b436-2f2236d2dec9"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4af30355-ef07-4cd1-b903-1dcae01b6431"),

Guid.Parse("db8415dc-f7d8-4f3c-9e72-1f335dea7aa7"),

Guid.Parse("89a36e6d-a28b-4696-8630-bfdfa33f24a1"),

Guid.Parse("02ec03fc-2985-43a7-97cb-88c9f60dacd7"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3419755d-69bf-41b2-bddf-6ec66c7f10ac"),

Guid.Parse("556121f2-aee6-47d9-b765-3d190c34934d"),

Guid.Parse("0a9599f2-e3e0-43ae-b23e-7c428c74f33a"),

},
},
            new GuiduuidListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("70df9f55-ed85-41af-a13a-eef4cdb61eb6"),

Guid.Parse("0a3253d3-3d0c-4e5d-8b4d-508059582832"),

Guid.Parse("89e01e58-b50d-44b8-b61c-19a9079982fd"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7ce9654d-e8df-43b8-aa35-70980fe45079"),

Guid.Parse("e183ee31-4e0e-41a6-a8ff-63cf43492be8"),

Guid.Parse("7ef91224-14c1-4bce-8c28-38a343b91f4a"),

Guid.Parse("96feaa85-026a-4bd7-b192-b24e05c22d34"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6eda5e01-6eae-4bb2-ae2a-b6c1aa207ef8"),

Guid.Parse("92bc8edd-a16c-4304-a611-4528699b1f62"),

Guid.Parse("31038de1-5004-4079-9066-f233402f6c51"),

Guid.Parse("24c99c22-f4ae-4b53-be75-8ece2e69b900"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f255878c-ef2c-4b7c-afc3-b30e3be14959"),

Guid.Parse("175b2300-6bbc-498e-bf1b-3733360443fa"),

Guid.Parse("56e21786-e1a9-44c4-aca0-9a471915ccc9"),

},
},
            new GuiduuidListD1E2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("73bf4394-fc4d-45d3-8b8c-72e88ccd7720"),

Guid.Parse("0939b257-ad51-476c-80fa-a06f0362d590"),

Guid.Parse("a4052ced-a0e5-47af-9255-8c22a4e8f240"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("aede2f73-2ce6-4246-b02e-55c7da167b15"),

Guid.Parse("a5a00910-af73-4b9f-a6f6-3e5a89648840"),

Guid.Parse("9cabb476-9732-40a1-8873-bf1429b2fb24"),

Guid.Parse("18018bae-ad5e-4929-a0a2-64b588f35e2e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ca02f415-48ff-4d21-ace5-97383c2944f3"),

Guid.Parse("66de44e7-4765-480a-af74-ced7c8446024"),

Guid.Parse("40e3028e-6523-4b8b-9d91-566b03388d39"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f0c9f994-721c-4f83-a89a-00a93fece56a"),

Guid.Parse("278185dc-3552-40ee-8154-ecffacf11937"),

Guid.Parse("e785bdd4-8c8b-48f3-b1eb-2c26130e5baa"),

Guid.Parse("1e6214f0-618f-4073-82c4-f01576b9e459"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6592273f-48a3-4b55-8383-cfc86102f6c2"),

Guid.Parse("4fcb6e95-9b61-4fe3-b029-428e3564ad45"),

Guid.Parse("48098df5-12c8-4327-ab65-951287ea6a3e"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("635c2c61-b791-477b-906a-e7373c39b854"),

Guid.Parse("db82fb04-0759-464a-8de4-d8647b90d472"),

Guid.Parse("62745297-2366-41d5-aed7-b8e4f96a6b2d"),

Guid.Parse("6cf0791f-2da8-44c5-a6d6-0e16d7c3086f"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0065ee69-fa8f-4939-a8fd-feda3ffacb23"),

Guid.Parse("19d05445-e670-4cfa-bd91-b8ccc81a103a"),

Guid.Parse("da6e518a-e3b5-4f33-a150-a474774e91ba"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c4c6abae-fdcb-440e-8640-6e1938f99a4b"),

Guid.Parse("5d2fdfd0-493d-45dd-90d8-5eb3ef1ec788"),

Guid.Parse("e5519c75-bd98-45bf-a825-13e199248dd3"),

},
},
            new GuiduuidListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("827c1d62-9e98-4701-b33e-add6e2db17f8"),

Guid.Parse("ad1c64df-f2aa-4ce5-931d-7b30d92a25eb"),

Guid.Parse("f8140637-0559-4f9f-8009-856b5dc24975"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e7ada354-a49c-4b9b-a2d7-5c808daa5493"),

Guid.Parse("25394f42-70e2-4098-926d-c986b9620ead"),

Guid.Parse("2d82183f-df58-41f6-8778-2438511a4c4a"),

Guid.Parse("dbe6f20a-d8ad-489d-8dde-795c6f57b27a"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e7ac23c3-7e60-4b4b-8be7-e289ec08c982"),

Guid.Parse("9c29074d-48ad-4e10-9342-4f7e8d024c47"),

Guid.Parse("e3f48c48-18fb-4316-8a29-0745459bda8e"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("19be3c20-d37f-4922-93e8-6be9e800b1b6"),

Guid.Parse("067a9ce7-5bac-4324-9513-b45fca33f5be"),

Guid.Parse("e58a3589-9350-486c-8cef-faf37fc0fea0"),

Guid.Parse("dbf10504-8d42-455c-9e9c-bd0a4b656fd9"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eece3de0-e969-45cf-b255-e67dc31aee50"),

Guid.Parse("821927ff-9d47-40df-8a9a-906348a7ec39"),

Guid.Parse("91ae88c4-a70d-4feb-b3e6-aa554510a2ef"),

},
},
            new GuiduuidListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("96e81031-be98-495e-8bdf-ae1b9e956175"),

Guid.Parse("3aee7a71-8c53-4076-9d36-9537f604edda"),

Guid.Parse("f2010ce5-19e9-4969-b393-7ba3ebe62d83"),

Guid.Parse("7bc0f94f-0cc4-435b-87b7-f6772e76f182"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0c037825-8adc-46b9-982d-553bdf0ce39e"),

Guid.Parse("f114201d-5f1c-4b69-a521-0802e22f323f"),

Guid.Parse("2c1d9823-f50f-433b-b091-e35a92627db4"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8744a819-6db9-4dd5-a387-d8d8d930d3bd"),

Guid.Parse("68e4f4af-0beb-430a-b0bb-cd3af248f51e"),

Guid.Parse("1dbb8390-15b8-4ae5-8721-ba0f25852232"),

},
},
            new GuiduuidListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d0369346-55fe-42cd-9d69-2875648138b2"),

Guid.Parse("fa1a0299-4020-4b47-8fd0-1ec97b91fae6"),

Guid.Parse("5c940bb1-4af3-4d9b-9715-d7600a94671a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e71f8592-c49a-4d6f-9e6f-9b90c5dd22b9"),

Guid.Parse("99dbe01b-a173-424a-a33a-8f5b046a3629"),

Guid.Parse("0bd777b5-78c1-493c-8618-8d78e5201c80"),

Guid.Parse("974f1f73-70b3-464b-ae6f-e06ea4de8bf2"),

},
},
            new GuiduuidListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("615cb6c7-7a6f-439e-bd29-00a27913ea4e"),

Guid.Parse("b2649127-6344-4f35-9567-17ec820692a3"),

Guid.Parse("288406c1-393d-474a-a546-79518484ca3e"),

Guid.Parse("c383355b-d49f-4713-8897-f5dcbcae9338"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("164de0ef-4e7b-4fb3-9af2-f742abed5ba4"),

Guid.Parse("15ff89ca-3e3f-469e-acdf-d27cf24f7776"),

Guid.Parse("eb7067ad-bf79-40e7-857d-c9b083e6f934"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c18b7f4a-c0ae-480e-8581-fb6afc63af65"),

Guid.Parse("f1690f6a-f329-4f32-aa03-55613c0cc073"),

Guid.Parse("f742b2f1-aa53-4007-b3de-f6c83c21e1cd"),

Guid.Parse("8a2d19cd-fdf2-4edb-822d-4b6a3c71cc84"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9349aacf-4434-4c2b-8326-7d8a8a8c5217"),

Guid.Parse("e5090398-f470-4427-8c60-5b541e5974f9"),

Guid.Parse("aaf8174e-c043-48a6-85bb-a0765ae4104d"),

Guid.Parse("5341d30e-91ee-402e-8f83-d59bf50c1f8f"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7ddd2307-e733-4f6b-8416-0107174fd9c3"),

Guid.Parse("9dfaf91e-33f9-435a-b897-3d29229f7b60"),

Guid.Parse("e9430469-4f5b-4587-b955-79e86e72962d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d0a80d96-6123-4d5c-bce0-6a7d4bbbf75d"),

Guid.Parse("adc9ad4e-002b-461b-932d-6b5fb55a001f"),

Guid.Parse("68d5ba35-cdad-40dc-9f50-2e1829bfb072"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b7372ad5-f0bb-4223-80c3-a366dbfe0aa9"),

Guid.Parse("24628915-5ab4-40fb-85e2-25a3b6eae4f3"),

Guid.Parse("15fcffb5-c5e7-447e-8323-08b67f4c0a52"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ab56cfb3-6b93-4595-8b30-98a6324a3a7d"),

Guid.Parse("0bc89a67-3707-4347-a21c-988af306721e"),

Guid.Parse("89aec874-b361-413a-a6cf-5198a53944e8"),

},
},
            new GuiduuidListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d405d9a0-fec4-412e-b831-5f6642ad0f62"),

Guid.Parse("4e9b36ce-852e-44bd-9385-d7cdab7b2660"),

Guid.Parse("1510b6a8-46fe-4143-bf32-2593a45d9166"),

Guid.Parse("40d89ccc-e072-42cc-a7f6-594edcdad537"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("15a0743d-52c2-41e9-bf74-d15a612d137a"),

Guid.Parse("2cb7105e-79ef-4aa4-bc1f-e73bfeea86e2"),

Guid.Parse("460dd90e-3a94-4702-a7e3-a30223847eec"),

Guid.Parse("047ddb57-67ac-4df6-83b6-cbe4cc504ea7"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a4026347-0b34-435b-b999-550aa2924160"),

Guid.Parse("f2ffe0c9-652f-4aee-a098-db5156b3d98f"),

Guid.Parse("0fde7a84-2110-4508-b90b-631823586424"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3e6255c-b44e-4466-b475-149b278a7ff1"),

Guid.Parse("cecf1e40-2010-485c-9040-29f89360853f"),

Guid.Parse("8b708730-373a-4c10-bbf1-9f1c6ec28b23"),

Guid.Parse("9614d25c-e70a-415e-bd21-8dac315a8c48"),

},
},
            new GuiduuidListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2f9f594b-7b74-4e2a-bd17-082bacc9629c"),

Guid.Parse("132fbab7-cb71-42d7-b058-6b31de643f17"),

Guid.Parse("fe287f9b-4ae3-4aaf-a50b-ab123c3dd80e"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4d168357-fb7d-4aa8-8388-8d12b1c44ad9"),

Guid.Parse("27acccb2-4928-4073-b1cd-4a064106cf92"),

Guid.Parse("2a2e08d9-d32d-478f-bfc6-3bfb96bbee4d"),

Guid.Parse("316aa475-8d9c-49b4-a166-e0bb3b2ff44d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6bb6f7ae-26f3-4400-b353-17abe4a283b8"),

Guid.Parse("f2769020-a150-4ad3-b6af-7943f465b1f9"),

Guid.Parse("f510fdde-54fc-4bd3-bda1-1b86ff125f1e"),

Guid.Parse("af71e6c4-6b23-474f-b273-5cddcca99026"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1b0d460c-218f-4845-b8bc-822d376c87d9"),

Guid.Parse("a7150b1a-700c-4670-b6f5-448a130f874e"),

Guid.Parse("ebdccf3b-3251-4f3a-95ec-be9b3c7058e8"),

Guid.Parse("614f7cac-9a5d-4507-8073-3c259bc9d692"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c352f05b-7345-4045-a3b9-545bf182d4af"),

Guid.Parse("81d30063-94ac-4ce1-99cb-b2874e3d770f"),

Guid.Parse("88fe2996-544b-4230-9224-e82b762c2032"),

},
},
            new GuiduuidListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cdc90ae6-73b6-4902-8de5-6c8e28c48ab6"),

Guid.Parse("881e3fc5-204d-4b92-8b64-518397e5e708"),

Guid.Parse("70475036-35b2-4224-bcf9-6e4facc7d199"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f05dce10-2520-4afd-b673-05f4d4ea672e"),

Guid.Parse("ef1b5bb8-225c-40ba-9d7c-3803471d12e4"),

Guid.Parse("fcdb909c-7365-466c-bb5c-695f697a91d3"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("46879a75-bcc0-4772-8169-126f7d2f7676"),

Guid.Parse("d3bb9673-8a61-46da-b78d-3b7e590c590d"),

Guid.Parse("ad0e6e5c-14d4-46c2-8dc4-2d5e258df744"),

},
},
            new GuiduuidListD1E2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0d416b7f-832c-428e-841f-d9ef46076b9c"),

Guid.Parse("f002163c-bb78-43ea-8dc6-de44c57ecc81"),

Guid.Parse("bd9f9036-b5be-4a4b-8a84-7aa8c8135181"),

Guid.Parse("f29e6f3a-6935-4f77-9c0b-66476e7a08fe"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dd43d70a-90fd-4831-8976-3786bcb03831"),

Guid.Parse("e45162b1-b8b2-43cf-b84a-19fc1ebaf8fe"),

Guid.Parse("c93f4877-8801-44a8-b3be-03bedc55f808"),

},
},
            new GuiduuidListD1E2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f4a1c945-85a6-483e-accc-078aba3ef195"),

Guid.Parse("4db58e73-e801-45a4-a149-065e028d1da8"),

Guid.Parse("1b9a2022-f211-4f10-b4fc-37dbc5800aff"),

Guid.Parse("a4bd6794-79cb-4858-8b16-2e004ea9882a"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1e884d16-b51c-4ad6-b929-ce49e97cfb77"),

Guid.Parse("9aa76f06-8bdd-4632-9d0c-edef8ba11c27"),

Guid.Parse("6de9e1ac-cd54-47b5-9333-49e2a5c03b90"),

Guid.Parse("b84b7dec-c702-4cbb-9d48-6223a0900375"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e7e7f7ec-214f-44bb-b2ed-2ab04917811a"),

Guid.Parse("bb719cf2-fe00-471d-aeed-5619df10a936"),

Guid.Parse("ca8a0445-f234-4d32-9c01-8b08df39f771"),

Guid.Parse("85571639-f5a2-4f8f-ad3f-71654f1519e0"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("26473d9c-c217-4204-b10e-ddefa782ed2e"),

Guid.Parse("48afbe55-f74a-49db-b8b6-dfb0d74cb8ae"),

Guid.Parse("665e7bb5-e579-41f8-97e3-20dd1993898f"),

Guid.Parse("dc5da0c5-528e-49cf-a0bd-33892d00da24"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8e3b6b7c-ffa0-4d71-9bf8-be8b0114d47d"),

Guid.Parse("4dfcca9a-dad3-4d8c-9313-c1819a52c759"),

Guid.Parse("9ccbc119-6055-40d8-9293-a5dcfa870d12"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("272735f5-d4fa-4007-937d-3bd0f0514f95"),

Guid.Parse("dde6cc9d-7778-4128-b524-d63c13940274"),

Guid.Parse("0d9a3ea3-de10-4d73-bda9-4cd737088c05"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a76bd99e-e802-4aa9-987a-78bf1fcab63d"),

Guid.Parse("b55dd72a-b422-4963-b635-502c6a960210"),

Guid.Parse("b22cb629-eb0d-437e-9ddb-41d2640de18f"),

Guid.Parse("5e99fbe3-f933-47fb-99cb-d770cf8282bf"),

},
},
            new GuiduuidListD1E2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8a4795d8-5071-4b32-af8c-6ecaeb2f98c0"),

Guid.Parse("810a97ae-d31e-471b-a8b0-9cc5d37397f1"),

Guid.Parse("74b14d0b-ec4d-402e-b089-62efd296a60a"),

Guid.Parse("094ed448-f9ae-4720-98bc-ff944d22c8bd"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 192,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7aad2ad1-f075-47cc-acf7-604719f843f9"),

Guid.Parse("2ab1a9a3-2be2-4347-a6e9-1db97f345832"),

Guid.Parse("df25334f-ee00-4d83-aee8-7a56eb2e8421"),

Guid.Parse("1883b6ef-1d91-4803-8ae8-7033f2bc021f"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e4c61d02-cca7-4e8f-b468-81c51773c216"),

Guid.Parse("37f7d761-7cdd-4c46-8d38-6b766d034c51"),

Guid.Parse("bf8c712a-fa5e-4665-be43-0ebe5678a504"),

Guid.Parse("52b1d977-2502-4b6f-af87-caede55544ed"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("dd99c9fd-7c4f-4254-96ca-35e84fb1f3fc"),

Guid.Parse("85d2abed-1dc0-43ce-bdfb-db9a3f2abf79"),

Guid.Parse("6f6d75a1-82a2-4803-9ef3-d7b42083921f"),

Guid.Parse("6063cd5f-414b-4af7-9b5e-da2bc85a6cae"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 199,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("172d779c-5205-4985-bde0-60c8918032f2"),

Guid.Parse("ab7752eb-a548-4f19-b290-3b8322e94bba"),

Guid.Parse("5d4100fe-d7f7-4a5f-8e44-ce49041fdf92"),

Guid.Parse("a4f38e4d-712a-4fbd-8e7b-08dd4e85a076"),

},
    ModelInner = null,
    NullableValue = null,
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 173;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 190;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 185;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 180;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[31],_testData[34], false);
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
                parametr1.Value = 165;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 190;
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
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[34], false);
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
                parametr2.Value = 115;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 173;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[34], false);
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
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 190, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 123, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 89, query1, 190, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 173, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 123, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[34], false);
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
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 35, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 49, query1, 38, query2))
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[26],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 185, query1, 99, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 180, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[7], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[8], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[9], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[10], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[24],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[25],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[26],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[27],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatch(connection, 109, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 32);
                var models = await ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 91);
                var models =  ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                GuiduuidListD1E2M.AssertModel(models[0],_testData[17], false);
                GuiduuidListD1E2M.AssertModel(models[1],_testData[18], false);
                GuiduuidListD1E2M.AssertModel(models[2],_testData[19], false);
                GuiduuidListD1E2M.AssertModel(models[3],_testData[20], false);
                GuiduuidListD1E2M.AssertModel(models[4],_testData[21], false);
                GuiduuidListD1E2M.AssertModel(models[5],_testData[22], false);
                GuiduuidListD1E2M.AssertModel(models[6],_testData[23], false);
                GuiduuidListD1E2M.AssertModel(models[7],_testData[24], false);
                GuiduuidListD1E2M.AssertModel(models[8],_testData[25], false);
                GuiduuidListD1E2M.AssertModel(models[9],_testData[26], false);
                GuiduuidListD1E2M.AssertModel(models[10],_testData[27], false);
                GuiduuidListD1E2M.AssertModel(models[11],_testData[28], false);
                GuiduuidListD1E2M.AssertModel(models[12],_testData[29], false);
                GuiduuidListD1E2M.AssertModel(models[13],_testData[30], false);
                GuiduuidListD1E2M.AssertModel(models[14],_testData[31], false);
                GuiduuidListD1E2M.AssertModel(models[15],_testData[32], false);
                GuiduuidListD1E2M.AssertModel(models[16],_testData[33], false);
                GuiduuidListD1E2M.AssertModel(models[17],_testData[34], false);
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


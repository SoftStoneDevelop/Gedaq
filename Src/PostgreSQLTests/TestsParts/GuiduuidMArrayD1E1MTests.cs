

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
    internal partial interface IGuidMArrayuuidMArrayD1
    {
    }
    
    internal partial class GuidMArrayuuidMArrayD1 : IGuidMArrayuuidMArrayD1
    {


#region TestData

        private readonly GuiduuidMArrayD1E1M[] _testData = new GuiduuidMArrayD1E1M[]
        {
            new GuiduuidMArrayD1E1M
{
    Id = 6,
    Value = 
new System.Guid[3]
{
Guid.Parse("dc60641e-115c-4653-b679-4be33fb90b1a"),
Guid.Parse("3eb2e1bb-04c4-4dcc-9373-857601111f19"),
Guid.Parse("bcdb693d-14af-4f38-917c-4b02653a34c7"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0d08b37d-cff3-4650-a07f-098508f69a63"),
Guid.Parse("2df24b23-b3d2-41eb-a07a-27b118b6c8c8"),
Guid.Parse("e37c5975-e2d9-498f-9f1d-d163d7275fe9"),
Guid.Parse("a1793bab-3eae-489e-98eb-122c3aa7c6e2"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 12,
    Value = 
new System.Guid[4]
{
Guid.Parse("e543db0e-c67b-4457-b243-554c2d696b0d"),
Guid.Parse("7d2aae89-c208-4e9f-95be-31d8ed9ac174"),
Guid.Parse("2f7b4b1d-713a-4331-8cbb-33002b9a8160"),
Guid.Parse("09a036e3-e126-4d63-8d08-f24475838eaf"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 5,
    Value = 
new System.Guid[4]
{
Guid.Parse("568c767c-5db2-44e7-bf1a-dba318406949"),
Guid.Parse("ff89d6a4-d05a-4b4f-936b-b43839efd1e6"),
Guid.Parse("bd16af1b-ec46-4d74-a631-1ebb31aa545e"),
Guid.Parse("efe75920-f657-4564-8529-021cf10aff66"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7af47810-1a32-408b-b00b-0ae752bcf1c8"),
Guid.Parse("e05bb23a-46eb-48f5-b058-f0df1f719ab5"),
Guid.Parse("480bb1d8-b98e-400f-acf1-75f9220edddd"),
},
},
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 15,
    Value = 
new System.Guid[3]
{
Guid.Parse("ec556ee7-0e5e-4c89-97c1-5a1c7a15686f"),
Guid.Parse("4a89e052-9526-4b6f-aad6-77451ffe2a46"),
Guid.Parse("17a9ddb1-f903-444a-a3a4-69c73420d914"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 24,
    Value = 
new System.Guid[4]
{
Guid.Parse("268a7b3b-b4c3-4708-a995-b0a63b544e3c"),
Guid.Parse("26e7bd3c-0a75-4fd8-8655-fe86261e8973"),
Guid.Parse("faca76cd-77b5-463f-8fe0-df509ae2ceb6"),
Guid.Parse("c398c13b-58c4-4cb0-bf25-9bcb873197fe"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("6cbfc3ab-0a2a-4b7f-bf17-ad1d58a1d309"),
Guid.Parse("9beb9118-2984-4118-a987-5df958f9c3db"),
Guid.Parse("e73a6a6d-bc9c-4c04-b3b1-17f022ab9562"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Guid[3]
{
Guid.Parse("b3cc88af-ec78-4245-b92b-1307d931b557"),
Guid.Parse("9ac111c5-27ee-445a-94a9-3c08369eca29"),
Guid.Parse("fab6107c-fc27-4244-8922-2b9a27e1324c"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("935c4d0b-042a-4359-b81a-9ce7dcb74562"),
Guid.Parse("2d94bf1d-e6f7-4ce3-b44c-1393e4924567"),
Guid.Parse("1474cc4d-40b4-4cc8-a538-b505baafee47"),
Guid.Parse("7a89e502-29be-4f5b-a421-1848b9b12b32"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("dd97bb30-b143-4636-bae1-9bcb7221d2f8"),
Guid.Parse("b7f53761-d738-48b1-b1a9-815164343b38"),
Guid.Parse("81f5036e-7f25-4af2-943a-1c372af6e9e0"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7ca177f6-965f-4cd0-88f6-e3a1a5637fb9"),
Guid.Parse("0e55dba1-f69a-45ad-9fcb-414cb3424701"),
Guid.Parse("a6665875-9006-4985-964d-f1bd0033f261"),
},
},
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Guid[4]
{
Guid.Parse("250bc63c-f6cf-498d-99d2-470286f4b66c"),
Guid.Parse("89fd4637-cdfe-4fcb-8cbe-a24fbc046018"),
Guid.Parse("5b59b28a-0cce-45a9-a1e1-202435a000f0"),
Guid.Parse("248c7a42-e015-4d9f-8d0d-936bf8bf9e1f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("cc5acca9-a392-4eec-bf8a-276b6b85cf9b"),
Guid.Parse("a80c712d-1a89-4cca-92d7-800a524c98dd"),
Guid.Parse("a919625f-bacc-4ae8-8b68-94140e6cfcfe"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("b7e26192-7f23-4b3c-943f-92ffeecaef27"),
Guid.Parse("fac26a81-ea8e-4a14-bb68-ebc203c3f09f"),
Guid.Parse("ea6690ef-77a0-42c0-bfe9-8cfad3f9a9ec"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("684be7b2-d742-4a9b-abc1-29724c7a6450"),
Guid.Parse("915ad594-74b1-4ecc-9ed9-f7ff4bb7e19e"),
Guid.Parse("2e5e0d52-71e9-4514-acf1-e8ffc26b9b09"),
Guid.Parse("7fbd7799-84be-40d4-a162-09cf9a30f70b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("bcfbe056-2503-4fe8-9f70-3678ff9685ca"),
Guid.Parse("ed5b946e-65fc-42fa-a0ba-6a973fd1cc15"),
Guid.Parse("f2d1c24f-e5cb-4487-bb18-35cd9ee986c9"),
Guid.Parse("8124756a-7d75-4ad9-a2c1-355c49393833"),
},
},
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Guid[3]
{
Guid.Parse("ee1bef0b-2df8-49b0-8fd1-8de50c632bb4"),
Guid.Parse("0bc8828d-7d67-4669-ad70-908023b83051"),
Guid.Parse("12a37338-e7bf-44fb-9022-d7054c8a95d7"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("4d5a1f02-95d8-45b7-8581-93716e552738"),
Guid.Parse("6dcb4ac3-42dc-43e7-b389-21ee288b5db0"),
Guid.Parse("cd14398b-4a2b-4b8e-ad92-b894ebce976b"),
Guid.Parse("1cb0d3e4-b1b7-4ed2-b969-075f8b7b211b"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("4e63d15d-a6f2-47bf-b7f4-cd0a9661f0e8"),
Guid.Parse("42eb7e44-ff89-43a6-9d3e-3d158766a05f"),
Guid.Parse("c31fc6ad-3e96-4143-98ee-483ba38cb8dd"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("738bdb4f-7bb6-4d3b-887b-f09a67361600"),
Guid.Parse("36970af0-d5a8-42c8-80b9-22ce0509288a"),
Guid.Parse("ff9ca999-a8e6-4114-80fe-57f132326c0f"),
Guid.Parse("cf42d887-e76c-465d-9808-1d9884d86429"),
},
},
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 61,
    Value = 
new System.Guid[3]
{
Guid.Parse("6f1396ab-34ea-40bb-bc1a-99a73b762b27"),
Guid.Parse("95c9a5ef-16a4-44a9-a04f-718ec4a3254f"),
Guid.Parse("7018d28d-6864-4c15-93b7-de99e04f4834"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Guid[3]
{
Guid.Parse("5da98bc3-b27c-4939-8540-50bbaf458e1e"),
Guid.Parse("5a353f16-369f-4bf8-bd07-e38c3568fabf"),
Guid.Parse("eab56290-d110-4803-8f30-c1ee150f8d3f"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 38,
    Value = 
new System.Guid[3]
{
Guid.Parse("f57aa8ef-2b63-4282-866f-2963b7684b37"),
Guid.Parse("87847c6d-0343-495c-b210-81374b51eb83"),
Guid.Parse("d091b035-81d8-42b7-9ca9-a497dee06926"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7cc42d23-dfe8-403a-ae34-718da6dc59f9"),
Guid.Parse("0046ef78-2342-4fca-8329-71879c8f1358"),
Guid.Parse("27b263ad-9bd4-4e70-b38c-5669b0f7750a"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Guid[4]
{
Guid.Parse("d8011b76-b41a-4b08-b302-5d9956d65928"),
Guid.Parse("5c96551e-4de4-4fef-8506-8ae32c9539a9"),
Guid.Parse("e8f24562-3bbe-4e02-8ba7-5d6f5207fcc6"),
Guid.Parse("5cec4baf-16fb-4da2-b667-1eac94bb7f7f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ca285ac4-16b6-4b27-92ba-0c8b3c694952"),
Guid.Parse("d0b50af5-74da-48d7-8426-e35784956f7d"),
Guid.Parse("4c9ffe82-45fa-4b1d-bbb5-7e8b338cf3cb"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Guid[3]
{
Guid.Parse("41516f95-6145-4a7d-8f21-f26b2bd649df"),
Guid.Parse("773ffa8e-981f-4719-8bbb-d1157de34e82"),
Guid.Parse("35f1a9dd-6c7a-4033-a850-b049047d21b3"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 47,
    Value = 
new System.Guid[4]
{
Guid.Parse("efd7bde5-3313-4bc2-825f-217ee9f1b777"),
Guid.Parse("4fd96875-8812-47ce-9880-ded89d76baac"),
Guid.Parse("b4eb04dd-b211-4daa-b91a-ee5a5cb379c2"),
Guid.Parse("ecb7763f-a9c2-4d0b-8f1e-1f062c5a260d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b8014911-15c4-4895-bb80-293b03dced9e"),
Guid.Parse("d2fa91f5-678b-4a73-ba6f-3d922b8b743b"),
Guid.Parse("5bfce4ac-c51b-483e-8c31-6483283d4fd0"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("83303c5b-46c1-459e-a01d-4f9c0f246025"),
Guid.Parse("498fe442-b52a-47eb-a09b-e67b76e47527"),
Guid.Parse("3b926e52-d3af-4b26-ae14-23a454b7b6f4"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("fc572bbd-f17b-4885-be3d-0c9730cf6272"),
Guid.Parse("2a0ab9a5-bf11-4244-9875-8f6b12b15eb6"),
Guid.Parse("47508ec9-3188-4cf4-b0d6-27d75ad9296e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4419880c-5c2a-45d0-8eb9-e600b423da1d"),
Guid.Parse("0e163218-f6eb-47ce-9d0c-c6d63fda568d"),
Guid.Parse("d21af6da-511b-496f-b84a-9bccde008cf2"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Guid[3]
{
Guid.Parse("3275f912-ba83-4683-9027-bccb913aac92"),
Guid.Parse("983b751a-f881-4998-b715-858200ff4b8a"),
Guid.Parse("8a333835-6b8e-4632-ab0d-3b96664ddb21"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 52,
    Value = 
new System.Guid[3]
{
Guid.Parse("2d9c38cb-61b4-4ceb-9d34-a597b972afce"),
Guid.Parse("b6661b6b-195f-4d65-98bf-2e1bca876263"),
Guid.Parse("c690b154-a87c-4ac5-9a71-e8f80640b6be"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6e1e5258-2f81-4273-aaf9-d3f3e06af918"),
Guid.Parse("a82619b6-d93f-4790-8bb4-20b940117b80"),
Guid.Parse("4d0d0534-2dc4-4018-8a59-26d549946976"),
Guid.Parse("d247fd01-81b9-42e9-b4f0-ac3f5145f7b7"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 84,
    Value = 
new System.Guid[3]
{
Guid.Parse("93dae266-034e-49fd-8b47-308c544d3ee4"),
Guid.Parse("04b9787c-651f-4a55-9cee-2ecbeb08fa66"),
Guid.Parse("edc0dde8-095d-49b3-8a80-fdc39e59413d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b0769043-d63e-4727-b9c2-e5d3dce0cb24"),
Guid.Parse("bb080d68-1c6e-4d9f-b2f9-ae4b00370a3c"),
Guid.Parse("427ef3ff-d23a-4a06-acda-09dfa9f43b88"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Guid[3]
{
Guid.Parse("2c23911f-27c9-493c-a697-ddf4ebc9eb4e"),
Guid.Parse("179b9c57-faec-48ba-90fe-7c7f70ab3f19"),
Guid.Parse("1da7b8d5-3095-4014-a81e-0a752039e691"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 55,
    Value = 
new System.Guid[3]
{
Guid.Parse("a818c05d-339d-4ca6-ba73-bb7017a7dea0"),
Guid.Parse("91ef9cc6-64d1-4a44-9917-753637799823"),
Guid.Parse("dc64c563-a03c-45cc-b4a0-77588f1ade40"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d29a6c6b-36ff-44ad-8f87-fa02b634f249"),
Guid.Parse("9a81a006-4195-428e-920d-82c70c7497d6"),
Guid.Parse("1bd33ebf-1382-4f67-92b0-36a01f4fb226"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9778ce17-2abb-4e38-ba98-2eb1b9603149"),
Guid.Parse("9e1cdf3b-bffa-4878-99b3-602ef43fb7ff"),
Guid.Parse("fc233004-fe26-4c0f-923e-2beda0bfc629"),
Guid.Parse("6906d55c-8e0c-4782-bf0e-292a245f6556"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Guid[4]
{
Guid.Parse("793aafa2-0813-4e1c-8aae-fbf7fc09313f"),
Guid.Parse("05ef878e-504d-45d6-93e7-e4928a663c1a"),
Guid.Parse("1ce24fda-61a0-41f9-a5cc-6717157a4a44"),
Guid.Parse("90ef2d53-6f08-4b3d-b679-c5e5b52a2187"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 102,
    Value = 
new System.Guid[3]
{
Guid.Parse("49a6bfb8-27b1-41d5-8866-4f85029f551d"),
Guid.Parse("38100930-b0de-40e8-af10-ea03a8ef0198"),
Guid.Parse("3dca9b49-354d-49fc-848f-a73e959b5533"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 61,
    Value = 
new System.Guid[3]
{
Guid.Parse("5fd8b0d3-b37e-4509-b9dd-f2af4ec73b3a"),
Guid.Parse("2925b75a-fed4-4c5b-adec-bb54976e8ffe"),
Guid.Parse("601b0e16-4fa8-405b-ba81-ff9628d7b15c"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b5cd673e-7a48-4ae0-be5d-4da32849bb1c"),
Guid.Parse("61823910-cf44-465f-8ca6-8708d6436b67"),
Guid.Parse("11782b5d-8344-4689-824c-fca99c757408"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Guid[3]
{
Guid.Parse("c106763a-e3ca-4ad2-9b8e-e04bac4d85b0"),
Guid.Parse("fb8e3399-929b-48ad-8251-9e4fda5d8a45"),
Guid.Parse("d4390199-a79c-4c1b-b90f-87f725ffd9dd"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a866f903-019a-4b1c-b12e-1e426b4018a0"),
Guid.Parse("a570a3c7-0dd4-4255-86d5-fc38a7117b99"),
Guid.Parse("344d646e-6e68-4a9a-9f61-aae4707a6e09"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 106,
    Value = 
new System.Guid[3]
{
Guid.Parse("bd28b156-79d3-4d98-9bd2-2f6767957e41"),
Guid.Parse("21601240-dde3-4bc0-86fa-7bc9f4a95038"),
Guid.Parse("e0bc9ab7-53ad-4565-abc4-64fd2f0bc515"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 68,
    Value = 
new System.Guid[3]
{
Guid.Parse("827c5a98-f502-49b4-87a7-9e24a0ff18d9"),
Guid.Parse("c82d9252-6bd2-4a9e-95ed-a5e20a9ece41"),
Guid.Parse("e31d22e5-ab5a-4bf2-92b9-1100d4f9736c"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4e3793f8-1066-4b24-9b71-3eeb2532d3e8"),
Guid.Parse("46a80d5a-6544-45da-b5cb-efa44a537209"),
Guid.Parse("7003754f-c959-4145-ba5a-23ad7512e08f"),
},
},
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 110,
    Value = 
new System.Guid[4]
{
Guid.Parse("01a89533-f61e-4387-9fed-5a97a6dc1f1f"),
Guid.Parse("f55a31dc-181b-406b-9785-54b0160d3c2a"),
Guid.Parse("b4110ec3-ba6a-4015-a99a-9a05e967c091"),
Guid.Parse("7927d15b-4c08-4d09-9ab5-c7604d4f95a9"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Guid[3]
{
Guid.Parse("fc067618-b985-4b1f-b4a2-16dcf8c9edb4"),
Guid.Parse("5008e6ca-3663-45b6-95d5-0bf4ebee1e0c"),
Guid.Parse("84b6f70e-7a73-4740-b72f-1720ad7a1dde"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 71,
    Value = 
new System.Guid[3]
{
Guid.Parse("2d503ff6-ff4f-4fd0-9b5f-582f487fd3cf"),
Guid.Parse("48898ed3-8ec1-469d-b0c7-5abdac2db921"),
Guid.Parse("57218742-ed02-46ee-a16d-0dc3d2f5d889"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9b2bb13d-7ab8-492e-824f-ad46b7a9f64b"),
Guid.Parse("b9653b75-3c31-472b-8ff6-ae270e7e9eb4"),
Guid.Parse("f8d4b08c-7857-414c-aebd-67c2ad7a03bf"),
Guid.Parse("68a02b67-a0cb-443e-846e-966db07c1a7a"),
},
},
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 118,
    Value = 
new System.Guid[3]
{
Guid.Parse("db7a9896-4c0f-4aad-a624-42e5fe13460a"),
Guid.Parse("b6a35f66-291d-44ab-adce-bb7981d4977d"),
Guid.Parse("54e8b212-05d3-4553-b819-a75191e13028"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Guid[3]
{
Guid.Parse("af12c242-212e-400e-9428-5d8ef587dd9b"),
Guid.Parse("b1847190-6abd-4f7f-a61e-81758efd3154"),
Guid.Parse("a1e88351-2725-4515-98c7-c4aa9c8fb103"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("269a8fd6-5f8b-408f-bbc4-d0a9c055ffa0"),
Guid.Parse("147594f5-9a94-4110-b596-199d4e0c847b"),
Guid.Parse("0317b460-5fc5-4f72-90cd-16dfe65fd831"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("77efe3d8-976a-4ae2-bafa-bbe90d4daca2"),
Guid.Parse("831f8ced-52c4-4121-acac-0fedd26b04b6"),
Guid.Parse("9711acb9-70a3-4c54-b89f-e1640d31d349"),
Guid.Parse("c3c273e8-49d1-4e8c-92cb-acf6607de359"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3d38c372-bd83-47ba-ae25-72c4ca2e91f2"),
Guid.Parse("130d6732-f11a-4301-b025-2110661c4a9c"),
Guid.Parse("826d66ae-a6eb-44a1-9a34-b46381492f61"),
Guid.Parse("64b24f0e-31b5-4484-805f-a4efd3915749"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Guid[3]
{
Guid.Parse("9e6b23db-f2ef-4e78-9516-27917f40822f"),
Guid.Parse("a4da71dd-4885-4aa5-965d-d455d5dbb774"),
Guid.Parse("034171d9-1293-4b0b-9e4b-02aa3d6838f2"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0b8dcf40-c1cb-456b-a924-339d50dedda9"),
Guid.Parse("0769472c-8a2e-43e4-ba83-897991d78742"),
Guid.Parse("f76bba5b-8e87-4a3d-b5ca-486ad18fb295"),
Guid.Parse("3f9c4c74-888a-4839-ae4b-397d66fa6e30"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Guid[4]
{
Guid.Parse("76ff7888-0283-4677-ab2e-b9f78b4bba71"),
Guid.Parse("4e0bba43-0baa-4e9e-afd5-eb902c5f647a"),
Guid.Parse("9f806e54-febc-49ed-8438-a226b9632ed0"),
Guid.Parse("4b554492-9b88-45f5-a301-b08994b01e0a"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 75,
    Value = 
new System.Guid[4]
{
Guid.Parse("67081bc5-f5e5-4dd8-91de-389eeb921078"),
Guid.Parse("a1db57a4-c450-443c-a85a-3422afccde26"),
Guid.Parse("8166a358-7a12-4448-8d29-d237e5eec85e"),
Guid.Parse("42b0507e-fd95-45c6-9fec-005b6aa044da"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b1847dea-1764-4205-a047-28d19d80c72a"),
Guid.Parse("c8d809ea-db2d-4ae5-b99b-dcada484c560"),
Guid.Parse("07c3ffc3-2c35-48bc-92d6-ff5743101fe4"),
Guid.Parse("41f89d19-4aa5-4636-bc12-9cc4f366cdd6"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("951bf4fd-99b1-4bd4-ad20-e5292239a10a"),
Guid.Parse("cb2b5db2-4bca-4300-a86c-32c1f42ba646"),
Guid.Parse("ee125bcd-f2ea-40e2-ba2b-876b7cd924ca"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 144,
    Value = 
new System.Guid[3]
{
Guid.Parse("fad9175d-c92d-41c4-b69e-7411acdf265d"),
Guid.Parse("4bf1983a-38cd-488a-b9ee-2c5e03217a01"),
Guid.Parse("477d27d8-6b15-4379-a4ee-8bcfccda6841"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("13044980-e3c1-4e46-8823-895bca5fda70"),
Guid.Parse("90e32620-4da6-42d0-8e82-dc17c8ca93c4"),
Guid.Parse("36e9bd36-bdc9-4129-9de2-9c1ef3822189"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 149,
    Value = 
new System.Guid[3]
{
Guid.Parse("40a551c8-0f96-4303-bcf5-a1172f2ba9db"),
Guid.Parse("78689d1a-5c0a-409c-94df-7c4420e4755e"),
Guid.Parse("27146b64-2837-4121-9a1b-58f0a9adec61"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 78,
    Value = 
new System.Guid[4]
{
Guid.Parse("451fdfb0-25d4-4382-8e49-6d5303914971"),
Guid.Parse("13dc582c-be35-4b4d-b95b-e469aa748372"),
Guid.Parse("3d5832e1-c8db-4590-bc7e-8aa604283ce0"),
Guid.Parse("ceea2918-cd87-4950-ba4b-edb4f594ef11"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 156,
    Value = 
new System.Guid[3]
{
Guid.Parse("16f1759d-f183-4f84-b49b-f653f54b831b"),
Guid.Parse("cc042f35-979a-4e29-bfce-b1a15782e1aa"),
Guid.Parse("a777e1a3-ebe5-4e20-aefc-579b2e915075"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Guid[4]
{
Guid.Parse("d6293490-7330-4b44-938e-c906e7bb86fb"),
Guid.Parse("de22efac-2f23-4550-a765-5b4afe7c8e91"),
Guid.Parse("c7018e06-d5c3-411f-9f59-29b1dd1aa59d"),
Guid.Parse("64a6a935-d8ef-4d31-8cbe-629ccc325804"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 86,
    Value = 
new System.Guid[3]
{
Guid.Parse("f086f443-b06a-4a6e-84b0-b94b99211ba7"),
Guid.Parse("7447dda8-94ed-4332-ace5-5ac40ebc0f8e"),
Guid.Parse("6e1ad214-7a62-4d21-a7b7-e7a32c9b2027"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Guid[4]
{
Guid.Parse("031ff56c-0090-4b50-8be0-61e7773e0525"),
Guid.Parse("db8682b7-c1c2-4dbe-9176-4aa4ab74d831"),
Guid.Parse("bbb17175-7650-4f9c-9368-c133da4dd9b0"),
Guid.Parse("cd14cfcc-eac8-4be5-910f-17e62a9d01bc"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8dd4c1c6-41a0-46b8-9960-d419e63cfa31"),
Guid.Parse("729c45c6-ded0-416c-9293-8caa3a34254c"),
Guid.Parse("1bb5ca9d-c9e3-4892-b8ef-c9d30c106309"),
},
},
            new GuiduuidMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Guid[3]
{
Guid.Parse("85094984-b231-4ebe-8187-13be7d636857"),
Guid.Parse("5042396e-17b2-43dd-a964-1a77624747e4"),
Guid.Parse("ee73c9a0-ef1b-492c-87d4-7a2595547894"),
},
    ModelInner = new GuiduuidMArrayD11MI
{
    Id = 90,
    Value = 
new System.Guid[4]
{
Guid.Parse("481fb040-4e30-483b-b7e2-c050469a9bfd"),
Guid.Parse("4f241f41-e346-4cc2-9dd1-3eb7c552dca3"),
Guid.Parse("bdb8cc9a-9295-469f-95bd-9e9e4bdd6b55"),
Guid.Parse("1d1012f7-d533-42a4-bbee-f874e6c1af07"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMArrayD1E1M
{
    Id = 177,
    Value = 
new System.Guid[3]
{
Guid.Parse("c92d95c2-f347-453b-8923-d8db2f2680ad"),
Guid.Parse("806cf3b5-68ea-42c1-b88f-c1992fb2375f"),
Guid.Parse("6e281d77-3506-4ed9-96a1-e5e46a05d831"),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmarrayd11mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
INSERT INTO public.guiduuidmarrayd11mi(
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
            queryMapTypes: [typeof(GuiduuidMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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

                changedRows =  ((IGuidMArrayuuidMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmarrayd11mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)), 
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
                methodParametrName: "guiduuidmarrayd11mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmarrayd11mi_id
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
    guiduuidmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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

                    nullable =  ((IGuidMArrayuuidMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable =  ((IGuidMArrayuuidMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((IGuidMArrayuuidMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("cc5acca9-a392-4eec-bf8a-276b6b85cf9b"),
Guid.Parse("a80c712d-1a89-4cca-92d7-800a524c98dd"),
Guid.Parse("a919625f-bacc-4ae8-8b68-94140e6cfcfe"),
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

                    nullable = await ((IGuidMArrayuuidMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmarrayd11mi_id
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
    guiduuidmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
                methodParametrName: "guiduuidmarrayd11mi_id", 
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
                nullable =  ((IGuidMArrayuuidMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidMArrayuuidMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
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
                nullable = await ((IGuidMArrayuuidMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidMArrayuuidMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("7cc42d23-dfe8-403a-ae34-718da6dc59f9"),
Guid.Parse("0046ef78-2342-4fca-8329-71879c8f1358"),
Guid.Parse("27b263ad-9bd4-4e70-b38c-5669b0f7750a"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMArrayD1E1M> models = null;

                models =  ((IGuidMArrayuuidMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMArrayD1E1M> models = null;

                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD1E1M), typeof(FlatGuiduuidMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
FROM public.guiduuidmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMArrayD1E1M>();
                await ((IGuidMArrayuuidMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMArrayD1E1M>();
                ((IGuidMArrayuuidMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
FROM public.guiduuidmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmarrayd1e1m m
LEFT JOIN public.guiduuidmarrayd11mi mi ON mi.id = m.guiduuidmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidMArrayuuidMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD1E1M), typeof(FlatGuiduuidMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
FROM public.guiduuidmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMArrayD1E1M>();
                await ((IGuidMArrayuuidMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMArrayD1E1M>();
                ((IGuidMArrayuuidMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
FROM public.guiduuidmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmarrayd1e1m m
LEFT JOIN public.guiduuidmarrayd11mi mi ON mi.id = m.guiduuidmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD1E1M), typeof(FlatGuiduuidMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMArrayD1E1M>();
                await((IGuidMArrayuuidMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                await ((IGuidMArrayuuidMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                await ((IGuidMArrayuuidMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMArrayD1E1M>();
                ((IGuidMArrayuuidMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                 ((IGuidMArrayuuidMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                 ((IGuidMArrayuuidMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                await ((IGuidMArrayuuidMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 131;
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                 ((IGuidMArrayuuidMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.guiduuidmarrayd1e1m m
LEFT JOIN public.guiduuidmarrayd11mi mi ON mi.id = m.guiduuidmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
                var models = await((IGuidMArrayuuidMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD1E1M), typeof(FlatGuiduuidMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMArrayD1E1M>();
                await((IGuidMArrayuuidMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                await ((IGuidMArrayuuidMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 61, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                await ((IGuidMArrayuuidMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 110, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMArrayD1E1M>();
                ((IGuidMArrayuuidMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                 ((IGuidMArrayuuidMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 103, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                 ((IGuidMArrayuuidMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 103, query1, 167, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 110, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                await ((IGuidMArrayuuidMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 24, query1, 118, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 110, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduuidMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
FROM public.guiduuidmarrayd1e1m m
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
FROM public.guiduuidmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMArrayD1E1M>();
                 ((IGuidMArrayuuidMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 36, query1, 88, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduuidMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.guiduuidmarrayd1e1m m
LEFT JOIN public.guiduuidmarrayd11mi mi ON mi.id = m.guiduuidmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
                var models = await((IGuidMArrayuuidMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 106, 162))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[22], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[1],_testData[23], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[2],_testData[24], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[3],_testData[25], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[4],_testData[26], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[5],_testData[27], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[6],_testData[28], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[7],_testData[29], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[8],_testData[30], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[9],_testData[31], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[10],_testData[32], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[11],_testData[33], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        GuiduuidMArrayD1E1M.AssertModel(models[2],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 6);
                var models = await ((IGuidMArrayuuidMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                GuiduuidMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                GuiduuidMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                GuiduuidMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                GuiduuidMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                GuiduuidMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                GuiduuidMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                GuiduuidMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                GuiduuidMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                GuiduuidMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                GuiduuidMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                GuiduuidMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                GuiduuidMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                GuiduuidMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                GuiduuidMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                GuiduuidMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                GuiduuidMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                GuiduuidMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                GuiduuidMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                GuiduuidMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                GuiduuidMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                GuiduuidMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                GuiduuidMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                GuiduuidMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                GuiduuidMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                GuiduuidMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                GuiduuidMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                GuiduuidMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                GuiduuidMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                GuiduuidMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                GuiduuidMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                GuiduuidMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                GuiduuidMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                GuiduuidMArrayD1E1M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models =  ((IGuidMArrayuuidMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));

                GuiduuidMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                GuiduuidMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                GuiduuidMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                GuiduuidMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                GuiduuidMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                GuiduuidMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                GuiduuidMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                GuiduuidMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                GuiduuidMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                GuiduuidMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                GuiduuidMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                GuiduuidMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                GuiduuidMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                GuiduuidMArrayD1E1M.AssertModel(models[13],_testData[34], false);
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
FROM public.binary_guiduuidmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMArrayD11MIWA),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMArrayD11MI),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidMArrayD1E1M),
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
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
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
FROM public.binary_guiduuidmarrayd1e1m m
LEFT JOIN public.binary_guiduuidmarrayd11mi mi ON mi.id = m.guiduuidmarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
                var models =  ((IGuidMArrayuuidMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD11MIWA), typeof(GuiduuidMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
                var models1 = new List<GuiduuidMArrayD11MIWA>();
                var models2 = new List<GuiduuidMArrayD11MIWA>();
                await ((IGuidMArrayuuidMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMArrayD11MIWA>();
                var models2 = new List<GuiduuidMArrayD11MIWA>();
                ((IGuidMArrayuuidMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmarrayd11mi
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
                    GuiduuidMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmarrayd11mi
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
                    GuiduuidMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD11MIWA), typeof(GuiduuidMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
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
                var models1 = new List<GuiduuidMArrayD11MIWA>();
                var models2 = new List<GuiduuidMArrayD11MIWA>();
                await ((IGuidMArrayuuidMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMArrayD11MIWA>();
                var models2 = new List<GuiduuidMArrayD11MIWA>();
                ((IGuidMArrayuuidMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
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
                var models = await ((IGuidMArrayuuidMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmarrayd11mi
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
                    GuiduuidMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmarrayd11mi
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
                    GuiduuidMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD11MI), typeof(GuiduuidMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
                var models1 = new List<GuiduuidMArrayD11MI>();
                var models2 = new List<GuiduuidMArrayD11MI>();
                await ((IGuidMArrayuuidMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMArrayD11MI>();
                var models2 = new List<GuiduuidMArrayD11MI>();
                ((IGuidMArrayuuidMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD11MIWA), typeof(GuiduuidMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
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
                var models1 = new List<GuiduuidMArrayD11MIWA>();
                var models2 = new List<GuiduuidMArrayD11MIWA>();
                await ((IGuidMArrayuuidMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMArrayD11MIWA>();
                var models2 = new List<GuiduuidMArrayD11MIWA>();
                ((IGuidMArrayuuidMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMArrayD1))]
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
                var models = await ((IGuidMArrayuuidMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


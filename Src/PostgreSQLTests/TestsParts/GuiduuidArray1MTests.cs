

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
    Id = 6,
    Value = 
new System.Guid[4]
{
Guid.Parse("26e409c1-47c0-405e-bef9-87c970fbdab8"),
Guid.Parse("d3f9149e-6eb8-47d1-ace4-c930fa6d1f7a"),
Guid.Parse("739fb024-840d-4143-9b6d-5dfd46213cec"),
Guid.Parse("09e78dff-1187-4127-b670-855c0953ee3d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ae7ca04e-0fd2-480c-8144-592a369f7ddb"),
Guid.Parse("00f96361-e800-421b-9688-8dc293cd60c7"),
Guid.Parse("069d3874-8fe6-41b9-821d-a7ccd4936cf5"),
},
},
            new GuiduuidArray1M
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("a48f1b16-e020-4ff1-a337-ac301f28b19d"),
Guid.Parse("14244a60-abb8-4752-a75f-a314e83c7708"),
Guid.Parse("f8831e7f-7573-4e75-a337-cb5a18a506e9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 2,
    Value = 
new System.Guid[3]
{
Guid.Parse("6d3fa191-c9d0-449f-b298-5145839298bd"),
Guid.Parse("182a8806-6cbe-4171-9a0b-023e4d68e496"),
Guid.Parse("fc1eb31b-eceb-458f-9d37-fb470afe01bc"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("96e051c2-f720-4816-ad47-b260fb9ec03d"),
Guid.Parse("661b2dcb-238b-4ba0-ad79-572982f92ba9"),
Guid.Parse("9a7185d5-57f8-4561-bd45-01617e908992"),
Guid.Parse("c628b21a-bc6f-4412-b238-2158c0e2d5de"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("bb621d38-dfa9-437d-ab87-61de7c5cbf8f"),
Guid.Parse("8dc4a6dd-3153-4854-bdbb-b902591464c1"),
Guid.Parse("ccdb4e36-a2b5-41b6-b742-50a3009fd550"),
Guid.Parse("82991f60-3b04-41d5-8b66-14e377eae361"),
},
},
            new GuiduuidArray1M
{
    Id = 14,
    Value = 
new System.Guid[4]
{
Guid.Parse("a04a4bcd-8025-43d3-983c-9d7d71f68522"),
Guid.Parse("47d5ff9c-a899-4c56-80b4-e4f07fb58b12"),
Guid.Parse("885891fb-2676-4a6e-b9a3-76a1e1226f11"),
Guid.Parse("9f0a5e91-8786-4dae-8798-9a32068e5043"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 16,
    Value = 
new System.Guid[4]
{
Guid.Parse("e1432481-2d31-462d-abca-f6eb599bb983"),
Guid.Parse("dba6f7ef-0c03-4ec7-9912-948a67cc3e02"),
Guid.Parse("3db7fde0-8b54-4dcb-bbc8-421b541ffcd1"),
Guid.Parse("42bbfaef-042c-4114-b572-8a174792cb02"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 5,
    Value = 
new System.Guid[3]
{
Guid.Parse("b09fd90a-d45a-4ce2-99bb-82b9dc5dca7a"),
Guid.Parse("7a49d851-7ca4-4564-a1eb-5800b1cea157"),
Guid.Parse("c30ee6be-d573-420e-a053-b6fa6657cd56"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 21,
    Value = 
new System.Guid[4]
{
Guid.Parse("e1168381-e1a7-4957-897f-c6723330c17a"),
Guid.Parse("88c44e09-3e0c-4041-800d-9a069e836bd9"),
Guid.Parse("4effd0cc-f247-449e-9ba9-0946c507a6a9"),
Guid.Parse("3e5af18b-bb6f-4c99-928a-14d1858feff5"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0912bf42-04a0-4ff5-8bbd-85dc82c44d16"),
Guid.Parse("6ae4cc1b-54e7-4d42-b7ba-48c8e6bdbec2"),
Guid.Parse("5c6972b5-af64-490a-a2db-dc158eb77084"),
},
},
            new GuiduuidArray1M
{
    Id = 26,
    Value = 
new System.Guid[4]
{
Guid.Parse("7fc2768e-d9de-4735-989b-da0df10f5893"),
Guid.Parse("11c904cf-784c-4f63-8471-a4dd5b76b516"),
Guid.Parse("adc14a49-9c6b-4725-9399-c811a2021d68"),
Guid.Parse("a388b6c5-d682-499e-a8c0-9885e29ffdb3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("1e03425b-31ec-4dad-9490-3450ba62225c"),
Guid.Parse("33a76f1a-77f5-47cc-bcf6-415c5e682fbe"),
Guid.Parse("ec343e56-7b7e-4900-8a37-ca7debe1f737"),
Guid.Parse("35ed78a6-0ce0-45c9-b8cc-dc06d3aa16d5"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("99545c66-06a9-41d2-9940-851925c7a1d8"),
Guid.Parse("59c4fa43-6638-4e97-a4cb-4b4f837cc1cf"),
Guid.Parse("2db88cf7-3661-4c62-9289-ee0fd00ccbc6"),
Guid.Parse("049e195e-08d5-436e-8145-499dcda3ee5a"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b9d293ed-0af6-4d4e-9476-42529dd7c4a2"),
Guid.Parse("daaf5485-316f-4286-9864-fe6cf8d84158"),
Guid.Parse("5d0cc1a6-db20-4a77-839f-f04855910946"),
},
},
            new GuiduuidArray1M
{
    Id = 32,
    Value = 
new System.Guid[4]
{
Guid.Parse("cdf2d674-a892-4ac1-8f82-b906fd22e74f"),
Guid.Parse("c09e4c9a-a24c-45bc-8bf5-f3d3f505485b"),
Guid.Parse("c21f8afb-a892-4a80-b3a3-a9d065bf830c"),
Guid.Parse("0d9bf6b5-57e3-4755-a111-34c5077e1fb7"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6947c792-f6da-4e04-978b-b124bcdbf9c2"),
Guid.Parse("9919a505-f05a-4178-95e5-77d07b5f71b8"),
Guid.Parse("c7ac0abf-9ce0-41d7-9bc0-e4c488f1ae44"),
Guid.Parse("f573efba-d175-4d88-9e12-5d4c4b96ac3f"),
},
},
            new GuiduuidArray1M
{
    Id = 39,
    Value = 
new System.Guid[3]
{
Guid.Parse("7a775b4c-a752-42e8-9b29-e3372c7c179b"),
Guid.Parse("0a5bcb77-a79c-431b-909e-70efc85e0016"),
Guid.Parse("613779e8-102e-4c5c-a73a-91ecb192f905"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 16,
    Value = 
new System.Guid[4]
{
Guid.Parse("2e33a384-94b8-4ced-a76f-711ade4b645f"),
Guid.Parse("7f0d9152-c1e5-4d09-8fc1-206e947eed42"),
Guid.Parse("e60acf48-3ffd-4dec-96e5-60f49984da72"),
Guid.Parse("7889c920-d51b-423c-a1d6-c0001864595c"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ee826629-782a-4ca1-93f3-b2a0c195ec1e"),
Guid.Parse("5ec144db-714f-403d-9a10-95839a44cb42"),
Guid.Parse("3087b8ad-0638-47f1-8a00-118de261899f"),
Guid.Parse("ec162280-8f68-4f02-9205-5c15fb24eb03"),
},
},
            new GuiduuidArray1M
{
    Id = 47,
    Value = 
new System.Guid[3]
{
Guid.Parse("1b3cb555-1697-4808-b350-b4dbf31f3c2e"),
Guid.Parse("da4ded0b-ade1-498f-a5cb-a4ab1b19c99e"),
Guid.Parse("2cdaf1fd-494f-4240-9e57-b990a2e90441"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 56,
    Value = 
new System.Guid[4]
{
Guid.Parse("3797fb31-9b64-4c70-9ef9-c3e92cea5df7"),
Guid.Parse("1ed21eaf-29e9-4ede-9c9f-1feb0792e6a9"),
Guid.Parse("058ad5ae-8678-4939-b548-7e03ad2ce1f2"),
Guid.Parse("7a9e7334-4c7c-4574-9735-9748b4c2f9ea"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 20,
    Value = 
new System.Guid[3]
{
Guid.Parse("c4693e9e-72b7-44a8-ac99-ba4c16a472eb"),
Guid.Parse("825e4a0e-2801-4861-9d3c-35bd2136be5e"),
Guid.Parse("68855248-7c9b-46c2-84c2-450f7ed693e4"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2c518c3f-6f00-4e78-9d78-b881ec5072e2"),
Guid.Parse("02b168a3-086e-4d28-bc61-ae7108e65c34"),
Guid.Parse("22deed54-cf59-4267-81bd-5c5f1589a0e1"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0ed956ef-e785-4cb2-b0b9-0d4d607e31b4"),
Guid.Parse("22b24e01-6632-455b-83e3-25006cef6c13"),
Guid.Parse("2811e95c-2f34-490c-83a8-3a2a5683f26d"),
Guid.Parse("f86eeef1-d4b9-4f9b-8ff7-dd777f0fa7c9"),
},
},
            new GuiduuidArray1M
{
    Id = 63,
    Value = 
new System.Guid[3]
{
Guid.Parse("0389536a-cf19-4cd5-ac8c-a4343abc0acd"),
Guid.Parse("c47a5d72-fc61-4458-85a0-eea0f866ee33"),
Guid.Parse("1566a406-6aee-4a9a-a0a5-1c84b5592e32"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 64,
    Value = 
new System.Guid[4]
{
Guid.Parse("7552f59a-10c2-4692-826c-560106d6b78f"),
Guid.Parse("9368e928-5dd0-4af7-b434-0d277f651f3c"),
Guid.Parse("899d6643-25b2-41de-a311-73704f439bc8"),
Guid.Parse("9ffc9ed1-53a7-40bd-b267-f299fd782a09"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("a3b327d5-05d2-4c0d-ac93-6c1ebf94829f"),
Guid.Parse("da17e46b-cfd1-44d3-aa6a-ab2a58bff5ca"),
Guid.Parse("f6e2a640-6d86-4ef2-9851-31dd33ca5606"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 67,
    Value = 
new System.Guid[3]
{
Guid.Parse("af9b7efa-ee18-485b-9f46-41d97dbc0bea"),
Guid.Parse("f7f44142-57ea-4d89-ba5d-373c302a2887"),
Guid.Parse("907c013c-fd62-46aa-83da-92a64dbe8208"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2d2cca4a-fbf3-4225-8e45-f22320a1346c"),
Guid.Parse("9bbe6c7b-6d8a-41af-9197-9800b4cba1f3"),
Guid.Parse("06773afb-6cc5-4e45-8697-97eb245b8fac"),
Guid.Parse("4995a494-6c16-45bd-8fc9-170f1369ebbf"),
},
},
            new GuiduuidArray1M
{
    Id = 71,
    Value = 
new System.Guid[3]
{
Guid.Parse("a0df4397-0415-4a3a-91c2-a6a7f7e5af87"),
Guid.Parse("a35a9338-004a-4758-93aa-7b66fd2cb00f"),
Guid.Parse("c5588e20-93fc-4800-8bf3-4e350dd676b2"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 30,
    Value = 
new System.Guid[4]
{
Guid.Parse("dbbc40c4-e76f-4f18-9016-aec706d2a22f"),
Guid.Parse("a7b7698b-e7c2-4c45-b4ef-e9b7a31599de"),
Guid.Parse("7821255e-934e-4602-b2f6-8c07d15a55a2"),
Guid.Parse("9072a2df-5984-4556-868a-f73fbf13a3bd"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("65965bf5-8baa-4218-9e9c-d6a7ce3714af"),
Guid.Parse("96d45906-bd3d-4916-8363-6584808b341a"),
Guid.Parse("60d3b9be-8d70-4c56-a6a0-e6ff3ab58c6a"),
Guid.Parse("eeef6611-c9a1-4905-baf1-dfa502c4ffc5"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 78,
    Value = 
new System.Guid[3]
{
Guid.Parse("de13b9ee-253c-4f2f-857b-d977329538bb"),
Guid.Parse("8283efe2-82d6-41f9-9699-18f9722b7582"),
Guid.Parse("f18c0feb-e7c2-4086-8863-01487fd4f245"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 80,
    Value = 
new System.Guid[3]
{
Guid.Parse("809bd9d9-eeb7-4b9b-96d8-a78e6daaa8fc"),
Guid.Parse("74defb78-4a8e-42c5-903a-69c1ad7d6fb9"),
Guid.Parse("b0d54090-7dd5-42d4-b27a-0a23a3c6ce6a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 35,
    Value = 
new System.Guid[4]
{
Guid.Parse("783f760f-57a9-41b7-a3ec-b3df5b3ac7ef"),
Guid.Parse("b8c7b792-1c29-42a5-ba08-35de2d7995b5"),
Guid.Parse("190ba443-0cff-41ff-a6d3-ac4d4c29f8e3"),
Guid.Parse("c3f84179-0cba-479a-b26f-50cee2349f0d"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fd8133dd-ebac-4a2e-9ded-f25914a22ab9"),
Guid.Parse("ddd756e1-6441-4c5e-9455-edc53bfd63e3"),
Guid.Parse("dd330ffb-0099-44c5-ab0e-5329257cf380"),
Guid.Parse("5cea340e-fe2a-4c7a-a955-b03e62c221f9"),
},
},
            new GuiduuidArray1M
{
    Id = 86,
    Value = 
new System.Guid[4]
{
Guid.Parse("8be5e6ba-0fcd-405c-911a-1bcac0508e8d"),
Guid.Parse("ba99b7c9-609d-4ddd-aef6-1755a95a8dbb"),
Guid.Parse("e0f20638-4dc7-4089-89b1-f194d1188d24"),
Guid.Parse("e3a1f115-f5c4-4fb9-b2b8-64422717d0d3"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ea3faef7-bf2d-44d7-97ac-3a926dc95c98"),
Guid.Parse("0acac7c6-bcfe-406e-8fa9-cdbef39ead42"),
Guid.Parse("09367b02-e7bc-4d16-a176-b70955fbf9ae"),
Guid.Parse("da7eb699-973f-4c91-985f-24ce68f0e563"),
},
},
            new GuiduuidArray1M
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("2dfe46a9-c994-409a-afc6-7cc543605ffa"),
Guid.Parse("360f0f36-5487-48a5-b3de-e58910c3263d"),
Guid.Parse("1c9facac-5bf7-4edd-8c5d-39ee30ea3c0e"),
Guid.Parse("b1079d43-d39f-48e6-9923-728e6fb95593"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("cde32294-52d2-4493-a7a0-4e5719760908"),
Guid.Parse("a8f978dc-68fd-491f-9057-e5b6efa7f6b8"),
Guid.Parse("257bbb39-1f44-4a49-9f36-0ba2ed2b1d35"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fd815753-67da-49bd-be4c-64d0fc30728f"),
Guid.Parse("a70f235f-a9d4-4e7c-86b7-8ac894180f80"),
Guid.Parse("3a0fde3d-aaf0-49b9-863a-88865103c181"),
Guid.Parse("d0fb8432-6e06-43e5-98b8-1f9c20165f8c"),
},
},
            new GuiduuidArray1M
{
    Id = 92,
    Value = 
new System.Guid[4]
{
Guid.Parse("fbd5c54f-ae9c-4453-a17b-d73476f285b3"),
Guid.Parse("c78e18dd-131a-46b3-8328-fc79caaf77d2"),
Guid.Parse("54aefb31-8a8d-45aa-a09d-77d907be53a8"),
Guid.Parse("7512b4b7-dcfb-49e1-b4b9-71dc4e032296"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 100,
    Value = 
new System.Guid[3]
{
Guid.Parse("2dcd024e-d7fb-4662-8d4c-48d359987408"),
Guid.Parse("2a074ab0-9fd0-4377-8d0d-7e825358c673"),
Guid.Parse("a2ec5984-14e8-4dc8-a25b-2e4afef1de3b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 44,
    Value = 
new System.Guid[4]
{
Guid.Parse("81f62e8a-255b-401b-8bee-bd5513acdfa0"),
Guid.Parse("537130ad-9808-469e-ab4c-930b9addb7c5"),
Guid.Parse("31975fdb-e576-48c5-bb13-98a5ee79e24e"),
Guid.Parse("b3070dd7-5248-4b69-b65a-9b32bbd8d1a0"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 102,
    Value = 
new System.Guid[3]
{
Guid.Parse("4db0ce66-d588-4c66-8d74-56f52cfc667a"),
Guid.Parse("5f069771-c586-4cab-a5c0-599c16a06505"),
Guid.Parse("335d1769-0720-4f26-afbe-124ca545e7f9"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 106,
    Value = 
new System.Guid[3]
{
Guid.Parse("814d341e-d3d6-481a-bdbb-4c15cacf52fc"),
Guid.Parse("610fd0ab-bef6-4bc7-9a1f-917d83c706b8"),
Guid.Parse("d32ea4b5-de22-4375-97f4-8097a1649fb8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 51,
    Value = 
new System.Guid[4]
{
Guid.Parse("c3317bfa-d492-45cc-905e-7c4e94bbd05e"),
Guid.Parse("91a18b42-b4b5-4d5d-bd15-edba6ec1541f"),
Guid.Parse("2efce678-c36e-4243-b8a2-2d5c625c7369"),
Guid.Parse("62ea1f48-653e-4863-a28c-e63b75af4a29"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 107,
    Value = 
new System.Guid[3]
{
Guid.Parse("cd7c1ad8-653e-4f3d-9515-0119410bb1ac"),
Guid.Parse("f72a2cf8-fed8-421f-a143-f7dd1a8cb6bc"),
Guid.Parse("a209c3cb-022c-4c35-a358-9c951d176a0c"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("95771fa1-b1ca-4452-9918-c197ff78f7bf"),
Guid.Parse("f5b859a7-8a6a-4c23-a4de-6a01a1ba89ed"),
Guid.Parse("89486f06-4b34-4886-bfd4-2df42077368b"),
},
},
            new GuiduuidArray1M
{
    Id = 115,
    Value = 
new System.Guid[3]
{
Guid.Parse("f4e36d91-0459-42cc-8f13-687459a23c08"),
Guid.Parse("1dab5488-11cd-4a91-8a71-dac400557a97"),
Guid.Parse("9bbdedbd-98b2-4e38-87d1-1fac8275b111"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 52,
    Value = 
new System.Guid[3]
{
Guid.Parse("35ba7ecf-0822-4ba0-a4cf-133c5fc88461"),
Guid.Parse("f210585b-5270-4005-a1c2-39a0b774115e"),
Guid.Parse("5ac0942d-2402-45fa-99e5-fd17b873cfde"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("01e09253-43c2-4cd3-8aec-c6c93b38449e"),
Guid.Parse("b2a717c3-8032-4550-8b87-3b55640a1b0b"),
Guid.Parse("dfa377ff-11a0-4085-9aa1-a640dea039bb"),
},
},
            new GuiduuidArray1M
{
    Id = 124,
    Value = 
new System.Guid[4]
{
Guid.Parse("ed5ad7fb-629b-4e59-8fe4-5a3496351246"),
Guid.Parse("49956903-66e1-43a8-b62c-2fa749224cb5"),
Guid.Parse("3c2afba9-6e2e-4371-aa50-a990eabb77c5"),
Guid.Parse("80841652-2a16-4e8d-8944-2571d7f26444"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5cbe7c69-b8c5-4f3a-8eff-8ffeb3f0b826"),
Guid.Parse("804c021c-3276-4e02-a159-04010c09a745"),
Guid.Parse("9613e1a4-d88c-4d74-8f39-a895a3b4d97f"),
Guid.Parse("643eb1b0-7c4b-4a26-be55-d422b8444aa1"),
},
},
            new GuiduuidArray1M
{
    Id = 126,
    Value = 
new System.Guid[4]
{
Guid.Parse("9dbd534a-e48f-4b23-8d1f-275a0fbceca9"),
Guid.Parse("66c0d366-d32d-4c64-9542-f50763543d87"),
Guid.Parse("255dfa57-4ff8-4316-b5a7-4246141512af"),
Guid.Parse("2ccb2466-8ab2-4346-ae3e-540aa0c142bb"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("a501e0ed-3fb6-41ae-b1bc-44d437c02aa2"),
Guid.Parse("4c5d6c48-5975-4115-8589-d324b72692ed"),
Guid.Parse("bc682492-3852-4af7-bf9d-19813d0e31f2"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 134,
    Value = 
new System.Guid[4]
{
Guid.Parse("e497ff75-1696-4dc3-85f4-f78145d649cc"),
Guid.Parse("27110a23-5fc0-4859-8f39-32fa5110794d"),
Guid.Parse("0e957c49-78b5-43c0-b831-c110c3d58a9c"),
Guid.Parse("1540d35b-1710-4d3e-aa17-6af12518f2ab"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 143,
    Value = 
new System.Guid[3]
{
Guid.Parse("4ac20321-fac7-40fb-95a7-0f8562d87f51"),
Guid.Parse("31807f69-35c4-44aa-a26e-22fb4f802b83"),
Guid.Parse("f850a840-bdbd-49dc-9e3a-be0517562405"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 63,
    Value = 
new System.Guid[3]
{
Guid.Parse("bbb9cb49-2a71-40e5-868d-f6ced640662e"),
Guid.Parse("edf89b44-512e-4d8b-9bed-4ca2148c8434"),
Guid.Parse("e3f0af63-0bfb-4e10-8bfe-274478b174c6"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("eca78107-d881-4986-9c1a-c4c46ed018cd"),
Guid.Parse("db42fefd-8f19-4d87-88b8-f4efcc0876e7"),
Guid.Parse("6beae426-4cc9-4775-92f7-b10b1e79be99"),
},
},
            new GuiduuidArray1M
{
    Id = 151,
    Value = 
new System.Guid[4]
{
Guid.Parse("16fabe50-0ed4-4ec5-93d6-e6a6708bc82f"),
Guid.Parse("fe09a37b-dc2c-4101-b38c-0a41dbc64708"),
Guid.Parse("4646981d-8e69-44ff-a176-7e11228624df"),
Guid.Parse("9593dc6c-078c-43ac-88ec-157786d51fb0"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("198f920d-a491-42de-88ba-f7f5dd4973a2"),
Guid.Parse("be7d891f-a551-4a90-92e1-40c344e04e21"),
Guid.Parse("87376c60-60ca-48be-84cc-2322e1986349"),
Guid.Parse("79875de8-28da-40cb-9097-c494f2a65b5d"),
},
},
            new GuiduuidArray1M
{
    Id = 156,
    Value = 
new System.Guid[3]
{
Guid.Parse("6fc3418a-b27d-42b3-8aa9-968266d8c5ba"),
Guid.Parse("dd998735-0b68-49d1-94b9-b4a1ca547fee"),
Guid.Parse("fcec0d99-58dd-46a9-b557-00d7cbfb54c4"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 71,
    Value = 
new System.Guid[3]
{
Guid.Parse("109d0545-0986-4712-a2bb-5254876d6c67"),
Guid.Parse("d1e984f1-bfcf-446e-8051-3dfc64f4062c"),
Guid.Parse("5550f793-b9bd-4d74-848b-662a4876e228"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b8a1fd1a-5d56-4855-ac6d-730b248b69be"),
Guid.Parse("5c50dd12-632a-4d33-82b0-a4909c954bab"),
Guid.Parse("8597449c-3573-40f1-8528-60c5cd20554a"),
Guid.Parse("b7882aca-84ac-4c4f-828a-5a353ae7777a"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 163,
    Value = 
new System.Guid[4]
{
Guid.Parse("1f5ecc33-4783-470c-8d91-581d745bc773"),
Guid.Parse("121cb339-d1d9-4308-97b9-b56d018a2f64"),
Guid.Parse("45ff15a1-0bb2-4c09-bd92-f482941cba11"),
Guid.Parse("9dad8c14-31d8-4670-b181-17ba13b22dd9"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("bc0305ba-8a62-4719-bbc4-4a32249b7982"),
Guid.Parse("2e8d4db3-51a4-4c0e-9def-f84f27bd2114"),
Guid.Parse("288673ff-6919-4b98-91d1-27410b446be9"),
Guid.Parse("62944a94-e441-455d-b548-e58719c19c3f"),
},
},
            new GuiduuidArray1M
{
    Id = 164,
    Value = 
new System.Guid[3]
{
Guid.Parse("c3d105d4-1181-4add-85e2-cdd87580ed7e"),
Guid.Parse("31427aa3-a790-4cb5-a090-434bbd41abf9"),
Guid.Parse("cd0b7265-15d4-4fdc-884c-aa4deb570a12"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 80,
    Value = 
new System.Guid[3]
{
Guid.Parse("d71aae68-4497-440a-b2bc-3fd63e8aeb55"),
Guid.Parse("1fd29d8b-706b-44bb-9882-f53c0a58cc94"),
Guid.Parse("c3fb61c5-ba42-455b-b1d7-2ed2dd907394"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("13f5784c-02ba-4993-b0e7-395325d579a1"),
Guid.Parse("44de9007-2982-4415-b507-6df19cf9a0d1"),
Guid.Parse("5247d169-d392-40cd-8545-7198727f7e50"),
Guid.Parse("0b5c20bb-c745-44e6-86b9-09c59301d8fa"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("afa87359-3a0d-4aaa-9828-7bb0d1173663"),
Guid.Parse("7eda5c35-9ac3-4fed-9e3f-491829ca920c"),
Guid.Parse("76243cf0-2796-4fab-b6c3-0badc4771b27"),
},
},
            new GuiduuidArray1M
{
    Id = 170,
    Value = 
new System.Guid[4]
{
Guid.Parse("b01683f8-19fc-4fff-a624-5ac6f06e96d4"),
Guid.Parse("63edaf68-b275-4e34-aa29-95e63702c773"),
Guid.Parse("01d2e692-d09b-48cd-8698-a39b9b0e3c58"),
Guid.Parse("146374d0-0828-4169-8d9c-f10356b2ff8b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2d682eb7-f881-48b7-91ed-691fb3d536b5"),
Guid.Parse("c0ca9b79-497e-4ace-8cc6-216b8ccd2ce0"),
Guid.Parse("481004a4-f303-4f52-be07-1b181788b880"),
},
},
            new GuiduuidArray1M
{
    Id = 174,
    Value = 
new System.Guid[4]
{
Guid.Parse("06b7b251-9298-4c30-b27b-65a79d4466b7"),
Guid.Parse("e93929e5-552a-4f04-a613-4c340b9bd7ea"),
Guid.Parse("fe5168d0-7c87-45af-baa1-5d62fd0859f1"),
Guid.Parse("bef8cfe8-6a11-4aef-a9e7-d26515b460d3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 81,
    Value = 
new System.Guid[3]
{
Guid.Parse("236a0aa9-855e-4e70-9cbb-0aa725c56326"),
Guid.Parse("1ea8d4be-b8b0-4327-95dd-4ac520c6df6f"),
Guid.Parse("473a279e-3eb6-4522-8403-46668af8916c"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("15569a4d-de4e-4dda-b230-24d95ab1b4c7"),
Guid.Parse("71d3a6e0-05b3-45c1-99c2-f74b10906134"),
Guid.Parse("cd360d75-be1e-4392-b9a7-9644e61740c4"),
Guid.Parse("4e65632f-9257-4c6c-8a15-64db28fbbb08"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b59193e8-da8d-440a-a249-b421dcb1bb1e"),
Guid.Parse("b526db4b-ac7f-4b92-90aa-3f9ae3b4a473"),
Guid.Parse("4c7eea24-4207-4d97-9a33-6ab99b779ee1"),
Guid.Parse("574e0235-7568-410d-9aed-b6dacb462f1b"),
},
},
            new GuiduuidArray1M
{
    Id = 183,
    Value = 
new System.Guid[4]
{
Guid.Parse("f7c172db-c377-4984-b385-bc401295cb59"),
Guid.Parse("86471574-567e-4d24-938e-ca0aef15ff57"),
Guid.Parse("cfa37218-c845-4402-adc4-f771a9106379"),
Guid.Parse("6540fe89-0a55-4e81-aaa7-da194311a9ae"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("811627a9-4c0c-4800-a98b-5b5e696e1392"),
Guid.Parse("275bbcc6-7243-4cd5-a927-52442a157b69"),
Guid.Parse("68dbfec2-0593-47a6-bd41-660230291793"),
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
Guid.Parse("0912bf42-04a0-4ff5-8bbd-85dc82c44d16"),
Guid.Parse("6ae4cc1b-54e7-4d42-b7ba-48c8e6bdbec2"),
Guid.Parse("5c6972b5-af64-490a-a2db-dc158eb77084"),
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
new System.Guid[3]
{
Guid.Parse("b9d293ed-0af6-4d4e-9476-42529dd7c4a2"),
Guid.Parse("daaf5485-316f-4286-9864-fe6cf8d84158"),
Guid.Parse("5d0cc1a6-db20-4a77-839f-f04855910946"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("6947c792-f6da-4e04-978b-b124bcdbf9c2"),
Guid.Parse("9919a505-f05a-4178-95e5-77d07b5f71b8"),
Guid.Parse("c7ac0abf-9ce0-41d7-9bc0-e4c488f1ae44"),
Guid.Parse("f573efba-d175-4d88-9e12-5d4c4b96ac3f"),
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
Guid.Parse("ee826629-782a-4ca1-93f3-b2a0c195ec1e"),
Guid.Parse("5ec144db-714f-403d-9a10-95839a44cb42"),
Guid.Parse("3087b8ad-0638-47f1-8a00-118de261899f"),
Guid.Parse("ec162280-8f68-4f02-9205-5c15fb24eb03"),
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
Guid.Parse("0ed956ef-e785-4cb2-b0b9-0d4d607e31b4"),
Guid.Parse("22b24e01-6632-455b-83e3-25006cef6c13"),
Guid.Parse("2811e95c-2f34-490c-83a8-3a2a5683f26d"),
Guid.Parse("f86eeef1-d4b9-4f9b-8ff7-dd777f0fa7c9"),
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
                parametr1.Value = 143;
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 170;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[34], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidArray1M.AssertModel(models[0],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 78, query1, 64, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 26, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 39, query1, 156, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 67, query1, 26, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 170, query1, 64, query2))
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 32, query1, 21, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 21, query1, 92, query2))
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 71, query1, 163, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 13, 80))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidArray1M.AssertModel(models[0],_testData[2], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[31],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[32],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 78, 67))
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidArray1M.AssertModel(models[0],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[34], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                GuiduuidArray1M.AssertModel(models[0],_testData[9], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[10], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[11], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[12], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[13], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[14], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[15], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[16], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[17], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[18], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[19], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[20], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[21], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[22], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[23], false);
                GuiduuidArray1M.AssertModel(models[15],_testData[24], false);
                GuiduuidArray1M.AssertModel(models[16],_testData[25], false);
                GuiduuidArray1M.AssertModel(models[17],_testData[26], false);
                GuiduuidArray1M.AssertModel(models[18],_testData[27], false);
                GuiduuidArray1M.AssertModel(models[19],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[20],_testData[29], false);
                GuiduuidArray1M.AssertModel(models[21],_testData[30], false);
                GuiduuidArray1M.AssertModel(models[22],_testData[31], false);
                GuiduuidArray1M.AssertModel(models[23],_testData[32], false);
                GuiduuidArray1M.AssertModel(models[24],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                GuiduuidArray1M.AssertModel(models[0],_testData[9], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[10], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[11], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[12], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[13], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[14], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[15], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[16], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[17], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[18], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[19], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[20], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[21], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[22], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[23], false);
                GuiduuidArray1M.AssertModel(models[15],_testData[24], false);
                GuiduuidArray1M.AssertModel(models[16],_testData[25], false);
                GuiduuidArray1M.AssertModel(models[17],_testData[26], false);
                GuiduuidArray1M.AssertModel(models[18],_testData[27], false);
                GuiduuidArray1M.AssertModel(models[19],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[20],_testData[29], false);
                GuiduuidArray1M.AssertModel(models[21],_testData[30], false);
                GuiduuidArray1M.AssertModel(models[22],_testData[31], false);
                GuiduuidArray1M.AssertModel(models[23],_testData[32], false);
                GuiduuidArray1M.AssertModel(models[24],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[25],_testData[34], false);
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


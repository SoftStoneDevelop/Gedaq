

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
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("142e7b82-beb1-4cb7-b787-6b107255979e"),

Guid.Parse("8978c23b-e3be-4d83-872a-4c7c8922f872"),

Guid.Parse("fed61749-cd23-41f1-ba7a-57b1086405b3"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a27a86c0-34af-4cbb-8560-79caa0c37904"),

Guid.Parse("c85e93a5-bcdd-48ab-99c7-659c6b6e4317"),

Guid.Parse("8744d108-7677-46f5-8009-650930f57c85"),

Guid.Parse("b6689a29-acac-497a-ae9e-4a49590a6c3e"),

},
},
            new GuiduuidListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9610c58f-d968-4657-a008-ae49ddfcfc0d"),

Guid.Parse("88dedbc7-6868-427b-8680-53206087a974"),

Guid.Parse("719ba813-53f5-4991-9cff-cb37162aac89"),

Guid.Parse("20f690cb-cae6-404b-b813-acbf1b3ff3f9"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("10ab6c2a-858a-4956-a2ca-dbb58e757e67"),

Guid.Parse("2f21a24e-eea3-4b7f-9f54-c5cfaafd7d4a"),

Guid.Parse("e4b27187-9f7f-4f56-81a8-e31f295eb772"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("af9022d6-c1f8-4bf0-ab4b-a9c61f274009"),

Guid.Parse("8f0ff6a2-0cc3-4c36-a239-6c24d5f9f39b"),

Guid.Parse("ee4f8167-8b35-4ff1-9c8f-9b8391340ffb"),

Guid.Parse("f38919d0-b746-400d-99c6-b508e2d0a3cf"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("44f0fd00-ee4d-4f87-ac88-e021bc74e96d"),

Guid.Parse("79c4e075-27c7-4e49-a037-c59f3361f05c"),

Guid.Parse("657493dd-6ae7-48f2-8901-5740304d3008"),

Guid.Parse("a8cbbe54-6123-4d19-8572-b18a4edb0971"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ec9ff6f7-8ff8-40c9-830e-36517ee4c3b2"),

Guid.Parse("568a6516-5c13-4f0b-91ea-685279b0493d"),

Guid.Parse("3432dabb-2a46-48dc-a506-971b44590742"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8790837a-ec0c-4507-abea-d0d33729110f"),

Guid.Parse("d68d451a-2303-4806-ba48-f26ee7999705"),

Guid.Parse("7cc4bea5-7f08-46cf-b5a6-c326de9910fe"),

Guid.Parse("734e91b1-19b7-4eb8-978d-3005ebcc5977"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c407bb1a-7b54-4e74-99ac-dd36a79c46f7"),

Guid.Parse("3ed6ceee-9fcd-4acc-95f9-c27e7f3f4a55"),

Guid.Parse("834f9872-c07f-4da5-a7ad-62ec1202c1f4"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d14402f4-0b86-45b4-ae82-ca55856dd7ef"),

Guid.Parse("47a20e5d-7c98-494f-acd5-23b8c56ea9f3"),

Guid.Parse("c1426384-9b3b-48e8-9440-e234e3213fdd"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be195051-e1a2-4864-af3a-ae96aea23a3e"),

Guid.Parse("3d8ea584-01f1-4ab9-980d-b07aebe19bf3"),

Guid.Parse("80dd013e-7dc2-4167-a4ac-d441aafbfa93"),

},
},
            new GuiduuidListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0d54c868-18b6-4cb3-9a5a-0ff2e64bfd53"),

Guid.Parse("c1276b4e-4f36-4884-b819-810845646c6a"),

Guid.Parse("70ea3b67-9dee-4b55-a469-3bb1c2d7c15e"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a64e9714-16c4-46be-b197-39f5be471e8f"),

Guid.Parse("810e15c8-9746-4ba4-aa50-e596244eb976"),

Guid.Parse("f3638f59-fe1a-47b3-ba6a-4f4a42961cd7"),

Guid.Parse("f803101a-ce93-4fff-bef2-bae9b4dafd65"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3af89f44-bf2f-4b01-a56c-68d742a664e7"),

Guid.Parse("fbf10ab7-4d5d-4ddd-860c-599574af717a"),

Guid.Parse("1958cfbf-0e43-4051-bd40-ff0add17a2dc"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("134a6e8d-33cb-43d7-846f-f65b5f8da8b7"),

Guid.Parse("5e4237af-d341-4719-bf05-ce5ba6941660"),

Guid.Parse("331b901e-95ff-4b1f-869d-3070d19f10c3"),

Guid.Parse("e60a0326-1c44-41ce-a6e6-18d85b8b5ae1"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("aafa4159-5590-4417-8fef-def0f8237f9c"),

Guid.Parse("a8e146be-ec32-44cc-8493-f225de628485"),

Guid.Parse("83fdbfff-4e21-4282-8dac-30061cce36f0"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a8994eda-0c57-4865-90fd-67442814489d"),

Guid.Parse("0144da9b-5775-4720-8bd2-a9e0b9838a24"),

Guid.Parse("2f1aa7af-d038-40a1-ac10-5e6720c6d602"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("48bb9afd-c9e0-49b4-97a7-a7c2fd721d41"),

Guid.Parse("bc389bf9-e7d1-4007-9813-7edc8c76dd92"),

Guid.Parse("6b878f23-bbb7-4858-86b8-2b817f8b5662"),

Guid.Parse("ed69d905-f59f-493e-97cc-63284f42947f"),

},
},
            new GuiduuidListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a917eb9e-8e60-4aa7-88cd-abf9fadae416"),

Guid.Parse("342f3b0e-f72c-4f64-b4a4-0960d63971d6"),

Guid.Parse("7f3122dd-fda5-4041-8fb2-21c53e5f1e1c"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("310cd27f-ba20-4569-a0e0-609b02e95e0c"),

Guid.Parse("20ed63fd-b3d9-418f-bddf-44f1bc3821ad"),

Guid.Parse("6172fcf9-610e-4aa6-9a18-14d174600a3d"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("323c5590-8e54-4ea7-b5e3-ce0f71a0fbf2"),

Guid.Parse("9eafa533-4466-42ce-9ea4-9718da075e55"),

Guid.Parse("90d5bf72-f723-4188-9f79-726a0f111679"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0471f97f-73e5-48c8-a02c-475463a62590"),

Guid.Parse("a267c4c3-e714-4f2c-9608-1fee8fc71691"),

Guid.Parse("c921cc91-b4f9-4791-9f9c-a26415072b44"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6e19ec6e-35d1-4624-8e6e-1d57e71bd92d"),

Guid.Parse("27f8b6e7-9e9a-4746-90f1-4d30b8a3dd0f"),

Guid.Parse("c99488fb-bd3c-4215-bd9f-d220d910f044"),

Guid.Parse("a36c9690-6362-4ddc-8640-e09a6bfd4b29"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5aaed130-b352-45dc-9fc9-1bec5cf44b45"),

Guid.Parse("db9b40b2-465c-4b89-99a5-9edb7d550b2e"),

Guid.Parse("5799fac0-3fad-4171-ac62-637d7927c34a"),

Guid.Parse("6cd37cde-2b60-447f-b3f3-fc67dabc0991"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3e6f277e-1eb7-445b-8eea-52fcbe3a2b20"),

Guid.Parse("89661c60-0b03-4978-9ad8-55ff2b79b8ae"),

Guid.Parse("ba20883a-c499-485a-971d-5495288aebd0"),

Guid.Parse("09cb2fd0-6700-4edf-b8ea-de343b1b7913"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bbe16af3-bc27-4e36-89de-fa433b1faf8a"),

Guid.Parse("ea85ebdb-8c32-472e-9be7-98f584f6d5f6"),

Guid.Parse("8a9081db-1c88-4116-9e27-db8668a78160"),

},
},
            new GuiduuidListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("31dee3d6-b60b-4bd7-a519-6d70ae1adf41"),

Guid.Parse("8526d318-ee1c-4dd2-be28-ff988f8f1f68"),

Guid.Parse("b7467c76-af6a-4418-b144-f1b1f815ec3f"),

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
Guid.Parse("ead6a3da-e405-4fce-9c54-852405a6545c"),

Guid.Parse("e1e4309e-03f8-4de9-813d-996ee9eeecca"),

Guid.Parse("bc60f593-c62d-44a4-824c-6fc55a7b58db"),

Guid.Parse("823b2bdc-7e88-4fc4-9cc2-1fff7dbe0510"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1610f4c1-123e-4992-8b3e-212a9f4501ff"),

Guid.Parse("e268e9b3-53c5-4b84-aa8e-d13c8ab6246a"),

Guid.Parse("2463ac4b-a117-45bf-baab-f1c577638e33"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ebb6e812-a3c2-468e-9b65-ef0c3d98651c"),

Guid.Parse("08ac4942-f3bc-4949-b0c1-583c9589a2c0"),

Guid.Parse("0fa03351-ef20-44c6-a6bc-ddeea4d5c174"),

Guid.Parse("3c4cee55-4d32-4787-976e-049220374d26"),

},
},
            new GuiduuidListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6c6fd8c7-027f-4bc5-9cca-15970d9f6fe9"),

Guid.Parse("adfa42f6-4b1d-45ed-9da3-bdb353dcce23"),

Guid.Parse("fe92e617-8fd5-4a12-80b7-cc60dac9f893"),

Guid.Parse("cd935c29-5058-41b7-936f-fff12dc34c7e"),

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
Guid.Parse("1c47ba1a-6119-4d9e-8d1f-ea5f6021f3fd"),

Guid.Parse("61b3a6a1-88d5-456f-8959-2d2ddb61dcd6"),

Guid.Parse("93908a2b-ed05-4ed8-9013-ee634edabaf8"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f863fe70-0fda-4936-83af-e1a30480d489"),

Guid.Parse("66e58877-031a-4417-816b-6a28906072c2"),

Guid.Parse("814aab08-44f4-4ab2-a499-bc0f74800a4d"),

Guid.Parse("c51f491d-bda2-4aca-880d-e5a33a88b338"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cfbd0b38-79fc-4000-b616-78dba66d79b4"),

Guid.Parse("ec30463c-0fed-46c5-b2c1-df49d38b08b5"),

Guid.Parse("253dee7a-8c61-4e14-86f2-59acd48ca463"),

Guid.Parse("3ff7f7bf-dfdc-41d1-b4f6-8a21645a91c8"),

},
},
            new GuiduuidListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d05fe840-8eca-4bca-8040-3aebe3b3c3cd"),

Guid.Parse("c3f4a2ae-98dd-4ded-81ae-c18025ec3d66"),

Guid.Parse("80c829d5-a801-427f-b9da-cdfa9a2c6473"),

Guid.Parse("09e2ad26-9c8a-4f2a-9b76-3a06fc20e097"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("40bd2a40-fb52-4f19-9b10-c8bf4b767efe"),

Guid.Parse("e23151aa-2653-4f70-a34a-9009efab67c2"),

Guid.Parse("3472768c-b5d5-4dd6-8fe3-6d823b2ac158"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f64a9317-7094-4268-bbea-d2189bbd99b7"),

Guid.Parse("8ef637cb-2482-4586-8e44-dd60573ee545"),

Guid.Parse("a7e28dfa-a81a-4410-aa4c-a3007acb5304"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("07388870-1ecb-4ab8-8bd2-3e475a484d33"),

Guid.Parse("810ebaa3-834c-4b57-b85c-608a312dcb09"),

Guid.Parse("b5d6dadd-e22b-4b1b-9b75-adea48ee9e0e"),

Guid.Parse("2473d2d7-84af-4dbf-a26f-1bc2e8eee35e"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("038a75e5-1206-4369-b65a-e515d336e217"),

Guid.Parse("b4ccb43e-f295-4aff-9599-818ba2d51132"),

Guid.Parse("f726c62a-3b19-4730-854c-eac462a0f7cc"),

Guid.Parse("0aedac2e-52a1-40ca-ba9d-52ece6f9ba4e"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a97d11e4-b3b6-4d18-bfd9-630a553cb645"),

Guid.Parse("80e81935-ea43-4e0f-907f-a8d510769d8a"),

Guid.Parse("6d9fd137-4854-4611-821a-d3bd6bf15ad2"),

},
},
            new GuiduuidListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3fd9529d-46d5-4bfc-a89e-2930f9c3d2ad"),

Guid.Parse("4a1baf0e-2017-45d1-976e-afe9cca19e4b"),

Guid.Parse("aeccdb4a-1a39-48f7-841b-5b22afd52567"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3c7ff1d1-003b-41d0-aacb-09f8dd50c6bb"),

Guid.Parse("6f5d9c24-6ea5-4b37-86f3-ed08b7e21097"),

Guid.Parse("3fddc0b4-cae2-4f2a-ae36-852fb298ebc9"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("60cdebd6-306e-4cea-ba22-aaa0dd4aeeb6"),

Guid.Parse("f212a710-5362-4f62-bb84-6da50ce7c7d8"),

Guid.Parse("921867d3-fb9d-4b84-9f97-3b8d623f3c76"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bc2e6c14-cf54-410c-9432-fd1292b8aef5"),

Guid.Parse("b0d1034e-b899-47e2-b0de-ede1ca2a51af"),

Guid.Parse("b0410502-7ca7-4e51-8f4d-1ed2b5688a60"),

Guid.Parse("ca33b84d-9c44-4194-bbfa-763a5a0d3a33"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6035e33b-4b89-4a91-8ef3-4d2e26c80129"),

Guid.Parse("6e3a266c-b482-463d-bc57-1213b8f88a8d"),

Guid.Parse("b56b67cd-09d4-46fb-9eb7-56c80b54c1db"),

Guid.Parse("a3b2a133-5ea1-4732-aeb1-5bc868247f6e"),

},
},
            new GuiduuidListD1E2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bce046b9-c996-465c-be96-69f7bacb688f"),

Guid.Parse("6c3c3486-504b-42a1-8d90-5dbdcd634554"),

Guid.Parse("c274ae5d-569b-4088-aa29-b94848533ee0"),

Guid.Parse("b7b00829-9c94-405c-b130-f704c3757fec"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0f1c958d-9e17-4e12-8d9f-1889d5c0bb40"),

Guid.Parse("6658ac33-addd-4240-87eb-aa501649cf43"),

Guid.Parse("e0f08bf5-c432-49e3-9493-b74649452c00"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edddefcf-9548-4361-b955-54c06366c9c2"),

Guid.Parse("1a360538-dc7b-47cf-8328-939b74c8b4a2"),

Guid.Parse("fc613af6-9f30-412b-9fc0-2cea685215aa"),

Guid.Parse("eb77585d-3095-4f62-8ef9-d3f8586d9d24"),

},
},
            new GuiduuidListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5d66ad0-34e2-4f54-b011-c47504cf38a0"),

Guid.Parse("3dd5fd80-7505-4d1d-bf02-888a2e8f1be8"),

Guid.Parse("2984e0cb-3e38-4d82-9aad-e25bea54451c"),

Guid.Parse("0bfbfe33-50b6-4f93-8088-5f7c940473de"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a3170e64-12c6-4b1e-bdc3-3646cd9e5438"),

Guid.Parse("0b880a9b-10dd-4203-b413-c0153e686233"),

Guid.Parse("716b81b0-c542-4f8b-b11e-2ec49489c7c1"),

},
},
            new GuiduuidListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("12fcd407-3c8c-4b04-b342-7c27c8473b40"),

Guid.Parse("9e753d0d-c7d0-4a0c-a3e0-e9611b4115fa"),

Guid.Parse("2f931d28-7499-47c5-ab1f-4cb5dd477adc"),

Guid.Parse("00f6bd3c-9787-45f7-9cef-d85b3a8f4388"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d8cdd6a8-5bbd-41ce-a856-68eaa2593c3d"),

Guid.Parse("679af43c-5999-415a-99d1-635191cf9dcb"),

Guid.Parse("e62e939d-889a-479d-ad9c-2c9b37b733c2"),

Guid.Parse("013a44a9-3253-424c-b897-af04ce53cd94"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d46c6ee9-cd79-4e1e-96a6-4ecd7f0bfaf3"),

Guid.Parse("b3fce180-0961-43e6-a9a6-7af2fc0e6ac8"),

Guid.Parse("9d00a5b0-7818-4f19-814c-23a76ebf1e8b"),

Guid.Parse("2feade6f-50fa-4248-8f88-31d43fe4a773"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3d920c33-97a9-489c-a5c0-41da83e3033e"),

Guid.Parse("4460a025-4dfb-4d6f-a26d-12a7a81d7784"),

Guid.Parse("e324ba19-3f6e-43bd-af10-59a97cd3341f"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("095b99da-5ab5-4042-9101-73b58d2442c9"),

Guid.Parse("6b19019e-7298-400e-a8de-1b5fc37c6405"),

Guid.Parse("9b75626f-81a1-4ec3-822e-1a4e01da07ab"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a112b22-7c72-4d7e-9e34-f1d20cd8adff"),

Guid.Parse("ba61c274-ba83-40cb-b4e2-7b8d66fd44b1"),

Guid.Parse("213f717e-267f-4485-b2e7-1f7c2239e12e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7774cb0b-cf81-4bda-8848-9e952b7005a8"),

Guid.Parse("a0130e75-a55f-4f4d-bfdd-b80df579e17f"),

Guid.Parse("5470008e-464a-49e3-8bf9-eb8e2b0cbfb8"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3e3cdb5b-0300-40f9-8404-b27709ffae48"),

Guid.Parse("ffc15037-ed05-4f2d-861b-7d66d7b38e2b"),

Guid.Parse("f8aa9425-020f-4d3f-9a29-464007eb6b38"),

Guid.Parse("432ff4cd-ca0e-45ca-ba74-da122b5c6cef"),

},
},
            new GuiduuidListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b90a6873-5145-41d5-bd7b-cf20d80ad760"),

Guid.Parse("381dac79-84a3-4be2-b004-db917ea48ca9"),

Guid.Parse("ee269902-c381-490f-b3e7-600ca6467de1"),

Guid.Parse("1419bb1a-0229-458f-a35a-34e40a27afe8"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("327dfca4-4c50-4543-bc7d-176855a15174"),

Guid.Parse("e39094fe-e5e7-4e0b-a466-1685a29c9392"),

Guid.Parse("06a40cb3-249e-4d45-9735-32e12e391221"),

},
},
            new GuiduuidListD1E2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1c17efd2-c92b-4423-bdb3-079ef2c284a0"),

Guid.Parse("7b4000e2-b829-4b7e-92ed-8e6e6921d707"),

Guid.Parse("ea717791-1c8b-405d-880b-dd29ee1182d4"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3c851194-447c-44ea-84e2-f2978de257f2"),

Guid.Parse("d3789595-995c-4a69-b072-8821dfdd519f"),

Guid.Parse("f60eb5ea-34b8-41b3-936f-4ed03817e566"),

Guid.Parse("33925e4a-1892-4b84-b575-f0cd0259d435"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41cbc930-f290-4ce9-9afc-a139996bb93d"),

Guid.Parse("55597545-fb50-4ce7-b902-46f808af3aca"),

Guid.Parse("3cc755ca-dc5e-4c7e-83fd-7818a0bcac01"),

Guid.Parse("020b3e8f-e248-4258-bf98-4a7becbc30e9"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c12eb6f0-859e-44f6-aba4-1d8d470add1c"),

Guid.Parse("87a08725-97f6-4fd6-93ac-ed2175683bab"),

Guid.Parse("e69a5114-67b6-4e0c-abe4-2a85a61c509a"),

},
},
            new GuiduuidListD1E2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c905fd23-74bc-4859-9733-83689b284749"),

Guid.Parse("3a9f947d-7e68-430a-abec-ee71d314977a"),

Guid.Parse("d61b3bbb-a4b9-4258-9fa8-93957b059e51"),

Guid.Parse("c1d888e1-5d17-4cae-b40c-4e72d3da4e78"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0b21baea-d114-4415-9e67-f85acb4ff272"),

Guid.Parse("5e91ba64-d8bf-4603-aa32-28b3aa0eb5aa"),

Guid.Parse("f9b6713a-f42c-44bd-b456-724fe3710454"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("086e2972-1163-4967-8bef-84e36d6ac47c"),

Guid.Parse("d3a3d982-645b-4384-94f2-763494d9e321"),

Guid.Parse("0f215658-df83-479a-adb2-daa9189f39d8"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("56a84b13-a5a6-45ec-a541-d995fb7a750b"),

Guid.Parse("06dd84b2-a819-4ff1-bfb3-52611f377b87"),

Guid.Parse("86df37da-61cf-4cb8-be5e-59c1272226b4"),

},
},
            new GuiduuidListD1E2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7900ab3-af3c-4fce-adc9-8e71325abda1"),

Guid.Parse("aecf1af0-4c24-4851-9d25-a61794a3462e"),

Guid.Parse("5fb4375c-cebf-4e67-b535-def183fb7ec8"),

Guid.Parse("5a2dfdd6-fbe4-4146-ae0b-0ef0ffd8a36c"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("89267112-9c12-4991-a3af-e5fec7ba5f66"),

Guid.Parse("a3c7b05f-1aa7-4d0f-9d8d-636cef44bd6c"),

Guid.Parse("c421fc9f-f22f-41d1-834e-f91622aaa0ce"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4ae5a8ed-f173-4c20-9e00-a9a00089bcb2"),

Guid.Parse("af02bdb2-eb22-4545-a14a-a0bfd0a60c3f"),

Guid.Parse("d14707af-65e8-4afa-a536-fb5bb0bada27"),

Guid.Parse("257280ca-b189-468a-bb95-4931c999143e"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("87741da4-7da6-40e1-90fc-b35b6b1bfaef"),

Guid.Parse("d69a400a-e514-4668-835d-348ff78a178f"),

Guid.Parse("871b02c7-08a3-4a3b-ac5e-abab585a2fc6"),

},
},
            new GuiduuidListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6b48ca2f-0f6b-4e84-a74e-7a7abb93cf85"),

Guid.Parse("f0c4e314-eedd-4d0a-b007-fe307e194118"),

Guid.Parse("669aeaa9-2d96-4d7c-853d-1db3c2fa0b7d"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("50cce375-8d08-43b7-9eeb-a428ffba52a6"),

Guid.Parse("77258615-202b-4644-8a52-b78666ba3abc"),

Guid.Parse("241664d9-b837-4b4b-805a-72bfe872e9ab"),

Guid.Parse("a8f09b42-9c6a-49f3-9b83-7ca4ba48c79c"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e9bd7ed5-6d4d-4677-9532-eab5dc141963"),

Guid.Parse("0a9c12de-4459-447a-a137-b84356d7879a"),

Guid.Parse("f1892d79-3a68-49ac-8b51-b36e1063fb66"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5f4b1b23-4c51-4258-a406-f554454158eb"),

Guid.Parse("0149c5ca-9d4c-40d1-a427-0bad12324bea"),

Guid.Parse("947e38fa-ccd5-40f6-a5ac-8edaef6db0ca"),

},
},
            new GuiduuidListD1E2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("40d933ce-a8d1-495b-b3d5-e6f73162188e"),

Guid.Parse("63b68c99-59ec-4bb1-ae54-aa0828c06256"),

Guid.Parse("efd34914-5f38-4220-a460-5727fb4d2e40"),

Guid.Parse("510f29b7-e1db-4b7c-9fa8-bc1967652254"),

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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
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
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 163;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[34], false);
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
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 105, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
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
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 163, query1, 153, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 101, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 153, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 163, query1, 81, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[34], false);
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
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 141, query1, 81, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 67, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 111, query1, 168, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 153, 137))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatch(connection, 72, 33))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 149);
                var models = await ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                GuiduuidListD1E2M.AssertModel(models[0],_testData[28], false);
                GuiduuidListD1E2M.AssertModel(models[1],_testData[29], false);
                GuiduuidListD1E2M.AssertModel(models[2],_testData[30], false);
                GuiduuidListD1E2M.AssertModel(models[3],_testData[31], false);
                GuiduuidListD1E2M.AssertModel(models[4],_testData[32], false);
                GuiduuidListD1E2M.AssertModel(models[5],_testData[33], false);
                GuiduuidListD1E2M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models =  ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                GuiduuidListD1E2M.AssertModel(models[0],_testData[13], false);
                GuiduuidListD1E2M.AssertModel(models[1],_testData[14], false);
                GuiduuidListD1E2M.AssertModel(models[2],_testData[15], false);
                GuiduuidListD1E2M.AssertModel(models[3],_testData[16], false);
                GuiduuidListD1E2M.AssertModel(models[4],_testData[17], false);
                GuiduuidListD1E2M.AssertModel(models[5],_testData[18], false);
                GuiduuidListD1E2M.AssertModel(models[6],_testData[19], false);
                GuiduuidListD1E2M.AssertModel(models[7],_testData[20], false);
                GuiduuidListD1E2M.AssertModel(models[8],_testData[21], false);
                GuiduuidListD1E2M.AssertModel(models[9],_testData[22], false);
                GuiduuidListD1E2M.AssertModel(models[10],_testData[23], false);
                GuiduuidListD1E2M.AssertModel(models[11],_testData[24], false);
                GuiduuidListD1E2M.AssertModel(models[12],_testData[25], false);
                GuiduuidListD1E2M.AssertModel(models[13],_testData[26], false);
                GuiduuidListD1E2M.AssertModel(models[14],_testData[27], false);
                GuiduuidListD1E2M.AssertModel(models[15],_testData[28], false);
                GuiduuidListD1E2M.AssertModel(models[16],_testData[29], false);
                GuiduuidListD1E2M.AssertModel(models[17],_testData[30], false);
                GuiduuidListD1E2M.AssertModel(models[18],_testData[31], false);
                GuiduuidListD1E2M.AssertModel(models[19],_testData[32], false);
                GuiduuidListD1E2M.AssertModel(models[20],_testData[33], false);
                GuiduuidListD1E2M.AssertModel(models[21],_testData[34], false);
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


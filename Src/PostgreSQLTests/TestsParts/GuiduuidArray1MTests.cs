

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
Guid.Parse("e30fa74a-60ae-4176-b958-0baf828fb033"),
Guid.Parse("0f0ac1c9-b1f9-47a8-a034-f05528f2de43"),
Guid.Parse("9ae1daf6-7757-4fbe-835e-d17fb8bf38bd"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 12,
    Value = 
new System.Guid[3]
{
Guid.Parse("acfba07c-2452-49af-94d2-19f1707071be"),
Guid.Parse("2040fd37-785e-4973-9466-3b63b8bf79ad"),
Guid.Parse("39d28087-78be-46c9-adb6-343b359fb75b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 2,
    Value = 
new System.Guid[3]
{
Guid.Parse("4b8c7a5d-ff15-417d-8aa8-837a27b37e73"),
Guid.Parse("6ed423eb-214c-4cfd-8942-0f87a0b22bef"),
Guid.Parse("ef5e178d-a043-431d-8c94-4c42cfe6a67c"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ad8b92d8-f928-4160-a89c-372aef098593"),
Guid.Parse("55ba8ef6-65ed-442f-909f-b679570170b9"),
Guid.Parse("a02e258f-5198-423c-a229-0ddb908708e8"),
Guid.Parse("f8abbf63-c8b5-4143-8cd1-f2efb05dad00"),
},
},
            new GuiduuidArray1M
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("c9740256-2833-40ff-9358-294a02677adf"),
Guid.Parse("8fad35fa-9a88-444c-9a46-019a69b7fd2d"),
Guid.Parse("d5a26c65-0bb4-4ce0-aa63-a039d4d1f072"),
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
Guid.Parse("b4f92a01-16f5-4b0d-94cf-86a534ec5111"),
Guid.Parse("c05f1e45-fa25-4797-92c2-f6739a82063c"),
Guid.Parse("190202be-d222-495a-8861-5e04cf386c78"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 6,
    Value = 
new System.Guid[4]
{
Guid.Parse("0b8c3dff-4c68-468e-9418-0a88dd5d9f78"),
Guid.Parse("2b3f680b-8bb8-408a-a943-900c42116c98"),
Guid.Parse("ee6e491c-a5b1-40b0-b695-6c954db19800"),
Guid.Parse("14f386a2-aa5b-4510-9256-11176f1ba4e8"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fc76df6b-7342-40d1-bef7-c68fc30ed7db"),
Guid.Parse("ecd23a4c-9240-4051-a5ff-fd7c91923d5a"),
Guid.Parse("67c6e48f-f146-4bf8-880e-599cab5ebb97"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 26,
    Value = 
new System.Guid[3]
{
Guid.Parse("6495cb06-d7b4-4d71-90d1-7d480b5cb6ed"),
Guid.Parse("b9aa288b-07ce-4c56-a06d-9e6dcd697ac9"),
Guid.Parse("8ff6dc04-1d73-4a36-b4f1-4068b19c05b3"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("45788249-f037-4f9a-a024-960c9e746a9f"),
Guid.Parse("5bf4f47c-88d1-4957-be35-60a0a8d36fbd"),
Guid.Parse("db3f6eab-4ea1-4263-b44b-089032d90724"),
},
},
            new GuiduuidArray1M
{
    Id = 33,
    Value = 
new System.Guid[4]
{
Guid.Parse("221e763a-3a86-4159-905e-2bd79cf46121"),
Guid.Parse("07e8eac9-8c69-4f2e-9bde-2c31cbf599eb"),
Guid.Parse("99b41b3f-6fa1-4c50-815f-19d00bf77f49"),
Guid.Parse("2de3bcf4-8642-4609-ba9a-a7bc3fcd00ca"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 14,
    Value = 
new System.Guid[4]
{
Guid.Parse("0f2e2a76-6c80-4237-a70b-c1b1d458bc15"),
Guid.Parse("d30fa4ad-bd50-467c-9fcb-22176f442b85"),
Guid.Parse("1564a1f4-aa91-4cd2-91f5-1c2977321cb9"),
Guid.Parse("ee140aff-c056-4ac7-a265-2a19a7ee1b4b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f0af463d-8aa4-49ac-9080-76b0ea5ead74"),
Guid.Parse("6c266bb4-f25e-4bdf-a6d6-3298cf24657c"),
Guid.Parse("d5853843-8bdd-4a78-83a9-82e86398d319"),
},
},
            new GuiduuidArray1M
{
    Id = 38,
    Value = 
new System.Guid[4]
{
Guid.Parse("08818474-2bd6-46f9-98ed-4dd09973f08f"),
Guid.Parse("6fc94744-21f6-4c58-b29c-a288da97ddfd"),
Guid.Parse("28e65169-aa65-44b0-b7d2-9f661da5f252"),
Guid.Parse("d6760fde-413e-49fa-97e5-62fd725f3c81"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 43,
    Value = 
new System.Guid[4]
{
Guid.Parse("28f9e16f-ee81-454f-b520-161e0c533bb0"),
Guid.Parse("9205bb1d-9c2a-41e1-9693-0cb52dbf7466"),
Guid.Parse("ec7b8366-6674-4c43-9457-abf8a55b8a25"),
Guid.Parse("e096506c-6e44-4557-9143-b946dd764d00"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 23,
    Value = 
new System.Guid[3]
{
Guid.Parse("0603e68a-f08d-4cf7-82b6-fd762d09a705"),
Guid.Parse("21f7d986-ba71-494d-abb2-bab5cd757877"),
Guid.Parse("1fc224df-ae09-4008-8c71-58b4548da92c"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d601241a-9815-4494-b954-a11f3e71022b"),
Guid.Parse("d4c46441-a43e-45ac-b8ff-fd7e3908c79c"),
Guid.Parse("187c7631-a994-4747-8b1a-b500b2878724"),
Guid.Parse("c7717c7b-1a87-43ac-8e51-cfb2a2256801"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3e7fefba-9d1b-4f00-ad66-074c2aaeb427"),
Guid.Parse("38ed8c61-55c0-46e2-b158-a22903d26022"),
Guid.Parse("52ca19cc-6120-417b-a536-e7f5cad041f4"),
Guid.Parse("1a7fd351-fefc-49f6-ae7d-b4efb499209f"),
},
},
            new GuiduuidArray1M
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("2ca4d590-c693-4bcd-b9aa-17cd5fb9537b"),
Guid.Parse("64ff991e-cbb5-4fe8-a50c-a0d61ec01f7b"),
Guid.Parse("c56a0c74-b430-4b86-8968-f33a9b1bd08e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a213a05c-ff9d-444a-9be7-6b5cdd31768c"),
Guid.Parse("13ac52d3-061c-4de8-a82c-55199851ae77"),
Guid.Parse("a07427df-a38f-43a2-9b53-2d6acd3a206f"),
},
},
            new GuiduuidArray1M
{
    Id = 54,
    Value = 
new System.Guid[3]
{
Guid.Parse("c6443904-d5d3-4f30-8190-8277929db1a0"),
Guid.Parse("8c3547ec-9eaf-4d3e-85df-d4f6292f1b38"),
Guid.Parse("4fd5062b-319c-4b4e-9ed5-4a619ce67d3b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("32a4a6ac-cbc8-4cf1-a834-79adea1a3625"),
Guid.Parse("9fe02d3b-f1a4-4f93-bddc-4320334f7672"),
Guid.Parse("9ad61713-8f7d-41c9-a7ee-850849d0dfa9"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 63,
    Value = 
new System.Guid[4]
{
Guid.Parse("953e5173-6566-473b-80d8-8d77dfb841c8"),
Guid.Parse("9147523c-0ede-48fa-a489-b3aa90488509"),
Guid.Parse("f0c736f1-c854-40dc-a440-5eaccdc3e024"),
Guid.Parse("fa464149-15f6-4dec-99bc-c16ba09100ea"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 68,
    Value = 
new System.Guid[4]
{
Guid.Parse("f1ffbcd1-856e-4d9d-b7fc-30cb13686aba"),
Guid.Parse("aa22a6a1-cb7f-47db-a658-13e64150a28e"),
Guid.Parse("a961cc80-54a1-48df-b13e-de468baa9c04"),
Guid.Parse("30d1ea4a-a17d-4d1f-b93b-1e6e988f607b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 31,
    Value = 
new System.Guid[3]
{
Guid.Parse("3a1c7227-9413-4bea-9f19-d988103fdf7c"),
Guid.Parse("1342c654-e8af-47b2-a65a-afbcfe11ecc5"),
Guid.Parse("ff6ac14c-3e80-4450-a800-fef79555220f"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("78f907ce-aa3e-4de8-9e1f-bb75680541d3"),
Guid.Parse("2476c84c-bcf1-4d88-bb04-f21d17383a0e"),
Guid.Parse("38baa40b-f4f2-410d-9ecb-9315ec601eac"),
Guid.Parse("99143803-1c2b-44bb-b98f-655f3ca75502"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fe24a7bd-a322-4365-b708-42e1bc797c11"),
Guid.Parse("0eb801db-53d0-4ff7-85de-6d0bb03813c3"),
Guid.Parse("75c79730-c89d-4697-86e6-54495a941ab0"),
},
},
            new GuiduuidArray1M
{
    Id = 80,
    Value = 
new System.Guid[4]
{
Guid.Parse("e45faa16-81c3-43c7-bacf-8e9e245da177"),
Guid.Parse("9081cf8e-1daa-41b1-a8ed-bea2b2dea8b5"),
Guid.Parse("dcdd9492-293f-465b-9037-d820a9b038d4"),
Guid.Parse("c8747334-3eee-454c-b2cd-7136872e3142"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 38,
    Value = 
new System.Guid[3]
{
Guid.Parse("d32a1f98-41c1-4942-8e2b-4d3c1f3bad4e"),
Guid.Parse("f161ffb7-61a1-4436-a10e-d8a41f602996"),
Guid.Parse("ec9175c6-40b5-411d-9799-b61fc15a930d"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("84cb56fe-6f7f-4c29-8dc8-acb07a61e1d2"),
Guid.Parse("f4d98ab4-e62c-42f0-b310-6d0c5f050959"),
Guid.Parse("d988e71a-c4de-48f4-a91e-e2adcaf43b35"),
},
},
            new GuiduuidArray1M
{
    Id = 82,
    Value = 
new System.Guid[4]
{
Guid.Parse("f6fc626d-2062-40c8-b6cb-8fd905a0f106"),
Guid.Parse("e3b34a6c-6fe6-4ab8-a2a7-911a2d20818e"),
Guid.Parse("c3c3b1a9-ea0f-44de-a937-ca7219cb7032"),
Guid.Parse("f6edad55-4d93-4ee5-b5ea-1967910ab212"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 85,
    Value = 
new System.Guid[4]
{
Guid.Parse("ff9ad6c5-8cdd-41d3-b614-8d2e16589456"),
Guid.Parse("b4cfc1c9-e3e0-477e-9196-9b1cd0534abd"),
Guid.Parse("44cbaea1-2975-4cfa-b67f-1122579c65d3"),
Guid.Parse("e4459115-710a-4d44-b509-b5fe145c1e80"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 43,
    Value = 
new System.Guid[4]
{
Guid.Parse("6f880059-0064-4f0b-a777-1fea7e33ce4d"),
Guid.Parse("b54e3568-77e5-40e0-a9f6-530a050d1fad"),
Guid.Parse("8b6e802a-ee91-412d-99b6-9e2658f26446"),
Guid.Parse("32d214ad-58cf-4aa0-b657-db3428a25eb4"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f55f51ef-6439-4802-a9dd-4d7e0e20f1d1"),
Guid.Parse("ba77f8d6-10fa-4a37-9edc-7a0cb92971f5"),
Guid.Parse("0ba681c9-401a-4c0c-86aa-5f3cd460fa0f"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("74003643-7da7-4efb-ba10-f59429a69e50"),
Guid.Parse("b6c44b83-2c77-48e9-bcb7-b76bbf7ab758"),
Guid.Parse("113ed38c-5dce-487c-99ff-6ec182ae72b8"),
},
},
            new GuiduuidArray1M
{
    Id = 94,
    Value = 
new System.Guid[3]
{
Guid.Parse("cf7825f0-7d55-4ac0-bd91-79ba002c58d4"),
Guid.Parse("7552d78d-5af0-4401-bff6-07b22a800ab1"),
Guid.Parse("68aafdac-040e-4935-935b-fc6d95150710"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 96,
    Value = 
new System.Guid[4]
{
Guid.Parse("ec73b902-1c48-4140-8a01-e0c89f664d93"),
Guid.Parse("db9b115f-e381-4ff9-94a7-0a5c90bff3bf"),
Guid.Parse("d4afa2f8-5b50-4acd-8087-fb2aa9cdf9be"),
Guid.Parse("7487fa68-23a8-4eac-9b50-dbe7151b826f"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 48,
    Value = 
new System.Guid[3]
{
Guid.Parse("9552d783-9de1-409a-8fc3-28e8fd227b4c"),
Guid.Parse("dedc182d-f736-446d-a8fa-5ffa6d7300cb"),
Guid.Parse("7d69b436-497b-412d-b40c-188f9265e071"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("06fa5e2c-8ba4-4d28-859f-4d5a0b96ce97"),
Guid.Parse("abc6eb45-c5de-40e7-8ff1-9a3dbb97e297"),
Guid.Parse("bedb4551-975d-4bf7-9a24-b9992636d18d"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7da79eb8-3ddb-40b9-9887-b2077e02a1ea"),
Guid.Parse("72c98b3f-8e53-4fe6-a064-bc2515a5259c"),
Guid.Parse("2b7a3f94-5ab1-4f36-822c-d32d7b211857"),
},
},
            new GuiduuidArray1M
{
    Id = 103,
    Value = 
new System.Guid[3]
{
Guid.Parse("7fa40979-3d91-4954-b1c2-25333026a95f"),
Guid.Parse("db14f378-5917-4084-a9d3-7cc8a4124bc3"),
Guid.Parse("6c71252d-8711-481a-bd4d-313296ec1525"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("51be93c2-0b0d-4f8f-a29c-078e0d5489c1"),
Guid.Parse("a8aa23ae-c382-4edf-9a7b-218b3f6a228c"),
Guid.Parse("6c258a88-06df-4ae8-af19-b69ac07cf873"),
Guid.Parse("f1b1349e-e516-47aa-ba0c-f0e5c98bd0d4"),
},
},
            new GuiduuidArray1M
{
    Id = 104,
    Value = 
new System.Guid[3]
{
Guid.Parse("3404b024-a531-422f-95ed-06f6b2851452"),
Guid.Parse("3f05d8b7-160c-487f-b536-121de9e7a975"),
Guid.Parse("8a47a33b-ee43-4ef3-9af6-6df717235992"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 56,
    Value = 
new System.Guid[3]
{
Guid.Parse("4e0bef7e-9f2f-47bc-9015-7d007e86e4fb"),
Guid.Parse("e833db2f-ceac-47bc-87ba-326829450ebe"),
Guid.Parse("b3572ac0-e20d-46ff-8623-b53df5abfb86"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8ba8aa09-c2ab-4de3-9f3b-b874701aced7"),
Guid.Parse("0f561458-5e0f-4f21-9473-3af84be23678"),
Guid.Parse("44840c3f-74ef-4a06-821b-27df5d1cc69a"),
Guid.Parse("3835ee52-1192-444f-ba81-ad767af42516"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 106,
    Value = 
new System.Guid[4]
{
Guid.Parse("8a7293bb-8295-4bdc-b88b-dc3350a3bd01"),
Guid.Parse("a375aa7a-8270-4e6b-96dd-1b61c0427880"),
Guid.Parse("2418cd00-01a0-4fb1-833a-238ef1738adf"),
Guid.Parse("92d0fbd3-3f77-47cd-b71d-69daa1236304"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2df41d4a-9820-41ec-9cd4-002d0f7dba16"),
Guid.Parse("93852e0f-5cfe-4ee1-b3e4-0d3924dd3a70"),
Guid.Parse("8d3083fb-838d-4205-b455-ab56aed4a918"),
Guid.Parse("285b3b98-ea06-461f-8ba4-7542ddb6955d"),
},
},
            new GuiduuidArray1M
{
    Id = 111,
    Value = 
new System.Guid[3]
{
Guid.Parse("836edf7f-a6c8-474a-90e5-ec847617e54d"),
Guid.Parse("fa6819e9-3a94-4862-b430-c31f00c5c3aa"),
Guid.Parse("e9b6cef4-5144-4559-831b-2ca8f2219ce5"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 64,
    Value = 
new System.Guid[3]
{
Guid.Parse("4f7eb586-b424-43aa-b1fb-acf6f077ff6b"),
Guid.Parse("0957a460-0325-449f-bcb6-47211cc35a9a"),
Guid.Parse("3f1b0a66-741c-4b5b-94a4-6150fb3a066b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c7f96105-84ba-4278-8e3f-bca42adb58e5"),
Guid.Parse("044601f0-8936-4f70-ae31-d7a5b61f2976"),
Guid.Parse("a57f729e-73c2-4a29-a0ff-2620f938b220"),
},
},
            new GuiduuidArray1M
{
    Id = 116,
    Value = 
new System.Guid[3]
{
Guid.Parse("e0ac7f1c-0198-421d-be9b-a3fc71a78017"),
Guid.Parse("a3744bb0-d061-4bc3-bf5f-95b7b94006a2"),
Guid.Parse("f8e366ae-aefa-4940-b08c-3443b0ab9843"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a5302b9f-8607-4056-bce0-f420ad4d15b0"),
Guid.Parse("6bf1b557-a348-4064-89f2-0a557f014788"),
Guid.Parse("4a49e110-3cbf-4cb5-b041-130b25fb3791"),
},
},
            new GuiduuidArray1M
{
    Id = 124,
    Value = 
new System.Guid[4]
{
Guid.Parse("37e0245f-47f5-487f-bc4e-aaa7e9597d08"),
Guid.Parse("93f5dbe8-f42a-411e-b353-dfa432b1878a"),
Guid.Parse("d8563db7-d24b-4137-a1f1-f9fea09f19b0"),
Guid.Parse("d9411ca6-3205-4f1f-8614-9a825d9aecd9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 67,
    Value = 
new System.Guid[3]
{
Guid.Parse("9b2c25c8-041b-4e06-bd82-740f9629d12f"),
Guid.Parse("dcc51df2-d339-41dc-9597-0ebe308733e0"),
Guid.Parse("9ca0ef2d-cae0-4547-9f4e-ab2295b03a3d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("84f955b7-8ab2-46b3-adc4-045b76d9fd58"),
Guid.Parse("c04853d7-836b-48ec-962a-088ba9539ded"),
Guid.Parse("beb05a61-e57b-4904-9304-fdcb770d7d7c"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 128,
    Value = 
new System.Guid[3]
{
Guid.Parse("3a6f8499-94c3-4a68-8c84-e2c047b19ed2"),
Guid.Parse("1f34462f-d40b-48ec-bde1-dec1959ccd71"),
Guid.Parse("263befff-f71d-4153-bba0-a4826134f099"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 134,
    Value = 
new System.Guid[3]
{
Guid.Parse("f28627ae-bd41-437e-bdc6-4e65cb47df97"),
Guid.Parse("c384f8fe-fc77-45b9-b44b-b6eaf25a1064"),
Guid.Parse("13c7af73-e6b7-4e9f-9f49-7335ac86a821"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 76,
    Value = 
new System.Guid[3]
{
Guid.Parse("0ef23264-5657-466e-8896-019e43a17355"),
Guid.Parse("4158fc88-81d1-47d0-b9d5-c425321486aa"),
Guid.Parse("b9ab5b68-4611-4b1b-8a73-762817311ab4"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("88cc5b74-c110-425d-9567-3c056ce180b8"),
Guid.Parse("0ea733b4-83f3-493b-a5fd-0aeabf07552d"),
Guid.Parse("e1e07229-02d8-4db4-b598-667bb7662511"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 141,
    Value = 
new System.Guid[3]
{
Guid.Parse("401ccd7e-9cd7-4e13-bf35-8ff7404eed15"),
Guid.Parse("c2ca4488-cd7d-44bd-99df-95acfd8fb1dd"),
Guid.Parse("1bde8c28-15fd-4f59-af8a-ef466814049f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("19834d77-8ee5-445d-a3c9-f99568485090"),
Guid.Parse("1b24a7e3-0bdc-4294-9a1c-af8773316d76"),
Guid.Parse("4b9dadc7-c137-4c25-bfad-9af12a6038b4"),
Guid.Parse("0b58cfa3-eb43-4280-bb71-1c3e0b6f2b78"),
},
},
            new GuiduuidArray1M
{
    Id = 146,
    Value = 
new System.Guid[4]
{
Guid.Parse("77ae61e6-5137-46de-8063-a6885cfc6b73"),
Guid.Parse("8f6457af-f288-41d5-9d09-232d1fba5ed1"),
Guid.Parse("982a014b-7d6d-483a-b021-32f4b2ac9bfb"),
Guid.Parse("33658618-44fe-41ca-9f7e-70d7d15c4c24"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 83,
    Value = 
new System.Guid[3]
{
Guid.Parse("23a17e59-d784-4f21-adf0-aa7a890a00eb"),
Guid.Parse("4e67a637-12b7-40eb-ae1e-faa468f15985"),
Guid.Parse("8e27391c-59ec-4c79-b31f-0ee3036cb912"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0ce5cc7a-2947-4283-b0c5-1ff7944bc2c3"),
Guid.Parse("15280815-b5ee-4147-b509-8160382658fc"),
Guid.Parse("af04df3c-6845-4f02-81cf-aef3c83c57fb"),
Guid.Parse("da03daf2-6e66-4303-a19f-df04f5381a1a"),
},
},
            new GuiduuidArray1M
{
    Id = 151,
    Value = 
new System.Guid[4]
{
Guid.Parse("3a331220-1422-4a1a-969d-5feaf47d914d"),
Guid.Parse("3e8b81a9-ab44-4e59-acaf-600b3cfeae5d"),
Guid.Parse("4cf29c24-96a0-4a36-a5be-25331fa17389"),
Guid.Parse("bb154871-faf7-4466-afe2-9e5bde14d75c"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 155,
    Value = 
new System.Guid[3]
{
Guid.Parse("e5c91972-f1a0-4e5d-a8b0-773cfaed49d6"),
Guid.Parse("16b9d117-f26f-4aa9-ac63-818a06ed476d"),
Guid.Parse("5809b828-3d6e-47c9-bc91-3e2af5b1cebf"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 89,
    Value = 
new System.Guid[3]
{
Guid.Parse("5615ee15-8148-4820-9310-a602dfd05b6d"),
Guid.Parse("06a50dcd-f5ff-408d-bf78-7c97ef92dd16"),
Guid.Parse("5c46c3a5-0b06-4ee8-b439-01bdf9be2fb1"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 156,
    Value = 
new System.Guid[4]
{
Guid.Parse("710bd5aa-a9b4-462b-a595-6fbbbcd1efd7"),
Guid.Parse("559fb5c9-a515-442d-9826-41f0b44b3786"),
Guid.Parse("9b5e55c6-b4ae-4973-8e0e-8ed09dd611f1"),
Guid.Parse("46871702-b60f-4830-b477-33dcaa15ebca"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("966f5de9-389b-4b76-a0d3-dc256f5dfeba"),
Guid.Parse("7e2ed551-8b88-4f5d-874d-68e6e38cc04c"),
Guid.Parse("eec29cbe-2707-4c4e-a071-b3882a5941b2"),
Guid.Parse("bdaf25e1-3411-4306-a8c4-abf35277749b"),
},
},
            new GuiduuidArray1M
{
    Id = 161,
    Value = 
new System.Guid[3]
{
Guid.Parse("d94679a1-ef6e-4e93-af40-1a660f2f65f9"),
Guid.Parse("d6d222c0-b7a5-4e68-bf56-5b44792c73ba"),
Guid.Parse("36424196-23c7-4ef1-ac5d-8876cb7247c9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 90,
    Value = 
new System.Guid[4]
{
Guid.Parse("928f0011-1d6c-4c73-9ebf-762991c40cfd"),
Guid.Parse("c1f4189a-2b00-43f6-9b21-e9ce566b25bc"),
Guid.Parse("cd85760c-2faf-437e-9a70-402e2b986414"),
Guid.Parse("38b31d22-3c4f-4ed4-8981-ac5eeba0d7b2"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a9b4e0be-66a5-4f6e-a073-916e1b81ed73"),
Guid.Parse("67198c2a-c962-42d6-820d-82226d289d6e"),
Guid.Parse("08207a99-dab0-4dc8-af47-93e0ca1da11f"),
Guid.Parse("329b0202-0547-42be-8224-0ee5f685a228"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 162,
    Value = 
new System.Guid[4]
{
Guid.Parse("f4c42d68-e277-403b-b948-1e2e6fe749ca"),
Guid.Parse("b085fb29-4424-443f-a3d0-e30a84eaae70"),
Guid.Parse("c1a18651-605c-4be7-8c68-2840db0a6620"),
Guid.Parse("f21d7812-acbd-4151-8222-b9067016f224"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("52424886-a9de-4d06-af06-2501b7bbb11c"),
Guid.Parse("0635d5e1-5abe-4ff5-9867-5e2e218c58cf"),
Guid.Parse("0139b9d1-ee71-47a4-b2e2-0fb7f6a94a92"),
Guid.Parse("ea8e380c-87a4-4151-bd47-0e8a59bb8f47"),
},
},
            new GuiduuidArray1M
{
    Id = 167,
    Value = 
new System.Guid[4]
{
Guid.Parse("611fad83-24b1-451f-855c-ccc2a6b1d08a"),
Guid.Parse("e4c841a0-5362-499f-94fc-ee8e9dd37462"),
Guid.Parse("1e4795b4-6a13-404c-a7c9-c97cee029798"),
Guid.Parse("84ab7582-2415-4acb-8fa3-ba3285a26ce8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 98,
    Value = 
new System.Guid[4]
{
Guid.Parse("987dd346-acc0-43fb-8e6e-663250ced5ad"),
Guid.Parse("f825587e-fe92-441a-a5f6-7fb08a3022ff"),
Guid.Parse("f32c52c8-b1b8-4eaf-938f-914b0f4feb7a"),
Guid.Parse("3ffe9bd8-385f-495e-ae65-b8eead45df1f"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("32f03941-2e1c-4ad6-a2f0-a1aa1836c65d"),
Guid.Parse("91c01bb9-fb4d-44d9-a8f8-974d301af215"),
Guid.Parse("358f2ede-4641-44e3-a135-99cdd2000c44"),
Guid.Parse("4fea926c-528e-443d-a5b9-9d6a5f90bb78"),
},
},
            new GuiduuidArray1M
{
    Id = 170,
    Value = 
new System.Guid[3]
{
Guid.Parse("1dcd1af9-4e38-44b1-81b0-8ea4abd5b1c0"),
Guid.Parse("49d8d65f-1693-4f32-a155-2d9605319edc"),
Guid.Parse("a7a7e967-9ce6-44e3-9436-bfda4ec1b235"),
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
Guid.Parse("45788249-f037-4f9a-a024-960c9e746a9f"),
Guid.Parse("5bf4f47c-88d1-4957-be35-60a0a8d36fbd"),
Guid.Parse("db3f6eab-4ea1-4263-b44b-089032d90724"),
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
Guid.Parse("f0af463d-8aa4-49ac-9080-76b0ea5ead74"),
Guid.Parse("6c266bb4-f25e-4bdf-a6d6-3298cf24657c"),
Guid.Parse("d5853843-8bdd-4a78-83a9-82e86398d319"),
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
new System.Guid[4]
{
Guid.Parse("3e7fefba-9d1b-4f00-ad66-074c2aaeb427"),
Guid.Parse("38ed8c61-55c0-46e2-b158-a22903d26022"),
Guid.Parse("52ca19cc-6120-417b-a536-e7f5cad041f4"),
Guid.Parse("1a7fd351-fefc-49f6-ae7d-b4efb499209f"),
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
new System.Guid[3]
{
Guid.Parse("a213a05c-ff9d-444a-9be7-6b5cdd31768c"),
Guid.Parse("13ac52d3-061c-4de8-a82c-55199851ae77"),
Guid.Parse("a07427df-a38f-43a2-9b53-2d6acd3a206f"),
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr2.Value = 38;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[34], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[34], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 12;
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
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[32],_testData[34], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 13, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 38, query1, 49, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 54, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 49, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 80, query1, 161, query2))
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 12, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[32],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 54, query1, 161, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 13, query1, 162, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 68, 43))
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 116, 104))
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
GuiduuidArray1M.AssertModel(models[0],_testData[22], false);GuiduuidArray1M.AssertModel(models[1],_testData[23], false);GuiduuidArray1M.AssertModel(models[2],_testData[24], false);GuiduuidArray1M.AssertModel(models[3],_testData[25], false);GuiduuidArray1M.AssertModel(models[4],_testData[26], false);GuiduuidArray1M.AssertModel(models[5],_testData[27], false);GuiduuidArray1M.AssertModel(models[6],_testData[28], false);GuiduuidArray1M.AssertModel(models[7],_testData[29], false);GuiduuidArray1M.AssertModel(models[8],_testData[30], false);GuiduuidArray1M.AssertModel(models[9],_testData[31], false);GuiduuidArray1M.AssertModel(models[10],_testData[32], false);GuiduuidArray1M.AssertModel(models[11],_testData[33], false);GuiduuidArray1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
GuiduuidArray1M.AssertModel(models[0],_testData[13], false);GuiduuidArray1M.AssertModel(models[1],_testData[14], false);GuiduuidArray1M.AssertModel(models[2],_testData[15], false);GuiduuidArray1M.AssertModel(models[3],_testData[16], false);GuiduuidArray1M.AssertModel(models[4],_testData[17], false);GuiduuidArray1M.AssertModel(models[5],_testData[18], false);GuiduuidArray1M.AssertModel(models[6],_testData[19], false);GuiduuidArray1M.AssertModel(models[7],_testData[20], false);GuiduuidArray1M.AssertModel(models[8],_testData[21], false);GuiduuidArray1M.AssertModel(models[9],_testData[22], false);GuiduuidArray1M.AssertModel(models[10],_testData[23], false);GuiduuidArray1M.AssertModel(models[11],_testData[24], false);GuiduuidArray1M.AssertModel(models[12],_testData[25], false);GuiduuidArray1M.AssertModel(models[13],_testData[26], false);GuiduuidArray1M.AssertModel(models[14],_testData[27], false);GuiduuidArray1M.AssertModel(models[15],_testData[28], false);GuiduuidArray1M.AssertModel(models[16],_testData[29], false);GuiduuidArray1M.AssertModel(models[17],_testData[30], false);GuiduuidArray1M.AssertModel(models[18],_testData[31], false);GuiduuidArray1M.AssertModel(models[19],_testData[32], false);GuiduuidArray1M.AssertModel(models[20],_testData[33], false);GuiduuidArray1M.AssertModel(models[21],_testData[34], false);
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


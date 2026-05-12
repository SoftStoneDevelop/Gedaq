

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
    internal partial interface IGuidMArrayuuidMMArrayD2
    {
    }
    
    internal partial class GuidMArrayuuidMMArrayD2 : IGuidMArrayuuidMMArrayD2
    {


#region TestData

        private readonly GuiduuidMMArrayD2E1M[] _testData = new GuiduuidMMArrayD2E1M[]
        {
            new GuiduuidMMArrayD2E1M
{
    Id = 3,
    Value = 
new System.Guid[,] { { Guid.Parse("bd403d90-722d-42a4-b0f0-46f22a8120d5"), Guid.Parse("c50f44c9-3923-4ac5-a87f-4629d965c2c0"), }, { Guid.Parse("ebdceca3-5354-4146-919d-0e70f1cc6fe6"), Guid.Parse("553c49c4-3039-4802-9c01-39140da451f7"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 6,
    Value = 
new System.Guid[,] { { Guid.Parse("4dd46122-d530-423f-8cae-643dd3082f5e"), Guid.Parse("dd81f588-75b1-48bf-b08d-6dcf1b3105d5"), }, { Guid.Parse("f67642e0-ae42-4ef4-8442-9fd2e7e2f355"), Guid.Parse("e5d6f9a8-8254-4532-94d4-ebdf0f293962"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.Guid[,] { { Guid.Parse("44ffb126-a58d-43d8-9266-048f5803f99d"), Guid.Parse("b5b84542-d801-48be-b03c-cafc7ea020e4"), }, { Guid.Parse("40044523-4ebf-4eaa-813d-325cc012745c"), Guid.Parse("3e5d1198-77d2-4963-a34d-d7173db15b7c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4e5194ea-a9d0-4923-abed-32a6ccc99cfd"), Guid.Parse("2f74668b-7c8b-46d7-9959-74638e322f08"), }, { Guid.Parse("568844c0-28b8-4617-aa62-2294995e3e75"), Guid.Parse("3e68a633-c7e3-4caa-9b66-29afcb684230"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("55f68153-993f-4fb4-9d60-9f501d21eb7d"), Guid.Parse("17dd192a-cf9a-4db2-8041-c01533a03792"), }, { Guid.Parse("14b13db2-ccfb-4d70-89f6-c4c416a0979b"), Guid.Parse("efc7a577-6d52-428e-9d36-6f5654aa9387"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 7,
    Value = 
new System.Guid[,] { { Guid.Parse("38c5c261-f38d-4a30-a9c1-552e17a2d59d"), Guid.Parse("7619f0ca-cb49-4d5f-9ea2-a8b888e7a8c3"), }, { Guid.Parse("8888e767-be8b-4b9c-a8eb-8b4512b1ba1d"), Guid.Parse("0dc737c1-6071-4599-8e3e-b89739dad3bd"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Guid[,] { { Guid.Parse("2f5f2dee-1cb0-4b5d-a825-66a8faace53c"), Guid.Parse("e81f7ae8-77cc-4d5c-ad07-fd05fa13a791"), }, { Guid.Parse("adc99594-1849-451c-96a8-0e9bf7f2208f"), Guid.Parse("3d944a52-ec66-4826-bbf2-e53fa455a723"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 3,
    Value = 
new System.Guid[,] { { Guid.Parse("edc0bb57-c7da-42ad-bfa5-27e0dbee6345"), Guid.Parse("4d9c0337-fd00-4199-a74a-802a914be5a1"), }, { Guid.Parse("393ed3e2-451d-4a07-8880-70e4810fde23"), Guid.Parse("d7917a34-e74c-46e6-8d38-57d91c593e7e"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ebc984e5-9965-4f39-826e-0e589d4151d3"), Guid.Parse("81adeec1-904f-407d-b40a-204de086d8fd"), }, { Guid.Parse("c76db4f3-89c7-4348-8c53-986e05c0466b"), Guid.Parse("0c6a64d1-503b-48fa-9bf4-a1c203455ea7"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Guid[,] { { Guid.Parse("544aeb12-8fe2-447b-92f6-89182f522b02"), Guid.Parse("2c3e3b6b-82b8-44d0-9986-1971ff0c53ca"), }, { Guid.Parse("b2c1bf16-493f-4fc2-b6a3-8af61ae2335c"), Guid.Parse("322973c5-99ec-4d13-b843-7f1a7abd1598"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4734bee1-1f7e-4db5-a7d1-513a9b404e48"), Guid.Parse("ec573e94-4fd0-49ce-ad43-c06f00be50c5"), }, { Guid.Parse("42ea9115-b08a-4318-aace-e964b3514112"), Guid.Parse("967e2cb8-8e53-46aa-8d79-8ef24044eb76"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Guid[,] { { Guid.Parse("4b5c53b5-50e3-495e-8d8a-46d64a296c22"), Guid.Parse("5a4a02c3-1a14-46be-a16d-ae848d348982"), }, { Guid.Parse("33b3b6ae-0977-4dc6-8927-1a965057b7ee"), Guid.Parse("bee79231-30ca-489c-bc1a-588dddc736b4"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 11,
    Value = 
new System.Guid[,] { { Guid.Parse("55c10992-570f-4eee-9e47-2d668f09d4a1"), Guid.Parse("c2a778fe-0b87-4dc3-ab3a-c041b100b1d6"), }, { Guid.Parse("e4ed9541-0569-4a9a-a754-e1a548580399"), Guid.Parse("743c3093-4b88-48f8-8469-5bfa3b212180"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c5604137-38a2-4220-9f45-04fd9aa1ed23"), Guid.Parse("c8273a27-4ec1-4d9b-b720-480368d3b4cb"), }, { Guid.Parse("aac472bf-f234-43f6-ae22-46a5a2ff1e22"), Guid.Parse("37d2be02-00e2-40d5-ba16-b0a7f5476fa9"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Guid[,] { { Guid.Parse("e48cd4b2-9e83-4969-af76-b5791ee6a707"), Guid.Parse("03a32e5d-25b1-4de0-9d8e-75e22e14517e"), }, { Guid.Parse("fc718057-8850-41be-8422-4067b8ab63a4"), Guid.Parse("a9aa1d92-39dd-4b3d-8620-822a079b0841"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("1b406e10-5853-4fd0-8a85-4c6179bf90b5"), Guid.Parse("bfd4b880-798a-4a38-9e5a-80b0077b815b"), }, { Guid.Parse("baed991b-fee6-4181-ac38-d2260682f029"), Guid.Parse("75d1416e-951a-4c80-b22b-20d27aa5188c"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Guid[,] { { Guid.Parse("b7669a5a-49e9-4c82-b992-c32836c23235"), Guid.Parse("6956056a-fb73-483a-955a-6fa9f54048cd"), }, { Guid.Parse("cb38d0a7-6135-454d-bb0a-e4f5d881e49a"), Guid.Parse("5300ceba-0ce7-4345-ac59-6f7751d8dcc0"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Guid[,] { { Guid.Parse("bacc8d9b-682c-44f4-a1f5-b38145bdd32a"), Guid.Parse("8e24ea0c-97b9-48b5-ba24-0931afec5d95"), }, { Guid.Parse("e98f16c4-e659-47aa-b843-42785f2bbef1"), Guid.Parse("e1a7c1a1-c697-4139-936d-d71227cfbf23"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 42,
    Value = 
new System.Guid[,] { { Guid.Parse("8700b475-6324-403c-b586-26f3adf49b04"), Guid.Parse("6a1bb456-411b-49ff-8c2a-cd5361a11926"), }, { Guid.Parse("9542498a-c1e3-4015-8310-945b96f56855"), Guid.Parse("fa1b9834-f719-4642-a9bb-424484b6ad29"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("57ed977a-8150-46f7-8795-90732440e6a7"), Guid.Parse("c18fa2c9-3b56-4c0e-ae6d-427d4fe99af6"), }, { Guid.Parse("883f776b-1cf8-4189-ab53-151727ee6b6d"), Guid.Parse("5569dc75-c068-409c-83fd-304f31a30a72"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 50,
    Value = 
new System.Guid[,] { { Guid.Parse("2d832b85-d4d8-47d4-b07a-da6918ad40cf"), Guid.Parse("03f6fe15-6a22-45d2-9bb6-94d3751e4b65"), }, { Guid.Parse("1029559c-6f14-4f9c-b3fb-9d338e351a9c"), Guid.Parse("de3b6ed3-4e55-42d2-961b-922d17d97fba"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Guid[,] { { Guid.Parse("f42471c8-ee57-4fde-94dd-29c0752545f6"), Guid.Parse("9c8f1619-0ebe-406b-bd8d-93895c7f0f9b"), }, { Guid.Parse("93c94094-f353-4c6f-be68-0aaddaf6a464"), Guid.Parse("b971d22b-cc53-40a6-85f1-ea69971e178e"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("a327107f-2437-4292-a620-ac69b05ae3e9"), Guid.Parse("d0d9ef5b-61b5-4c26-bcc1-4f8da5acfefe"), }, { Guid.Parse("a899f2df-135f-4db1-add7-73000acddb43"), Guid.Parse("8ea9d2c4-f787-4263-9e48-72d65669fb18"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Guid[,] { { Guid.Parse("cfc11691-467c-411e-a31f-85c590f4e132"), Guid.Parse("e85acabe-8821-4f5d-b27e-d59f8e62937e"), }, { Guid.Parse("1fa01add-e8d4-40a5-b265-eab0ec60ef4a"), Guid.Parse("f9baf428-a7a8-43e6-a973-1c0075cc0c5c"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 61,
    Value = 
new System.Guid[,] { { Guid.Parse("5f1bf24e-d55e-400a-9d36-6817933535d7"), Guid.Parse("ef003d46-7b9e-41c0-b576-e188cee358bd"), }, { Guid.Parse("023be55f-333f-49d3-a762-f16d47199c13"), Guid.Parse("9b51f975-2dcf-410a-9e57-2674b21720b3"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 23,
    Value = 
new System.Guid[,] { { Guid.Parse("88300fbd-bce0-4031-a0e0-926e58a62d64"), Guid.Parse("6b3ad513-b5ff-4ac1-942f-2791ad126ba4"), }, { Guid.Parse("77088912-23a1-4f57-93cb-05e294e1833c"), Guid.Parse("24ea842a-a213-4b0d-83d8-8fd910e72405"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("223fafd7-4d0b-46c7-86a7-1d6b1c3319f0"), Guid.Parse("b0b105fd-2e20-42dc-b322-e338e63cdfb0"), }, { Guid.Parse("0bf5820a-c2a3-4108-9f24-66c66dece2a5"), Guid.Parse("2fedc2a6-a4ff-4c64-b244-07eb2439e8c4"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 64,
    Value = 
new System.Guid[,] { { Guid.Parse("f1b43f2d-369c-4c7d-a311-11ae63adaaef"), Guid.Parse("f705ed74-ad6b-461a-900c-2454e6d336e1"), }, { Guid.Parse("3457ec24-d08a-47be-9317-4d52cf2c4afc"), Guid.Parse("263f22f5-bff5-45bc-a291-99fa821f74cf"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("dea60e4e-f766-4598-9357-4ebb08c61cfb"), Guid.Parse("e577d8d7-4ec0-4097-9d88-5cdf29aa53b0"), }, { Guid.Parse("c21482d2-92dc-4b39-8f34-6428053fd559"), Guid.Parse("f05863d6-7d59-4531-89a2-b1c1c28f3266"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 72,
    Value = 
new System.Guid[,] { { Guid.Parse("4e540415-c28c-45c0-870b-5eb0f800eef5"), Guid.Parse("a083cca5-c8a9-4cc3-9d4e-0c00d13ab7e3"), }, { Guid.Parse("e97e9f87-206a-43b4-8f8a-f6e2d5260392"), Guid.Parse("a9aa5325-65d0-4123-9f21-c2ff205552d9"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Guid[,] { { Guid.Parse("b7036df5-a8d9-4e1d-ab98-128ab9b947e9"), Guid.Parse("cbf959c5-49dd-448a-ace2-9a3ff67d063d"), }, { Guid.Parse("581785be-4cd8-4094-9494-0a392b5fa8b4"), Guid.Parse("09a709ad-ce83-47ef-a1ba-69b385a35b8d"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("528e737c-7a21-4218-a2d9-4528053872a9"), Guid.Parse("c7535c77-1cd6-4abf-891c-73b106f56370"), }, { Guid.Parse("c8bce89e-d583-43e7-9703-5989bd563e6e"), Guid.Parse("83abdff3-8146-47c8-94bb-7de5720b6558"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("2df88e9d-97ee-4c4f-ba16-1880af8f5533"), Guid.Parse("64b95b99-fc5e-442a-a56c-4c6d13d5b7c0"), }, { Guid.Parse("d8598e8a-7843-4b7d-b711-db22c47627cf"), Guid.Parse("0a0828e9-f6e9-4c92-9115-50b08c7018b3"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4aadbe76-514d-4679-9d98-51e2bf4382a7"), Guid.Parse("cd5ceef1-169e-486b-9187-d42900aedb4e"), }, { Guid.Parse("63befe81-8269-42a7-bece-9d00f7afec3f"), Guid.Parse("794e2564-41d7-476c-8afe-43068a3f79fc"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Guid[,] { { Guid.Parse("0aaf2332-018e-4aa2-b940-eee32141d5d2"), Guid.Parse("7dacd6fb-e2a1-462e-a2d5-010fde8ed740"), }, { Guid.Parse("44903f4a-1b03-4654-9025-4c3b2354bca6"), Guid.Parse("8a714a39-e345-4536-825c-8e5d5f7fda19"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 35,
    Value = 
new System.Guid[,] { { Guid.Parse("7fd99ea0-707e-4522-b90a-fe5139970f6b"), Guid.Parse("cb8018dd-f1f3-4ae4-b257-ae02d5a22099"), }, { Guid.Parse("3aa7344d-05bd-4fb5-81f0-a58c6a98e70e"), Guid.Parse("2d8bf0fe-2111-490b-b9ce-0602c4e95073"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("81e7b013-3cb8-4272-9ead-e70fe04467ef"), Guid.Parse("350a79d7-37d0-4290-84b9-75d9149608df"), }, { Guid.Parse("75c25d9f-6499-4b81-bfd9-a1333d8e22c4"), Guid.Parse("4aceeb82-09ad-42e6-bedc-a8edcd02d253"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Guid[,] { { Guid.Parse("83d418af-6036-4b37-bb60-aeba2f8f2812"), Guid.Parse("b58001b9-53a5-43cb-a18c-14370a1ac72e"), }, { Guid.Parse("ce809bdc-f3d0-4d62-be3c-fff1567a841c"), Guid.Parse("ad6f3df0-7245-4de2-965b-44f707e672b9"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5972d274-7c13-4ff8-b27e-dfe21229a79a"), Guid.Parse("5a2e91d6-642f-4630-a11c-b90785d88b4b"), }, { Guid.Parse("7623b677-a188-44f8-bbe0-f46036eb01a0"), Guid.Parse("c9c35f2f-4703-4470-9cde-826b78970e7b"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 95,
    Value = 
new System.Guid[,] { { Guid.Parse("7e01af0b-a804-443e-9fc2-290d6c2ac166"), Guid.Parse("0355c62a-93cf-4fb6-b509-c70a5d864008"), }, { Guid.Parse("182baef9-08d2-4ac2-acc0-c01c56e05860"), Guid.Parse("35d459a5-cf66-4ec3-ac06-943b2f535cea"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Guid[,] { { Guid.Parse("cb002a9f-8cd1-4bea-b8ee-68046f558550"), Guid.Parse("c38ba307-15fe-4880-890f-da16ab2d926c"), }, { Guid.Parse("b4a6770c-de91-454e-befd-6973df9c7637"), Guid.Parse("81cc8d06-9cc8-479f-9814-182ff9c67bca"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("dafbf901-12bc-46a5-8e1b-10a42ecf1e97"), Guid.Parse("d34a3e3a-3e61-4f4d-b731-96a439c467cd"), }, { Guid.Parse("15edf2b4-8008-4575-aa20-d47713201dc8"), Guid.Parse("6941411b-1f33-44d5-bdec-4f4d12399dd6"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Guid[,] { { Guid.Parse("eb351092-d794-4b95-aa07-7b2a36b94c6b"), Guid.Parse("6dba4757-a81d-4e6c-8df9-3c9004fda116"), }, { Guid.Parse("e0fbc52b-eb57-4de1-9354-14a131246306"), Guid.Parse("3de40f66-19f4-4423-baca-ad6bba56bac8"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("58e19329-c2be-4be6-8708-c4d78daa0e6e"), Guid.Parse("af49c28c-49eb-422f-94fe-15f723044b6e"), }, { Guid.Parse("c5948c72-baf4-4c6c-8395-9f17da303394"), Guid.Parse("1ba871ff-7366-4be6-b7f6-c2485a399630"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 100,
    Value = 
new System.Guid[,] { { Guid.Parse("f5f754d5-881e-4f56-8af0-007dba6902c7"), Guid.Parse("996054af-85f0-4e93-95d0-06fd097994ed"), }, { Guid.Parse("1626bd05-7b15-4158-9844-05160e1b9a81"), Guid.Parse("c6c72a6a-07db-4c92-9f23-cbd7ab037af3"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 52,
    Value = 
new System.Guid[,] { { Guid.Parse("f67f0c7b-19ee-4f62-a95d-d6165f69cb9b"), Guid.Parse("84e91509-0387-49b3-9e40-ebf6112ebf5d"), }, { Guid.Parse("4672f970-3c9a-4d0d-981e-6a7fbbb90f68"), Guid.Parse("99bb5129-805c-4764-8e5d-04b7d3c18c30"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Guid[,] { { Guid.Parse("d797a6f6-54ec-4dca-b855-f346f27a8e38"), Guid.Parse("faa0695e-8164-44c3-b83b-4e45fe16b2ec"), }, { Guid.Parse("d21ae4c4-324b-4499-b6b5-1d95f6d14a02"), Guid.Parse("418e7834-3f7d-45d4-a579-22c54d88ae55"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("62411c7a-7860-415a-ba11-3c7d206b4d93"), Guid.Parse("3a9b8964-ad90-42d9-9d9a-a9ec8ec249bc"), }, { Guid.Parse("30616ddb-df98-45c4-9d2c-a04a2efbe062"), Guid.Parse("e9d2e745-6bb4-4c35-9f34-a408a35a9a4b"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 108,
    Value = 
new System.Guid[,] { { Guid.Parse("0239e05c-c892-4b65-95d5-9c8dc6d1af7b"), Guid.Parse("ee230a02-c7fd-4242-bc2c-c96debcb8ce5"), }, { Guid.Parse("30c770ff-22f3-4f50-991a-d8e1d9d3fc5f"), Guid.Parse("48160fb0-d84b-44e6-bd22-a6f0bc4450d7"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 59,
    Value = 
new System.Guid[,] { { Guid.Parse("45063711-f95d-48e7-876f-6add02dabe96"), Guid.Parse("85d85236-ca31-4d66-ba4e-a061d0458903"), }, { Guid.Parse("3a2de006-5192-4de5-b938-e90150b0a306"), Guid.Parse("0d101b90-10ad-4360-b903-bde8f9058f2c"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7d07cc43-3c28-4662-984e-3ba94b5799ce"), Guid.Parse("27da1593-080f-42d8-a2d4-3eb556c39d86"), }, { Guid.Parse("f37c3e83-09fb-41ae-984e-62bfb8302d3c"), Guid.Parse("32140fed-c124-4109-8024-95eb57f2b5f2"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Guid[,] { { Guid.Parse("9209c4c9-33fe-4b08-a00a-36bcfd3ce940"), Guid.Parse("d8ca1652-ffec-470d-a07e-1d6dcdfcb28b"), }, { Guid.Parse("8609c3bb-b76a-4fbf-9cfd-92cb395f6601"), Guid.Parse("55660108-2486-4e3c-877f-10a2c7488f58"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f4966915-0085-428e-986d-95731d525859"), Guid.Parse("520872af-a44a-4bb0-aab4-2d662efbc76c"), }, { Guid.Parse("b6c58a80-6fe4-4a7f-9bcc-a8ca96e74cdd"), Guid.Parse("c7a304f5-4a12-4b2f-86b1-ba2018077398"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Guid[,] { { Guid.Parse("1a885f71-70a8-490b-bebe-16cb891ba6e8"), Guid.Parse("bbbec425-30b7-4678-a7c5-72f92ee483a5"), }, { Guid.Parse("cf8614ad-d861-48c4-8cb4-113382ff63bb"), Guid.Parse("6332428b-4bd9-4155-a9d7-9fe34cb6e020"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Guid[,] { { Guid.Parse("bc58fda9-a1f0-47f6-9891-8cc3452d0871"), Guid.Parse("2dcbb96a-5ed3-49b1-bc82-6cfcc6e57e54"), }, { Guid.Parse("4827f419-20ba-45d0-b15f-8e57154fc3b2"), Guid.Parse("93917a86-fe96-451e-a642-1d1316d0c870"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Guid[,] { { Guid.Parse("ee6f5f04-914c-4051-97dd-165636edfd88"), Guid.Parse("f40f8813-4c9b-4402-8432-4e63188e3a55"), }, { Guid.Parse("0f8565b1-9286-4afa-bd60-581b6dff87df"), Guid.Parse("4621786b-5365-4e7b-ac64-9f727b1961cb"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 134,
    Value = 
new System.Guid[,] { { Guid.Parse("21e7a968-2b8b-46ec-bd0a-d2d0774e0a12"), Guid.Parse("a3e340b3-05cb-4ae8-b1b7-07bb801e976c"), }, { Guid.Parse("49f1a255-2035-4cd2-90f8-b0822e2ba560"), Guid.Parse("dd0f6931-1410-4b49-b826-72b5caf6d6f4"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Guid[,] { { Guid.Parse("40585acb-ff88-4ad4-9a55-496063db07cf"), Guid.Parse("d2f96ef7-58ca-4bab-923d-5fe6acee1741"), }, { Guid.Parse("734bee32-e0b8-44c3-8638-d427bbfcec59"), Guid.Parse("44fa27a2-c4dc-4335-8fd0-0206a78f30c4"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("a1777cd3-f33f-4749-8927-ad7c5bc0ff27"), Guid.Parse("b67864fa-41ca-4ef5-b94f-8dd23e0d0f46"), }, { Guid.Parse("8920046d-4054-4130-86f8-7f81596d4130"), Guid.Parse("6aaf5c86-c03c-4263-bf3e-a7977aef66c3"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("2d435e9e-94b7-4dc8-a295-d09a6f4d2b4e"), Guid.Parse("3a5e106b-a42b-42d7-a721-2a6cf4426fac"), }, { Guid.Parse("fb042176-3381-4c10-a6e3-a2f26231a25a"), Guid.Parse("1cb55429-1b47-40d2-82db-10af71e9663c"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 135,
    Value = 
new System.Guid[,] { { Guid.Parse("2d521978-1133-4f39-bcf3-a3f8dad2aaf1"), Guid.Parse("7a442c09-b4f9-4301-b95e-93b894add316"), }, { Guid.Parse("ec511420-68f0-4613-9209-1b9529831d49"), Guid.Parse("d677de53-f4f5-4edd-956d-c055af56ffbd"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c3cc69e4-8657-4d0a-a683-787dcbc391a6"), Guid.Parse("2325c697-8e2c-4c0e-b1f9-8770178ccd50"), }, { Guid.Parse("e3fcea08-36cb-43da-b232-9ffe43bca949"), Guid.Parse("fe540911-695d-44ed-8c3c-99094d1cd152"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Guid[,] { { Guid.Parse("aa36cdf5-a132-4436-a491-d1e4da2fc0d3"), Guid.Parse("392a70c9-15fc-4ce5-9943-8f18cfc8679b"), }, { Guid.Parse("2d4ec083-23c9-4729-b3d7-df062224fa4a"), Guid.Parse("ad8dce6b-62ea-4b5d-8d0e-4eb579828174"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("bbf834e5-f00b-47c6-b8e3-d686e80fe642"), Guid.Parse("c4d035e9-2453-4b92-a4a7-c9eae5070fd8"), }, { Guid.Parse("fd925649-c5c3-4004-8ef4-d17a2a990e4e"), Guid.Parse("8578ef43-a6af-46ea-a9a1-d50d04b52806"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("3b0d3a8b-989c-4537-b18b-0538aedf97bb"), Guid.Parse("994d8629-a1bc-49bb-bb84-4f73c258a907"), }, { Guid.Parse("23a58fba-92b0-41eb-9ba0-5f2f6d41b6ae"), Guid.Parse("9294124a-d60e-40cd-ba06-5059e5aa4469"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Guid[,] { { Guid.Parse("4668974d-b110-4dd7-b30f-817ae999c09c"), Guid.Parse("9d10a241-db27-455a-b2a9-26c47b79d30a"), }, { Guid.Parse("d0e756d1-79bf-4855-8adc-76cdda752807"), Guid.Parse("add2d0bf-979e-4804-a5eb-61402a9dc664"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Guid[,] { { Guid.Parse("28ffcd76-a41b-4eaa-926a-8142bec139d8"), Guid.Parse("a1698beb-6a10-4d52-9813-3732aba244d9"), }, { Guid.Parse("e808827f-49e2-448a-912e-536846f78c8e"), Guid.Parse("09ab3c43-e775-4059-aa06-a9eb38f90947"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Guid[,] { { Guid.Parse("817f68d4-4dbd-4c28-a065-5ae76f2dcd2b"), Guid.Parse("a829ce76-4cc7-4bc3-8c09-23ecd6378a7d"), }, { Guid.Parse("1b4e9676-350d-4364-a8aa-47f963e5a989"), Guid.Parse("40cf8d94-25c8-49bb-8ad1-ebdda7cb10a4"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("73afabbd-7f5e-4e4f-bbd9-091feb4a7d14"), Guid.Parse("d69ce53f-e552-42d6-bb30-9e108eda9e66"), }, { Guid.Parse("4495f0c9-0206-4c39-8a73-77bda0ad3c35"), Guid.Parse("fe964c7f-a43b-40e5-998f-79fcf3ece448"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Guid[,] { { Guid.Parse("58336f55-dd87-4e63-838f-f817cdef14ad"), Guid.Parse("b17b1a0d-a8f1-496e-a3e6-cda998051117"), }, { Guid.Parse("39187eb5-7468-47bd-9550-a3e88a8f18a5"), Guid.Parse("b8a4544b-0d67-4ba1-a5d2-01042b01fcf1"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e83dd86f-935a-4c16-9964-f3f589f110b5"), Guid.Parse("9be5a493-9533-4543-ad6a-a7c5cf900661"), }, { Guid.Parse("d56655b3-bba6-440f-ac1b-6c0c5dfa0400"), Guid.Parse("fa27b3cd-9a0a-4e63-b028-f9e39689349c"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 170,
    Value = 
new System.Guid[,] { { Guid.Parse("bd63c7e1-584f-4a89-9ef5-9ef2ba5a51a6"), Guid.Parse("783c9770-e426-4a3f-97f8-ebab56f26bf5"), }, { Guid.Parse("b8049af0-d38d-493c-8fe4-f496174f4481"), Guid.Parse("3eaa61cc-80ff-48be-b1d3-8b4d781678e0"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Guid[,] { { Guid.Parse("9f708d82-99ba-4fb8-92c2-03497549d139"), Guid.Parse("dc686fc4-aefc-4611-80d8-decc3b07099f"), }, { Guid.Parse("2bb4ab07-074d-4f22-a36b-c14506c07d63"), Guid.Parse("94388009-3b89-4a3c-a118-3643eda4c395"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("250c574d-9fb3-477d-9099-bc0c22b308c5"), Guid.Parse("5ec89f21-a618-4f2c-908a-198e0e8fdad2"), }, { Guid.Parse("d484ded9-0b78-4e71-8b8d-f0749010351a"), Guid.Parse("f4c99aa3-f397-422f-8170-c71a63be1992"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f5cfd660-cca3-43fb-87e0-a1684e8d7adb"), Guid.Parse("3044a42e-63d1-41a0-bd40-5a1bd215b538"), }, { Guid.Parse("dc767174-b020-4b8e-945f-2c2825f41e4c"), Guid.Parse("34540faf-3a80-497b-b31f-3c96e7cbe97f"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 174,
    Value = 
new System.Guid[,] { { Guid.Parse("21834185-a4ca-4e33-a163-13485b98524c"), Guid.Parse("44e87df9-bd45-4d78-985e-7b00b46bed82"), }, { Guid.Parse("fef7fc83-e55c-44f0-aee3-60f9920022b5"), Guid.Parse("ae28ae25-8aed-4278-a458-32bc31bc3de0"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("755843d6-a073-485e-ba92-70cd9f5960e9"), Guid.Parse("3f4da6f5-294b-41a3-8eac-21400158a534"), }, { Guid.Parse("5e0a4fd7-d01e-4ac8-8da9-f97812024c72"), Guid.Parse("9eda8ac9-ff35-41b2-90d8-4890e556c59c"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 178,
    Value = 
new System.Guid[,] { { Guid.Parse("36b2fe35-405b-47e1-b635-8df4ecdc4a34"), Guid.Parse("eaf184a4-3d16-47c5-988a-cd60b18a0745"), }, { Guid.Parse("3f2f3c54-1a09-4b91-b4d7-00a3fcdedc02"), Guid.Parse("0bcd0719-7875-4da3-b6a2-bd6159fb55a3"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 89,
    Value = 
new System.Guid[,] { { Guid.Parse("b51a199a-5ca6-4e33-8d77-d56e3af308b6"), Guid.Parse("c4ef54d0-c8c8-4af7-aea3-2cfdd0cd0d94"), }, { Guid.Parse("0d71d6e7-d7f6-4a4e-9f52-fd84f0ba2225"), Guid.Parse("30c2f754-063c-4d2b-8c01-3f186c378bda"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 182,
    Value = 
new System.Guid[,] { { Guid.Parse("9b07908b-b2aa-4730-a61a-2c987ecfa0c8"), Guid.Parse("924a1251-b761-4dce-884c-0a713225aea9"), }, { Guid.Parse("ea46e6bf-c136-435a-a551-fc971f90f525"), Guid.Parse("c1e6630e-b628-4f8c-9ad7-5af296f4de13"), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1mi(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
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

                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd2e1mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                System.Guid[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("4734bee1-1f7e-4db5-a7d1-513a9b404e48"), Guid.Parse("ec573e94-4fd0-49ce-ad43-c06f00be50c5"), }, { Guid.Parse("42ea9115-b08a-4318-aace-e964b3514112"), Guid.Parse("967e2cb8-8e53-46aa-8d79-8ef24044eb76"), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                System.Guid[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("1b406e10-5853-4fd0-8a85-4c6179bf90b5"), Guid.Parse("bfd4b880-798a-4a38-9e5a-80b0077b815b"), }, { Guid.Parse("baed991b-fee6-4181-ac38-d2260682f029"), Guid.Parse("75d1416e-951a-4c80-b22b-20d27aa5188c"), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd2e1mi_id", 
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
                System.Guid[,] nullable = null;
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("57ed977a-8150-46f7-8795-90732440e6a7"), Guid.Parse("c18fa2c9-3b56-4c0e-ae6d-427d4fe99af6"), }, { Guid.Parse("883f776b-1cf8-4189-ab53-151727ee6b6d"), Guid.Parse("5569dc75-c068-409c-83fd-304f31a30a72"), }, }));
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,] nullable = null;
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("223fafd7-4d0b-46c7-86a7-1d6b1c3319f0"), Guid.Parse("b0b105fd-2e20-42dc-b322-e338e63cdfb0"), }, { Guid.Parse("0bf5820a-c2a3-4108-9f24-66c66dece2a5"), Guid.Parse("2fedc2a6-a4ff-4c64-b244-07eb2439e8c4"), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD2E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD2E1M> models = null;

                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 7, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 154, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 38, query1, 38, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 6, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 105, query1, 29, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 88, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 135, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
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
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 61, query1, 64, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 13, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 10, 105))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 108);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 135);
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MI),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidMMArrayD2E1M),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
FROM public.binary_guiduuidmmarrayd2e1m m
LEFT JOIN public.binary_guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
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
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI), typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models1 = new List<GuiduuidMMArrayD2E1MI>();
                var models2 = new List<GuiduuidMMArrayD2E1MI>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MI>();
                var models2 = new List<GuiduuidMMArrayD2E1MI>();
                ((IGuidMArrayuuidMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


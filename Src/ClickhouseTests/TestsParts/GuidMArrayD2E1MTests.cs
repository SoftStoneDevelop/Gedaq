

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IGuidMArrayMArrayD2
    {
    }
    
    internal partial class GuidMArrayMArrayD2 : IGuidMArrayMArrayD2
    {


#region TestData

        private readonly GuidMArrayD2E1M[] _testData = new GuidMArrayD2E1M[]
        {
            new GuidMArrayD2E1M
{
    Id = 9,
    Value = 
new System.Guid[,] { { Guid.Parse("b9475307-b9ad-4337-bf51-e950bf7cecde"), Guid.Parse("0ab8a4fc-0eb0-4273-8aa9-54bd7b61b0cc"), }, { Guid.Parse("e9755441-f530-4580-9830-c1162779b698"), Guid.Parse("ad50117a-4cb4-402b-95e6-45712f0e9d54"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Guid[,] { { Guid.Parse("ce10c367-35cc-4706-9b10-7677ba68131e"), Guid.Parse("b3273a5d-5c7c-49b5-a423-7a846f955f3f"), }, { Guid.Parse("1a4891c8-dc39-4229-b9c4-cf0d6c096405"), Guid.Parse("fe0df7ff-32f7-4685-a725-d7bf2b7e82b9"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("40483730-9748-437c-b9f5-54a0c672f922"), Guid.Parse("cb462247-6a0d-4631-98d3-8dcea612e77e"), }, { Guid.Parse("99b03354-d80d-47eb-b9dd-2bafc90d7c4f"), Guid.Parse("a12868f9-fee3-42ed-8729-2f3e50eea6e7"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Guid[,] { { Guid.Parse("2e7fdad8-ff7c-45ca-b57e-8ca0d3d62a52"), Guid.Parse("46ef679f-277d-40f2-bbb5-36402068560b"), }, { Guid.Parse("eed7173c-fc4b-41ff-9716-2f8e5a6acc94"), Guid.Parse("ab562cb7-279a-4467-a973-f6d6a847737d"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Guid[,] { { Guid.Parse("36bbb0cb-f5e8-4653-82c9-df7b1010fc90"), Guid.Parse("03322e97-7bd3-4f81-8150-4b9d6f63cd9c"), }, { Guid.Parse("e6ac1fee-04d2-4ada-8a9e-af6393d66afc"), Guid.Parse("6e5c0084-28ee-47ec-beb2-beb9cd111ed4"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e9ad390a-b031-492e-9e42-d6f61cea7ae9"), Guid.Parse("6b174deb-b914-4128-9cee-f17d84e2a74a"), }, { Guid.Parse("d6de0443-b6f5-4f6e-8624-b3164b3788c7"), Guid.Parse("beda8c8d-eb06-4ae7-919a-0a2373cbe2f1"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("69771b7e-af6f-4b1f-8259-2340413655ea"), Guid.Parse("ce41bfe1-7f45-4369-95d8-57cba12e5f28"), }, { Guid.Parse("46ecc5a3-13ed-4f2f-914a-21d1b6bc6aad"), Guid.Parse("a29cd02b-653b-40d8-b38f-b9912f65de57"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 17,
    Value = 
new System.Guid[,] { { Guid.Parse("9a3d49c8-ba28-4a5c-ad7d-8faaa1e41b37"), Guid.Parse("0bce1c45-4c89-4f45-853c-405af8e11f88"), }, { Guid.Parse("3245559f-b49f-40fd-8787-6f5b24216088"), Guid.Parse("7842fbe0-953e-456e-81ed-26ec6e29cabd"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Guid[,] { { Guid.Parse("e5aefa3f-f646-4827-a28a-b85e8cea9a8a"), Guid.Parse("67d6b75b-b810-44f5-89ee-911c07fd4862"), }, { Guid.Parse("38171421-ce62-4f81-b727-4c1ef07ff881"), Guid.Parse("c9da1c89-b465-4112-a9b1-20ee06ec2a47"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e1cf99d7-bbe2-451f-ac69-4f34b13646d8"), Guid.Parse("66a4605c-a372-4d5d-a141-b194bf10b552"), }, { Guid.Parse("11907765-00bf-4889-8c05-63912b46ad36"), Guid.Parse("fc6fb18c-e7ea-46f5-846e-f76c2e87b3a3"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b3e30dc0-5f01-4c6b-88bd-b7cca268fde8"), Guid.Parse("f69ab0c6-c8b4-4500-a4b4-0063fcdec5a8"), }, { Guid.Parse("eca46ce9-52c3-4616-beee-0b3d8e4b39e3"), Guid.Parse("a17f21af-9bc6-47da-86a1-2629d498820a"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 25,
    Value = 
new System.Guid[,] { { Guid.Parse("12fb43fb-df1f-4669-b46b-f8be546416c0"), Guid.Parse("4b82be65-d962-4d66-8d7c-1ffe542cfc4f"), }, { Guid.Parse("378d7575-6fd3-46b7-b2eb-f1d64d974023"), Guid.Parse("d3d8ecec-9551-4953-94fb-6decf2cd2f20"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Guid[,] { { Guid.Parse("ecdd56cd-234a-44dd-b100-2dd3bc5c2ba5"), Guid.Parse("7eefe2a7-b06a-4263-8456-4135eb9e189b"), }, { Guid.Parse("cf49d821-4f6e-4096-a161-5067f6282e84"), Guid.Parse("8e8d3007-99e7-40c2-95c0-4468134924d8"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5e5c9af3-baf8-40d2-8ca9-f5e8bdf0d93e"), Guid.Parse("062f78e8-7462-4949-b89a-5da4e68bcb1e"), }, { Guid.Parse("30a7e401-b971-4737-930f-5f84afd6e94d"), Guid.Parse("2e5c1a72-51d7-4ae7-a12f-7775f9e07a5e"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("57cde73f-b2c3-4b72-9bee-06ee04506a23"), Guid.Parse("540f7664-2e50-44ee-87cd-dcf0fc67b3eb"), }, { Guid.Parse("c0fa7217-b1cc-430c-bea9-ea24e99cad27"), Guid.Parse("8c1d75c7-54dc-4799-bee8-78385c9a4f0f"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Guid[,] { { Guid.Parse("6691f651-bb18-4234-a361-faa6e3673be8"), Guid.Parse("5f051f0f-880d-4742-abc5-fa606c0c4944"), }, { Guid.Parse("b52a55ff-b401-4f3e-9058-84b3521545c7"), Guid.Parse("50c3ae19-df15-4dbf-a5de-6c6c1590f18e"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 24,
    Value = 
new System.Guid[,] { { Guid.Parse("65838c8c-6ec1-4eff-a1f5-9904de50a27e"), Guid.Parse("87f319ab-25d0-4c96-a61b-2ec2c0c302fb"), }, { Guid.Parse("bbb3215a-b2f9-4a3c-906c-6aeb986fb9a2"), Guid.Parse("021b0e62-94bd-4aad-aa34-1874eab77fa6"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b213a785-5723-4fd9-b784-50ed3c2d2dd1"), Guid.Parse("9bff9f55-ce13-4901-bf43-478b14b5f4e0"), }, { Guid.Parse("c5ff21b1-56f9-4ca3-9fd3-71ed0fed6c84"), Guid.Parse("4e5db940-add0-4bfc-9eb6-d51df80285e0"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Guid[,] { { Guid.Parse("53f9c557-0de1-4865-a0cf-f5dce9b780b2"), Guid.Parse("50435c3b-4920-418c-9c96-b94acdbebf2f"), }, { Guid.Parse("f2149138-e0b7-44aa-8189-72bc0b3c6974"), Guid.Parse("178c41c6-d6c5-4df2-9ede-866db6f716bd"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 25,
    Value = 
new System.Guid[,] { { Guid.Parse("c7c14635-3751-4c23-bcee-0e56691a2f9d"), Guid.Parse("122ce269-c0d3-4639-bd93-0c23eb5ec023"), }, { Guid.Parse("5814467a-6750-4026-8001-d4e1ccc2faf1"), Guid.Parse("e373fba6-09b4-4676-b6bd-8f0a428eb726"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("10df02a2-c8c6-4050-829c-8bfdf60929d2"), Guid.Parse("eacef8c4-7c25-428f-86bf-65c64418dff8"), }, { Guid.Parse("0f1e26ce-feef-4e58-8589-890a79b46288"), Guid.Parse("9fe1cc2f-8681-4707-b38a-dc6440064b77"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Guid[,] { { Guid.Parse("d005be5a-77a0-4bde-a15e-2063c1804b8f"), Guid.Parse("b59d7d2a-9c8c-4c5a-9f99-887dcffe42ce"), }, { Guid.Parse("035425cf-4173-4565-ae88-8ad5b321364a"), Guid.Parse("3c98c722-8b4c-4c98-b57f-bc49841c8503"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Guid[,] { { Guid.Parse("338bcb41-4172-46c3-ba8b-2361250645bc"), Guid.Parse("64eb6c90-9f09-434a-b450-52a74d6365b7"), }, { Guid.Parse("992178e4-c412-417f-9ace-1d726e983e75"), Guid.Parse("daff78c9-a17b-42d9-9b54-3bf44bcaf128"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("0ceade6d-1863-4dc4-85e4-71d10f86f1cb"), Guid.Parse("7ad0ca79-f332-4047-8faf-b9b0cf2eb9b2"), }, { Guid.Parse("690c7879-b7cc-40c6-9e17-9f1f1e0b5fed"), Guid.Parse("c7b10bb9-7e46-4fa2-a327-8bb1c1091675"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Guid[,] { { Guid.Parse("0f6e2f23-92bb-45a5-8a05-3947116dd35c"), Guid.Parse("d6345a9f-532b-4f5c-b27a-929bab93f6bb"), }, { Guid.Parse("fde77109-6011-41cd-9cdd-594d19d28e94"), Guid.Parse("131bda51-2ac0-4b1e-a00d-fc0c6fb2b6a4"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Guid[,] { { Guid.Parse("96532ae0-4be5-4763-b942-e5237bc2e39c"), Guid.Parse("a443d09e-92a6-41af-8ff0-2c81c3351d5b"), }, { Guid.Parse("cb11137d-e8be-4e6b-95a4-f3396a2a1532"), Guid.Parse("e2724219-2711-4de0-ae7a-24129ecee242"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("af203ccf-8b0a-433c-8679-529451d4a256"), Guid.Parse("34a79a45-02d4-476d-86bf-b9e2d9c87bf9"), }, { Guid.Parse("1cfddfc8-2066-42e3-9cb7-3f06686cacf7"), Guid.Parse("7e40c1b1-e308-43f4-8d45-539f5821ffa5"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("0699e0ff-c6ef-4406-afcc-2754d95bcb97"), Guid.Parse("94062a43-9de1-461b-9176-f1d8add3cefa"), }, { Guid.Parse("f73aa941-355b-4d22-9e37-1d213db39630"), Guid.Parse("bd6b4ffb-1675-4611-b590-e55082be3b65"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 50,
    Value = 
new System.Guid[,] { { Guid.Parse("08977e1e-c099-495a-bee4-1e62cd80a51b"), Guid.Parse("58cb111e-a5db-4016-a34f-5e0868a6f1a9"), }, { Guid.Parse("b89470f7-ad75-4deb-9783-b678dfe1c5fc"), Guid.Parse("000bead9-805f-4210-9921-0997c8571ac6"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Guid[,] { { Guid.Parse("f8323581-ac3a-4090-8d63-09d765d39cf1"), Guid.Parse("c477fcc6-3e7e-4b9b-99dc-2f10e7127075"), }, { Guid.Parse("f803930a-7918-44b6-b048-5f93289dc74e"), Guid.Parse("19c8d67a-1de7-4a4a-9f73-e64e10c34ab5"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7a477ef9-2af6-4083-aa41-1da26518a331"), Guid.Parse("226f6158-00c7-4674-b16a-fab560e8209c"), }, { Guid.Parse("9eb55b1f-62e4-4a16-8738-ecfac31fdba9"), Guid.Parse("1478a046-05b1-457d-af3e-05820a769301"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 58,
    Value = 
new System.Guid[,] { { Guid.Parse("a5b2774e-0e31-4ab6-8422-42a8d3716a4f"), Guid.Parse("fdd3540d-f96e-43c4-b24e-60f1061ca0ad"), }, { Guid.Parse("4bf5822e-d3f9-4075-ab9b-e0497ed33c0a"), Guid.Parse("8040ba54-426a-41a7-8996-65bf11a7a3dd"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Guid[,] { { Guid.Parse("b9d8e740-5c02-49bf-9b25-f72b52bc9efe"), Guid.Parse("b23c09ed-cdc2-4caa-b02d-c7c3c420ee69"), }, { Guid.Parse("98277ed8-099f-40c2-a2a9-6c293755112c"), Guid.Parse("df45d846-b03c-40b4-95da-9c1dcdcbbd7a"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("bfd55a9c-5f11-44c6-9a2b-4686f948e798"), Guid.Parse("7c7b7daa-931c-4d8e-bbb2-f3a22543264e"), }, { Guid.Parse("32562a8a-b6c1-46f4-8fac-07f1dfc92909"), Guid.Parse("c5ec4d61-58f6-4cb0-b598-9ba9ced38e5e"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d70839c5-82d5-4831-9004-23f9621e696c"), Guid.Parse("ccb7c835-5925-47de-a37d-bc5f644a1b4f"), }, { Guid.Parse("5c158392-6c4b-4283-9841-c6beafe04f91"), Guid.Parse("7374d245-605f-419b-992f-47b204fe40ec"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Guid[,] { { Guid.Parse("091eb367-229c-4581-9e24-393b9de3fcfb"), Guid.Parse("c341f3ac-92b2-4f75-aeb4-6ef6c0205cc0"), }, { Guid.Parse("2e2fca72-d297-46cc-aaff-0d6722cce785"), Guid.Parse("309fe6ab-eae4-4396-8c52-292ac410ff01"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Guid[,] { { Guid.Parse("11829a23-c5bc-4c5b-86ef-cbea3583506e"), Guid.Parse("73fc1e2a-9eb5-4bce-8a33-e78ac1eca163"), }, { Guid.Parse("d1e85dc7-668f-4efc-81db-e283e95168fa"), Guid.Parse("ecf3c362-f147-4e87-adc5-3839948ae92b"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Guid[,] { { Guid.Parse("0d4720f1-50a1-42f6-b398-192880e595d3"), Guid.Parse("39ad125d-8887-4bd3-9907-04ced99151dd"), }, { Guid.Parse("07fedf5a-e6a5-48e4-b56a-3b12a7b64176"), Guid.Parse("edbd2e60-9b5f-44d5-900a-6c95c924ed3d"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Guid[,] { { Guid.Parse("f3a0ebb9-814f-4011-be74-66a6d6baef1b"), Guid.Parse("27841f0b-eefd-4b17-b98d-17711cffd1df"), }, { Guid.Parse("84719d25-77d5-4a64-84a2-acce26938687"), Guid.Parse("be729b4b-0a4a-40a0-8a8a-33f8c4672f99"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7d48f820-ceb6-4f02-ac01-5112c3f8ba36"), Guid.Parse("76b33601-a3e0-4b8f-8dc4-3218cad8f336"), }, { Guid.Parse("8159e018-c140-43ea-a4f1-c8637922951c"), Guid.Parse("046054ed-c73c-456a-81ee-e3bc7460cc7f"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 70,
    Value = 
new System.Guid[,] { { Guid.Parse("660ce73a-7f63-4e83-9cce-4ffd7fe39aec"), Guid.Parse("b56958ee-0c1f-40ca-addc-a06cfa1e2afb"), }, { Guid.Parse("ac15f6b2-29a0-4461-b156-6ab041e1e5b9"), Guid.Parse("025fdba9-69b4-4da8-92fc-5c5d30ef9709"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 56,
    Value = 
new System.Guid[,] { { Guid.Parse("77bc719e-f4cb-4e3c-a90b-61b81c63a3fd"), Guid.Parse("0ce22708-7727-4ad6-b0ee-4f5e5a79b0cd"), }, { Guid.Parse("3f8d62ab-643b-496d-bdda-cda7341b80ba"), Guid.Parse("d7189fff-4b28-4e3d-836c-b7009a4135e0"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Guid[,] { { Guid.Parse("6d4778d4-90c1-4ceb-b3b9-ff368e4ab3fb"), Guid.Parse("723d2c33-af38-4771-bc20-81381e9d0778"), }, { Guid.Parse("c6127afb-cfea-4544-875c-145521e68b67"), Guid.Parse("0029bfa7-cd17-4f95-83f4-0b67d1ca4c4e"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 65,
    Value = 
new System.Guid[,] { { Guid.Parse("b3b5be87-b370-4cc8-a39b-5a0cad814d74"), Guid.Parse("895803d9-b1b3-4857-aad6-f359dd04fd48"), }, { Guid.Parse("be6a96f2-4530-4c06-a601-8989f779d862"), Guid.Parse("d5c0ba43-d748-4b06-b6c3-286f952ea746"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d32f54e6-9a76-4aed-a082-04d3c3d6469b"), Guid.Parse("fb932e10-0cb3-4645-a69b-1e4829d6d04a"), }, { Guid.Parse("0ce24f7f-8027-4cee-9c4c-2571a28a8dd6"), Guid.Parse("9fb1b077-62c8-4d47-9a70-4a8cdf5d050e"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Guid[,] { { Guid.Parse("f9a9a204-dcc3-4df0-8c50-bdc1b3d9ce0e"), Guid.Parse("847e00d2-57eb-44be-981a-51dd4ad9f588"), }, { Guid.Parse("866cdea1-8aa6-4ac9-aadd-fe22ac497ab2"), Guid.Parse("960e9fa2-3800-4c8b-ad78-c478cff4a5e2"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Guid[,] { { Guid.Parse("0ed6f4cd-6d4b-4865-b834-038e55ca6d45"), Guid.Parse("5ec39824-6be5-484a-9f91-486c171131f1"), }, { Guid.Parse("17e15e0e-ed4b-4095-8d30-ee277b27d251"), Guid.Parse("affd7697-1d88-4f98-a68e-195effc77be4"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e1c4456d-ed25-4fc3-bd93-fd377c47df04"), Guid.Parse("c5fa4eff-6d86-45d4-a93b-92b27f78263d"), }, { Guid.Parse("e0570e74-9a68-48f4-919a-44d83d23eb77"), Guid.Parse("e2707183-8308-4816-9407-9206c42f6e8a"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Guid[,] { { Guid.Parse("bc296223-5630-49d4-b9aa-f4eebf181824"), Guid.Parse("c3875793-f8b2-42c8-be1a-4529f13abea6"), }, { Guid.Parse("c5785846-cc14-4885-ae00-303cfe43b359"), Guid.Parse("8e3df859-c19f-4b48-b39f-3ff1ebe303d1"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 77,
    Value = 
new System.Guid[,] { { Guid.Parse("561d68fa-55a0-4517-81ff-244ba6ff9100"), Guid.Parse("c6d2f080-bed3-4758-8299-452f42819a3e"), }, { Guid.Parse("e29442ff-41de-4a7b-bf29-75704102ff67"), Guid.Parse("18bec81a-9312-438e-a493-ee809bb41732"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("023f0756-e784-4a2c-96fa-95c5cc40a92b"), Guid.Parse("ee96d98b-12d9-4b0a-b409-5cfb80729f5f"), }, { Guid.Parse("afeaa091-f99a-417e-afe4-abd0fba6c7ba"), Guid.Parse("a8e14a0d-3105-4334-af2a-8720d67e5399"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Guid[,] { { Guid.Parse("76a79d78-d2f2-431c-a41b-ecfca6c29880"), Guid.Parse("106dd6a6-5816-4a5a-a2d6-c0944c63647e"), }, { Guid.Parse("6fbf61de-6195-465f-b728-adb4cf936663"), Guid.Parse("a5d5b8d4-035c-4762-b7c9-1b9c39901a37"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 85,
    Value = 
new System.Guid[,] { { Guid.Parse("650dc556-1c9e-4ead-ae2d-4657c6e7f6be"), Guid.Parse("72388bc7-c7de-4e93-8a99-572076d54811"), }, { Guid.Parse("28c0225a-7a01-4147-8247-507160223069"), Guid.Parse("ece82e39-b008-413f-82c1-1b4cc0170a5c"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Guid[,] { { Guid.Parse("d62dd501-b1e5-40dc-bf11-3dadb19d56ac"), Guid.Parse("be8513ee-12e2-4fb9-84f6-772743545d98"), }, { Guid.Parse("c11abce5-592f-42b6-935e-5993d0ef8a61"), Guid.Parse("d1b0684a-27d6-4f7f-913a-0ba2a7cdc090"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 88,
    Value = 
new System.Guid[,] { { Guid.Parse("a262dc7e-37ce-411d-81e4-005b27d2f909"), Guid.Parse("bab2c4c0-2dd6-4c48-af28-266f25c05168"), }, { Guid.Parse("d26bc93a-5aff-4acc-b064-352ae9f2b013"), Guid.Parse("049c64e7-445c-4913-a0f2-e254a1ae2200"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 91,
    Value = 
new System.Guid[,] { { Guid.Parse("90193a54-ab5f-4379-8608-4c30b8b62687"), Guid.Parse("2d4e9853-a294-498a-a60e-1a0db83e1bfd"), }, { Guid.Parse("4bc8d127-a34e-4a37-9eab-ae497c09ac80"), Guid.Parse("4a638725-034f-42eb-8d7d-d3c21399ba96"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Guid[,] { { Guid.Parse("7de1592d-dd57-49d0-8027-fd8f65540f7e"), Guid.Parse("989fe9a5-91f6-4804-842d-155210dcb693"), }, { Guid.Parse("921375f0-2a15-42b3-9aeb-a5c3ac47481a"), Guid.Parse("4c9ee099-2437-4428-a81d-d4ff7570bdb4"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5c964f6e-1a0a-4e47-aa54-a70665a5d8b3"), Guid.Parse("149a318a-7aef-4a39-9863-ac6c336db1dd"), }, { Guid.Parse("8af4e0c4-ffe5-4047-ae8c-211da017208a"), Guid.Parse("59158132-cf13-45c9-8cca-4bfbbe15ca42"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Guid[,] { { Guid.Parse("0ee22b64-9fcd-4a70-9267-0e456df869c0"), Guid.Parse("1c995951-2edb-451a-889f-12cc3ad02714"), }, { Guid.Parse("91124d3b-0095-42e1-9471-d12609bca66f"), Guid.Parse("dd71449e-e350-404b-a212-0505f059f244"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.Guid[,] { { Guid.Parse("612c871a-f29a-44b6-8010-b991a6836a72"), Guid.Parse("df3cc564-1133-455a-bbd3-d9244875b7d5"), }, { Guid.Parse("ddfa8935-6f79-4acb-a5b1-b6b815f16309"), Guid.Parse("f0b8a8eb-df30-462a-a4ab-04e1cfabf5a0"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("1046f7cc-60cf-459b-81d7-b57ef2e9f5ab"), Guid.Parse("ec3f2964-b5d8-486e-83d9-d15627e498aa"), }, { Guid.Parse("5a9096e2-91ba-4800-a6c7-fd7843dc2c36"), Guid.Parse("aad5fd6e-b2d0-43d7-9986-f79d8e35ab11"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Guid[,] { { Guid.Parse("8e7a0635-35c7-4669-a1f2-dee31299481e"), Guid.Parse("7cd36b60-9d62-4560-b13e-c665b0ab4433"), }, { Guid.Parse("3d9139ac-d2e6-43f9-bc3d-f1e9b30db84b"), Guid.Parse("6e6991bf-3d05-4de2-a4f0-3d88532da96d"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Guid[,] { { Guid.Parse("2b075672-f9b1-41f9-971f-ee7604cb9274"), Guid.Parse("d6e52862-c74a-4fac-a99a-1f88e8a3082c"), }, { Guid.Parse("58b95b88-8595-48fd-9ccd-546889fbbd4f"), Guid.Parse("619164be-af6f-4a53-b011-c8020ca4fd6a"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Guid[,] { { Guid.Parse("8845abc7-48d8-49a5-a263-67b7076c7362"), Guid.Parse("c7bef997-b4af-45be-a861-7cc409653981"), }, { Guid.Parse("bc2b3eb4-5bfa-40de-9798-d698e1ce2c28"), Guid.Parse("6593bbb7-dd43-45b4-b272-bdc6cfcc99ef"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Guid[,] { { Guid.Parse("8bd62df0-81fa-4539-bf07-dd2abeffca67"), Guid.Parse("6561ece2-fcf2-426e-8ead-aea133f3aabf"), }, { Guid.Parse("b22b1564-a9b7-495e-b2ff-e2954184ce26"), Guid.Parse("6f3ebbed-c7ad-4339-ba1c-aadb7e7eb43c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("6212695d-75b2-43a8-a629-e6a1f32f994f"), Guid.Parse("b36ec6fb-d39d-4431-b230-aa7f24eb72f5"), }, { Guid.Parse("8a96a7c4-2492-4a3e-8c48-132a95d92115"), Guid.Parse("28395aee-440c-413f-b938-2866f2c3f809"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("9d5ed44f-a5e0-410a-a1b9-0218e8f17fa6"), Guid.Parse("ac47abd4-61de-4207-8091-93e3640611cd"), }, { Guid.Parse("0a6850fa-c24f-422a-8a63-8aea16dfbe9b"), Guid.Parse("9aa0b07a-6bac-46e9-a33e-5c1e15ed71c0"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Guid[,] { { Guid.Parse("465ebdb5-584e-4c6a-80e2-ee9afd4d3f35"), Guid.Parse("2bc46c71-3a33-4ccb-a8a7-f67dccbfd066"), }, { Guid.Parse("a879d8c4-2029-49b2-a179-a5a6ec802649"), Guid.Parse("9dafcf72-5554-4b77-808b-471cdc5171a2"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 108,
    Value = 
new System.Guid[,] { { Guid.Parse("b7ea3203-f940-489a-ad10-62f58672b8ae"), Guid.Parse("a9772931-ee3e-4833-b6be-c3aefbcf63b1"), }, { Guid.Parse("8074d05f-7d2f-4d5f-978f-556ffd34d18a"), Guid.Parse("a87b899f-8771-4b78-9c58-406ac5f88897"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c5be3c0e-f27c-41c1-8a88-8cbc4d5c512a"), Guid.Parse("4b64397a-ab27-4ed1-8931-483ad18fa3f3"), }, { Guid.Parse("b4d15909-3619-4d98-a7ac-5082e0024af7"), Guid.Parse("248e5ff8-95c4-4753-8855-65982a903d16"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7a04c6cf-e495-4469-ac00-375e41f76f57"), Guid.Parse("70ee840d-624a-4212-b7c1-e8207b2b08d6"), }, { Guid.Parse("b8c4ca18-42a3-4640-bde0-209f8ef8c46e"), Guid.Parse("a1cf62b6-c300-409a-91f8-a19e1f4dbad8"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 116,
    Value = 
new System.Guid[,] { { Guid.Parse("d7aeda69-04f2-4548-8da6-6854d4a252e1"), Guid.Parse("ae786654-3f25-4320-a807-66ed9f86b676"), }, { Guid.Parse("2e7e787e-a96c-4b0e-b768-3a1a62bad92c"), Guid.Parse("69981813-5745-4da2-82fa-ea3a3d7abe09"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 116,
    Value = 
new System.Guid[,] { { Guid.Parse("ee9f1d01-c2d9-439d-95a6-fa20e185aed8"), Guid.Parse("61faa646-4f21-4042-aeab-98028490097b"), }, { Guid.Parse("d6840d4b-3bea-4ed0-b075-9e1dcf02fbfe"), Guid.Parse("1aa9ad93-8774-48a0-90e7-e806eee53edf"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 123,
    Value = 
new System.Guid[,] { { Guid.Parse("9684c157-910a-4fb4-bd6d-6ef3b2fb3b3f"), Guid.Parse("e0dd8166-01a3-4af4-88eb-b4c772a63314"), }, { Guid.Parse("56b5cd96-9f20-484b-824b-256d1abaab13"), Guid.Parse("fd2da6ac-25a3-46a4-887d-7d4aa1185a13"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 125,
    Value = 
new System.Guid[,] { { Guid.Parse("ae6fdfe9-03f9-436c-9e75-e3fcdb08846d"), Guid.Parse("126f2d31-607f-499b-bb5a-173ac079554d"), }, { Guid.Parse("778972b7-f513-4f3c-9da5-d8bd7577e09a"), Guid.Parse("5239567a-ab88-477e-88e5-6dc7cde5bdb2"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Guid[,] { { Guid.Parse("5d17a210-7cfa-4fcd-9ce6-28af4db0e874"), Guid.Parse("b50d0cbf-efc0-4fe3-b54d-ed60437d9355"), }, { Guid.Parse("7a23db27-6d97-418f-aa94-bb1e1b7bba98"), Guid.Parse("7b15b839-cea1-4f79-9a9a-8de95d2873ac"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 126,
    Value = 
new System.Guid[,] { { Guid.Parse("436bf11f-6196-43cf-b8cf-69b696e3ae5c"), Guid.Parse("5afa4d01-5b23-4833-8eb0-f2c16ff56553"), }, { Guid.Parse("76782f66-6b7f-44c9-be8a-d47a758f43ca"), Guid.Parse("6328e24a-5f9c-4cce-84e8-aecc3beb8554"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d350c4df-48f0-4cb1-9265-62420622478a"), Guid.Parse("869f32d7-3306-4155-983f-e471c3e9e93b"), }, { Guid.Parse("e50eeaaf-8f77-4c68-96cd-8ac03319100c"), Guid.Parse("0abefb1c-d5cc-48d6-a400-59ef9b534412"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Guid[,] { { Guid.Parse("0fdbe684-7578-4fe8-af26-0de3fd3c2e71"), Guid.Parse("e84b5536-daea-4276-9dc7-1d59b031d9ad"), }, { Guid.Parse("799c36ed-37fd-4b94-8ba4-1c7f19f6e93f"), Guid.Parse("1b3bf866-32e3-46bc-b412-9b833e10cdb3"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Guid[,] { { Guid.Parse("852fc220-4564-415b-a604-942af8fa6630"), Guid.Parse("b2a62281-cb1a-4db5-a97a-dd15340cbea2"), }, { Guid.Parse("8e500f8d-aa38-4163-be36-492775ccb6a1"), Guid.Parse("3f6aae25-1563-4fc6-a948-f8283b165e2d"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("9c6b931b-8636-459a-94e5-aa3f465c3a8c"), Guid.Parse("e392fe56-ff85-496e-9c8a-6f7df366bd8b"), }, { Guid.Parse("1ef03054-b410-40bf-a475-048ae27435af"), Guid.Parse("81af1879-7080-41d2-973d-c3ff815742ef"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4fbb6d6d-c4c1-4f5c-aed7-53a54a02f789"), Guid.Parse("23c97770-11de-4ee2-be73-f3174ef7bc57"), }, { Guid.Parse("035e9ac1-ebd2-462d-9f67-7809b96e9642"), Guid.Parse("7810878d-d06c-433b-b538-31e66dee51e4"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Guid[,] { { Guid.Parse("959f4cc5-b1d6-48e0-891f-72a20afa0a6c"), Guid.Parse("acb78f65-729e-4b38-a337-652c0396d711"), }, { Guid.Parse("c7f9e59e-434e-49f9-9018-e5b96dc345fa"), Guid.Parse("0c291190-e1d3-4040-ae48-7b061ed1b7ca"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 129,
    Value = 
new System.Guid[,] { { Guid.Parse("4ff5fbdd-4e60-40f6-9ac4-0a1d4b5a4676"), Guid.Parse("c0ffea9a-c9bf-4873-afb7-61b5b63a729b"), }, { Guid.Parse("092413fe-9d82-450d-b843-a8f26cdc4436"), Guid.Parse("3563d0e5-2a6f-4f78-af03-f6de656135b9"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("8dd932ce-58e2-450f-b744-030ef1edbcf9"), Guid.Parse("65dcd84d-c2a7-4d42-84ab-fec56039b6ed"), }, { Guid.Parse("52c40524-0451-4bc4-9ef3-55fe4530494b"), Guid.Parse("081384e7-e299-4b99-b97c-fd469eed1fdb"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("86b53ca0-0732-4199-b0ff-91ca6971c64c"), Guid.Parse("d2ca78ab-7879-4150-9515-a1987db1bed4"), }, { Guid.Parse("ea1818e2-29b8-4ff2-affc-5ed2af03ce54"), Guid.Parse("9aed0064-79cc-46e5-8735-c1bede471d1b"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 147,
    Value = 
new System.Guid[,] { { Guid.Parse("8faef89a-d2ab-4cc7-bd7c-36766c1eec34"), Guid.Parse("92f5b4a8-6378-4104-a7e4-c454283cbe15"), }, { Guid.Parse("2e13760c-16f1-435c-8839-ef760ee5b622"), Guid.Parse("270df076-30f7-4f18-9a1e-513202877f12"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 130,
    Value = 
new System.Guid[,] { { Guid.Parse("68fb3749-c98c-4a44-96c4-38b30f366741"), Guid.Parse("657b2aec-6530-4b6e-9563-9b3172cfdea2"), }, { Guid.Parse("a0222ff3-a3f3-4230-a110-a46f4e86da44"), Guid.Parse("5b5abc93-d46f-4dec-9ff6-85c8506deb81"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Guid[,] { { Guid.Parse("4d35d9cc-cebe-4a65-af49-4ea1edd53276"), Guid.Parse("ed40d5d1-e081-4381-b2ea-a875a54ab62b"), }, { Guid.Parse("6a3e55a3-d8c3-4726-ba7c-0479919bf897"), Guid.Parse("6188f4ec-040b-4f96-a019-90d4c533918a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 134,
    Value = 
new System.Guid[,] { { Guid.Parse("0e1084fb-b590-4174-8f0e-9d1b0f21344d"), Guid.Parse("f358be69-58c7-4fa1-b92e-f3f71547b696"), }, { Guid.Parse("7665541e-433f-44f9-bab3-e330e06affe3"), Guid.Parse("c8cf78ab-3b1e-4ce6-a8d3-6bc47da443cb"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("3f580e49-8669-4543-8245-01fb6082efc4"), Guid.Parse("d00745b2-aac0-451c-9b38-552a2864ca67"), }, { Guid.Parse("fc5863b2-4538-48ca-8a1a-4ba47f9d777c"), Guid.Parse("a7a549b2-87a4-4777-998a-f247976c6c3d"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 158,
    Value = 
new System.Guid[,] { { Guid.Parse("69705641-55f6-4e6a-89aa-a5a8e24297ca"), Guid.Parse("6b2bbf49-731f-4f70-b562-44575b1228b5"), }, { Guid.Parse("fad983e0-1765-4c59-854a-59eb7caa8e2d"), Guid.Parse("72fcb444-e217-46db-9546-9730e99b50b3"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Guid[,] { { Guid.Parse("f339460a-68ff-4bc1-9f63-acffb0bd6360"), Guid.Parse("24a1a715-5a26-4d5f-a453-6933adfc0f4a"), }, { Guid.Parse("8f32bfb0-d429-4d46-ab7b-794142f5f3c8"), Guid.Parse("8531175f-a80a-4c0d-a21a-f0e3908cf6c6"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("a52f16cb-6fbb-45e3-acf4-a6f569f81708"), Guid.Parse("c138f30d-41ab-4b15-953b-e1420f88237f"), }, { Guid.Parse("338d71d8-e695-4aa0-94f8-1db237f9db95"), Guid.Parse("3ae5df11-e443-4d4d-9ee2-44eac93fe863"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7dcfdd82-0c55-4914-b9b0-ad041a696caf"), Guid.Parse("1fdf30f0-ae0a-4e39-ae94-495384b244b0"), }, { Guid.Parse("a915eaf7-8c30-473b-8978-c0eb073367a4"), Guid.Parse("9a1b18ca-f38a-4e20-a2b3-2c5f0e91951b"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 160,
    Value = 
new System.Guid[,] { { Guid.Parse("e3b72628-4b35-44fb-aab6-c6c61af1a88b"), Guid.Parse("c21b5951-c1ae-4eac-89ad-708b5a4910ff"), }, { Guid.Parse("5d41918a-b299-46e3-929a-b627d49ba13e"), Guid.Parse("d9a505d3-0640-474b-97f1-88b3fb77e715"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 136,
    Value = 
new System.Guid[,] { { Guid.Parse("4a29bb68-f640-4478-94c5-171785f6d218"), Guid.Parse("2ef2bbe7-3a7e-48c6-9be1-f9a32f0074ad"), }, { Guid.Parse("c42b33a7-521f-4647-92f8-e9cd04c46d48"), Guid.Parse("93576080-a166-44d2-b6cf-134dab8f32ac"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("3646e482-9ba6-4c60-9c13-fb0381b2c627"), Guid.Parse("ff054be6-7ab0-4b8c-87f1-a4714f803306"), }, { Guid.Parse("8ccaf45a-6d84-4bcc-9bf3-4d8a9479a378"), Guid.Parse("da76db22-6f34-4234-af91-06dc7e3c3436"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e0336694-be07-401b-b13b-33e03af76f1f"), Guid.Parse("2b958b78-005c-47ad-8c42-007b425ab039"), }, { Guid.Parse("cf056020-705c-428a-9a13-05fa024b1363"), Guid.Parse("e0d57c06-8cc9-4bcf-aff2-b1d075dd7023"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 161,
    Value = 
new System.Guid[,] { { Guid.Parse("dbd721e4-ecb6-44d6-a067-88d3a5941232"), Guid.Parse("9684e28f-88c9-449c-8c98-e42d685bfd08"), }, { Guid.Parse("42936e73-5d8a-4272-aeea-bcd0b1ffdb57"), Guid.Parse("ea86c1cc-435f-4b86-b2e9-0a5d928093b7"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Guid[,] { { Guid.Parse("8c4ddeb5-754d-498e-8a14-daf8718f97eb"), Guid.Parse("4f871d91-7ed2-46b5-8de9-6b1d20f1595a"), }, { Guid.Parse("bd3b9435-e9c5-4399-b978-44226a1bcaa1"), Guid.Parse("4692d65a-56da-4195-a903-8c8c3c8a3ad7"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("6d81e0d9-11d0-4cf6-a4d2-850c7f87ae64"), Guid.Parse("94701c63-2356-41de-be45-f34565781665"), }, { Guid.Parse("761ae994-3c67-4279-9409-0a47f9a7428b"), Guid.Parse("6eb49606-e343-4c96-9e94-d506dec7f5bc"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 169,
    Value = 
new System.Guid[,] { { Guid.Parse("eb27da0e-01cd-4cc3-a39f-72a48a3a647b"), Guid.Parse("7ddbab5f-3680-402e-ae26-bad36e0e9227"), }, { Guid.Parse("37400970-c93b-4a7c-8d68-aac99787a869"), Guid.Parse("962c803f-ba97-4f84-9c91-5631d8e8376d"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 151,
    Value = 
new System.Guid[,] { { Guid.Parse("d36f6c40-f82d-4bfe-9e13-e09eb1701908"), Guid.Parse("b64ee7c0-33b8-4188-9e96-7682c4587354"), }, { Guid.Parse("3097a236-6369-4fa3-aa99-63f30b91d225"), Guid.Parse("61ead550-8955-4be6-8c64-a290097a3f25"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("8171dfa1-84dd-41d3-a308-45d28ec642aa"), Guid.Parse("b4ec0649-a491-4e6d-95b8-dc9f359f5637"), }, { Guid.Parse("4dfbcee8-6baa-4054-b1d7-c196a33a6a6d"), Guid.Parse("e12bd869-1b23-4243-82bc-81c27e6ff6c5"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c3ed86ed-5cbe-48e0-892f-8de70115a1a5"), Guid.Parse("cdb93182-5ca4-4efe-8bd4-14ea9fa22cb9"), }, { Guid.Parse("dd374feb-6f19-4c5d-a740-7d506cba0233"), Guid.Parse("f72e2a94-5d96-4b38-a40b-d76174b8cc6e"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 176,
    Value = 
new System.Guid[,] { { Guid.Parse("63cffc0b-abb2-4428-8902-ad47688af951"), Guid.Parse("98dd3f8c-4187-46ff-b665-959dfe04c557"), }, { Guid.Parse("de84d234-8367-49d8-8866-92827586e009"), Guid.Parse("5c3d4c81-eb28-467c-87ec-47fd8fe78fa4"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 154,
    Value = 
new System.Guid[,] { { Guid.Parse("8b0e0b3a-c39c-4b09-8402-355cff165709"), Guid.Parse("37dddab6-8806-4431-a432-13993117c11b"), }, { Guid.Parse("aec6d723-01ba-4189-bf0e-64234357f703"), Guid.Parse("180800fb-5985-4862-a7d3-4aad195211b8"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidmarrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UUID))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UUID))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IGuidMArrayMArrayD2)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IGuidMArrayMArrayD2)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.guidmarrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IGuidMArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IGuidMArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}


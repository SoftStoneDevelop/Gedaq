

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
    Id = 1,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("60c43c26-570b-49ae-b064-b279e2801205"),

Guid.Parse("50431b16-2ccb-4ccb-bc64-ee14156b48f9"),

Guid.Parse("fa99b04d-eee7-4cb5-9dc1-f7f1634d97fb"),

Guid.Parse("1c9b355e-482f-46d7-85d5-a4e022417c45"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("03ece2da-05ad-495b-95d8-469f9d269e70"),

Guid.Parse("3f11ae8b-699c-4959-8c1f-2bb65cb2b79a"),

Guid.Parse("7d9e1691-0418-499f-a790-9bfe3a2dfe49"),

Guid.Parse("5de95f53-091a-496f-89a2-044f24e32e70"),

},
},
            new GuiduuidListD1E2M
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e8b95b07-2496-462d-b3e9-0ceca8e47a73"),

Guid.Parse("8590acdc-0eee-4de2-ba98-d8d2e93cf80d"),

Guid.Parse("45b2d818-5bf5-4f16-beea-1984e54a0c12"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b1f04793-d3e3-4327-99e9-b74a5285edab"),

Guid.Parse("3f20ffd5-6c67-490d-8a40-d70541552156"),

Guid.Parse("93a9ca7d-b083-4927-89b5-60ece261fb80"),

Guid.Parse("da88e26c-f259-4fe4-94f0-0762e4853193"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6c4d6a20-56d1-4330-87fa-b67ae7fd487d"),

Guid.Parse("18e3f188-d682-4062-be02-31be88e73596"),

Guid.Parse("78c2c766-28be-4e84-aa12-ffe9d83f049b"),

},
},
            new GuiduuidListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("09114fb0-ba16-4a77-a896-b2117e6d7a93"),

Guid.Parse("2cd0d6be-01a1-41f0-a47b-73579348e6f8"),

Guid.Parse("dbe9c8ad-4fd5-46f8-9df2-4dc9484aaaeb"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d66f6236-635e-455f-991b-62ac92a33e8e"),

Guid.Parse("bcf8b3b5-93ac-453e-8197-2b285033ed02"),

Guid.Parse("5034178f-d7ff-419f-a065-4284abe48c11"),

Guid.Parse("3f5b9065-c8f8-430e-b057-6226d4a6879f"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("355c6f2e-7cee-436f-86b7-471a958cf87c"),

Guid.Parse("4c2afe4d-1393-44f3-b32a-43668f754fa0"),

Guid.Parse("370dcdf4-34ff-4ace-8030-786af4f782ce"),

Guid.Parse("d3709172-5c58-4449-86f5-10b75eb980e1"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f66c5b3a-9b0c-4d73-89d7-c186f25775f6"),

Guid.Parse("43f51a68-29f2-484d-a0d9-bcfaba9d9462"),

Guid.Parse("36a23e43-31b0-4f9b-98ce-15502147148a"),

Guid.Parse("d746ddf5-df25-4039-a3bd-58d13c652f5c"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c05ae2b2-471b-4b8e-914d-19afc4779d35"),

Guid.Parse("97a56b85-e4ff-41e6-9ada-791d36e71e92"),

Guid.Parse("1182b06f-9d38-44da-9491-91c52e95e9f3"),

},
},
            new GuiduuidListD1E2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3e9b40bb-5edb-4823-92fb-3b4f463c74a8"),

Guid.Parse("b0b139e7-9d49-4828-bc26-33ef8121e55d"),

Guid.Parse("9d9eb6b5-9bd0-4b5f-99ba-f518fd8eb7f1"),

Guid.Parse("d6980e0f-710f-4016-b413-487fd498463b"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a016f47-3dd3-492a-95dd-9b9abb154e9b"),

Guid.Parse("8993c31b-da4a-4721-81e8-aae5ece6f67d"),

Guid.Parse("a70f3e37-eb04-47ea-a3ec-7f2b08b0e969"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("33ef34e1-13f7-4b7c-b3f0-2f38847d7e56"),

Guid.Parse("248e065f-ccda-43b9-b3fa-8b3a8875e08e"),

Guid.Parse("6014cbcb-2e78-43de-814d-eb6054793db1"),

Guid.Parse("1fb26fa9-940d-4c28-9abc-838e5aefaf20"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fc7d5c4a-6b29-4de3-98a7-4b3c4e9927e5"),

Guid.Parse("b45610b5-440f-41c8-bcf2-7462465e45ff"),

Guid.Parse("b0571daa-4a2f-4bd6-8315-5426f3db8a5a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5b79faaf-30cf-44ab-acc1-877c968769c1"),

Guid.Parse("79adc167-8913-4f64-892c-50006c6a6335"),

Guid.Parse("1d8d9417-dab6-4290-a851-2f26d3f1e648"),

Guid.Parse("22c92176-7a9f-4bcf-abae-7f0b6bef1685"),

},
},
            new GuiduuidListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("311d5bc3-7207-4a40-91a7-fcfe173abd65"),

Guid.Parse("10ce0d79-9f15-4ffe-afdd-597f5deafd4f"),

Guid.Parse("e97944c5-93c2-42b9-9610-63f51628777a"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e484141c-cba8-4b0e-8823-adbc6b1d23f2"),

Guid.Parse("d00d527e-4472-4265-a392-04b51e879aca"),

Guid.Parse("06100ba0-567a-4fc8-b8de-4ea057358bf7"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2aeff8c3-76a1-435b-8fc4-8caebff58fa5"),

Guid.Parse("ac9c1b73-0a8d-443f-8181-8325232b23f9"),

Guid.Parse("d01ba567-9780-4e34-a462-344d9ed94df5"),

},
},
            new GuiduuidListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c2f6c065-2435-41e5-a534-f760849665b1"),

Guid.Parse("ef3a4c94-c653-4957-a5bc-a0a4f862035f"),

Guid.Parse("b6f67c88-f050-4c31-b5de-bca22a2fd63a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ec884e6d-396f-4754-ae6e-1c0969029272"),

Guid.Parse("bd932794-f4ae-4857-aa1a-7e15bac48efb"),

Guid.Parse("de6fe075-5188-426b-9e02-cf034c321bf1"),

},
},
            new GuiduuidListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dba2f8a4-3355-4687-8726-67342a301612"),

Guid.Parse("8e6a57f6-59ce-46f1-a070-94abb382c92d"),

Guid.Parse("e68f2e01-b3fd-4683-8690-55b392fb5e9e"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("18f7f3e6-bf7a-459b-8fc7-77531dc8824d"),

Guid.Parse("09c3b5ee-39b7-4b45-922a-9bdaba4bb2a4"),

Guid.Parse("2dc702e6-e88a-42d7-81ec-1a5346faa498"),

Guid.Parse("7b057d77-11e4-4bac-8f9f-fdf643343bd5"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("11ea05e5-1bb2-4f02-ba1c-6b3b114ca2a7"),

Guid.Parse("91a85651-98f3-40c7-a30d-e7ba82697486"),

Guid.Parse("224ddac1-d565-410d-a9ce-559fba4d6ee1"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("50b73ca2-f8a2-4834-8a70-9b722cc1fc84"),

Guid.Parse("58eefbca-50d7-4fdd-a374-202980d3e680"),

Guid.Parse("46fe7630-8d50-4dbe-a559-7d4c8d4001f4"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("02d25691-1af3-472b-a9d4-59472cd39141"),

Guid.Parse("81e0ad59-bb52-4af5-9715-3a486a3e7ce3"),

Guid.Parse("cf7ed0d1-16f6-4426-9f46-865fce1c70f5"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7c81b83f-400c-41ec-9b56-71f806823a15"),

Guid.Parse("22e6f22f-60c4-41d4-b5b7-8bf78fee269e"),

Guid.Parse("d029810b-7871-4e11-bcd6-ded4a210e028"),

Guid.Parse("a256b07b-90b5-4c0f-b339-74e92c17dfef"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dd4773f4-a4fc-4ceb-97d4-7deda819a148"),

Guid.Parse("be62f829-fc10-4a4a-aef8-2ee38d9ae997"),

Guid.Parse("50ed514c-e911-415b-bccb-2b773e8151de"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("994efc14-4cb7-4ad3-be2d-7fc28147a04e"),

Guid.Parse("aaefee1c-afc7-4b1b-8d31-0765dc795139"),

Guid.Parse("5d537895-3fc6-4f1b-ac6f-5448f7431a5c"),

},
},
            new GuiduuidListD1E2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("86bbc884-4132-40d2-a992-15c3ad45b356"),

Guid.Parse("a957e512-d344-4946-a0b5-3151254ca0d8"),

Guid.Parse("143e73a1-cfd6-4562-93e2-0e124f6116f8"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("87494b33-6970-4d83-af3b-2b4d5fea1018"),

Guid.Parse("b09bd6a5-f0d4-4f91-99bd-e473288210a2"),

Guid.Parse("975f1549-3477-4c6a-a4a2-c88044b91ab4"),

Guid.Parse("fa239f42-0fad-41d8-a59a-75f7700231f8"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b832ff21-25cd-43a6-9524-fd92af668149"),

Guid.Parse("a2cc8441-055c-4d50-93ff-5d736701229e"),

Guid.Parse("8a865ac8-ffeb-4681-acb4-5881a34126d7"),

Guid.Parse("9c53838e-2a47-4e66-818b-90b6884da40a"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("407dac1c-14f7-4879-a33c-459402647554"),

Guid.Parse("9025912b-47e0-4e28-a44c-d7377440c1c2"),

Guid.Parse("9350082b-6ee0-4621-a55c-5c4ae567703b"),

},
},
            new GuiduuidListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b6b01d8b-bf24-4447-9f17-1174120e32b9"),

Guid.Parse("4c826b3e-62c3-4352-8c34-dba11baf988b"),

Guid.Parse("c2c04f81-6517-4fd2-91f0-1b862b1ef03f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0ad92085-8e7b-4de7-ba16-24e9f4cf4a35"),

Guid.Parse("350431ca-eb62-43d6-a1e5-b49b981d2e98"),

Guid.Parse("821f78b9-3266-44a8-a836-43f1ba7cab38"),

},
},
            new GuiduuidListD1E2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b8aa1412-af8e-4b7f-99b1-f43de4939dd0"),

Guid.Parse("63cb87ad-02fa-4076-bcc2-0af0b34db755"),

Guid.Parse("6fdad0b7-ead7-4ba1-98e9-02aaddf6e1be"),

Guid.Parse("01ec7562-b7b0-4fc5-b3f5-6fae1dd80062"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b814f824-4e56-4600-92a1-e4c5d4d39322"),

Guid.Parse("c82ce088-6aef-49ee-8ef1-4feb4a0f7f4a"),

Guid.Parse("59af2e0c-3f5f-400c-9337-e5280a631564"),

Guid.Parse("5dd64542-7735-4212-9661-7af00f7a5a6c"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7a0b729a-fa21-493e-ac24-38abc9a5658d"),

Guid.Parse("3353bf67-953b-4187-a052-9f5e3a5e5858"),

Guid.Parse("6275a833-ad92-4c63-b4fb-43e0e2ffad6c"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08b4b7e1-243e-4ae1-8b75-238f94d71c92"),

Guid.Parse("775422d9-d931-41ea-be00-48f1cf9533ee"),

Guid.Parse("9cd9d266-acdb-4395-8ccc-5e5fd04002a5"),

},
},
            new GuiduuidListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2e357ff3-e173-497d-be6a-1607b47f0021"),

Guid.Parse("a4a9b77f-7f4c-42d5-b456-71982331cab2"),

Guid.Parse("06498d5e-abbf-43db-86e5-c3571f71672e"),

Guid.Parse("bcc4e128-3c7b-455c-9aab-0a6428e6edcd"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("de36d37d-e929-4a9b-9386-885d05adb8b1"),

Guid.Parse("ce57dece-28bb-4ce4-b6f1-8e916cd9b09b"),

Guid.Parse("7f1d2292-1b7a-4ee1-bcc6-b9d7417b77ad"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a6c709d6-9e20-4705-8442-18401283c78e"),

Guid.Parse("6b05ce63-ced5-41a7-8c00-dc705f7c7579"),

Guid.Parse("833c8787-a01c-405d-923f-5283aa900e2b"),

Guid.Parse("48e74ce8-4428-49e3-8292-74aa0703bcef"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a386a003-068c-4644-94ec-4f8132ed710a"),

Guid.Parse("9e465225-4801-445e-b222-cb1b2bda3c56"),

Guid.Parse("683ba43f-0911-40b2-93e2-7c3f427fe64c"),

Guid.Parse("5232284a-8430-4727-b8f6-cb389f397f48"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9a1dbd60-a944-4b82-a0a4-9522859200d3"),

Guid.Parse("1258187f-cd56-4e70-8b59-f30f37a93b22"),

Guid.Parse("626a8f2e-b300-4ccc-9e6c-7f099ebf9b8f"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f31f5cef-f940-4b47-bff8-f1d4315a917c"),

Guid.Parse("09a04d2a-fea7-4326-af50-d4b5f234bb60"),

Guid.Parse("5c7389a9-7ce4-49cc-b1b5-23b161bb145e"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9377f9e3-3fa4-4c19-81d6-7ebd11d66c80"),

Guid.Parse("743d5ef7-22e6-4ec9-9c3a-41243eaa6a21"),

Guid.Parse("1103a3be-0929-4717-8070-7e46aa62bd4b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b95555ff-5bca-4910-99e1-e756f1155e87"),

Guid.Parse("6ea9b0ca-c8ee-4208-850b-48905798cbb4"),

Guid.Parse("2b25a4f8-9aab-4a8d-997c-1e2f037a34da"),

Guid.Parse("d800345c-b976-46d3-80f8-000dd0f899a6"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3ff40c3-b633-4e45-aef5-1871d5f3b964"),

Guid.Parse("ef8c29b7-185f-46d5-be01-3120dc48e62d"),

Guid.Parse("0ef53d04-92c5-40f4-916d-449b87ea4b1c"),

},
},
            new GuiduuidListD1E2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a5eccbd6-45e9-414e-9757-a38ca3d4b731"),

Guid.Parse("5eb25ee8-9642-440f-883f-d61a85b42529"),

Guid.Parse("dd1f9709-271c-4025-b335-1d668c34f87d"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("32b242c8-6992-45b8-a5c5-b3c972f9687f"),

Guid.Parse("8312c2d7-bd48-4941-9b99-2d883a40f9a0"),

Guid.Parse("a9839b68-1699-48b9-8c3a-0bc28533043a"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ca6d0388-ee6d-4b08-b3b6-dd114ae8c46d"),

Guid.Parse("c3e56272-f258-48a1-8c88-d7eac671fa95"),

Guid.Parse("ac4c0dd9-cd04-4670-adc0-ba7375fd8f30"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a00e401c-46e2-4db3-8fbf-3d5e9254334e"),

Guid.Parse("288de387-4666-4436-bbc8-0252c8fd5096"),

Guid.Parse("33e9ea88-6c80-4cfb-9817-6e0003f38a73"),

Guid.Parse("25a25fd1-7d38-4f43-a1b6-cd64809d2f12"),

},
},
            new GuiduuidListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3cbbd888-f49e-4d55-b7a9-c9e9893d34c4"),

Guid.Parse("dea6fb5d-2fb7-4c63-95e9-d6f5512b6c93"),

Guid.Parse("e43d6420-2a9c-4332-af15-15ac7f87834a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5658b232-7cc1-4346-8b53-49725c285578"),

Guid.Parse("f8034450-f8e6-4550-8665-bb8faf5525ff"),

Guid.Parse("a124e426-6753-42b5-9d66-ca9b824b9105"),

Guid.Parse("2e28ada4-b1ed-4792-b88c-8fc64dc8e617"),

},
},
            new GuiduuidListD1E2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("13921e23-e769-40da-8eb1-4532d653b57f"),

Guid.Parse("d0792256-c3b1-41b2-a46b-d14cd95d8a69"),

Guid.Parse("f98734d4-7ffa-4592-b914-ff047c38bd80"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2521b22c-eb43-49fe-98b8-38fbf5ac9a12"),

Guid.Parse("a15c04ba-ef69-4329-93b9-8ad658f78ef5"),

Guid.Parse("1723d4bd-13c8-4949-85ca-ce1795acccb4"),

Guid.Parse("902c89e2-f879-4c18-a35f-b6ef6a507647"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b87150b5-3650-4ff2-a828-3788df64f5ff"),

Guid.Parse("f0dd1add-11a5-438c-9f66-42247cbd2c6b"),

Guid.Parse("4fe6c11c-aaa5-4143-b156-56a2aae791d6"),

Guid.Parse("c100ce6e-b7b6-4134-8db2-d65a4f262459"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c8b9e1d9-307c-4d64-8625-116891b14033"),

Guid.Parse("1131d034-7c01-488b-a11c-8d5f1393825e"),

Guid.Parse("b281db53-f492-44f5-9621-c104873d7458"),

Guid.Parse("03e2b817-c41b-47b7-a02b-7a42ab121175"),

},
},
            new GuiduuidListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fed624d1-ece8-416d-b9ed-db3254ca37d1"),

Guid.Parse("9ee8a3fc-fa24-46e4-8d68-a65bb333bfb2"),

Guid.Parse("32752df0-7112-49c0-bdaa-b89928bb4a1f"),

Guid.Parse("bc6172b0-5de3-40a5-926c-2cca039ad1b3"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0dcdd38d-9e52-4e84-b69f-6e7d8b56d862"),

Guid.Parse("ddd5f7cb-e10d-4c80-9cbd-eb02694d32e2"),

Guid.Parse("8192a8bd-c40c-465e-8fc4-cebf79dc4ece"),

Guid.Parse("71ac23d9-9dfe-4eee-b21c-a384754d4ed1"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9b379151-a342-4e3f-9cff-7d1ec4d35e46"),

Guid.Parse("0ac4a05a-b855-4848-b16d-b0af3f8d749c"),

Guid.Parse("0cea4b21-fd88-4f17-8108-dbedc1d794ae"),

},
},
            new GuiduuidListD1E2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5ccbc4be-70cf-48ae-8f2b-bc11b0e7b98f"),

Guid.Parse("669dac60-1d38-489f-8f62-eb0293ae0bac"),

Guid.Parse("6b855b2b-4d49-446b-959a-ce8920f6524c"),

Guid.Parse("44fe039e-d2bd-4294-b55a-f5d3407d0a19"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9b362e6e-2a73-4f01-8210-7d6f1b0f97f0"),

Guid.Parse("a79fe37e-178d-436c-a23e-efed9e516ab6"),

Guid.Parse("0cf78552-f120-40c5-98ec-a48fb934218c"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cc1461c8-d013-46e6-a7ea-4751a8d77bc1"),

Guid.Parse("4502f81f-c693-4b37-bb49-2c07a24da14d"),

Guid.Parse("26d43b16-b570-442f-b3a1-01594e1a71c5"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0eba99ef-f008-4dbc-9b28-60826943f45b"),

Guid.Parse("af13e114-97e4-4dae-9895-4748d98c61f2"),

Guid.Parse("62502cbf-744d-4bd7-870c-0e809d4f0b12"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("104cdc8d-faae-429f-9192-52d2a599f601"),

Guid.Parse("a68deeec-260a-4621-9605-efd41f25b9c0"),

Guid.Parse("40ce13d1-6720-4f89-91e8-d73c166300aa"),

},
},
            new GuiduuidListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4043f7f5-0dfa-48d0-add9-add98f6ec896"),

Guid.Parse("2af81c4e-099c-460a-90c9-8e849c5e3aaf"),

Guid.Parse("40feab2c-f8c4-4b9b-bf15-3502aca04eef"),

Guid.Parse("126ee000-462e-4089-8101-a61394e2597b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("753e24a5-394a-4112-bb74-5fecfdaefbf4"),

Guid.Parse("911f03d7-e4f9-4adc-a190-96c1673c52c5"),

Guid.Parse("8ffab921-aa30-4b22-a1b7-0435fa3fe833"),

},
},
            new GuiduuidListD1E2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("be723188-1863-4f8c-bcb1-309ae6e1bb07"),

Guid.Parse("540bb926-bf09-4147-8421-3ea49ac300d6"),

Guid.Parse("4eeebe0a-8de4-4b8b-9583-ea338b549e24"),

Guid.Parse("0752d921-4118-448e-a507-278270ca1ef3"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b8f7e218-671a-4d77-95e6-54fefbf56bff"),

Guid.Parse("b79b6fc1-ee62-4367-997d-79cb7cb6c9cd"),

Guid.Parse("6ad399db-7868-4301-81d2-d6ac7121ed9f"),

Guid.Parse("e13d665c-74d5-4592-9300-deaae4cd1e63"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e38a54c1-836d-45a7-b4e3-828f7f2c99c3"),

Guid.Parse("4edddb7b-a78f-4a61-b7e2-3c7ca575d341"),

Guid.Parse("e01129e6-d729-4a2a-bc17-4912f57021b4"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b54f5827-fa5d-4674-b9d8-a43929ae5654"),

Guid.Parse("2cc6a5c7-4a6a-4d82-a74d-4aa19cd5249e"),

Guid.Parse("114cc6a5-7f3b-4730-b4cc-77174479a64d"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("19beb0e1-a9fd-4a0c-995f-d5109200efbe"),

Guid.Parse("13f0227b-3696-4f15-bb0f-4cf8a2c07b9a"),

Guid.Parse("3591a194-3253-4ecf-a4ee-fe30f46d9c0e"),

Guid.Parse("7859a352-d582-460d-be98-f3db0b003ba6"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a739587-c8a7-468c-ae6b-904fcc8d8b4f"),

Guid.Parse("f10ca2f8-dc45-4622-bfa3-50624a2a6706"),

Guid.Parse("74397a87-dc25-40ca-b74c-7d15c6ce4681"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("66df5616-d782-4137-9d45-074eced9222c"),

Guid.Parse("cbcea5e0-cfd4-437e-9146-7a1fd7d0b74d"),

Guid.Parse("6f85c09e-a611-454d-964d-959472bef84d"),

Guid.Parse("3812f2cf-6361-4ed2-aee2-e09cbe65113d"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bbe5d9b5-4269-4a77-9df7-c11c8cac1ccf"),

Guid.Parse("b900a8d9-51ad-4d2c-814f-e4e0bd1e97a3"),

Guid.Parse("442018c5-9beb-43e4-8831-e87f390fb73e"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41e1fde0-9d62-4c8e-9518-febd57e31d6d"),

Guid.Parse("ea7740b7-c087-4e2a-9edd-aecfc81294eb"),

Guid.Parse("9ea22788-4a77-4c81-aa10-dfe11483b266"),

Guid.Parse("8038e021-d175-49e5-92c0-2d70f8d22cee"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2170e203-42e1-45fc-b1c7-e8314a37830f"),

Guid.Parse("c2fd13c8-aaf5-4175-ad22-608fa9f0ec2b"),

Guid.Parse("1804c6a2-64e7-49f1-ae4c-84514c74ac9b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("472981fe-3b60-40c1-8a76-a3beb81fbe0e"),

Guid.Parse("e928c8d0-215b-4977-bbdd-fa249342d4c5"),

Guid.Parse("444a2c23-4b73-48d2-b8d4-b92e7feb2309"),

Guid.Parse("cd1bcb2f-5765-4fe3-b520-99858f3ce6a7"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b74dff80-74f5-44c2-93fb-e706378653ee"),

Guid.Parse("dfec1dc3-553a-40c1-85c9-e1db79932e1f"),

Guid.Parse("28b97d2b-ea38-4c21-bfe3-d8b72b1bb3bf"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d8738db6-112d-49ec-ad1c-63765117993c"),

Guid.Parse("bf790752-771b-4f01-8ac1-fe7e422b899e"),

Guid.Parse("017f0639-6ee2-47cf-a3ed-754e98eae413"),

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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
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
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
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
                parametr1.Value = 101;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
                parametr1.Value = 53;
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 156, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 151, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 101, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 32, query1, 170, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 165, query1, 16, query2))
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
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[30],_testData[34], false);
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
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 170, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 1, query1, 32, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[28],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 92, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 156, 81))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatch(connection, 156, 144))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[34], false);
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
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models =  ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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


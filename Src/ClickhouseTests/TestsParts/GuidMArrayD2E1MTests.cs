

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
    Id = 5,
    Value = 
new System.Guid[,] { { Guid.Parse("c42d41b7-1ea2-45e0-a243-4b0857dd2c5e"), Guid.Parse("bbf3d556-acca-452d-9939-3538885afcf4"), }, { Guid.Parse("b42ca826-1a8b-4d54-8323-3dafdc8a928e"), Guid.Parse("51fe2de6-f48b-4d6c-b012-432431efc969"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 1,
    Value = 
new System.Guid[,] { { Guid.Parse("0ad9d42b-66e7-4fdf-9c98-a078a88a9c90"), Guid.Parse("7e28fe4f-e321-432c-8b54-b6106cc935be"), }, { Guid.Parse("760683be-25ef-4497-9b77-6a5b7e04721f"), Guid.Parse("a6487a79-246c-43ac-b7ca-fe2d0637d41d"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("684e6bba-e436-4b0c-8b94-3574660a2fb8"), Guid.Parse("26dd1bb6-72b5-42c0-9da1-e86bbed4ebd6"), }, { Guid.Parse("ab5c615f-f4b8-49b5-b495-2bfcc77f8dc7"), Guid.Parse("cf8da787-01e9-4986-8535-af0548a4043d"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Guid[,] { { Guid.Parse("ddbdd144-6698-4b3a-8d34-6145f56da11a"), Guid.Parse("eb2e8291-4d9d-4869-949b-a46784a04b2f"), }, { Guid.Parse("ecbf283f-1d15-4856-93f2-0a33b421e30b"), Guid.Parse("ea9f0bf9-2861-4b23-a0ea-c25b73ac7708"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Guid[,] { { Guid.Parse("895c0bfb-e011-442d-b624-99073331ecf5"), Guid.Parse("38ab6cd3-a9da-4b97-9759-e43394e4c8be"), }, { Guid.Parse("93f0cee3-6ef1-4981-b9ea-95f7b378b521"), Guid.Parse("0d28e1b7-1505-4e68-8e9d-2cc15f5dd500"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 20,
    Value = 
new System.Guid[,] { { Guid.Parse("4fe6131f-22ec-41de-a6cb-cb09537e6c9d"), Guid.Parse("2c1c7b3d-08c0-44af-843a-3b1e9e037511"), }, { Guid.Parse("9970cb97-7271-46e3-93fc-5681ced76834"), Guid.Parse("a66750c2-ffed-4d04-8675-0adfe5630799"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 16,
    Value = 
new System.Guid[,] { { Guid.Parse("73af4b50-ec1d-4355-a2af-0f5f12751e8a"), Guid.Parse("0a5481e1-e793-4e69-82c5-1b232722c840"), }, { Guid.Parse("1e7af54d-c8bb-45e2-88ed-cc09a80ea69a"), Guid.Parse("982110c9-5c55-466a-8c5e-c05964b8c9a7"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Guid[,] { { Guid.Parse("1258b481-d2ba-44ae-bd82-856897bfebfe"), Guid.Parse("63ad7570-a7b9-4f00-ad48-a7f3ce3caf5e"), }, { Guid.Parse("a4585c5d-05fb-4006-84f0-5b53e6bb3905"), Guid.Parse("40bf7aee-0a33-48b4-857c-9296b14d30c7"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 19,
    Value = 
new System.Guid[,] { { Guid.Parse("89875710-2eb2-47f8-a342-b1ba8638acd4"), Guid.Parse("77741ce0-d385-42d7-9b96-70a749fbc65d"), }, { Guid.Parse("9094fa3b-99a8-4360-a2ee-65433c024a81"), Guid.Parse("036511e5-d58d-4231-9a6f-98b16c1a6ce6"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5d483826-da81-4d7a-9932-11c123ce97cb"), Guid.Parse("11ed9fec-8fd7-4911-bbf8-a03c0ebb95ce"), }, { Guid.Parse("596a3cb2-eaf5-4203-92fb-19b8c05b65c3"), Guid.Parse("4706504f-1ff8-47bd-aed1-4f447200898e"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 30,
    Value = 
new System.Guid[,] { { Guid.Parse("a1e67d06-b0ef-40e6-a471-ceaed9725f9c"), Guid.Parse("dd2fe138-6b10-41bb-9d87-b6c312d12c02"), }, { Guid.Parse("48cda32e-a4fc-47b9-af02-01ef40fd3fe7"), Guid.Parse("bbe158a1-dbe4-41aa-9a6a-e32da7a906cd"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Guid[,] { { Guid.Parse("500321bd-3cb7-4643-b3a8-d26525f7ddcd"), Guid.Parse("b681c0db-5eb4-45fb-9bee-7e8b90b790cf"), }, { Guid.Parse("07ca2170-a050-4a43-8c51-868245437d18"), Guid.Parse("5f4796e1-bab3-4d70-aab4-856294042153"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Guid[,] { { Guid.Parse("1ea1085f-6da8-4820-8d31-8ed125a2dfa5"), Guid.Parse("fc62b1b4-068b-4f6d-8014-868ef4ae1e00"), }, { Guid.Parse("6df8f61f-15e3-41e0-b5b8-2387f4cdd5c3"), Guid.Parse("45e2acfc-0865-4349-baa8-2ba394f47511"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 28,
    Value = 
new System.Guid[,] { { Guid.Parse("2cafaaee-66e7-412c-8092-af885fb7cc3b"), Guid.Parse("5b9fb9c3-4674-4dc3-8338-87074f71884e"), }, { Guid.Parse("14303949-eee3-46f8-b008-6486691d64d3"), Guid.Parse("58aad479-acc1-4346-a2d5-c213a27d57d7"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 43,
    Value = 
new System.Guid[,] { { Guid.Parse("a8bbb762-5212-45d1-a1e9-2861e3c9f9de"), Guid.Parse("a8890cb4-2e1c-44c1-b902-c11d2de8c8c6"), }, { Guid.Parse("26103c02-d931-4e90-a709-326a4aa8b548"), Guid.Parse("542fc7f0-e100-46e8-9da3-048a6320a2ee"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Guid[,] { { Guid.Parse("0f40c84b-a3f1-40ee-a404-650ef45d8fa8"), Guid.Parse("6c302280-82a6-4c4d-af28-bf4909d9f497"), }, { Guid.Parse("402c2c1e-2080-4af6-8175-d85efe035586"), Guid.Parse("435444d6-01ef-438e-aaea-4cf353e90182"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7d3c43d7-d067-4bad-b938-29b674710c5f"), Guid.Parse("46fdbc22-b693-4c2f-9b7e-3ba04ceb9c0b"), }, { Guid.Parse("2f3247c3-3a85-42e3-82bd-0d7365b04195"), Guid.Parse("494799a2-b5cb-4b49-aab4-b730fbcf848d"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Guid[,] { { Guid.Parse("c01eda5e-8cc2-4ca2-a83b-508ec94ceb41"), Guid.Parse("2cea4790-e8ea-4a95-8485-98e5e3027191"), }, { Guid.Parse("6899bff6-2c9f-48c1-af29-43afb5982730"), Guid.Parse("011c296f-91f6-4204-86e1-aa7e56c455bb"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Guid[,] { { Guid.Parse("7d2dde77-2fbe-4340-a57f-3ac8f49f5563"), Guid.Parse("ad9da097-0361-4bae-875b-1c91f6356000"), }, { Guid.Parse("87e2da92-5a49-4bba-89d0-4f3088bc3000"), Guid.Parse("d159c0d0-f64a-442f-9e3a-18c8cb4f0829"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 49,
    Value = 
new System.Guid[,] { { Guid.Parse("e0ce1720-069d-41d1-af0b-6ef37cc343f0"), Guid.Parse("eadf402d-74a6-445d-bb56-757d876129dd"), }, { Guid.Parse("e9b537a6-7729-45c8-9f27-748dda130adc"), Guid.Parse("14febb52-8ee5-4903-bef8-493d92680cc0"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 47,
    Value = 
new System.Guid[,] { { Guid.Parse("560b43e2-7b92-408a-9246-f865b7c749f5"), Guid.Parse("33cdda5f-91f8-4dcb-83cd-8ae175ce1879"), }, { Guid.Parse("352f1b81-5a0f-48ec-9b00-75198a60baa6"), Guid.Parse("508af31b-68b0-4f7e-b30f-e6b46369e3f3"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("006ed4da-c0ca-4177-92fe-0f1d3b6f1b8f"), Guid.Parse("b73ba7e7-5537-4059-b6fc-79e46116ae06"), }, { Guid.Parse("e45036ad-6d38-4074-97c7-c35b4563b353"), Guid.Parse("e24c7908-4564-4648-aa65-46fdcd042b91"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("a257b5e2-d871-4dc9-803e-d81520b185dd"), Guid.Parse("fb2da7b6-0109-4003-9d0a-667b738e4d2e"), }, { Guid.Parse("d49ec033-508a-4ff1-b27b-547a3f0dc6a6"), Guid.Parse("050435b9-b0e4-4b8f-a548-8d714ce49302"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 58,
    Value = 
new System.Guid[,] { { Guid.Parse("fed89367-1ffb-497b-bd37-9f7cf01a43cc"), Guid.Parse("29f9636e-9e11-4bd1-9efc-1e14f6814170"), }, { Guid.Parse("1a1d8ef6-c108-434b-8047-a8d04ff68c08"), Guid.Parse("03210f2b-0dfb-46a6-8aa6-fe4d8194e910"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Guid[,] { { Guid.Parse("12185217-c067-4964-accc-aff4d5380759"), Guid.Parse("d205f83e-25a9-4960-a9de-531dcc679a03"), }, { Guid.Parse("536447c0-08cc-40f3-a644-be95b4da5c26"), Guid.Parse("4c86ad9f-a1aa-4392-8f2c-c3202eaa11a7"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 67,
    Value = 
new System.Guid[,] { { Guid.Parse("294d43fe-670e-493e-a7db-41eeb39972a8"), Guid.Parse("defb87c0-c537-4bad-903f-8376ef0a8994"), }, { Guid.Parse("a735649c-52ca-4915-8bc6-eac8d49130cd"), Guid.Parse("5f4621ec-8ea2-48dd-b628-81e7b9a3abd4"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 53,
    Value = 
new System.Guid[,] { { Guid.Parse("9757ca38-35ca-486d-bfc8-11fc6968f163"), Guid.Parse("8e0d9f48-5a88-4394-b1bb-f3a3c4420f33"), }, { Guid.Parse("90fcc672-3086-4ac6-87d4-76a28bde2fe9"), Guid.Parse("d3eaf677-fc58-4bea-9c8f-754751b01c24"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("550769c0-9d5b-4717-8e85-23cb814c9613"), Guid.Parse("1343e3b6-eaff-499e-b587-6a40668dd9e2"), }, { Guid.Parse("9937a158-69d4-4b1b-9522-7ac16615667b"), Guid.Parse("fbcde0eb-3523-4107-a5a2-e879e7efa38c"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 70,
    Value = 
new System.Guid[,] { { Guid.Parse("6458035f-d607-4cef-a549-6993383d3326"), Guid.Parse("7e5f0b85-c50a-48c1-8587-aa4df0bcbb8f"), }, { Guid.Parse("637e1f41-06ad-4bec-a3a1-042c461a40a5"), Guid.Parse("7cde17e5-c791-43bf-aead-4dde8fbcbf27"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Guid[,] { { Guid.Parse("800b348f-df27-418a-9c32-eeed2bf75bdb"), Guid.Parse("845fe67c-0362-4cee-a4fb-52871d7a0bab"), }, { Guid.Parse("93eb1900-6e39-487e-90d7-12053e09d2d0"), Guid.Parse("3e215a39-fe8d-49ca-92f4-7f65bbdce1b9"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("8eaba81e-3d44-497d-ba68-d095ee629bd2"), Guid.Parse("03817b3c-4341-47ae-bead-81d5cb9104e9"), }, { Guid.Parse("2882f7b9-0629-43d1-a16f-05b5f44311b0"), Guid.Parse("fcfa3381-dea8-4ed8-a87c-2b1b40cf199f"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Guid[,] { { Guid.Parse("565a0d0e-a762-41c2-bb79-36144d96f701"), Guid.Parse("145a41fb-b97c-47eb-901c-04064d4cc7d1"), }, { Guid.Parse("9cf85fce-00b5-409a-8e1f-4e92dcaad1da"), Guid.Parse("40dca66b-1715-4bfd-8535-6cc036d3f6e3"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 61,
    Value = 
new System.Guid[,] { { Guid.Parse("bf0dda02-0822-43d1-8c81-51f48bb885ee"), Guid.Parse("c2794126-4d0c-4c55-87e6-09b586e87d15"), }, { Guid.Parse("bb9e3832-2d44-45e6-9dd9-bf72e7e656df"), Guid.Parse("91b4f05b-a332-4382-b5de-226627322d8f"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5b1100fe-fe44-476f-a8a5-1028e425e002"), Guid.Parse("2c456170-5236-4cbd-9b9e-ae54934a6531"), }, { Guid.Parse("a7d50873-8336-40f0-b264-6ef95847b3f8"), Guid.Parse("857ccc40-ad57-4835-bd75-e4760d88ff2c"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 84,
    Value = 
new System.Guid[,] { { Guid.Parse("856a907b-8210-41b6-913f-af3926d14db5"), Guid.Parse("4f6e7fb5-1bca-4a92-84b7-e2326b99c3ad"), }, { Guid.Parse("c7146b3c-f4ef-4207-bdb0-20d4db1a6cdb"), Guid.Parse("1aba49b1-5150-45e8-9cbd-48882c04830c"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Guid[,] { { Guid.Parse("18be39ba-0a34-434b-ac24-1b77672e7465"), Guid.Parse("d9de9bfb-db93-4c5f-872e-2ce2b695cdfb"), }, { Guid.Parse("7cb02061-e67f-42be-9757-879ee5d7d4f8"), Guid.Parse("f525deb9-51e4-4a9f-a8c2-eeb883aae524"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("01dc48f4-df6d-4e57-a21a-a72703a29a83"), Guid.Parse("a8a0dc2d-51b3-414c-9565-31b74e940233"), }, { Guid.Parse("b1adcb20-e3a0-456e-8913-c4980e741639"), Guid.Parse("0c24ba62-93db-418b-a0b0-5e26f2dbdc12"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f8bfc67f-44f1-4258-952e-2f393f28c29f"), Guid.Parse("1d27a320-643d-4d6d-95ac-95c9209d7662"), }, { Guid.Parse("f77ad123-4860-4979-bc98-b7fb986dfc35"), Guid.Parse("16415703-3579-4012-acc2-c46819153901"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 86,
    Value = 
new System.Guid[,] { { Guid.Parse("d598abd3-8dad-4b6a-bd90-d341700678cd"), Guid.Parse("d058c984-da8b-436a-95b6-977562fd79a1"), }, { Guid.Parse("84d69656-1a93-45dc-8f26-d931324a86c4"), Guid.Parse("c22921d1-76a8-413a-ab12-9319a1926a2c"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 78,
    Value = 
new System.Guid[,] { { Guid.Parse("30e232c8-a136-449c-90bd-1a2b7c213e49"), Guid.Parse("1e42b5e5-4a01-40e3-baa2-0bf496658750"), }, { Guid.Parse("a16c988a-48c4-4b2d-8ebc-409adfb95338"), Guid.Parse("866ff776-c6f4-4aaf-8437-1ca1c0525d80"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Guid[,] { { Guid.Parse("6b067ef9-7842-4be2-b47a-4c5276f3ee3e"), Guid.Parse("8b2ca94b-7e81-48bf-8794-8c1740dd2e7e"), }, { Guid.Parse("fb498798-40ef-45b8-bf1e-a8a131b9c0ac"), Guid.Parse("832a2749-c37f-408d-94bc-948031081d1a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Guid[,] { { Guid.Parse("0624e934-0055-4bfb-a81b-370a28373ddd"), Guid.Parse("cd551731-59ff-428f-8f64-4c796c65f461"), }, { Guid.Parse("a5b4a2fe-385d-42c6-a655-50b8a9a90580"), Guid.Parse("6ec74a0d-6327-425c-bead-776931551fdd"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 89,
    Value = 
new System.Guid[,] { { Guid.Parse("607aa327-3bf6-4602-a46c-44382533d209"), Guid.Parse("603e2d66-7a08-4839-b8c7-29b147347420"), }, { Guid.Parse("de9744a2-a5ea-4820-adb5-745adf4cf093"), Guid.Parse("168bee74-d801-4a84-8fb9-c199c5e35636"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Guid[,] { { Guid.Parse("c41563c7-36f5-48b4-84bb-7512ed67c028"), Guid.Parse("ee0bef91-2c80-4de4-9ab1-b8b29522c1f5"), }, { Guid.Parse("181252a4-7fbd-4166-88df-8ca0be857923"), Guid.Parse("8fd762b7-b4d1-41c3-83b0-022603c2da01"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("3cdfb182-bfd6-4c55-b598-9944e258c733"), Guid.Parse("a84ee01d-1034-4232-b7a4-55bd8fc479dc"), }, { Guid.Parse("a1683015-89c3-481e-9305-642090147910"), Guid.Parse("e23c5da2-e3f2-46d3-ab69-a3353914b63d"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("99acf3df-93a5-4594-ba36-0241922b6f3e"), Guid.Parse("7d9e8975-645b-4d4f-94cf-9e25a399471b"), }, { Guid.Parse("13f9094b-b52a-4666-a6b5-faab28198467"), Guid.Parse("56d2e54d-4c02-4ad2-8c3b-f5b25f9e5a11"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 95,
    Value = 
new System.Guid[,] { { Guid.Parse("80640eb7-79e2-4449-93a5-bdeb73c7df5f"), Guid.Parse("4feced53-c44c-4323-9631-9f2485d4f4a7"), }, { Guid.Parse("c4f3eb6d-847f-4f00-8cd0-a8ecd3b30284"), Guid.Parse("877f38b6-d2d8-4b2a-b86c-3de38ae6962e"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 86,
    Value = 
new System.Guid[,] { { Guid.Parse("cf680d71-f46e-4cc8-8be9-2240f611bc0b"), Guid.Parse("26cbd2fc-bcdc-4289-9071-b0bbd8307d6b"), }, { Guid.Parse("2fca754f-9463-4020-ac90-482dbdc938f3"), Guid.Parse("8a4614d5-ffb6-46e3-b394-464191d471e5"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Guid[,] { { Guid.Parse("3af8b379-a08b-4fca-a581-996a2d5cea29"), Guid.Parse("c434e371-f475-4608-9d60-323b865de5c3"), }, { Guid.Parse("e23f6533-ad00-4040-8c8b-2cf3c7a899a1"), Guid.Parse("2b4f1af9-302b-4f36-8258-787cb61ab3ce"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 94,
    Value = 
new System.Guid[,] { { Guid.Parse("6c27d976-46b1-44de-ad7d-f71346624fd7"), Guid.Parse("ae8e4ffe-2505-40b4-a960-5db49c52bbea"), }, { Guid.Parse("1f263b3e-fb31-4d6e-a049-105169a0e6d4"), Guid.Parse("7927473c-863e-4be4-bb5a-96e73f44cdf3"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("08325091-f38a-4b46-be3d-7ef069734d5c"), Guid.Parse("3e784ef0-bbbf-4384-aabf-8ed77cbf1595"), }, { Guid.Parse("a2dfd8c6-994a-4938-bcaf-bbe8be1a696d"), Guid.Parse("a8c3745a-7b8f-48cd-8424-38ff481dfaed"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Guid[,] { { Guid.Parse("b282f9f6-87f4-44b4-9349-d62e45d6a850"), Guid.Parse("d32d9f03-708a-4ffb-a17e-84757093bde5"), }, { Guid.Parse("ca3444a9-f59b-4248-b67d-ea32e40869b2"), Guid.Parse("203737ec-45b5-4dab-966d-d1d6f3e7db49"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Guid[,] { { Guid.Parse("1266a27c-4f5f-4387-8021-108b38b74c6b"), Guid.Parse("b9e414ba-c66f-47a0-8d18-0968bf7b49ea"), }, { Guid.Parse("e996c6a0-0aa8-4ce9-b369-d4986c2fc4e2"), Guid.Parse("483d5c97-c634-4a03-a1f8-065d994d089a"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ec054470-4a56-460e-8baf-080149ac99e9"), Guid.Parse("763478b2-a2db-429d-a6ea-442f1192cc1a"), }, { Guid.Parse("a4b1b5e6-1ad1-4dca-b092-f477d30be489"), Guid.Parse("d1fee99a-5a16-46b2-969e-7d12c40ff375"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 104,
    Value = 
new System.Guid[,] { { Guid.Parse("9fed52b2-32ce-420f-983f-4e607cba3adf"), Guid.Parse("e92d6d29-2c07-4696-ae02-fbc46ffd3daa"), }, { Guid.Parse("b9c972f3-db53-4109-866d-3c9e9253ad4c"), Guid.Parse("0faf8978-a606-45d0-95f8-23b25a034488"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 107,
    Value = 
new System.Guid[,] { { Guid.Parse("1134b6d4-492c-4d2d-88b3-76a75ee71407"), Guid.Parse("b062ce16-8a02-4b52-b6a2-49aae68908a3"), }, { Guid.Parse("d06323a4-0289-4434-abd1-7b5d34f9eb16"), Guid.Parse("8b3d4d33-0983-4e31-b7a7-283ed82ba1e4"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("de3ced96-64ae-4870-9dde-ba9a6e31877e"), Guid.Parse("164f61cd-7577-4ab4-81f4-c0897bc984b6"), }, { Guid.Parse("86ff3fbd-4cb5-4e89-b87b-d0dc2fd4409a"), Guid.Parse("de5bd54b-883b-4426-84f7-8fdb1975fed5"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 105,
    Value = 
new System.Guid[,] { { Guid.Parse("de2b5cc0-2d4d-48aa-90c7-131bdc7bad1f"), Guid.Parse("529ddc0e-212b-4af3-b2eb-6b9ad7599a37"), }, { Guid.Parse("6ba2b078-1ded-4a28-b513-beed3d1129c5"), Guid.Parse("34fb58d4-b05b-499f-875c-695e9af3dc13"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 111,
    Value = 
new System.Guid[,] { { Guid.Parse("41699b10-1243-4956-9d6f-de2a0b28e876"), Guid.Parse("417e318b-8192-430f-83a6-64458ff1fba7"), }, { Guid.Parse("caff145a-2aee-4e89-8c51-65c690dc309d"), Guid.Parse("a9013900-c740-492a-b8d8-8beb4a3adcb8"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("34fd77b9-80bd-41cc-9045-06f6a1430b73"), Guid.Parse("576f528f-5d1f-47eb-b844-d557345c7132"), }, { Guid.Parse("87f0d2c3-a091-44cb-acfe-4aa6159aad8c"), Guid.Parse("40224366-0f57-4068-a875-570a0d595964"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Guid[,] { { Guid.Parse("200e59be-0e1d-49cd-bc5b-47347b89ff82"), Guid.Parse("e45b4fc8-223e-454b-b5f3-e0b2f9967ee8"), }, { Guid.Parse("d922e590-564c-476f-ba56-f82c448286e1"), Guid.Parse("161ad96c-8c12-4273-a413-8046f329fe88"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 117,
    Value = 
new System.Guid[,] { { Guid.Parse("5e174315-f1ce-4e23-aa22-fd854f43942e"), Guid.Parse("63591883-123a-45a1-9872-fec8cb36c938"), }, { Guid.Parse("89fbd1f2-3de3-4e6b-ab97-443ff1f2f3b6"), Guid.Parse("93361ccd-0192-44f6-9cb5-e7abc3c61dc1"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Guid[,] { { Guid.Parse("4703b06f-bd4a-4173-a554-fd94cba46b1b"), Guid.Parse("5bdc06da-40bb-4749-bfca-e5bc7dbd0150"), }, { Guid.Parse("ffe03417-ee01-4f0f-87bc-21885f100aed"), Guid.Parse("a2e62081-4249-4440-aa53-bf2507180176"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 121,
    Value = 
new System.Guid[,] { { Guid.Parse("5cd9c467-c61b-47b5-8b38-051858d67eec"), Guid.Parse("19999f39-7cc0-46e0-bbbb-be9593405087"), }, { Guid.Parse("3a7415fe-dc57-496e-992f-955c023e032a"), Guid.Parse("090b7437-efaf-41a0-913f-6c7bf84a2cd4"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("8d00b14b-b8ea-4aeb-95dd-47339084e553"), Guid.Parse("b9d05cdb-22c3-457e-9f32-a0f7835cb395"), }, { Guid.Parse("81931820-873d-4f04-b37b-e6ce80883b41"), Guid.Parse("5e3a00a8-d729-4b85-90ab-07380a90c745"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Guid[,] { { Guid.Parse("4ef71281-c73e-4305-80a7-b261bf855eed"), Guid.Parse("5aec2f22-ccd1-4aab-9203-058df5c80dea"), }, { Guid.Parse("7ddf87d2-cf8d-44a0-8dd1-3aeb0fd3b2ba"), Guid.Parse("4bf38ff1-e3e0-4842-9b46-59bf969d9fd0"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 124,
    Value = 
new System.Guid[,] { { Guid.Parse("77f87df8-9ad9-4d9d-8764-dad2a2c9d7f1"), Guid.Parse("bc430721-2141-42a3-8f67-828dc6fde13a"), }, { Guid.Parse("7383e789-f53b-4e08-9417-b5f6e784f176"), Guid.Parse("50f6b669-5e66-42ad-b657-4649260cf2c3"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("438ae464-1ec2-4541-81cc-9b33d75e213f"), Guid.Parse("362ef924-c98f-42a1-97fe-6f8fa57c1c39"), }, { Guid.Parse("83d56741-15e1-400f-b26d-0e7e7c1bbae7"), Guid.Parse("1599ee07-2e86-4577-8472-977a7016031d"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 131,
    Value = 
new System.Guid[,] { { Guid.Parse("f7d7ae28-76a9-4f7f-ad4d-045f88549fd3"), Guid.Parse("58f3ce69-8ffe-4285-b48c-ce97dbf186d6"), }, { Guid.Parse("50a32992-c0c7-49fb-afb4-99550562eb1e"), Guid.Parse("e8dc2685-c2cc-4af8-a989-d92cddb4867a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 128,
    Value = 
new System.Guid[,] { { Guid.Parse("dc3ca4d1-ba56-460c-985b-e92aac2581cd"), Guid.Parse("f258fd0b-874f-49f2-b427-3394671f04c7"), }, { Guid.Parse("a538ed25-7ecd-44fc-822c-ff4a362797c7"), Guid.Parse("d8d2b3bd-6b81-4787-bb9c-337c90d166ae"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7e45daa3-27db-4342-9a91-7978839fbed6"), Guid.Parse("3ed8d2d0-d385-4455-ae18-8b51473688fe"), }, { Guid.Parse("76acef39-8314-4fe9-97d6-959c434eb316"), Guid.Parse("99827a86-3a8d-4d34-8ca0-c001d259c9ad"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 135,
    Value = 
new System.Guid[,] { { Guid.Parse("4f306e85-981b-4f18-8cc2-fdf31a1148b8"), Guid.Parse("19dc264a-7f3f-4cbe-ab7c-207d818ad014"), }, { Guid.Parse("534844fc-afb4-4698-9039-43e03dc8ef38"), Guid.Parse("82cc6996-badc-438b-a610-c4ca396bab00"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Guid[,] { { Guid.Parse("f3dcb76a-42ca-41f7-b38e-ce8c2527b6e7"), Guid.Parse("b22cec37-5efa-4275-bcf5-c499ba64ee5f"), }, { Guid.Parse("daf6d3c6-8232-4d81-84a1-2166f0b59750"), Guid.Parse("049a90d8-d8f9-4973-a582-3d59c156163d"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("cf57139d-4139-45e8-93d7-320286e3c603"), Guid.Parse("77a406ed-f219-47f0-a955-3ba07ddc95c0"), }, { Guid.Parse("be48f838-4ecd-4f84-8b91-b2790270e7fb"), Guid.Parse("d75f8925-f391-4ba0-885b-e453e556a926"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Guid[,] { { Guid.Parse("96a628ef-950f-427a-8b76-3d3de0331d8f"), Guid.Parse("e089e998-063e-45d7-a1fc-0879eea99d17"), }, { Guid.Parse("c0da1e7e-a709-4f37-be77-a1a2e4c84625"), Guid.Parse("bb9cfead-6cc2-4f3f-9ca2-1ed68f0585a5"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 133,
    Value = 
new System.Guid[,] { { Guid.Parse("484e01bf-bc53-48b1-a03a-0ff4a3760469"), Guid.Parse("394206bd-2aa7-4ed1-9be4-73f71e66f7de"), }, { Guid.Parse("365703a0-08aa-4531-a607-60b62919c17d"), Guid.Parse("176eb871-77d8-4506-a149-3ad5e3cae387"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("85e3d5f7-f213-4128-8aa2-ff07a0000186"), Guid.Parse("e2602119-b17d-40cd-92e1-fbc069618bca"), }, { Guid.Parse("f2e28780-a4fa-4f90-a781-4dc66623b1fe"), Guid.Parse("bd0b79a5-4c36-4c7b-8205-e9b441e62379"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Guid[,] { { Guid.Parse("29ab013e-4008-4ee3-85fe-07dc813487b8"), Guid.Parse("4de0495c-d39a-468b-8a25-32557205cde2"), }, { Guid.Parse("5c504cf3-637d-49ca-a783-e64e0c2397c0"), Guid.Parse("d8df41bb-d91f-4ffd-8a79-0fbac8ba0f81"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 141,
    Value = 
new System.Guid[,] { { Guid.Parse("9d131370-f5b1-483f-98d2-d995ca60e07e"), Guid.Parse("7f048c43-8763-4ef3-ae4b-b92425b9a1ce"), }, { Guid.Parse("f406db3b-0ee0-4d1c-a243-edc95bc1abe2"), Guid.Parse("b0a3b6f0-0735-406c-857c-f5c26a8b351c"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("3bbfa339-f85e-41ac-acbc-ab85d2f39bee"), Guid.Parse("5c702de2-5b3a-42f8-8e3c-1881b81e3624"), }, { Guid.Parse("1ffd4b88-1790-47b9-96d1-f091896c87f7"), Guid.Parse("a43ebab7-0edf-41f9-b418-4e5aa0ec954a"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("2d1ab08b-8955-45de-9d67-fc8854fef1a0"), Guid.Parse("8e28d211-9fbc-478a-8552-3d2906a31efd"), }, { Guid.Parse("a38504a2-a0c8-4f2a-9fb0-a99fd1ab8e29"), Guid.Parse("6fdb9ac3-de82-4ffa-b735-fceaf8a16353"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 148,
    Value = 
new System.Guid[,] { { Guid.Parse("d65cb07c-1c15-44bc-95ab-768595ac1d45"), Guid.Parse("cf5b0b25-ba13-4b55-8bff-1fd19761d5bb"), }, { Guid.Parse("d898e8ed-76f8-46a5-bee3-6b5876c69322"), Guid.Parse("2416ee5d-ca66-465c-b49e-8533536e3fe4"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 147,
    Value = 
new System.Guid[,] { { Guid.Parse("c4381718-bedd-487a-8bc4-ad3fd28d2906"), Guid.Parse("04560a78-068c-408b-a681-1cf6e2598202"), }, { Guid.Parse("5642cb53-e9fe-4031-921d-e460e026b02c"), Guid.Parse("24a32a31-33c0-43b5-bfd2-09142044a8b4"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Guid[,] { { Guid.Parse("2b8daa8a-0844-42b4-a7aa-59f9c70531f8"), Guid.Parse("419a1197-958b-467e-9b70-e499f88ff63b"), }, { Guid.Parse("221a5695-586a-4e9d-b826-ebe39099ce62"), Guid.Parse("7b0a5044-e5fa-4b31-bf46-6d92a43b758c"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 153,
    Value = 
new System.Guid[,] { { Guid.Parse("25f2e877-1134-47d1-be2e-13db5c393c76"), Guid.Parse("c00ea665-6d42-40d1-88ad-98faaa91e7b2"), }, { Guid.Parse("848809e8-fd95-4902-9f68-f01b8a25b298"), Guid.Parse("eafb9c5b-e505-417b-91c0-5215a1628d66"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("cbdcd621-71b6-41e8-9845-3c25565e1b86"), Guid.Parse("db1c0a4f-763a-4139-a909-0f29dacf815c"), }, { Guid.Parse("d2ac6b0b-9d41-4d23-8953-d23bb7cd2224"), Guid.Parse("fc6fcd20-8407-4b6d-b91d-49d100d6edec"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 159,
    Value = 
new System.Guid[,] { { Guid.Parse("5f600e10-df0e-4188-a149-da6f36e5ee37"), Guid.Parse("b61e2d6e-aa17-48fc-bacb-bb755c206961"), }, { Guid.Parse("6afaf494-c5aa-48a7-9feb-a8cbd0d33c2e"), Guid.Parse("30ec9190-b44f-485a-b324-a74420a79b1d"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 162,
    Value = 
new System.Guid[,] { { Guid.Parse("8d307e75-4db6-4702-ae9f-48bc6c012279"), Guid.Parse("e4cc349e-09be-4146-bfa5-acd7f4b751ef"), }, { Guid.Parse("78099420-4fa3-4d91-97de-73d84a5b2d10"), Guid.Parse("511c3866-063e-4e86-b50a-a0738c68cfb6"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("a32c4bdd-8c72-41a1-8c66-fdd6eda36e11"), Guid.Parse("8a59a14f-8caf-4b04-b103-405aefb3e14f"), }, { Guid.Parse("8e9c874b-1cb0-48ba-aedf-06e9885e858d"), Guid.Parse("b3f8ab79-6c34-47c2-b187-781269f5122b"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e57e224f-ba0b-490a-a8e1-4efd95fcfa20"), Guid.Parse("68cd9285-a6dd-4cbe-8fd7-0bfd0780e696"), }, { Guid.Parse("2a01bf49-aeeb-479b-ac88-8afe587630ae"), Guid.Parse("1e8716ec-4344-4bda-8607-1af9e5cc6dd4"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 166,
    Value = 
new System.Guid[,] { { Guid.Parse("29e7e6c0-9e0d-4974-8cd7-4786c79fce01"), Guid.Parse("f88d5b83-b82c-4325-9a07-9709377de086"), }, { Guid.Parse("3dc73d15-0f9c-4b93-ab9b-857a769a9558"), Guid.Parse("646752b9-f91c-42c3-b295-035f225770bb"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 168,
    Value = 
new System.Guid[,] { { Guid.Parse("d00b07ad-558d-4490-9f41-5c53df4f1909"), Guid.Parse("9d6c0996-892c-4c33-8d6e-c8392a8d4fe5"), }, { Guid.Parse("501f4feb-3fa1-4135-b1a5-4556e5538a46"), Guid.Parse("79a6329f-f136-4ea3-b572-a78f7f372d5d"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ea86e8db-6972-4613-8386-6adb5899b371"), Guid.Parse("655a0222-ed7c-4297-b289-ec7bea8f08d2"), }, { Guid.Parse("21c2b3ad-a105-49de-b242-ecc2a53f60d5"), Guid.Parse("139ea3a5-25cb-4ad2-8eef-934594f71bb6"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("63463dcb-fc70-445f-a61f-5861ce2bdfeb"), Guid.Parse("9bd8fc11-438d-4af0-ae3b-595c9f4ed737"), }, { Guid.Parse("f175c006-1cc6-479f-bd3c-f4e7d5f95be9"), Guid.Parse("e4c3bb8b-12a1-42fd-9275-eb0ad45831cf"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 171,
    Value = 
new System.Guid[,] { { Guid.Parse("1f0d5da6-80e0-4268-8ace-e8d0ddef1cb6"), Guid.Parse("c58d3a11-29a7-4424-8473-fbff0fbb8bc4"), }, { Guid.Parse("c1876689-b032-4632-9fca-eab934968bdb"), Guid.Parse("39d4e2c2-6f47-4ec9-89fb-9aac969bc87f"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 170,
    Value = 
new System.Guid[,] { { Guid.Parse("7a641908-b54b-4312-ba6c-ae4838635676"), Guid.Parse("0503275e-9cf7-4c7e-88ea-3e19a5c9906a"), }, { Guid.Parse("13dbddbd-d783-4663-9fe0-b281004de534"), Guid.Parse("63b78514-8bcb-4470-b34e-7d5c790ededa"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("71ea44e5-36af-4fd2-99d0-00e815a27c29"), Guid.Parse("e8fe7a39-f9eb-4528-b75c-c368ce79cf96"), }, { Guid.Parse("51465927-62fe-4df4-9732-4d7179c16654"), Guid.Parse("df1696cc-55a1-4e5e-b85f-7bd3e19421ab"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 180,
    Value = 
new System.Guid[,] { { Guid.Parse("79dd9442-42ea-407e-b123-ce5994e1d844"), Guid.Parse("ec46e78a-c22b-45ad-8789-62c09f1f99cf"), }, { Guid.Parse("7dc4f4a6-28f5-47e8-aceb-6765fd2ff4b3"), Guid.Parse("03be1806-9a69-417d-9b69-ba0d9877dec4"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 172,
    Value = 
new System.Guid[,] { { Guid.Parse("29d4226e-ed12-4dd0-986b-9f3b361e1e51"), Guid.Parse("7973640a-727a-4cbb-b313-eca5d6647d92"), }, { Guid.Parse("677fadd2-c6b9-46a2-a889-9c4e963cccd1"), Guid.Parse("73d0941c-2464-43ee-9d9e-8f19c7c9351d"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("1d6e8b96-4a92-4a97-8748-97f7f49002b2"), Guid.Parse("c85005ee-fd43-4549-bb01-509038650698"), }, { Guid.Parse("aea6cae7-d197-4f71-9e1a-d9e0c9273479"), Guid.Parse("f31f34dc-7f50-4e0a-a5b0-f8b86ab40519"), }, },
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


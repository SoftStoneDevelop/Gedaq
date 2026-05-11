

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
    internal partial interface IGuidMArrayMArrayD1
    {
    }
    
    internal partial class GuidMArrayMArrayD1 : IGuidMArrayMArrayD1
    {


#region TestData

        private readonly GuidMArrayD1E1M[] _testData = new GuidMArrayD1E1M[]
        {
            new GuidMArrayD1E1M
{
    Id = 8,
    Value = 
new System.Guid[4]
{
Guid.Parse("2160d23f-213b-480a-93c8-c776058d27f6"),
Guid.Parse("92e7c075-01e5-4f6e-aaf8-614fe6e2e14e"),
Guid.Parse("8c857bee-7c41-4c5f-8f29-30f69e6fc6a8"),
Guid.Parse("686592bd-3305-4fad-a121-6b614940e99a"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 8,
    Value = 
new System.Guid[4]
{
Guid.Parse("c99e7e91-86c1-486d-99e4-eba6084e60e4"),
Guid.Parse("c06b7b0e-9bcb-4b67-8685-a61fef94cce6"),
Guid.Parse("eb39828c-e2c1-49b7-91c2-b0e7e30a579f"),
Guid.Parse("af607b5c-061a-4dda-8dc4-500ecca1a713"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Guid[3]
{
Guid.Parse("1539a0ce-be50-474b-8713-c0bcadeec17a"),
Guid.Parse("df1f8d48-f98c-493e-9364-f9d76f5101fa"),
Guid.Parse("be3a92b0-4eb9-42df-b995-4b13660cfb1d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 11,
    Value = 
new System.Guid[3]
{
Guid.Parse("6bfc822e-0222-4317-a317-e376152a9e58"),
Guid.Parse("ed7b9b45-e004-45a8-82d8-d2d43c858e15"),
Guid.Parse("c5d18aa0-dc96-463b-a357-c45f1f0c3b31"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("74500cf6-d174-4076-99dc-3ed13672c8e1"),
Guid.Parse("6306ad74-a53f-4eb9-af5f-f8be73806d1b"),
Guid.Parse("ab0c3c3f-bc9a-4230-b03b-450a46948620"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 10,
    Value = 
new System.Guid[3]
{
Guid.Parse("8e2873b2-7827-4396-b539-e4cc6006807b"),
Guid.Parse("065de664-4790-4670-a949-a78cdc140733"),
Guid.Parse("9df96929-dfe2-4a2d-a5b7-9d64114e341f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Guid[4]
{
Guid.Parse("a83a0d51-eaab-4703-927c-4c0a8dd9bad6"),
Guid.Parse("d36c966e-2755-4ef3-932d-216dc3665738"),
Guid.Parse("698019ff-a48d-49e4-b934-f30a130c8a99"),
Guid.Parse("05e52d19-1f50-4c71-8f12-415b5427aee6"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Guid[4]
{
Guid.Parse("3700f95c-6323-48a4-8a9c-975a0f79462f"),
Guid.Parse("ccf959a2-20d6-4a7b-aaa7-d035d37514b4"),
Guid.Parse("9f90c7f2-6941-4f5a-ac06-9ade64f911fb"),
Guid.Parse("199fe56a-b65e-42f1-a433-5ce4045283d0"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 21,
    Value = 
new System.Guid[3]
{
Guid.Parse("c77e78dd-1f34-4988-a435-1cf2e5b7f746"),
Guid.Parse("861647ff-5753-49ca-adbe-49fd27c76b22"),
Guid.Parse("3c570618-fb1f-42cc-8f87-dc9371378166"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4c5eb721-1eab-4e4a-97dd-9505a1c073da"),
Guid.Parse("3fdb7531-3fc8-4b65-87c5-40d23c3a6cb1"),
Guid.Parse("8f5b054a-1c00-4c6c-ae16-597d712b978a"),
},
},
            new GuidMArrayD1E1M
{
    Id = 23,
    Value = 
new System.Guid[3]
{
Guid.Parse("13a4d4cc-eb6f-4a47-8d4b-ff8ea4aaff57"),
Guid.Parse("b6940af9-a57a-4fa2-b83c-3a32eca9a611"),
Guid.Parse("65554cf2-8ae7-481e-8856-88a86d357d75"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("87f16f30-f5ae-4c0c-9d35-8789a00b344c"),
Guid.Parse("741921ad-72cd-4ff9-88cf-da7421d02bd6"),
Guid.Parse("6964ed2d-caab-4c1c-90f3-a6c6774adc55"),
Guid.Parse("bd435805-f941-477c-9501-a265b807f3f5"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 32,
    Value = 
new System.Guid[3]
{
Guid.Parse("353bfd7f-9c08-4279-8bd8-5bb895345bc3"),
Guid.Parse("0b3d5699-71a3-41d5-a3c3-9f3e316f799f"),
Guid.Parse("b509152e-c5e2-4d5b-9ae7-6989c37719c3"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Guid[3]
{
Guid.Parse("d5a2c12e-f9e8-4d8e-9ea6-26ba3efa111a"),
Guid.Parse("ff5d9bb9-5e82-4059-8228-804b2aa0dace"),
Guid.Parse("a229556c-5a98-4568-bc41-7351cef3c851"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ac8c5c8b-ed1c-4d93-9d5d-5b26cc97cbd1"),
Guid.Parse("58c7a444-ec7c-4691-abcc-a1ae4725e6a3"),
Guid.Parse("a8e9e217-ea50-4828-b32d-b72741540039"),
},
},
            new GuidMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Guid[3]
{
Guid.Parse("313961e2-7edf-4ed3-be36-6e41e8b711f6"),
Guid.Parse("6dc6e16c-8fa5-4c7f-a0fe-14d7a4876414"),
Guid.Parse("ee8a9c01-7670-44f3-959c-14be4fbcfde5"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Guid[4]
{
Guid.Parse("5134c238-9ebe-4a54-82ed-23b6a221b6a1"),
Guid.Parse("510bf7c9-405f-4247-ad92-35a1c5cb60fc"),
Guid.Parse("0c9aeae5-4fc0-419d-a35c-49a34cd33e7a"),
Guid.Parse("ac04bed5-f40c-455c-92d4-a86f73a60bb3"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("24cad03e-b5be-4069-ae41-22ca332256d3"),
Guid.Parse("32b080f8-1da7-4856-953d-9d1e6a5ff2ba"),
Guid.Parse("30f3e823-088c-4f00-a5d4-d21e69a9621e"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fa60bb33-396f-445d-871a-5c5f7147c71c"),
Guid.Parse("25c401b0-211d-4fda-97c3-ebf84374a402"),
Guid.Parse("c34dbf57-a7bb-42b4-8741-ea87f603f15d"),
},
},
            new GuidMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Guid[4]
{
Guid.Parse("edd096e7-0a6b-4951-9201-e39b99aa92c6"),
Guid.Parse("6a289b2c-5928-4650-866a-e791505b7705"),
Guid.Parse("a55d8357-bb91-416c-baeb-56f589d0570a"),
Guid.Parse("741c37b3-62f1-49f0-830f-a93c3c036c29"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("fb4bef01-7983-4f14-ae65-bc910868c105"),
Guid.Parse("5dfad531-f5c1-468f-9dcc-3190cf323764"),
Guid.Parse("fead6d39-2001-4097-9db2-64309111a138"),
Guid.Parse("608f32f3-4331-4765-a14c-6104d4fcdeb1"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("230eb2fb-2c6e-4085-8c13-39eb148572d1"),
Guid.Parse("017c6bc5-0d2a-4f57-a219-ca06795e0a98"),
Guid.Parse("7d26e168-0002-4d24-aa51-5ac0640e3773"),
},
},
            new GuidMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Guid[4]
{
Guid.Parse("48e063ac-2318-4bc0-9ab9-5a315737ffc4"),
Guid.Parse("abe56a4e-ddec-4787-83c4-72a24512de56"),
Guid.Parse("ca41d299-99a9-4f39-b7cc-ad32f09fd8a6"),
Guid.Parse("63000224-4406-4678-9172-80c850da6a1b"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 35,
    Value = 
new System.Guid[4]
{
Guid.Parse("aa59656c-7694-4818-bfc3-8324fb9602f2"),
Guid.Parse("7d4e6f3b-770f-4679-9f63-14418acb2870"),
Guid.Parse("c9b3e6b7-da3a-47d5-a5e9-ca885398cb58"),
Guid.Parse("4762ac53-9cce-4071-b2a7-b174c5d37cc1"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d4e2f397-c9aa-4673-a3c6-f60434c30a02"),
Guid.Parse("d7b0e3b5-a171-49db-8853-c7c09a8643f6"),
Guid.Parse("ffa67750-e6bc-4e07-b0f6-fa3c83d7649a"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7db9b38e-31bb-418e-8611-cd1c8b5acb20"),
Guid.Parse("04bda3b8-0a98-443f-a6c6-274a01c4fdcf"),
Guid.Parse("9f2cc969-a258-4e26-8d81-390abefb65cc"),
},
},
            new GuidMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Guid[3]
{
Guid.Parse("e5ead2cd-fa6d-492a-b427-3dfd233e8b55"),
Guid.Parse("fe4be9b3-ba6d-4941-98e2-e536673fbb19"),
Guid.Parse("d6ceb322-25f8-4fc6-8ca3-18a5cdad33e1"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("08156cce-d005-499f-bec3-08b2bf641b33"),
Guid.Parse("ab6a99e5-c92a-441b-9720-d2bd8b451408"),
Guid.Parse("65ba569e-3fe6-4085-bd1f-3d5de6ef6df9"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e9719568-e080-458b-9557-80f4910bd475"),
Guid.Parse("4cc7b1d1-0f75-40b0-9439-313b74f1042d"),
Guid.Parse("8f86b123-b0a9-4c7d-9f11-a1da8f697bd4"),
Guid.Parse("de541a03-428e-4dae-b5ad-9033a1491665"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 44,
    Value = 
new System.Guid[3]
{
Guid.Parse("14cda936-eb9f-404f-bcdc-16549149d8f7"),
Guid.Parse("3daec2a4-d1b5-4112-86bb-7d5b71531bd8"),
Guid.Parse("bf232920-4125-49ad-84a1-c3051f0c6921"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 43,
    Value = 
new System.Guid[3]
{
Guid.Parse("792b8d49-60ec-47ba-aa89-1e46328ff5c2"),
Guid.Parse("9c678983-c930-46dd-a63c-264fe418d00a"),
Guid.Parse("280b6c34-d2a8-4161-b96d-6fff2ad3a853"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e5a862f1-8790-47d3-a142-eace5a565602"),
Guid.Parse("54bd19c1-7749-4aec-a314-82f40fbc6fbf"),
Guid.Parse("27d0f4b7-87ce-4190-af16-30e1c21da7d9"),
Guid.Parse("5f57fdb8-c78a-4912-9612-a11870d31601"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9a7082e9-b33b-48ef-a651-f90bbf6eb80d"),
Guid.Parse("8dcba525-a910-4a36-8f6c-d751d02d43bb"),
Guid.Parse("63e61619-c10c-4ca9-b5df-64a6233dc00c"),
Guid.Parse("94524523-853c-47fc-ad59-60ec83e2a9a0"),
},
},
            new GuidMArrayD1E1M
{
    Id = 46,
    Value = 
new System.Guid[4]
{
Guid.Parse("f2a7b053-6e72-4378-be31-36c7bc4b6799"),
Guid.Parse("fe303d5b-a20a-4117-a019-871692a57dbd"),
Guid.Parse("11772ed6-75ca-47a4-a9c4-87a8da08ae2f"),
Guid.Parse("995226c3-6cd2-461c-9e3f-fe696145fd8e"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("7a67ea0f-760a-43ca-bd00-e29412f87828"),
Guid.Parse("51ab7922-5e5c-40c0-923c-8a7738f155f3"),
Guid.Parse("6977cb80-b424-4f75-b48d-d38874c866a6"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4a69a2aa-15d7-47e9-a1db-267a0a88826c"),
Guid.Parse("925ce68d-5e0a-40e3-908c-a5c90a00465d"),
Guid.Parse("24b26bd2-d772-48a0-92af-08364a4d92c5"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Guid[4]
{
Guid.Parse("0f5cf5f0-cf3d-48b3-8654-3c423cf4f7e8"),
Guid.Parse("944a564b-7926-46ff-afd6-8ec1f465ad27"),
Guid.Parse("c4446876-dc77-4a41-85f4-448811f39e43"),
Guid.Parse("2d86e056-ce2c-4209-8fa0-98eebe59515c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 58,
    Value = 
new System.Guid[4]
{
Guid.Parse("250eaa8b-4ec2-420c-91bb-995793b49f7a"),
Guid.Parse("9de669ce-3dca-4cd5-bc8b-c584a545c37d"),
Guid.Parse("1c637c13-94e6-4315-a749-fbe3a9b7c1f9"),
Guid.Parse("5f930be7-5a9a-471c-a970-9fdcf76f22f2"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 62,
    Value = 
new System.Guid[4]
{
Guid.Parse("d4a109b6-a594-4390-ae48-bceb6c27e0f5"),
Guid.Parse("0d45c137-0cda-4692-88ef-89716f58d24c"),
Guid.Parse("19ac1e23-58ba-4976-af81-8dced16f67ad"),
Guid.Parse("ee2b5d0f-69fb-45bb-8e28-96abfcc5954e"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 60,
    Value = 
new System.Guid[4]
{
Guid.Parse("77e73824-dbdf-400d-a3fb-96c2020adde7"),
Guid.Parse("ddf68ab7-56ce-4a6a-8c17-4241a35c530d"),
Guid.Parse("d6d572f1-c16a-4401-819a-4ec2ae702ab1"),
Guid.Parse("c480d8e3-d7e6-4d0c-9365-b5a6e6b8c22a"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("20087067-77ef-4639-964f-1a0f869f31ac"),
Guid.Parse("346f1926-fd81-4a2d-8cd9-74ec6f94e62d"),
Guid.Parse("a7e28160-23f0-436d-8d7e-4d3572aed6d5"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 71,
    Value = 
new System.Guid[4]
{
Guid.Parse("448e4128-8506-4b53-b4d9-d4f388a9fb83"),
Guid.Parse("93c8df39-1c8f-4fcd-97e4-e747f53a58ea"),
Guid.Parse("46ddc8bd-31e5-4646-a386-4edfe2828f83"),
Guid.Parse("b2426cad-792b-4b25-9ad6-b9ecaf568de9"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Guid[4]
{
Guid.Parse("aab6a12b-2d41-4257-b066-128e2da49f83"),
Guid.Parse("82d8c596-bebf-4e72-aeb6-407ce8f93de8"),
Guid.Parse("9f9bcd43-3f87-4b89-bfe2-8d00953b4789"),
Guid.Parse("440f9aa7-3ad6-4f09-b3b0-6dca15d5d853"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2d3d77d6-a227-4afd-9de9-9f1dd3b373b8"),
Guid.Parse("6c142a03-2470-43a5-8a9f-5250445715fd"),
Guid.Parse("61253671-2b02-4a5f-adad-fc07fbbcda4c"),
Guid.Parse("1ba92c48-31d9-44c1-b703-d3b15c70b6fa"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("3baf4973-945b-47dd-99c9-1ec3637d9a60"),
Guid.Parse("4307c1a0-adae-43e1-9ca0-efb35157cee5"),
Guid.Parse("13a4d35c-92b5-499b-b8ae-83787471f721"),
Guid.Parse("f717c96b-367b-4e31-ac5b-cb79d3503c16"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Guid[3]
{
Guid.Parse("f0e409d3-823d-4038-a6b2-3366d6bba55c"),
Guid.Parse("8d30e668-06dc-45e0-8bf7-1623043d4c46"),
Guid.Parse("a2657264-1d76-462b-bec3-64e03894baf4"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c776ff44-1498-4040-a64c-35688b0764b7"),
Guid.Parse("dc98f3cc-05a6-4a70-883b-88c3c557f63f"),
Guid.Parse("a5748e60-bbdc-4cef-b92f-78cbf33e2ef5"),
Guid.Parse("6169fc1b-96d2-4aab-a321-baa5e5b99d20"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Guid[4]
{
Guid.Parse("4bbe883a-6af1-4872-8fb9-6dac37e12774"),
Guid.Parse("1f21d53f-7814-44fc-be50-86c49133d1c6"),
Guid.Parse("aea62e46-366a-4a2b-bc83-b5877c1a05e3"),
Guid.Parse("599df2a8-16c9-4861-a3af-8a375625d095"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("4cdcb9e1-a547-43bc-96ee-1099194b1c7c"),
Guid.Parse("744696f9-c8bf-4855-b234-eb3489d93167"),
Guid.Parse("fe405ccc-0af6-4053-ad6b-e5fcc0edc66c"),
Guid.Parse("9ad65842-17bb-4d8c-a613-61322d7e6159"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Guid[3]
{
Guid.Parse("7c840d53-ecbd-41c8-ab4d-b926b11db596"),
Guid.Parse("cbc30a84-bd16-4da9-b23a-f24a0145d15c"),
Guid.Parse("fb533518-a39f-409f-92dc-e9904d2104f3"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Guid[3]
{
Guid.Parse("af9adf16-e8da-4256-8d67-c6e8c0737700"),
Guid.Parse("b41f55e9-bd7d-4a4a-8894-19565749b5ca"),
Guid.Parse("237c2e28-546d-4ed9-bf9d-773757f45fa6"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0b8900d0-09b9-4157-a8ac-c31846dc2e04"),
Guid.Parse("0e8444ed-7096-4b36-9616-4108ccf6ac33"),
Guid.Parse("ea0090d4-85c2-4a8d-8034-0a1c25716099"),
Guid.Parse("d9dd626c-f219-4f33-aa4a-c83c6075be9e"),
},
},
            new GuidMArrayD1E1M
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("898e3f99-9d1c-4676-befd-da1e49c93c3f"),
Guid.Parse("a26e7d63-a05d-4396-a518-f45051a4f9b4"),
Guid.Parse("9180da82-383a-4a16-a18a-f53f037f56ad"),
Guid.Parse("8fada9d1-db12-4a00-bf58-406c25526ec7"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("6149a757-1a1e-4558-adb7-7490ad843f5a"),
Guid.Parse("61f2c415-0d34-460e-b95b-9ad15098b319"),
Guid.Parse("046cc660-6685-465b-819c-d455f88720ba"),
Guid.Parse("ee6952b2-ce98-4179-b488-989216c01b2b"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 97,
    Value = 
new System.Guid[4]
{
Guid.Parse("0d74db83-5c5f-42b9-afc9-467582b1578a"),
Guid.Parse("4241c659-26af-4dd0-ae9e-75cc3306f81e"),
Guid.Parse("42a0fe43-2899-4904-bc61-ceb2f6e7671b"),
Guid.Parse("cd517ac7-f60b-40f1-93e2-b24ba7abcdad"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 94,
    Value = 
new System.Guid[3]
{
Guid.Parse("8fb64be2-2ff1-4f8f-adc9-6b665efef0c5"),
Guid.Parse("c228bf14-9585-4c98-a6c1-90e86fd5036f"),
Guid.Parse("826ba00e-a207-42b7-a2af-4ae92d4f520c"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6dd04f08-2dd2-4d9a-9411-7ac4adee838c"),
Guid.Parse("36587768-36fa-43f1-a84e-a10acd599b67"),
Guid.Parse("96e021cb-9bca-448a-9af7-86b82a2daf3b"),
Guid.Parse("0436c7ed-4443-439a-a5bc-a7d6caca8139"),
},
},
            new GuidMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Guid[3]
{
Guid.Parse("f64f2279-d052-4596-b33a-547015d0414d"),
Guid.Parse("eed43d6f-340c-4cb4-9abe-c6fbb387441a"),
Guid.Parse("19bd1e33-a552-41af-b0b8-6ede9115ac01"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.Guid[3]
{
Guid.Parse("3aa25d98-9129-4cf0-89ad-8530f397b159"),
Guid.Parse("f192e9fc-592e-4e84-8ab3-bd0139d46df1"),
Guid.Parse("9085719f-09dc-48df-958e-e3725a971916"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d5e7f789-0a34-4ec2-8831-1daf436461cb"),
Guid.Parse("d692d5e2-cb58-4615-9b31-089ee7eb8034"),
Guid.Parse("55fd2962-5aec-463e-8714-e3f724472053"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 109,
    Value = 
new System.Guid[3]
{
Guid.Parse("f71a872f-5fbe-407c-b497-3fcb57233b66"),
Guid.Parse("66560bed-0539-439c-88f8-27143c91159f"),
Guid.Parse("537f0397-937a-48a2-a958-3afc8bf71954"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 110,
    Value = 
new System.Guid[3]
{
Guid.Parse("9f70907d-ecdf-4207-b70d-beab8c58336b"),
Guid.Parse("bc18f8ad-dc11-4aba-909f-0b54d7794a6d"),
Guid.Parse("30eb47bd-629f-46af-8c8d-14da84aa1552"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("014f7592-e8b1-452a-9e96-74391334f644"),
Guid.Parse("888bb9ee-3f7f-4b81-9ac0-f18ecc5c9dcb"),
Guid.Parse("072d425a-10ad-434e-b88f-8fab8038f9cd"),
Guid.Parse("1ef24e89-a24b-4291-8082-58fe7f0f094f"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Guid[3]
{
Guid.Parse("2c4059fa-7df5-4488-9690-b6a25e76bb6f"),
Guid.Parse("125e541c-a931-4b10-a701-a5fc9a0569e3"),
Guid.Parse("a705b35c-292c-443e-a636-a18cee1fe3fd"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 113,
    Value = 
new System.Guid[4]
{
Guid.Parse("f2ab2558-56ac-4d5e-90b5-6488cbc65f7f"),
Guid.Parse("fed1582e-3b7a-4837-83ab-a14b3272a604"),
Guid.Parse("5245c4a1-f238-4afe-8fb0-94a393b2df7f"),
Guid.Parse("c318a841-f877-497e-863f-02241c0b84a9"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Guid[4]
{
Guid.Parse("231c820b-a307-4faf-a7ba-3cdaf63d95c5"),
Guid.Parse("143db5e5-6a6d-41f5-960a-809504d3bbe2"),
Guid.Parse("b4ff0368-6a28-40da-ac56-1e8b84b9e806"),
Guid.Parse("eb06656f-f70f-43d8-95e3-d69c29cc443f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 121,
    Value = 
new System.Guid[4]
{
Guid.Parse("3a7e008c-2cab-430b-ad0e-8d97f48cec4c"),
Guid.Parse("1475976b-beeb-442e-a92b-0858986ed137"),
Guid.Parse("fad89a48-a282-4913-8dc8-e6af816330e1"),
Guid.Parse("3f572c4a-8cfe-46ef-9dc4-622bda4411cf"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("32b96b5a-a189-41c8-b67b-08a5800bf0a6"),
Guid.Parse("fb97c0c4-6bec-43ac-89ca-8a724dc14f41"),
Guid.Parse("67d135e2-811e-4917-81b4-8923be4285ba"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Guid[3]
{
Guid.Parse("37ebc79f-f0f6-4649-88b6-720ca1f5a241"),
Guid.Parse("a0bc8e55-1c3d-435d-9625-255792030267"),
Guid.Parse("ca9a035e-63ed-4fdc-82c5-c013237488ae"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 128,
    Value = 
new System.Guid[3]
{
Guid.Parse("11d21eca-8e30-414b-97a3-8b5f3d258048"),
Guid.Parse("8decbfa5-466e-4d3b-9263-1839d3acee94"),
Guid.Parse("0e9f6278-54b0-47bb-b783-0d1657455caf"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b8b9af73-bf99-47c4-a1aa-a0127c3ca7e3"),
Guid.Parse("8aa6602a-557d-4c0b-a67e-4b51b3a9ce6b"),
Guid.Parse("9493707a-140f-46f9-b3dc-e2be75631a76"),
Guid.Parse("84adbb08-f862-4e94-9b11-102ba7393c8d"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a60ea1da-95fb-4cb3-b3b8-81a82a387a5a"),
Guid.Parse("e243176a-8f2b-4e3f-b96d-2d2347cf6486"),
Guid.Parse("b630963d-94e3-454f-a53c-e91dfe9e1f96"),
},
},
            new GuidMArrayD1E1M
{
    Id = 131,
    Value = 
new System.Guid[3]
{
Guid.Parse("5d202ec6-a686-46db-8e6b-863d143f300f"),
Guid.Parse("221488bc-ad1c-441e-981f-1f395d4a05fe"),
Guid.Parse("a18a8e93-cb51-43f2-97be-e82e58bde80c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 134,
    Value = 
new System.Guid[3]
{
Guid.Parse("2dbd231d-170d-43dd-b5c5-58aad708be88"),
Guid.Parse("b8626b03-1377-4e42-bc45-a59c29ae3cf6"),
Guid.Parse("9bbb7cab-a52f-485a-af53-ba4b48ed0316"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("68d42f4b-fd15-401b-9a3d-f343440b84b5"),
Guid.Parse("4641154b-8d86-42b9-9305-e1b94ca287c5"),
Guid.Parse("00520e0e-d117-40e9-a00a-f3cfa5b93be1"),
Guid.Parse("a3071212-5980-4632-a9c4-0a31be1a2a10"),
},
},
            new GuidMArrayD1E1M
{
    Id = 137,
    Value = 
new System.Guid[3]
{
Guid.Parse("e64bd585-7c19-44be-97ec-4e6636589415"),
Guid.Parse("e44bc6f0-5bf9-4d12-82fc-2a1f50e9bef0"),
Guid.Parse("ab65e46f-806d-43c7-b0d7-55a4ba6bac13"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 142,
    Value = 
new System.Guid[4]
{
Guid.Parse("675a2a49-f1a0-4c09-bd3a-6a9128d7af05"),
Guid.Parse("1cde02f7-2eee-401e-b54e-d4f504068c0c"),
Guid.Parse("32ba476c-dbea-49d9-ae1c-95da5905e080"),
Guid.Parse("b816af63-6b14-47d6-9e66-a7f86a4d894a"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 145,
    Value = 
new System.Guid[3]
{
Guid.Parse("dd0459b8-2c05-45fd-b0b1-2027439eafc9"),
Guid.Parse("81f5ce86-4df3-4763-b06f-75685db95b37"),
Guid.Parse("e6aa989f-ab08-4432-ba32-a882ab276ddf"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 144,
    Value = 
new System.Guid[4]
{
Guid.Parse("8e9b4aeb-039b-4241-899b-542053d2eadd"),
Guid.Parse("1859e77a-b056-4e46-bd60-1e8fd5793dca"),
Guid.Parse("7cfb0960-404d-4ce8-8411-c8d5abbe6233"),
Guid.Parse("5def1099-83ca-463e-877e-2e1b2f533d8d"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6aedfc31-f421-4a46-a91b-17d91fe242fd"),
Guid.Parse("69f259b0-c986-4197-ab91-e90f7836bc93"),
Guid.Parse("318bbed4-5663-45ca-8b6c-38acb3746559"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6fa9bae7-6f5e-4c85-b4e5-409edb9dc704"),
Guid.Parse("99464d59-7e31-4e59-9a3a-d34da45d021d"),
Guid.Parse("48cf8e2e-bf90-41c9-9e24-aa05696098cc"),
},
},
            new GuidMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Guid[3]
{
Guid.Parse("017a466c-10b6-4944-a823-d779343d6bff"),
Guid.Parse("c22ce5d9-1550-4351-99f0-8db150d91c81"),
Guid.Parse("14b91b28-38ac-4046-8b28-8cdd49b93b94"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 153,
    Value = 
new System.Guid[4]
{
Guid.Parse("0778d659-3640-4b68-a379-dbcc17b3123e"),
Guid.Parse("b9574182-23de-4489-b858-4b07cba2a370"),
Guid.Parse("27f9e59a-10a7-4123-9e8f-28a3a23a8cd7"),
Guid.Parse("845713aa-4e90-4e78-834a-ad4552976828"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9800eb04-91a6-4412-b8c4-56a1d587c110"),
Guid.Parse("97237842-9cce-4cee-8d4e-8fd1831bdadf"),
Guid.Parse("267e0b10-69d6-4fa9-8210-cbf5705b4e8c"),
Guid.Parse("b20a7665-4a17-4564-8832-c7844c9c7dc7"),
},
},
            new GuidMArrayD1E1M
{
    Id = 159,
    Value = 
new System.Guid[3]
{
Guid.Parse("7b48e8d5-a071-4ef0-b1df-eef22719e546"),
Guid.Parse("1192190f-7da2-47b8-a524-0dff0725fb1b"),
Guid.Parse("66546151-1d5b-415c-88a4-fd7d65643c37"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Guid[4]
{
Guid.Parse("7f799ef8-a09c-413a-9fb5-e8eff1be0f41"),
Guid.Parse("ac373b4b-c6d7-41fd-8f3a-7f5a155a7e65"),
Guid.Parse("acad3cc1-dcd7-4bf4-a252-f051fdd26d46"),
Guid.Parse("47a420d6-5147-43ac-b1f7-37f2164f5051"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Guid[3]
{
Guid.Parse("0d2bfeba-7511-4b4c-bfc8-11e4c6eef50c"),
Guid.Parse("42fc7205-a1af-4f51-8d57-99cb21c4cd85"),
Guid.Parse("78b1c2a6-381e-4d03-9791-87a085303073"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 162,
    Value = 
new System.Guid[3]
{
Guid.Parse("1e6d385b-bdbf-4309-8e88-988a17c5512d"),
Guid.Parse("7d3989f8-abef-4bd6-b45c-cb7362c96f37"),
Guid.Parse("69e53cfb-6f6a-4e32-8414-c677b9fbf707"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5a053591-93f6-4c2d-a51a-44c820e068a7"),
Guid.Parse("030690f4-421a-4936-9e89-c0e8dd7e97b3"),
Guid.Parse("cadf2c39-9e5c-4dca-949c-c3ae4bdb872f"),
Guid.Parse("fdcb527e-102d-472a-b322-f1e046c946e3"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bcb7aad5-65a9-4e83-9d7d-afc5357497f6"),
Guid.Parse("dab70832-dad3-4706-9d9f-c0f4f03c4d92"),
Guid.Parse("021b1640-6c40-48b2-bd01-6afe29b2f3dd"),
},
},
            new GuidMArrayD1E1M
{
    Id = 173,
    Value = 
new System.Guid[4]
{
Guid.Parse("74affe40-369a-468b-8ea7-b305c84ac160"),
Guid.Parse("79ed681a-72cd-45e0-a279-c9f452e0b94e"),
Guid.Parse("309e4653-dd3a-44fa-88e9-19bf81b73d89"),
Guid.Parse("735174c3-8190-4e5b-ba09-92ee20250c7a"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 169,
    Value = 
new System.Guid[4]
{
Guid.Parse("1620b6ca-952a-4fc7-9ee5-b738ae593e25"),
Guid.Parse("9fac3723-4874-48ee-a7ec-6e041e9b6668"),
Guid.Parse("c70af71f-3258-4cf5-9a67-71e140f13058"),
Guid.Parse("f7689cd1-340b-4b15-90b6-79f9a1177fcb"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9623d033-35d1-4f90-b16c-37ef1a597147"),
Guid.Parse("fbe5f090-a1cd-458c-8b06-453d8b575e8e"),
Guid.Parse("a92cc615-cc3a-429f-b100-52637f8970d0"),
Guid.Parse("330014ec-29d6-4d89-9c76-364807452163"),
},
},
            new GuidMArrayD1E1M
{
    Id = 182,
    Value = 
new System.Guid[3]
{
Guid.Parse("2ba14c8b-5a93-44d3-b82f-2ae44b036dac"),
Guid.Parse("0f15ec92-30fd-4fbe-b0ba-8f3097bcb843"),
Guid.Parse("e5f34ea2-f0fb-458a-ba0f-9335e319861c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 175,
    Value = 
new System.Guid[3]
{
Guid.Parse("3dc4f364-de15-4926-beba-c98be542b83b"),
Guid.Parse("6d5dc727-da9f-4673-9124-1ede1fa9e279"),
Guid.Parse("2be6e6b0-d7ea-4b74-9001-3c7435595b63"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("1542cca2-6c0e-4253-8e71-aaf5bda05fe7"),
Guid.Parse("ca31560b-a3f2-43cb-90ce-150c6a15a676"),
Guid.Parse("31d5661f-1701-4a70-b0d8-570d30c72abf"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c1db752a-23d9-4c08-9c94-0461c2480959"),
Guid.Parse("c8dfa99b-a5cc-4338-aa59-031d6f5124e1"),
Guid.Parse("1c6e0b5e-7183-4cbd-9e98-62927bd746ef"),
Guid.Parse("687e695e-0798-4fb0-8897-b7719b861cfb"),
},
},
            new GuidMArrayD1E1M
{
    Id = 190,
    Value = 
new System.Guid[3]
{
Guid.Parse("c1d42e56-7fa7-471c-8b23-887a9aaf58dc"),
Guid.Parse("c218cc14-d383-4b7b-ac58-4307e8b416e7"),
Guid.Parse("38aae483-1b73-46ff-be91-20e585a092d4"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 183,
    Value = 
new System.Guid[3]
{
Guid.Parse("67a65aa2-73a4-4044-a513-41b8640abf34"),
Guid.Parse("0638a024-8fc0-4a24-a25f-e24b36e91307"),
Guid.Parse("07afd8ca-419c-422d-adb1-fb32ae4773ed"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 199,
    Value = 
new System.Guid[4]
{
Guid.Parse("373f3fd5-cc24-4162-a389-809fdf2f24ff"),
Guid.Parse("4522b57e-2bc6-4377-ace3-f0fde3892eee"),
Guid.Parse("fa90717f-5b13-44dc-a1fe-ab40de24053b"),
Guid.Parse("8ebe5de5-ffa6-44f0-893a-968de79927da"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 184,
    Value = 
new System.Guid[3]
{
Guid.Parse("7f38f874-369b-4947-8691-ca25e1c0509c"),
Guid.Parse("47d928c7-8e14-4292-9ef6-020b757e1b80"),
Guid.Parse("3716e900-5aff-4f29-b424-a9dff0ded690"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c3353cf0-22a8-4f4b-b995-e24036ca4025"),
Guid.Parse("58f0ddda-dba0-4095-9477-b24dda91ac90"),
Guid.Parse("9221bcec-7a14-4e16-8779-083e73f4634c"),
Guid.Parse("1b440222-de51-464c-932d-d8257d1a1ea5"),
},
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
INSERT INTO gedaqtests.guidmarrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UUID)}, 
    {mi_id:Int32},
    {mi_value:Array(UUID)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
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
                    await ((IGuidMArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IGuidMArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.guidmarrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD1)),
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
                    var models = await ((IGuidMArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IGuidMArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}




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
    Id = 7,
    Value = 
new System.Guid[4]
{
Guid.Parse("d757ee38-b1c0-42ea-b516-9eba2659ee2b"),
Guid.Parse("63e23756-a3ae-45eb-aeae-502c53b32cac"),
Guid.Parse("a2015ffc-18cd-4e15-a3b2-9ece8818a2dc"),
Guid.Parse("05644054-b81f-4163-830d-f832498a6f67"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("5c53c10e-aaf5-426e-b044-746e9e46c4c4"),
Guid.Parse("a36aba9a-b17e-472d-8da4-fa0ccc25d7de"),
Guid.Parse("4e849dee-fce8-4b16-9f7b-eaf63b9398b3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 2,
    Value = 
new System.Guid[4]
{
Guid.Parse("21b58d6b-b8a3-429d-b78c-5073f56c007e"),
Guid.Parse("3bcb1c55-01d0-4e75-8fc9-f15df3b05eb5"),
Guid.Parse("f01ea324-3b3b-4014-b9b0-9316b1034573"),
Guid.Parse("52ab639c-c57e-47aa-8a36-86125ceead21"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("cd1a3e1f-6df9-4332-be15-b3bbb3b2c67d"),
Guid.Parse("0098a680-f7ef-41ba-92df-30ee3009989d"),
Guid.Parse("f523ebe9-d8a0-4f1a-804d-73ae96abfa65"),
Guid.Parse("6c5a9f64-f594-4d31-a687-46bb82d13562"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("cb7747c0-6ec0-44a8-8ea8-1ad7ccd1612f"),
Guid.Parse("29780650-526e-4a6e-8fcc-ad04a80cb8e2"),
Guid.Parse("1bb47ec1-a50b-493f-a514-40e695eb97e5"),
},
},
            new GuiduuidArray1M
{
    Id = 16,
    Value = 
new System.Guid[4]
{
Guid.Parse("63093a64-aab5-487d-b493-bc5b084f8477"),
Guid.Parse("1f8046c9-98ec-4236-a616-e0e4efe8940c"),
Guid.Parse("7fc62b5e-4718-4986-b519-d3b62d51050e"),
Guid.Parse("a190652e-4e3e-48e7-ab2c-440c3f2baaa2"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 25,
    Value = 
new System.Guid[4]
{
Guid.Parse("9a5234dd-2c7b-450e-93a5-6453187b10d7"),
Guid.Parse("10526800-a5b1-4dcb-81e3-c830252f456a"),
Guid.Parse("450ebe04-b410-42fa-ac3c-7e75c8c406d6"),
Guid.Parse("5ed3a4ed-c1f3-4118-9ae5-7407b6b17030"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 4,
    Value = 
new System.Guid[4]
{
Guid.Parse("f9adc42d-7b9c-49de-96e7-e9be608ff94f"),
Guid.Parse("9c24c27e-5717-4e9d-a75c-1d79075e5e6d"),
Guid.Parse("b9a129e3-b00b-4055-a378-896b6816bd1a"),
Guid.Parse("c1b8fdf0-78d5-4027-b0b7-c2ff1625df7e"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ab4ca25b-3565-4a46-bdab-c75eced68b57"),
Guid.Parse("ddab2c52-905a-4aad-b6ae-d495271684a7"),
Guid.Parse("186a8a1c-b6b1-4722-8860-b95b174251d0"),
Guid.Parse("babfc996-353c-476d-bdc0-1d1ada374cb8"),
},
},
            new GuiduuidArray1M
{
    Id = 32,
    Value = 
new System.Guid[4]
{
Guid.Parse("19a6b028-5d72-4cad-9fbf-d03da16d0559"),
Guid.Parse("1f604850-d7c4-4da3-9d93-0b4fb18d955b"),
Guid.Parse("da6717b6-8d7a-4e03-8c98-75e8ff06bed3"),
Guid.Parse("eb4a227c-8229-4233-9dcd-2d7873a4f4b2"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 37,
    Value = 
new System.Guid[4]
{
Guid.Parse("a58708a6-5711-402a-9e23-34903f1e1531"),
Guid.Parse("70786d6c-b3f2-4b65-be83-db450a659649"),
Guid.Parse("c9925440-cab3-4b84-bb89-86cc007d1200"),
Guid.Parse("0f966d97-d2ad-4a58-97bf-461345c44fab"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 10,
    Value = 
new System.Guid[3]
{
Guid.Parse("4c8d0362-0ef0-4504-a1b5-a0c27999767c"),
Guid.Parse("d8132e7b-0b34-44e2-883d-0d449b79bcaf"),
Guid.Parse("b4461e8a-b93a-4555-9fd2-7c5a5a692983"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("48c25393-9ebc-4d63-86a5-a3ee79a3c102"),
Guid.Parse("a928e4fc-ed43-4751-a67a-745b5ff81d4d"),
Guid.Parse("0fbc3580-93ea-4563-bb20-0a3700bd7cf0"),
Guid.Parse("eb816665-2273-4f06-9be6-91a04a702a69"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b1e54175-f6fd-4032-8a4e-5d9c40c7522e"),
Guid.Parse("2e801dcd-1de0-4a14-a635-32bf904a2a2e"),
Guid.Parse("b1a95c35-b44c-460a-b7a6-3fb6c9e9763f"),
Guid.Parse("28e249b9-067e-46f9-bfee-6b09e570a197"),
},
},
            new GuiduuidArray1M
{
    Id = 39,
    Value = 
new System.Guid[3]
{
Guid.Parse("727bdec6-372c-4537-ba32-c6b958a7177e"),
Guid.Parse("5a8318a6-1e2a-4026-b3a3-8000e3078c70"),
Guid.Parse("93de1b05-2093-4bfb-9428-6cfad4eebce1"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1c60fbe9-615e-4950-8ed6-dfab613e5a3f"),
Guid.Parse("021ad296-7c42-42ff-a809-81a544c8addd"),
Guid.Parse("d7009ab8-5a8c-457a-b052-7c68a3d8a5b9"),
Guid.Parse("5026c76a-e985-48b1-a9e5-fd329d831c04"),
},
},
            new GuiduuidArray1M
{
    Id = 48,
    Value = 
new System.Guid[3]
{
Guid.Parse("bddfce5a-139c-4e5b-ab4a-98770bb10ff9"),
Guid.Parse("68d1a9b9-73d3-41af-8129-b27b129182dc"),
Guid.Parse("e282e4bd-2022-400a-a711-d17e683fbcb2"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 12,
    Value = 
new System.Guid[3]
{
Guid.Parse("c4d2f234-87fb-4771-9025-6bcddd58b66b"),
Guid.Parse("b1ceb04b-cc68-4394-8f58-5eb1173bf627"),
Guid.Parse("14883f7d-d8b5-4313-91db-15dc6f4847b2"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("790bfb64-6338-4a70-ba9f-19a51c30aa23"),
Guid.Parse("98371d4e-5bdb-4153-a6b3-90ed5ed78ca3"),
Guid.Parse("172446ca-ef64-4b26-8657-dfcd2339ff07"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("93f170cb-75c1-42c7-bca9-87f3b0f1560c"),
Guid.Parse("7ff86b53-88a9-453d-9b67-35b09b49b12d"),
Guid.Parse("03bba142-9408-430f-a1ee-135d12a5a705"),
},
},
            new GuiduuidArray1M
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("1a7fd51c-9116-425b-88b6-0899a3d2200c"),
Guid.Parse("77846c07-2deb-4793-8ec8-e7683db07ae6"),
Guid.Parse("0459133b-c22a-4026-8234-f014f9ab7c49"),
Guid.Parse("39ca80e3-20b2-406a-94aa-731adb44b248"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 59,
    Value = 
new System.Guid[4]
{
Guid.Parse("945ff624-bdb2-4b75-b20a-0bc790e9455f"),
Guid.Parse("51fb1ba6-7634-402a-b447-9680b24deb04"),
Guid.Parse("11bb968f-ef7a-4aa2-9dd4-a060a546e75c"),
Guid.Parse("808c8566-0d6b-4699-b977-4d74fcc74ac8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 20,
    Value = 
new System.Guid[3]
{
Guid.Parse("da34e544-32dd-4d96-9e4d-c0e747904555"),
Guid.Parse("9a17b44e-0ca6-469c-ba59-a57b51f23c07"),
Guid.Parse("8cb50909-f19d-4632-a355-3653aa888d00"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("911c22b5-cc79-4cad-b2f3-43f6247f8e8c"),
Guid.Parse("1de4eeea-2930-4556-84b2-5ddbbf7cebaf"),
Guid.Parse("3dcdc5d8-5956-4e44-8c37-6174add08ee1"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0b275184-c289-44ca-a51c-5bba1c11b28b"),
Guid.Parse("a512e07e-7bc3-4189-9988-565b2d95abd2"),
Guid.Parse("6a9a00e5-09bd-4aa3-b237-91cc875a3637"),
Guid.Parse("2f07d4fe-faf5-40f6-9d25-ae4e59965ef4"),
},
},
            new GuiduuidArray1M
{
    Id = 63,
    Value = 
new System.Guid[4]
{
Guid.Parse("7dfc18b6-62d2-419d-bb9c-f98ecb36affe"),
Guid.Parse("78119b1d-03fc-4526-8694-391c90799285"),
Guid.Parse("de7c461b-86e3-4678-95cf-8f1d5e470429"),
Guid.Parse("4a8b790f-9818-40ec-bc8a-2d09b74e68cc"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("98c1588d-fb4b-4fd2-a8eb-1298ab1a90ce"),
Guid.Parse("d42ddcdd-f9b7-4833-bf7b-882ee45fff7b"),
Guid.Parse("bce9a759-de4e-4b9e-b18c-86dbbd8bab98"),
Guid.Parse("4922fed1-65c8-4e7c-be40-a66e17cfec94"),
},
},
            new GuiduuidArray1M
{
    Id = 70,
    Value = 
new System.Guid[3]
{
Guid.Parse("300a283c-a770-4a90-afed-042c8f02eb8b"),
Guid.Parse("99f1fb77-ca40-44c7-a1cd-f5cf70cdc013"),
Guid.Parse("8704036d-f46f-4fbd-9bbe-0106619f99a8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 27,
    Value = 
new System.Guid[3]
{
Guid.Parse("07b622d9-1c3f-40cd-aaba-97bc6c9ba04d"),
Guid.Parse("168e6ee5-9b82-4d81-832e-a98f5b72635e"),
Guid.Parse("a80d4523-e78b-4a7a-9441-c3712c4ba7e9"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0ee0b9d7-6cef-4239-9f6c-92885b1816bd"),
Guid.Parse("69aea19f-934e-4dc5-ae56-a7f8ff9349e7"),
Guid.Parse("22337d92-d493-4b75-84c1-35cce9ff0e58"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("611aabb7-32d7-48b1-ac80-7beaa399e3d6"),
Guid.Parse("fe04d50a-feda-4b4b-ba20-72cce4cdcf1b"),
Guid.Parse("bfa1399e-3fc2-4877-ada2-69316d180b7f"),
},
},
            new GuiduuidArray1M
{
    Id = 74,
    Value = 
new System.Guid[3]
{
Guid.Parse("7623014b-8396-45fd-bb30-35706a4ea3f3"),
Guid.Parse("e71d34a0-7692-4d5b-86b9-67e6a0caebd2"),
Guid.Parse("42df7677-fce7-4bda-b478-4bbd7d90858c"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c659d923-ca9d-43bb-9019-bd1e835f6d8a"),
Guid.Parse("960856b0-d76a-4076-8345-151ba94c8084"),
Guid.Parse("f10d7c92-ae9c-4a0f-aa34-788eeaeaf8a5"),
Guid.Parse("be615e71-369b-4a7f-a313-b554a96cc6eb"),
},
},
            new GuiduuidArray1M
{
    Id = 76,
    Value = 
new System.Guid[3]
{
Guid.Parse("ebf11e3c-3a7a-4671-b3ee-dc865693ae05"),
Guid.Parse("f6073c09-4b3a-477b-a4a7-c8d0b9bdd141"),
Guid.Parse("3152b0e2-ca3f-470d-9612-8ac1cec8f2a6"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 36,
    Value = 
new System.Guid[3]
{
Guid.Parse("ceb577be-7dd9-47c1-9d8d-8c491d29b821"),
Guid.Parse("009f52cc-e5a7-4fca-bae0-65b82ecbdf9f"),
Guid.Parse("125f709e-eeba-492e-8b1c-d1e43ff0e41a"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7dd4eaf8-1531-409c-87da-d256d97c02e1"),
Guid.Parse("263652b8-0782-42fa-9208-120d30c944a6"),
Guid.Parse("b6baf969-8c2a-4afc-9377-f1d75092bc0f"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5454feb5-9724-4df3-a7c5-c268ca6b02f6"),
Guid.Parse("904ecb7d-cd7a-4b01-bee5-2c0bc7858c1d"),
Guid.Parse("abab40e4-7ada-4d1a-8585-ef89739460ea"),
},
},
            new GuiduuidArray1M
{
    Id = 82,
    Value = 
new System.Guid[4]
{
Guid.Parse("b09ce3b8-59e3-4a40-888d-53f05dafa1c7"),
Guid.Parse("e9714b8c-6694-4aeb-915d-6799d6eb1a0b"),
Guid.Parse("7e23c64f-2e72-453e-8dc4-c9046a507327"),
Guid.Parse("1cad7d75-35bc-4e0e-beeb-2b012af74bd5"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 91,
    Value = 
new System.Guid[4]
{
Guid.Parse("d163a078-fc0d-42f7-b72f-1f60e19586f5"),
Guid.Parse("6959825b-f20e-46a6-8117-24b1bd94f560"),
Guid.Parse("e9e58879-1e13-475e-a61a-68c212ca840a"),
Guid.Parse("ad66b65a-9af4-4bd1-bd8a-921f0e2b99b9"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 38,
    Value = 
new System.Guid[4]
{
Guid.Parse("9a0ef9e7-fe6d-4185-865a-223e524b66e0"),
Guid.Parse("f164e4d1-11c3-46b4-a237-a1295054f5e5"),
Guid.Parse("b86e8355-d48c-45fd-a956-3d2f7b8145d5"),
Guid.Parse("c8f31e55-3722-48b7-b55f-63542429e330"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ed358ad5-6f94-4864-b80d-aaae3337acfa"),
Guid.Parse("5d0dd97c-f17a-4baf-b74d-247fa3ed970d"),
Guid.Parse("d141117c-2e64-4afe-8f40-81594a1bc165"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7454efd5-0270-49b6-8cf7-c7752becfc47"),
Guid.Parse("ac3e239d-8c59-4912-b876-36af140227dc"),
Guid.Parse("8eff4f75-852c-47e0-a085-c8e2251f0477"),
Guid.Parse("b7f25ae2-7002-4d37-9208-a2cc16ee285e"),
},
},
            new GuiduuidArray1M
{
    Id = 96,
    Value = 
new System.Guid[4]
{
Guid.Parse("850fd99c-bbde-4793-aea0-d083e579da68"),
Guid.Parse("5db52b2a-24d3-45b2-9f7c-26d5a6082a98"),
Guid.Parse("d03c8bd9-4f26-4a44-99c1-8e5f63b1145e"),
Guid.Parse("e30a10f1-31b3-4e1d-9110-93c15b154d2f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("73d0d7bf-e14d-4496-9fd1-dd11ac1723e7"),
Guid.Parse("81f97519-4b8e-4cf2-8a58-4e523dbec540"),
Guid.Parse("f56a9764-dddd-451a-9703-c3344d0af7df"),
Guid.Parse("aeb6cf6d-29c0-4fc0-8d29-322af680949a"),
},
},
            new GuiduuidArray1M
{
    Id = 100,
    Value = 
new System.Guid[3]
{
Guid.Parse("4773758f-6f94-4741-b3c8-a51bcdbe30e8"),
Guid.Parse("da21388f-41ed-4c23-9cfa-30cd83d63e2c"),
Guid.Parse("2069dfdc-4d79-4466-b36b-e887f566a09f"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 44,
    Value = 
new System.Guid[3]
{
Guid.Parse("b03c3a57-a852-4067-98ba-b8774b78f078"),
Guid.Parse("b4c35064-5839-4e2a-a602-8b075611946a"),
Guid.Parse("05274ec7-1c42-4f16-b3c0-beee96f96331"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6c32e6e4-227b-4901-b0ac-65dc18a4198d"),
Guid.Parse("ed2481b5-45a9-4b83-8f3c-c4cada7501dc"),
Guid.Parse("61410445-436c-4860-9627-503cb328eb2e"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 104,
    Value = 
new System.Guid[4]
{
Guid.Parse("2d9c4a15-5e5e-4d1c-8fef-f11f7b28fffc"),
Guid.Parse("09112244-272e-411b-8776-3305b1d8b33d"),
Guid.Parse("a1abfaa7-7798-4c21-a2ce-2b299c27a234"),
Guid.Parse("589f5d12-5fa5-451f-87e0-1cefb8b7065f"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 109,
    Value = 
new System.Guid[3]
{
Guid.Parse("513ac782-c7c7-40f5-87b8-fc3aeff742de"),
Guid.Parse("792c6d58-a0cd-448c-a000-8cd14776f258"),
Guid.Parse("67207ae1-cd13-4dd7-a342-c6c550a050f3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 45,
    Value = 
new System.Guid[4]
{
Guid.Parse("c8cad24f-79c4-4fc0-aec7-1e6766cf56dc"),
Guid.Parse("b3e383ca-c2c4-49d8-93e0-1cfa14117140"),
Guid.Parse("68d43345-cbc0-4d6d-be9c-ff7224e8471c"),
Guid.Parse("ea0d5917-4336-41fe-bb40-c7be57a3c8b3"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 113,
    Value = 
new System.Guid[3]
{
Guid.Parse("e6849313-81a0-4ac9-aff5-f904c9611487"),
Guid.Parse("cd44103a-ed96-4c13-a125-c776bf56a329"),
Guid.Parse("d92a974a-c6cd-4af5-aee1-b6923781ca4b"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d30f3780-d430-46e0-8683-d734c48af808"),
Guid.Parse("5085c8b3-72b1-4ca8-ac6a-8f83a5e12040"),
Guid.Parse("12f9facb-826d-42f0-b1e4-1372a8f5d6ab"),
Guid.Parse("a25a8bf5-7d56-4440-bfbe-991ae4502b4d"),
},
},
            new GuiduuidArray1M
{
    Id = 117,
    Value = 
new System.Guid[3]
{
Guid.Parse("7d450ded-a7b9-44ab-84a0-cd92ee3b48ae"),
Guid.Parse("0c5dce73-1e17-4662-9a4f-bb5121dab311"),
Guid.Parse("57640729-f0db-4fe6-a5cc-075b4f9d1e0a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 51,
    Value = 
new System.Guid[4]
{
Guid.Parse("d2f01dd8-5e7c-48f7-8b37-4f7df86a536f"),
Guid.Parse("99fed626-cb38-43d2-b265-49db0651cffc"),
Guid.Parse("be42f726-f66f-4c4a-928a-107e2ba551ad"),
Guid.Parse("15d1b9d2-ce62-405f-8792-0972ca42f661"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("89b0fb1e-fc42-43ab-ad47-6a922dcf1f02"),
Guid.Parse("f5a8926b-813a-4977-89ba-f2c40e9bdf7c"),
Guid.Parse("2159b03b-84fc-42ec-8577-e61a9e583464"),
Guid.Parse("58c7ec27-f575-4485-a205-8c7f02ae5dbf"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 126,
    Value = 
new System.Guid[3]
{
Guid.Parse("63fb42b0-277b-4c5a-abc8-172f68033343"),
Guid.Parse("201e4cd7-a476-4496-8ee5-82e7943053dc"),
Guid.Parse("b03a4221-7a19-4bcc-b580-9d1fae33a5ff"),
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
Guid.Parse("6b2c401e-db7a-471e-8ca4-e8fffed8ae7b"),
Guid.Parse("644ff9bd-b444-4423-8854-dc696e7f88fe"),
Guid.Parse("4695185b-2174-4a5d-a2f9-758b1404eac5"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 59,
    Value = 
new System.Guid[4]
{
Guid.Parse("df237768-f451-4c85-8cd5-1f8f0048b0ba"),
Guid.Parse("ba0abf20-f1be-4ff1-97c8-7fc1feb9cfcd"),
Guid.Parse("87d296bc-3d81-46fa-aac9-019ec90fa19e"),
Guid.Parse("89dc601f-28d2-4a02-8630-7500b08cf76e"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6713fe62-e7e2-49d8-99b6-f2595abfc1df"),
Guid.Parse("b81830c3-3afe-4a3f-bc29-18dee82a0fae"),
Guid.Parse("b72cae8a-16b1-45c7-85b0-e0101c96f418"),
},
},
            new GuiduuidArray1M
{
    Id = 135,
    Value = 
new System.Guid[3]
{
Guid.Parse("0b8f7a98-90c9-4c70-a66c-7f7c7ea45954"),
Guid.Parse("b3ea9408-ef22-4a16-9a28-0287a1c26be1"),
Guid.Parse("f2ef8bff-6696-401b-997b-2b9a8b54a0d8"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4506b21c-dea5-42b5-8c99-3674feecc21c"),
Guid.Parse("80c42e26-f344-4a2d-9985-39d2519679b4"),
Guid.Parse("5a03122c-5fa2-48ad-a274-cbfa64cb2cf2"),
Guid.Parse("77b55f42-6efb-474e-8ed2-d4bbe52d8eb5"),
},
},
            new GuiduuidArray1M
{
    Id = 137,
    Value = 
new System.Guid[4]
{
Guid.Parse("2a4a10bb-2770-41a9-8497-f7e15b92564a"),
Guid.Parse("f2098c81-b4bc-4fb9-911c-1e0c5f0959ce"),
Guid.Parse("f12e776c-0b31-4de4-8a7d-a155a3198010"),
Guid.Parse("0b064039-5de7-49ab-892e-bd58041620a6"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 67,
    Value = 
new System.Guid[4]
{
Guid.Parse("4ef2cc9c-5ef8-448f-b51e-89c3f22b396e"),
Guid.Parse("57390c8b-d03e-4d5d-900c-d6f0ab0ea285"),
Guid.Parse("5f5a3a29-eb80-4f57-81d0-bf176524a143"),
Guid.Parse("6408a5dc-705e-4b48-a116-c6b3681c1c43"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b7d69a28-66c9-452d-8ae5-8a72767fd8d5"),
Guid.Parse("2491125a-e41c-4c98-9bab-79e0fce8062f"),
Guid.Parse("43437649-9b5d-4a5c-9a66-3380c9a1cdd6"),
Guid.Parse("163f6d59-5f3b-4940-a1a6-06ed3dfa3192"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 139,
    Value = 
new System.Guid[4]
{
Guid.Parse("da4d262e-a483-4836-8848-3cc45719f1a7"),
Guid.Parse("8e41dc66-2e66-41b6-8ed9-8a0d11eb2f48"),
Guid.Parse("9bc95334-8f37-4d1a-aa2f-199bde9641bc"),
Guid.Parse("204ae45f-5197-44c8-b21d-5937871635ed"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4bc30a59-9e5e-47a9-8c33-1b05cc5770bd"),
Guid.Parse("e0a76d50-14a5-41c4-8c16-271b0a3b55b0"),
Guid.Parse("d988580c-0be0-42fb-be22-b889436c62ac"),
},
},
            new GuiduuidArray1M
{
    Id = 142,
    Value = 
new System.Guid[3]
{
Guid.Parse("cd9a34af-6b6c-4870-8f7b-9c04978e0ce2"),
Guid.Parse("faaf6c6c-4bc1-43b7-a936-b246a8bffa32"),
Guid.Parse("117dca7f-3d1d-4cae-83e2-4a89721a8dd4"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 72,
    Value = 
new System.Guid[3]
{
Guid.Parse("4632a4b8-4427-46d1-82bc-0951b0c1db5d"),
Guid.Parse("af6dfec5-995a-4ced-968e-7418af45d9a2"),
Guid.Parse("1e2da2fb-f70e-40f8-a5b0-08dc22ba8a0a"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ad41cc62-ee58-4b3f-acb0-3698f083cb2d"),
Guid.Parse("3aba2d78-9e01-4c3a-a738-7dcdb1e26193"),
Guid.Parse("b8394de8-ce4b-401e-a4e1-e5d4278fec03"),
Guid.Parse("fcb35287-0f88-4ba6-853c-eb3abbdae74e"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("422a4e70-d11c-4ae4-a3b3-f449a37dc9f8"),
Guid.Parse("99129473-4c64-4827-9c6c-5cffa82d41a1"),
Guid.Parse("50121f7a-4e89-4ca6-a0ff-02d57f27ca72"),
Guid.Parse("00b08bb0-0d44-4908-a6e3-1d7e138637e4"),
},
},
            new GuiduuidArray1M
{
    Id = 150,
    Value = 
new System.Guid[3]
{
Guid.Parse("a52dd733-9417-49b1-ab9e-6f9e8d9dc023"),
Guid.Parse("38907eb5-431c-4552-b451-71267b4fac65"),
Guid.Parse("3dba3c46-0aa6-492f-8280-e207810f9f1f"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6c4a5215-957e-4757-91b1-936bfd4c3cb9"),
Guid.Parse("c5327aa6-7cf0-40bc-862e-0c0bff4ad59c"),
Guid.Parse("7e802dc8-5d44-457c-9b25-2c78b297b837"),
},
},
            new GuiduuidArray1M
{
    Id = 155,
    Value = 
new System.Guid[3]
{
Guid.Parse("41e456aa-4290-4dd8-8e32-95ea69d8a113"),
Guid.Parse("ec187d52-0d21-4a7c-9ae4-cad79cc7f5d4"),
Guid.Parse("2123cddf-fd8a-4d57-9eb4-68e6f4ca9372"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("3ca03bfc-dd75-463a-afec-42f38d08a724"),
Guid.Parse("81517247-d3d7-45f2-a7c0-416a5be8432c"),
Guid.Parse("b01bb6bb-5a23-4532-abe0-3815a7e43e88"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("255593a6-3f95-4ffa-b838-010d601ee011"),
Guid.Parse("6ddf1c73-6ff8-471a-a4b6-94e8aa736b7f"),
Guid.Parse("60a628c0-60c6-4a59-9ae3-113b75eab715"),
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

                    nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("b1e54175-f6fd-4032-8a4e-5d9c40c7522e"),
Guid.Parse("2e801dcd-1de0-4a14-a635-32bf904a2a2e"),
Guid.Parse("b1a95c35-b44c-460a-b7a6-3fb6c9e9763f"),
Guid.Parse("28e249b9-067e-46f9-bfee-6b09e570a197"),
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
Guid.Parse("1c60fbe9-615e-4950-8ed6-dfab613e5a3f"),
Guid.Parse("021ad296-7c42-42ff-a809-81a544c8addd"),
Guid.Parse("d7009ab8-5a8c-457a-b052-7c68a3d8a5b9"),
Guid.Parse("5026c76a-e985-48b1-a9e5-fd329d831c04"),
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
new System.Guid[3]
{
Guid.Parse("93f170cb-75c1-42c7-bca9-87f3b0f1560c"),
Guid.Parse("7ff86b53-88a9-453d-9b67-35b09b49b12d"),
Guid.Parse("03bba142-9408-430f-a1ee-135d12a5a705"),
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
Guid.Parse("0b275184-c289-44ca-a51c-5bba1c11b28b"),
Guid.Parse("a512e07e-7bc3-4189-9988-565b2d95abd2"),
Guid.Parse("6a9a00e5-09bd-4aa3-b237-91cc875a3637"),
Guid.Parse("2f07d4fe-faf5-40f6-9d25-ae4e59965ef4"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("98c1588d-fb4b-4fd2-a8eb-1298ab1a90ce"),
Guid.Parse("d42ddcdd-f9b7-4833-bf7b-882ee45fff7b"),
Guid.Parse("bce9a759-de4e-4b9e-b18c-86dbbd8bab98"),
Guid.Parse("4922fed1-65c8-4e7c-be40-a66e17cfec94"),
}));
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("611aabb7-32d7-48b1-ac80-7beaa399e3d6"),
Guid.Parse("fe04d50a-feda-4b4b-ba20-72cce4cdcf1b"),
Guid.Parse("bfa1399e-3fc2-4877-ada2-69316d180b7f"),
}));
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
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IGuidArrayuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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

                var models =  ((IGuidArrayuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IGuidArrayuuidArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                var models =  ((IGuidArrayuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 25;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[4], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[5], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[6], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[23],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[24],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
        private void DbConnectionSelectModelDynParBatchConfig()
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

                var models = await ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
GuiduuidArray1M.AssertModel(models[0],_testData[17], false);GuiduuidArray1M.AssertModel(models[1],_testData[18], false);GuiduuidArray1M.AssertModel(models[2],_testData[19], false);GuiduuidArray1M.AssertModel(models[3],_testData[20], false);GuiduuidArray1M.AssertModel(models[4],_testData[21], false);GuiduuidArray1M.AssertModel(models[5],_testData[22], false);GuiduuidArray1M.AssertModel(models[6],_testData[23], false);GuiduuidArray1M.AssertModel(models[7],_testData[24], false);GuiduuidArray1M.AssertModel(models[8],_testData[25], false);GuiduuidArray1M.AssertModel(models[9],_testData[26], false);GuiduuidArray1M.AssertModel(models[10],_testData[27], false);GuiduuidArray1M.AssertModel(models[11],_testData[28], false);GuiduuidArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
GuiduuidArray1M.AssertModel(models[0],_testData[28], false);GuiduuidArray1M.AssertModel(models[1],_testData[29], false);
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

                var models =  ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
GuiduuidArray1M.AssertModel(models[0],_testData[25], false);GuiduuidArray1M.AssertModel(models[1],_testData[26], false);GuiduuidArray1M.AssertModel(models[2],_testData[27], false);GuiduuidArray1M.AssertModel(models[3],_testData[28], false);GuiduuidArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
GuiduuidArray1M.AssertModel(models[0],_testData[28], false);GuiduuidArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 135, query1, 8, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[2], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[3], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[4], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[5], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[6], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[7], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[8], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[9], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[10], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[11], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[18],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[19],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[20],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[21],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[22],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[23],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[24],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[25],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[26],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
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
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 126, query1, 70, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatGuiduuidArray1M.AssertModel(models[0],_testData[12], false);FlatGuiduuidArray1M.AssertModel(models[1],_testData[13], false);FlatGuiduuidArray1M.AssertModel(models[2],_testData[14], false);FlatGuiduuidArray1M.AssertModel(models[3],_testData[15], false);FlatGuiduuidArray1M.AssertModel(models[4],_testData[16], false);FlatGuiduuidArray1M.AssertModel(models[5],_testData[17], false);FlatGuiduuidArray1M.AssertModel(models[6],_testData[18], false);FlatGuiduuidArray1M.AssertModel(models[7],_testData[19], false);FlatGuiduuidArray1M.AssertModel(models[8],_testData[20], false);FlatGuiduuidArray1M.AssertModel(models[9],_testData[21], false);FlatGuiduuidArray1M.AssertModel(models[10],_testData[22], false);FlatGuiduuidArray1M.AssertModel(models[11],_testData[23], false);FlatGuiduuidArray1M.AssertModel(models[12],_testData[24], false);FlatGuiduuidArray1M.AssertModel(models[13],_testData[25], false);FlatGuiduuidArray1M.AssertModel(models[14],_testData[26], false);FlatGuiduuidArray1M.AssertModel(models[15],_testData[27], false);FlatGuiduuidArray1M.AssertModel(models[16],_testData[28], false);FlatGuiduuidArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidArrayuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 139, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
GuiduuidArray1M.AssertModel(models[0],_testData[27], false);GuiduuidArray1M.AssertModel(models[1],_testData[28], false);GuiduuidArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
GuiduuidArray1M.AssertModel(models[0],_testData[24], false);GuiduuidArray1M.AssertModel(models[1],_testData[25], false);GuiduuidArray1M.AssertModel(models[2],_testData[26], false);GuiduuidArray1M.AssertModel(models[3],_testData[27], false);GuiduuidArray1M.AssertModel(models[4],_testData[28], false);GuiduuidArray1M.AssertModel(models[5],_testData[29], false);
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
                var models =  ((IGuidArrayuuidArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatch(connection, 16, 109))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
GuiduuidArray1M.AssertModel(models[0],_testData[3], false);GuiduuidArray1M.AssertModel(models[1],_testData[4], false);GuiduuidArray1M.AssertModel(models[2],_testData[5], false);GuiduuidArray1M.AssertModel(models[3],_testData[6], false);GuiduuidArray1M.AssertModel(models[4],_testData[7], false);GuiduuidArray1M.AssertModel(models[5],_testData[8], false);GuiduuidArray1M.AssertModel(models[6],_testData[9], false);GuiduuidArray1M.AssertModel(models[7],_testData[10], false);GuiduuidArray1M.AssertModel(models[8],_testData[11], false);GuiduuidArray1M.AssertModel(models[9],_testData[12], false);GuiduuidArray1M.AssertModel(models[10],_testData[13], false);GuiduuidArray1M.AssertModel(models[11],_testData[14], false);GuiduuidArray1M.AssertModel(models[12],_testData[15], false);GuiduuidArray1M.AssertModel(models[13],_testData[16], false);GuiduuidArray1M.AssertModel(models[14],_testData[17], false);GuiduuidArray1M.AssertModel(models[15],_testData[18], false);GuiduuidArray1M.AssertModel(models[16],_testData[19], false);GuiduuidArray1M.AssertModel(models[17],_testData[20], false);GuiduuidArray1M.AssertModel(models[18],_testData[21], false);GuiduuidArray1M.AssertModel(models[19],_testData[22], false);GuiduuidArray1M.AssertModel(models[20],_testData[23], false);GuiduuidArray1M.AssertModel(models[21],_testData[24], false);GuiduuidArray1M.AssertModel(models[22],_testData[25], false);GuiduuidArray1M.AssertModel(models[23],_testData[26], false);GuiduuidArray1M.AssertModel(models[24],_testData[27], false);GuiduuidArray1M.AssertModel(models[25],_testData[28], false);GuiduuidArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
GuiduuidArray1M.AssertModel(models[0],_testData[20], false);GuiduuidArray1M.AssertModel(models[1],_testData[21], false);GuiduuidArray1M.AssertModel(models[2],_testData[22], false);GuiduuidArray1M.AssertModel(models[3],_testData[23], false);GuiduuidArray1M.AssertModel(models[4],_testData[24], false);GuiduuidArray1M.AssertModel(models[5],_testData[25], false);GuiduuidArray1M.AssertModel(models[6],_testData[26], false);GuiduuidArray1M.AssertModel(models[7],_testData[27], false);GuiduuidArray1M.AssertModel(models[8],_testData[28], false);GuiduuidArray1M.AssertModel(models[9],_testData[29], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
GuiduuidArray1M.AssertModel(models[0],_testData[6], false);GuiduuidArray1M.AssertModel(models[1],_testData[7], false);GuiduuidArray1M.AssertModel(models[2],_testData[8], false);GuiduuidArray1M.AssertModel(models[3],_testData[9], false);GuiduuidArray1M.AssertModel(models[4],_testData[10], false);GuiduuidArray1M.AssertModel(models[5],_testData[11], false);GuiduuidArray1M.AssertModel(models[6],_testData[12], false);GuiduuidArray1M.AssertModel(models[7],_testData[13], false);GuiduuidArray1M.AssertModel(models[8],_testData[14], false);GuiduuidArray1M.AssertModel(models[9],_testData[15], false);GuiduuidArray1M.AssertModel(models[10],_testData[16], false);GuiduuidArray1M.AssertModel(models[11],_testData[17], false);GuiduuidArray1M.AssertModel(models[12],_testData[18], false);GuiduuidArray1M.AssertModel(models[13],_testData[19], false);GuiduuidArray1M.AssertModel(models[14],_testData[20], false);GuiduuidArray1M.AssertModel(models[15],_testData[21], false);GuiduuidArray1M.AssertModel(models[16],_testData[22], false);GuiduuidArray1M.AssertModel(models[17],_testData[23], false);GuiduuidArray1M.AssertModel(models[18],_testData[24], false);GuiduuidArray1M.AssertModel(models[19],_testData[25], false);GuiduuidArray1M.AssertModel(models[20],_testData[26], false);GuiduuidArray1M.AssertModel(models[21],_testData[27], false);GuiduuidArray1M.AssertModel(models[22],_testData[28], false);GuiduuidArray1M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 134);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
GuiduuidArray1M.AssertModel(models[0],_testData[24], false);GuiduuidArray1M.AssertModel(models[1],_testData[25], false);GuiduuidArray1M.AssertModel(models[2],_testData[26], false);GuiduuidArray1M.AssertModel(models[3],_testData[27], false);GuiduuidArray1M.AssertModel(models[4],_testData[28], false);GuiduuidArray1M.AssertModel(models[5],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
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
        private void ImportModelInnerConfig()
        {
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
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidArrayuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
                importCollection.Clear();

                importCollection.Add(_testData[15].ModelInner);
                importCollection.Add(_testData[17].ModelInner);
                importCollection.Add(_testData[19].ModelInner);
                importCollection.Add(_testData[21].ModelInner);
                importCollection.Add(_testData[23].ModelInner);
                importCollection.Add(_testData[25].ModelInner);
                importCollection.Add(_testData[27].ModelInner);
                importCollection.Add(_testData[29].ModelInner);
                await ((IGuidArrayuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IGuidArrayuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(GuiduuidArray1M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray1M>(15);

                    importCollection.Add(_testData[0]);
                    importCollection.Add(_testData[1]);
                    importCollection.Add(_testData[2]);
                    importCollection.Add(_testData[3]);
                    importCollection.Add(_testData[4]);
                    importCollection.Add(_testData[5]);
                    importCollection.Add(_testData[6]);
                    importCollection.Add(_testData[7]);
                    importCollection.Add(_testData[8]);
                    importCollection.Add(_testData[9]);
                    importCollection.Add(_testData[10]);
                    importCollection.Add(_testData[11]);
                    importCollection.Add(_testData[12]);
                    importCollection.Add(_testData[13]);
                    importCollection.Add(_testData[14]);
                ((IGuidArrayuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                GuiduuidArray1M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[14], false);
                importCollection.Clear();

                    importCollection.Add(_testData[15]);
                    importCollection.Add(_testData[16]);
                    importCollection.Add(_testData[17]);
                    importCollection.Add(_testData[18]);
                    importCollection.Add(_testData[19]);
                    importCollection.Add(_testData[20]);
                    importCollection.Add(_testData[21]);
                    importCollection.Add(_testData[22]);
                    importCollection.Add(_testData[23]);
                    importCollection.Add(_testData[24]);
                    importCollection.Add(_testData[25]);
                    importCollection.Add(_testData[26]);
                    importCollection.Add(_testData[27]);
                    importCollection.Add(_testData[28]);
                    importCollection.Add(_testData[29]);
                await ((IGuidArrayuuidArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IGuidArrayuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                GuiduuidArray1M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray1M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray1M.AssertModel(models[14],_testData[14], false);
                GuiduuidArray1M.AssertModel(models[15],_testData[15], false);
                GuiduuidArray1M.AssertModel(models[16],_testData[16], false);
                GuiduuidArray1M.AssertModel(models[17],_testData[17], false);
                GuiduuidArray1M.AssertModel(models[18],_testData[18], false);
                GuiduuidArray1M.AssertModel(models[19],_testData[19], false);
                GuiduuidArray1M.AssertModel(models[20],_testData[20], false);
                GuiduuidArray1M.AssertModel(models[21],_testData[21], false);
                GuiduuidArray1M.AssertModel(models[22],_testData[22], false);
                GuiduuidArray1M.AssertModel(models[23],_testData[23], false);
                GuiduuidArray1M.AssertModel(models[24],_testData[24], false);
                GuiduuidArray1M.AssertModel(models[25],_testData[25], false);
                GuiduuidArray1M.AssertModel(models[26],_testData[26], false);
                GuiduuidArray1M.AssertModel(models[27],_testData[27], false);
                GuiduuidArray1M.AssertModel(models[28],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_guiduuidarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidArrayuuidArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidArrayuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


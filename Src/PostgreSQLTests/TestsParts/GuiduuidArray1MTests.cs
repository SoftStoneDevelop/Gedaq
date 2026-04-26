

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
new System.Guid[3]
{
Guid.Parse("a5de3e6a-8f72-4fea-bed6-00da823374a2"),
Guid.Parse("c51d3753-d337-48c1-8e15-7a21ea8d70fa"),
Guid.Parse("41c989aa-1bfc-42b7-b7a3-683d7da1ffaa"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("f2867680-26e3-4a13-ba09-5ce2bb42ac5e"),
Guid.Parse("ac1986c7-d5d9-4a41-a3c8-b814509929a2"),
Guid.Parse("f3ed02c0-c98a-4f40-beb1-af33d6d9d34d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 6,
    Value = 
new System.Guid[4]
{
Guid.Parse("f15f8ebc-c4ce-4d38-b3db-42473e164403"),
Guid.Parse("a2816f32-8737-4ec0-9916-f295e44a7e9f"),
Guid.Parse("e8e2e2d4-533b-4a93-9475-c74e7ae984d5"),
Guid.Parse("5bfc090b-03ce-4570-96a8-fdd437438523"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 15,
    Value = 
new System.Guid[3]
{
Guid.Parse("101cdf73-5a92-4a2e-8796-b3c5ec0950d3"),
Guid.Parse("fff7f95f-440e-437c-bed9-dcba337259ea"),
Guid.Parse("8852f7a4-6946-4209-a40b-538bb6e848ec"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 20,
    Value = 
new System.Guid[3]
{
Guid.Parse("e0dfdfdd-14c2-4c44-accf-f15f6b0073a4"),
Guid.Parse("537f4e45-1d93-481b-b942-469a15172756"),
Guid.Parse("60ef027d-7f23-413a-b444-fc2142a6ff41"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 14,
    Value = 
new System.Guid[4]
{
Guid.Parse("fd4334ae-54c7-4493-a0bd-5a4bca0fb9c5"),
Guid.Parse("bf5807b3-abfe-4127-818b-f30d8df12954"),
Guid.Parse("40cafe33-fdd0-4506-994e-12584e54e8a9"),
Guid.Parse("34d5f58a-7c9d-49f7-a53d-8c14f29ffe0f"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f6a67e8c-b942-47a0-8397-12a225d80d14"),
Guid.Parse("e168c90e-b9ff-4182-92c5-a52744814cdf"),
Guid.Parse("df508777-e9f4-420c-9f47-3bf22f085317"),
Guid.Parse("d75fda88-1179-48e1-9712-da569f3a855a"),
},
},
            new GuiduuidArray1M
{
    Id = 29,
    Value = 
new System.Guid[4]
{
Guid.Parse("7454a98c-8c05-4860-b54e-f7f3f0c52c46"),
Guid.Parse("160f409e-b69a-4376-a574-d44e1005c35b"),
Guid.Parse("f600095d-3612-4ce3-a85b-154e0fe17147"),
Guid.Parse("7d2e846c-bfb4-45b7-9e13-89f493a17160"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("73636bf1-4fdb-4562-b5df-da6a51748bad"),
Guid.Parse("29db955a-c52c-4636-a0f9-1ea91ed8f601"),
Guid.Parse("d17951cb-fabb-4cfa-af15-83d2dc413a91"),
},
},
            new GuiduuidArray1M
{
    Id = 35,
    Value = 
new System.Guid[3]
{
Guid.Parse("a868d8bd-eb63-4c61-abe1-738e58b818d9"),
Guid.Parse("443b631e-44ba-4115-83d5-7fe224282b7c"),
Guid.Parse("e08d3a20-2aa2-49d4-8242-c543bf0de98b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("304b262a-f17a-463f-b4be-b17e916d602a"),
Guid.Parse("84c12077-cb40-4937-9929-aa6b993a6691"),
Guid.Parse("7e9addce-c565-426a-9f9e-1f5f6ab6ccac"),
Guid.Parse("83754308-7dba-43e6-9ac2-7e1a6b30ba91"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 39,
    Value = 
new System.Guid[3]
{
Guid.Parse("4e662319-0b7b-4921-9f17-b3398c268e0d"),
Guid.Parse("21d0c3ed-a260-4806-a8ac-8856d704bb1c"),
Guid.Parse("652981c8-aeeb-4cca-bcbd-26a28c3bb00c"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b1b9cf0f-23a0-4c41-a60c-70c84113a2aa"),
Guid.Parse("bca3c09f-a0a8-4663-adc1-cbffc21b769b"),
Guid.Parse("777c3f8d-abd1-4143-a170-3380ab727351"),
Guid.Parse("68cd6a24-807a-477a-8bcd-bc108358ca5f"),
},
},
            new GuiduuidArray1M
{
    Id = 42,
    Value = 
new System.Guid[3]
{
Guid.Parse("9aa772ff-a75b-43fa-8952-dd54f5467021"),
Guid.Parse("c8471092-2232-40af-b5a8-71767b04ea37"),
Guid.Parse("c3c74076-67a1-4f7d-8684-a7ab17cc1bf7"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 27,
    Value = 
new System.Guid[4]
{
Guid.Parse("3dfd600f-bf74-4130-9db8-8908f6ffaf5d"),
Guid.Parse("feca9fc1-3669-46ea-bb8a-b0bec5ff17cc"),
Guid.Parse("a96bd9a0-2e07-40f8-9634-dc4f401facda"),
Guid.Parse("427cf128-96b7-4c95-9899-51808e5bb28f"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c6efc205-172a-40b9-a5c9-882329c0bc17"),
Guid.Parse("a8bdd2d9-0eb2-4081-b27c-83f358a9b8dd"),
Guid.Parse("bb4583e2-a3a8-459f-9128-a4dd36326b81"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 46,
    Value = 
new System.Guid[4]
{
Guid.Parse("04407ea1-90cb-4f51-9789-0251a1a34214"),
Guid.Parse("b81efac6-88fa-4a9c-8c41-3740e00fbf33"),
Guid.Parse("e43d1f89-d608-4c3f-b62e-37f9f4ee2a26"),
Guid.Parse("fb9627e1-477d-49bc-a495-e6619a190ce6"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 51,
    Value = 
new System.Guid[3]
{
Guid.Parse("5550ed8e-f3b2-45c8-a38d-572a9f2c7ba9"),
Guid.Parse("39cc51c7-a9fe-4d77-830f-0aec750cb576"),
Guid.Parse("40e06ed7-94b6-47dd-990b-52681a08aa34"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 28,
    Value = 
new System.Guid[3]
{
Guid.Parse("2316b3c8-dba0-4188-9dcb-e4a284bca990"),
Guid.Parse("af5b3e95-994d-4aba-a6d9-af72d3d89319"),
Guid.Parse("f69bd6c3-7e13-42d4-b3ce-d8cb80bcc80e"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 56,
    Value = 
new System.Guid[3]
{
Guid.Parse("87161d63-4409-4e48-b853-0d6e72f662d1"),
Guid.Parse("9824b21c-a154-404e-9f28-b765b1bc6d79"),
Guid.Parse("558322a5-eb40-4312-af6e-5efe905accd8"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 57,
    Value = 
new System.Guid[3]
{
Guid.Parse("ba10c974-0016-4b6c-ac23-b1982f5ff8ee"),
Guid.Parse("faf3009a-1c66-46fb-8bc3-7fa622f372ba"),
Guid.Parse("bf5f8368-85d8-4f8e-b5df-c2a8a34c1ca4"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 32,
    Value = 
new System.Guid[3]
{
Guid.Parse("0fab0996-6f51-43b3-abe5-82396eb5afee"),
Guid.Parse("e94da9b7-399c-4693-a01a-73a37b1367aa"),
Guid.Parse("7e56766d-d303-4302-bc03-3fb0e90c7ef2"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a9013cfa-38b7-4710-81df-51e54ead0493"),
Guid.Parse("2eb48289-a07d-4df8-9324-a5a09854dfb4"),
Guid.Parse("6999fa37-8f56-4efd-9010-b0d4551a77ba"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 65,
    Value = 
new System.Guid[3]
{
Guid.Parse("f31575e5-6618-40f2-86e6-5dc03c59ab21"),
Guid.Parse("daebcabd-1ce1-4127-97b1-94ba267569b8"),
Guid.Parse("99121cbc-84ca-48ed-9989-eb7774def9f5"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5a81623c-3bd4-493e-a083-0dce02683bc3"),
Guid.Parse("0b0f1805-cc92-4853-a65b-7f9e1cf378cf"),
Guid.Parse("a141cc7d-e96c-4a10-98bc-4b21a9f9c2e5"),
Guid.Parse("bdfcbb26-2a5a-4cc0-8574-53ff10477a7f"),
},
},
            new GuiduuidArray1M
{
    Id = 69,
    Value = 
new System.Guid[4]
{
Guid.Parse("beeee3d4-b94b-48fa-b78a-575231db8877"),
Guid.Parse("7f256c95-298f-4cb6-8ef1-ea76640b2855"),
Guid.Parse("a0b66796-5c80-4d05-a935-260dd5437de3"),
Guid.Parse("d4d66b85-f329-4dd3-9bd4-083c430c148d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 36,
    Value = 
new System.Guid[3]
{
Guid.Parse("bfcba19a-f1d0-492e-bdf2-f68b603114a8"),
Guid.Parse("a64dad17-c551-4d6a-8883-92c7c559c9a5"),
Guid.Parse("7e928175-4a37-4fe5-8460-c25aa7d51509"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("8f6e0465-a5d4-493b-87c4-90061673d283"),
Guid.Parse("1dc3679b-08a9-45aa-85e7-b7009ec1d33e"),
Guid.Parse("fb9fc4c7-bda2-4456-a24f-a3faf67a01ff"),
},
},
            new GuiduuidArray1M
{
    Id = 74,
    Value = 
new System.Guid[3]
{
Guid.Parse("bee604ed-aeec-4081-b04a-547ce7e684fc"),
Guid.Parse("5bebe548-b80f-4435-be6c-0563712d0373"),
Guid.Parse("a335dff7-34cf-4e91-b7a5-fed39bd220d3"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("608f2a6b-1820-4cac-86bb-719774d09739"),
Guid.Parse("f1e1cc9b-e096-41a8-a5be-e81551736240"),
Guid.Parse("c7dac165-db21-4710-819c-e25a64a53e3d"),
Guid.Parse("25f72e2e-41c3-49cf-b676-b707171b487e"),
},
},
            new GuiduuidArray1M
{
    Id = 78,
    Value = 
new System.Guid[3]
{
Guid.Parse("76de9c5b-8b2e-470f-ba86-d09fb5dce91f"),
Guid.Parse("0d9e4a00-a8bc-4e08-a9fc-a9c9ca22b52e"),
Guid.Parse("e6d1988a-0911-403e-9874-4760da385901"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 40,
    Value = 
new System.Guid[4]
{
Guid.Parse("cb1a7d1c-2017-4d1e-8b92-868434190a42"),
Guid.Parse("9986aa27-7ebf-40d0-9c30-f85dded77150"),
Guid.Parse("9403c04d-8a63-4980-a4d4-ac2b82d38292"),
Guid.Parse("f8c64704-071b-4918-a13c-81e431fb5dfe"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 83,
    Value = 
new System.Guid[4]
{
Guid.Parse("26d9407f-e179-4976-9b28-d13323eaf2ed"),
Guid.Parse("1c8537d0-0a11-440d-b2c5-e7dc3891006b"),
Guid.Parse("5f40637a-7e48-4d78-90e1-925661247957"),
Guid.Parse("ae9580fc-55eb-4b48-bcad-81b8eaed17eb"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("e51c3b37-dba4-4780-9166-60ccb08e3316"),
Guid.Parse("2d5ef907-1a93-4a76-b579-2a94c428c1ff"),
Guid.Parse("807f4102-82a6-453e-b306-77a4136e7548"),
Guid.Parse("b9e1382d-f516-44d1-b8c8-cd5b2b444f41"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 46,
    Value = 
new System.Guid[3]
{
Guid.Parse("5aa4d883-f3bd-4463-bd8c-48163fc5dba0"),
Guid.Parse("e82e38fe-305e-4289-b548-8b922d7007ae"),
Guid.Parse("4afd2853-2d60-4f55-b679-aea23e53d43a"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("51a919ab-9b7d-4f53-9a7c-7eb6048a58c4"),
Guid.Parse("149cd596-faed-43ec-8bb5-e2ea9681fe3d"),
Guid.Parse("99306f14-e36a-4405-9f0c-6039ae5248c6"),
Guid.Parse("af17c2f9-ab57-474f-9f28-8a73b30b2ca6"),
},
},
            new GuiduuidArray1M
{
    Id = 93,
    Value = 
new System.Guid[4]
{
Guid.Parse("6f1a2e42-e841-4d39-9858-7b444abb1638"),
Guid.Parse("8efe242e-f883-44ee-bfff-66b46f9fe871"),
Guid.Parse("17481db5-949b-4e13-a218-0a251e07e6ee"),
Guid.Parse("0d9b6938-c45f-4981-9424-6bd70632f394"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6c9f83aa-20b1-402f-8848-6df2230a74d1"),
Guid.Parse("ba00a5bd-9a02-439f-a10f-e10eeea6b770"),
Guid.Parse("a225d479-b568-4c56-835c-88d582f6ff3b"),
},
},
            new GuiduuidArray1M
{
    Id = 96,
    Value = 
new System.Guid[3]
{
Guid.Parse("af8e0530-a078-4550-8f8b-3735370532b4"),
Guid.Parse("8367ccf6-e4dc-48d9-acd3-a489be685b95"),
Guid.Parse("0a4ed57e-2285-411c-b426-28d55f8dda42"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 47,
    Value = 
new System.Guid[4]
{
Guid.Parse("c42ef3d7-c6e1-43f9-aa6a-6202634b5b9b"),
Guid.Parse("7206eadd-49b5-43ff-b36c-73701a826230"),
Guid.Parse("5d0f0a31-1213-4244-a85c-e9d56bac7889"),
Guid.Parse("afd851fc-d751-45db-9728-8dc3e2d028f4"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2c4bac1d-4522-4f95-a6ed-391001699336"),
Guid.Parse("5e97efc4-5376-46a0-8b81-8a331903fb41"),
Guid.Parse("02ce7cc9-64cc-4db5-8712-e1d95bf90ae5"),
Guid.Parse("a4761f85-d9f2-4328-a1b9-cbeb88c4fbbf"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("57feeb1d-ef4b-493e-be2b-3bff665503f1"),
Guid.Parse("e398c13d-6c62-44ec-b97b-9ffcd5d82835"),
Guid.Parse("02f9b1fd-a3bc-49fc-a20d-16d9fbdcfbf0"),
Guid.Parse("c094fb3b-a94d-42e1-bea9-3916c6592c7a"),
},
},
            new GuiduuidArray1M
{
    Id = 99,
    Value = 
new System.Guid[3]
{
Guid.Parse("17da1947-2ec1-41aa-8a13-2cdaacc7cddb"),
Guid.Parse("b84ad5b7-8882-4da7-961d-a512f36eef76"),
Guid.Parse("01b084ae-4315-4c19-bb3b-bd59f58075cd"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ec7cd466-c123-4419-9049-9a5b4dccc26a"),
Guid.Parse("8007e81c-0dd2-46c7-a183-ffab64ac7f9c"),
Guid.Parse("66593d7c-f340-4165-b5b5-c30ae9e80be3"),
},
},
            new GuiduuidArray1M
{
    Id = 104,
    Value = 
new System.Guid[3]
{
Guid.Parse("932af633-1427-44a9-bd91-b48edf59a612"),
Guid.Parse("0ee9bb43-6a46-4976-9f23-46113aaeac2c"),
Guid.Parse("8a7135e6-7238-4437-828a-a417f135bf27"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 50,
    Value = 
new System.Guid[3]
{
Guid.Parse("f5c78cdc-6fca-4415-a211-76c2ac33cf98"),
Guid.Parse("6416c4c3-025d-4a6d-b378-e5e3ccd936b4"),
Guid.Parse("1fa4349c-34c2-4bf1-9b14-c0e7695b9906"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b4ac22fa-277a-4244-98dc-2e192d1d032b"),
Guid.Parse("151e71ee-02ed-4572-b318-163d647542b4"),
Guid.Parse("8d0dda2c-de06-41d1-9628-af45d1dc6047"),
},
},
            new GuiduuidArray1M
{
    Id = 111,
    Value = 
new System.Guid[3]
{
Guid.Parse("04660ef1-84f3-4a78-8928-0750508fa898"),
Guid.Parse("b549317a-7623-469d-b42a-12f83fd56fe5"),
Guid.Parse("a07a4e97-06df-4b44-bc3f-5d315e45e882"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 117,
    Value = 
new System.Guid[4]
{
Guid.Parse("62aacf66-f58b-4848-9765-3be7e2b39bad"),
Guid.Parse("d201d363-a0e3-458d-83b9-215abf144ba0"),
Guid.Parse("521cd3f6-d0dd-43a9-be82-e5c796de20f9"),
Guid.Parse("a31668fd-dcdc-4d64-bf12-e64dca2bebc2"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 58,
    Value = 
new System.Guid[4]
{
Guid.Parse("73ca2ec4-3d47-4f67-b719-eea7b6d22dcd"),
Guid.Parse("48d39367-a068-4ffe-9c4f-8c8f50df30c3"),
Guid.Parse("7a97aafd-5ed0-4359-9b5b-2dd3665e12ca"),
Guid.Parse("59ce2ceb-e788-4fa1-9dc7-06340e4b836c"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 118,
    Value = 
new System.Guid[3]
{
Guid.Parse("5630ccb5-3ad8-47d0-ba38-cc13427aa93b"),
Guid.Parse("d0925ddf-1647-4234-8802-b29837e9f617"),
Guid.Parse("8cfb2cfc-322f-4081-a6d3-759dab75af8a"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0c102ff6-c3f7-44f6-a1e5-05428920948e"),
Guid.Parse("321ba2d1-6fcd-4bf4-9937-b0d666c5d678"),
Guid.Parse("67ac54e1-84f1-40db-8aeb-0e3d273d86ed"),
Guid.Parse("57ff7802-2969-4c7d-96e2-a58291e9e559"),
},
},
            new GuiduuidArray1M
{
    Id = 119,
    Value = 
new System.Guid[3]
{
Guid.Parse("88ea36f7-4ce5-42ad-8523-93bf85c0c636"),
Guid.Parse("a1460502-9ea2-430f-8fb2-895d59da1e2e"),
Guid.Parse("5f14c095-3844-4fb2-9af9-13eb85d292ac"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 66,
    Value = 
new System.Guid[3]
{
Guid.Parse("29edd16a-cbca-4aad-b1a7-101324cfce6b"),
Guid.Parse("cf1a1e0d-d28c-4f06-af1e-fa22c8ab9246"),
Guid.Parse("a11df2bf-9299-4216-887f-5f3c4544a6d5"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("cf6fa1ed-41b0-41bf-9f2a-91a47efd0040"),
Guid.Parse("1daf9548-a88e-44d7-9e5d-aa60727cdb8c"),
Guid.Parse("f6b72ae6-5be3-4b0d-90a5-53830d5b2fbb"),
Guid.Parse("f39dccfa-ceec-4a50-9dfb-1beb58020467"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 124,
    Value = 
new System.Guid[3]
{
Guid.Parse("7e502804-7567-4538-8d17-44ed9b9a4247"),
Guid.Parse("9f5474d3-472d-478a-bf00-0e2c0c96bd56"),
Guid.Parse("90046805-4a86-4a48-bb6d-c0924f402e02"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("219c2e6b-ea74-4902-a1e6-b374147d75af"),
Guid.Parse("f6e9f021-af78-4d83-92ba-0122ce8e0b3b"),
Guid.Parse("7db8ccf9-6f63-447c-a6e6-c7d6e6b7005d"),
Guid.Parse("a72d0d21-317c-4a01-b061-1acac1e9505c"),
},
},
            new GuiduuidArray1M
{
    Id = 131,
    Value = 
new System.Guid[4]
{
Guid.Parse("9ca4934f-afb1-44ed-a784-9dcc48fb47d2"),
Guid.Parse("18a94daf-16f4-4335-ae53-fb520273c4e2"),
Guid.Parse("820ad37e-527d-44d3-8052-73e1a3c34d50"),
Guid.Parse("b3389e78-b41a-461d-b115-fdf99ed797da"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 70,
    Value = 
new System.Guid[3]
{
Guid.Parse("452dac78-4d15-421c-8e3f-f82c1b439d3b"),
Guid.Parse("ff2b2c7e-40f2-46d5-aa4a-053d7fb207ff"),
Guid.Parse("0fdab442-2387-4de7-829f-a1f70cd4f395"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("49de11a9-79c1-4367-a9bb-ababc11ba19e"),
Guid.Parse("192d0554-4ce5-4428-b395-34a7db73dd9f"),
Guid.Parse("2796c20e-1d8f-4554-a3f8-c530fb8e1e87"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6412e508-452d-431b-a174-f1d149f39fb2"),
Guid.Parse("afcfae61-1406-4400-96cf-0aebcc87aaa3"),
Guid.Parse("8236f993-088d-4667-b150-5e65d3e5e158"),
Guid.Parse("b18d5739-b7c8-41cd-8d78-7b21ffd74763"),
},
},
            new GuiduuidArray1M
{
    Id = 135,
    Value = 
new System.Guid[4]
{
Guid.Parse("719d94a2-0978-44fc-9a34-5399340366d9"),
Guid.Parse("36e75844-9a19-4e47-822a-27d4e9612427"),
Guid.Parse("0852a8bd-75da-4812-ad44-4b82901ac118"),
Guid.Parse("f659c5d0-0646-4e9c-bdc0-cb1ee9da83e2"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("cd438c5c-2e6b-4fda-9f6c-a4c3be57ee20"),
Guid.Parse("a3a6b900-a726-4a39-9039-41dd547957b9"),
Guid.Parse("041dcf9f-cceb-4acf-a582-b915fd87a493"),
},
},
            new GuiduuidArray1M
{
    Id = 142,
    Value = 
new System.Guid[3]
{
Guid.Parse("ce4b5c1a-6314-4b7f-83b7-e3b4fc490cbd"),
Guid.Parse("80c3a5c5-fa57-4985-bb90-455fef1d4ca2"),
Guid.Parse("76eb4227-cd59-4509-a2de-39987d7659bb"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 75,
    Value = 
new System.Guid[4]
{
Guid.Parse("472417ff-1398-4157-96a4-22482e868f10"),
Guid.Parse("6c274fcf-d475-444e-8358-b03f9cd4e322"),
Guid.Parse("1ca11cf9-083a-4c92-9e9f-f9426e1596eb"),
Guid.Parse("2856a376-c3f2-47e9-bac3-d861195e4015"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d8076b96-e700-49be-9804-9b18005bdd4e"),
Guid.Parse("3b55192e-8c6d-42a9-b397-13bf87fdf5e8"),
Guid.Parse("516b701c-f6c2-413d-bcba-c5a90f0f6f22"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("45ebd0f2-fa0b-4198-8ee3-c47169993c65"),
Guid.Parse("17c03d9e-d0f0-4757-984c-47619fcb8ae5"),
Guid.Parse("d034d14d-494d-408b-acd7-7a7c85d507fa"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("73636bf1-4fdb-4562-b5df-da6a51748bad"),
Guid.Parse("29db955a-c52c-4636-a0f9-1ea91ed8f601"),
Guid.Parse("d17951cb-fabb-4cfa-af15-83d2dc413a91"),
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

                    nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("b1b9cf0f-23a0-4c41-a60c-70c84113a2aa"),
Guid.Parse("bca3c09f-a0a8-4663-adc1-cbffc21b769b"),
Guid.Parse("777c3f8d-abd1-4143-a170-3380ab727351"),
Guid.Parse("68cd6a24-807a-477a-8bcd-bc108358ca5f"),
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
                Assert.That(nullable, Is.Null);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                var models = ((IGuidArrayuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models = ((IGuidArrayuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidArray1M.AssertModel(models[0],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidArray1M.AssertModel(models[0],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidArray1M.AssertModel(models[0],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 39, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 131, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 13, query1, 118, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 39, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 99, query1, 131, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[29], false);
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
                int resultIndex = 0;
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 111, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 117, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[29], false);
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
                int resultIndex = 0;
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 69, query1, 78, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 117, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidArray1M.AssertModel(models[0],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidArray1M.AssertModel(models[0],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 29, 78))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduuidArray1M.AssertModel(models[0],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
GuiduuidArray1M.AssertModel(models[0],_testData[3], false);GuiduuidArray1M.AssertModel(models[1],_testData[4], false);GuiduuidArray1M.AssertModel(models[2],_testData[5], false);GuiduuidArray1M.AssertModel(models[3],_testData[6], false);GuiduuidArray1M.AssertModel(models[4],_testData[7], false);GuiduuidArray1M.AssertModel(models[5],_testData[8], false);GuiduuidArray1M.AssertModel(models[6],_testData[9], false);GuiduuidArray1M.AssertModel(models[7],_testData[10], false);GuiduuidArray1M.AssertModel(models[8],_testData[11], false);GuiduuidArray1M.AssertModel(models[9],_testData[12], false);GuiduuidArray1M.AssertModel(models[10],_testData[13], false);GuiduuidArray1M.AssertModel(models[11],_testData[14], false);GuiduuidArray1M.AssertModel(models[12],_testData[15], false);GuiduuidArray1M.AssertModel(models[13],_testData[16], false);GuiduuidArray1M.AssertModel(models[14],_testData[17], false);GuiduuidArray1M.AssertModel(models[15],_testData[18], false);GuiduuidArray1M.AssertModel(models[16],_testData[19], false);GuiduuidArray1M.AssertModel(models[17],_testData[20], false);GuiduuidArray1M.AssertModel(models[18],_testData[21], false);GuiduuidArray1M.AssertModel(models[19],_testData[22], false);GuiduuidArray1M.AssertModel(models[20],_testData[23], false);GuiduuidArray1M.AssertModel(models[21],_testData[24], false);GuiduuidArray1M.AssertModel(models[22],_testData[25], false);GuiduuidArray1M.AssertModel(models[23],_testData[26], false);GuiduuidArray1M.AssertModel(models[24],_testData[27], false);GuiduuidArray1M.AssertModel(models[25],_testData[28], false);GuiduuidArray1M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 111);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
GuiduuidArray1M.AssertModel(models[0],_testData[23], false);GuiduuidArray1M.AssertModel(models[1],_testData[24], false);GuiduuidArray1M.AssertModel(models[2],_testData[25], false);GuiduuidArray1M.AssertModel(models[3],_testData[26], false);GuiduuidArray1M.AssertModel(models[4],_testData[27], false);GuiduuidArray1M.AssertModel(models[5],_testData[28], false);GuiduuidArray1M.AssertModel(models[6],_testData[29], false);
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




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
    internal partial interface IGuidListuuidArray
    {
    }
    
    internal partial class GuidListuuidArray : IGuidListuuidArray
    {


#region TestData

        private readonly GuiduuidArray2M[] _testData = new GuiduuidArray2M[]
        {
            new GuiduuidArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0b6559a5-44b4-4aa7-a153-4a4115738caa"),

Guid.Parse("b8c54511-5328-4d75-a0bc-d49397c1efc6"),

Guid.Parse("88192b01-6228-4f80-8a3b-17792a4fb2e3"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("13caf097-e996-446b-a1bb-cd357988c1d3"),

Guid.Parse("ee1053f4-4c8d-4d8b-a2f8-56e844496ce9"),

Guid.Parse("f483af49-53eb-49a2-a178-20fc5c9ed4a1"),

Guid.Parse("cf739ab3-5215-40ec-a865-f387686aad54"),

},
},
            new GuiduuidArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bb991dfa-e3c6-492a-8f7b-fbb442f54d4a"),

Guid.Parse("18d1fb52-fa37-45b9-a025-ce93fefc138e"),

Guid.Parse("d8b6ad7c-f1ae-40b4-a8c4-2a878dd69e89"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e9886d0d-392b-4a4d-a281-dd973851a371"),

Guid.Parse("b5fac0be-c3a4-4bdf-8018-503d0b40a068"),

Guid.Parse("1994566c-dc29-4059-b2e2-d7f40ede7a15"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0199948-5948-432b-935d-c309035161ec"),

Guid.Parse("f744997b-7521-4f4b-ac56-9498a0185de4"),

Guid.Parse("30da78c6-8e05-44c4-8f52-2b03b17ee18e"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a8799faf-5c32-463e-8913-b594ee4b2ca0"),

Guid.Parse("8345749c-d591-440a-93ea-a962fdbb1429"),

Guid.Parse("4aeaee5a-cf7e-4384-803a-0b2e478819db"),

Guid.Parse("cf81cef6-e983-426d-b9db-bd449742892f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a65220b8-fab4-4edf-bfaf-06bada9d43c6"),

Guid.Parse("c5c7f5e6-7b06-44a0-b57f-54d59857cb49"),

Guid.Parse("36b62d53-aaf5-41a9-9d86-d8dff02725ff"),

Guid.Parse("18f2ee9b-1634-46aa-ac29-dbdddc8c661a"),

},
},
            new GuiduuidArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cf33fc58-d3c5-4b64-9e00-8dd491604b97"),

Guid.Parse("fb035e26-63bb-44ec-aafa-af4d35bb005c"),

Guid.Parse("d192df05-8525-42f1-b336-4511b33de381"),

Guid.Parse("e2e4e437-b8dd-441b-8887-d9d184d66af0"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3c52e89c-9259-4b2b-b31d-cdeb22e7d285"),

Guid.Parse("51ec5584-d93b-49f5-b823-003944a8899f"),

Guid.Parse("eba3eb0c-9dbb-49df-aaa7-e75986882dc8"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b3208981-a071-42c6-aa3e-3a8ccb118b60"),

Guid.Parse("75b434ed-7bc7-43f6-93a1-827daab5addb"),

Guid.Parse("c827c4b2-7a8b-4891-9bd8-61cb3254b5bc"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("28730b32-9ef5-4c04-82ed-8fa753bbbbcd"),

Guid.Parse("b8b181ca-41c4-44ea-85fe-75f57831f95c"),

Guid.Parse("e18b45c7-fae3-4682-a3e2-55b03c88473a"),

Guid.Parse("1c2493fc-1683-49b8-97ca-7f08601c6efb"),

},
},
            new GuiduuidArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6a6a90ae-2bc1-49b6-8b3c-bec0f7aaeaae"),

Guid.Parse("4be2da1c-afb8-489c-9341-5d380801874f"),

Guid.Parse("2fc8bb69-d29f-4654-8544-8b87324db677"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dc692e17-8648-41d2-bf72-547f708966f7"),

Guid.Parse("b4fdeaa0-d8d6-47b2-8a42-6da1c97b323c"),

Guid.Parse("7d7c87f7-e210-4f9c-b378-ed912b0e1a4a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("41215ffb-557b-46fc-b8eb-e8843e0c9510"),

Guid.Parse("edcff35a-89df-4cff-85f2-b4aa2922a450"),

Guid.Parse("67e127ed-f9ea-4fc5-a5b7-c641c4548331"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("516386cd-cb76-4aa1-848e-03532ac755a0"),

Guid.Parse("793a7fba-0132-4727-a876-2babb54a32a9"),

Guid.Parse("47b0d8e0-d972-4f0f-a197-7938b507347e"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("752c4f10-013d-4663-8fea-b05ecce9823d"),

Guid.Parse("dbf36aa6-4bd0-4c20-8963-d1d5d9ae0188"),

Guid.Parse("06cd5d46-1ae9-4ca4-9b7f-bec788236d07"),

Guid.Parse("c3021b91-280c-4f02-a459-ffcd12191769"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e33a7e08-d484-4ad6-bfb1-3142395f32bf"),

Guid.Parse("ba515c3c-3b3b-487c-a3f7-58c3345e110d"),

Guid.Parse("93cc1fc8-4fd2-47ea-b179-5f4c0d36686c"),

Guid.Parse("644457fc-8c51-4647-9e66-6c2159820d53"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e519ac81-20c2-4135-ab13-41081aef072c"),

Guid.Parse("718cc363-a6ad-4f3d-8279-a31170e230a9"),

Guid.Parse("703eb36d-9cd7-4dad-86d4-1bafa17dec6c"),

Guid.Parse("6b5fbb86-f87f-4f0a-902e-2ae621704e0b"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("413ffe5c-dbd9-4d2d-a584-b5291f30c480"),

Guid.Parse("20d2621a-52f6-412e-b842-f275f487f545"),

Guid.Parse("ada83b9d-45d2-4325-b7f2-b5f98cebda4c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fe07b74c-427a-4b08-894e-d8acf3bf1893"),

Guid.Parse("f11db20a-b083-481b-93ab-ffbef5a1d26b"),

Guid.Parse("d7545f8f-865f-40ae-ab0e-0cf62d5e5816"),

},
},
            new GuiduuidArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e5beb259-0c0d-4441-84ec-698dd1d1bcd9"),

Guid.Parse("6a9019b9-4a43-4042-9fa1-a280d4a1c579"),

Guid.Parse("2e9c8abb-5b1d-4265-983c-dd4d77a85202"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3048a97-33ee-47ff-81c7-c140e115dc37"),

Guid.Parse("6e93010f-e287-4a0d-9a05-35035702a2a5"),

Guid.Parse("eb48151c-d447-49a4-bc8f-645128261c83"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5edc5111-d7f5-4b2c-8995-4a98fa137fe1"),

Guid.Parse("33919b26-7019-4a74-ae27-297d5610bb9e"),

Guid.Parse("2441ea69-4da6-4355-a45c-bebe305dba90"),

},
},
            new GuiduuidArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d3d6129e-f840-4c34-93d8-c9dbe18d5d1f"),

Guid.Parse("288e6fe6-af6f-4aab-9078-b671dead1d47"),

Guid.Parse("d1e0b1e6-e3db-40b7-9392-a2c70434ce37"),

Guid.Parse("3f1a6dea-fe74-4666-9068-6699da549419"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("85633cfc-19cb-4570-b4cf-894eb92c013a"),

Guid.Parse("4d521190-cbf7-4d4e-81f5-773bb24ae81a"),

Guid.Parse("6774a342-da00-44fa-8876-3c4b4ae9bcb0"),

},
},
            new GuiduuidArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f2030677-4781-486e-a2ca-1b205f2b491b"),

Guid.Parse("b20885c6-c93a-4469-b82c-022656048260"),

Guid.Parse("47ff320e-adaa-418c-8b21-a7d8e376590d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eb78d229-a77e-4e09-8b6a-e5e7d70ac15b"),

Guid.Parse("62f4900d-003b-49a1-bf84-73a684885df9"),

Guid.Parse("25984cca-54ef-4c80-b82c-eff4d1cca02c"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6a62adf8-d43c-4866-94ed-f2eedb9aff3d"),

Guid.Parse("4a30fe6b-cffa-4850-836b-7e1239f6185a"),

Guid.Parse("4bf625e1-60b9-41f0-847c-1dd64f0d142c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eef2c050-76a9-4467-8762-2cc04ff45a73"),

Guid.Parse("02283580-4bb1-47bd-91e2-5522bdb5254a"),

Guid.Parse("6d9086aa-ff09-4707-b711-a2a61e9ec045"),

},
},
            new GuiduuidArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("52f732bb-e600-4600-81e1-995dfe8a99b7"),

Guid.Parse("af710546-82e4-4a45-bd0b-1d0a06b9b89a"),

Guid.Parse("c9517e48-0fe8-4a0e-ba2f-76e28b4116de"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("745db87e-536e-4f32-a0b1-b0c83b150118"),

Guid.Parse("e0a66110-870c-4285-a99b-521ba9db7b17"),

Guid.Parse("c4809d91-438f-425e-9980-8e874b960042"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9df5d34b-6aae-4373-8b77-aa373cef07cb"),

Guid.Parse("5494f3bb-6309-4097-82fe-ede93222fe28"),

Guid.Parse("688d228b-ce12-420c-85f7-b7451217ad8d"),

Guid.Parse("0a922d9b-98db-4e23-a407-a48cb824d54e"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("31730460-800b-4b55-92b7-7ae638d06548"),

Guid.Parse("4408a7c2-6193-468e-ac26-6e8fd8f1abaa"),

Guid.Parse("06332972-3ef0-45ad-94e3-836c917387bb"),

Guid.Parse("d7ac4221-c910-43f3-8d58-e5efeb99e15d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("690271a5-68f3-48aa-8fd3-f186ac7d77f0"),

Guid.Parse("197894d0-1f88-478a-9fe8-e2696cf9144d"),

Guid.Parse("344844c2-69e4-48b1-9375-1e1e3056c96a"),

Guid.Parse("f7ae90e1-8fec-4a5e-8a2c-fdf3e5a92d00"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("21a990e9-34fe-42ff-97ff-639172844179"),

Guid.Parse("1e4bce23-faa9-43a6-96a2-11bfe38ea1cd"),

Guid.Parse("730194ea-4a3b-4981-80f0-52cae176993a"),

Guid.Parse("6c70aa65-b1bd-443c-bc23-7c9cd4e2a190"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0524e3e4-183f-4b36-ba0a-bd4f09aeb70e"),

Guid.Parse("79ed4dbd-5f5f-498d-898a-90cb19e0b67f"),

Guid.Parse("a9b023bb-7c90-45b1-9d02-d425456d2fba"),

},
},
            new GuiduuidArray2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3c159d64-6a45-4f23-bbe7-c7fc19d01a89"),

Guid.Parse("764f08c9-c04b-401a-8ce1-0a48d5dd6756"),

Guid.Parse("1d8c35f8-b071-42fb-9a18-7312c44a2a67"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fc497f0f-7310-4693-b420-8783b1d98051"),

Guid.Parse("8d40d7e5-2d67-4bc7-ad40-a9a7a005fdb1"),

Guid.Parse("223fa241-71f5-43a8-8722-8e0306a2cb37"),

},
},
            new GuiduuidArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6b040ba7-6746-4b1d-b048-5e0466c808f6"),

Guid.Parse("a1a462da-4f63-4571-975d-a0b03e4d5410"),

Guid.Parse("851349e7-388a-4c52-bd55-634eeacbf87f"),

Guid.Parse("c84d56b8-e1e2-4093-b377-3f64cd35600a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6ef3849e-5b8e-4ea4-87d1-7129b88a5523"),

Guid.Parse("2cb5643d-f101-4dc5-9c9c-5890d9fbb337"),

Guid.Parse("6dd769c9-8a09-4125-9503-31457728202f"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a24542f2-7248-45e3-9263-b8735929379b"),

Guid.Parse("565bd2ce-d500-4349-bb24-ce2e52ecee6b"),

Guid.Parse("4c75cf2c-4c7f-4050-b6b9-e8ddf6daed30"),

Guid.Parse("8bd9474a-f027-4e9c-a925-9493e7014b4d"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d0fd0cd1-37b0-4146-8208-b4397c598631"),

Guid.Parse("72d7ebc6-1524-413c-8ff7-e85e13c4f33b"),

Guid.Parse("e848c37a-84a9-45c1-acd2-d9afa7e689f0"),

Guid.Parse("12112cdd-7f4e-43aa-9613-fbe86094a12f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("142c93a5-8542-47bf-97e8-7006b38dced6"),

Guid.Parse("fe5e49ee-85a9-4e1e-82b3-f2fe34a3a13d"),

Guid.Parse("8b092613-e99e-41c9-8eef-171369ceda9e"),

Guid.Parse("de290afa-f287-4f15-83d6-72732d7679b8"),

},
},
            new GuiduuidArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1cb571f-552a-4cfb-a023-10601962041c"),

Guid.Parse("86d57712-5c34-4ba8-96ed-fb18acdb3961"),

Guid.Parse("cf58c6c8-efdb-4cad-b83d-42eb4d01190b"),

Guid.Parse("15b1d59e-7d30-4379-b825-a4c694004a87"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("66d870f7-138d-440f-9b68-949b5ff061cf"),

Guid.Parse("7eafc850-32f0-4213-ac4d-8aac42b43d5a"),

Guid.Parse("e603d03a-7f00-4200-a56c-75c8cd9e0a6f"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c51ee3ad-df0f-4955-939e-f48875625ea2"),

Guid.Parse("79c43c96-3e99-44d6-9bb1-1d9c4b8e1576"),

Guid.Parse("19bedf5e-dc27-4fe0-af4d-1d2701f99e08"),

},
},
            new GuiduuidArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4b6d002a-3f6b-479a-8b56-53fc68c9ba0c"),

Guid.Parse("df26c37f-3d5e-42e8-95ba-1f73af7a5957"),

Guid.Parse("6b87e4b2-eba9-4e44-a648-1e3c1dc79fc9"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("319034a8-0c81-43c5-b166-acbf31588380"),

Guid.Parse("17f4b6ca-f598-4f3e-8108-b8e70a76edbc"),

Guid.Parse("697597b1-3713-44a5-a923-03642211b753"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("61953640-e351-4d00-adcd-61264d78a63e"),

Guid.Parse("df70a56d-a56e-4f63-8e5f-3bd7e50c8cde"),

Guid.Parse("7de4b9a4-c38d-4855-ae75-3560af7d961d"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("db2ac933-f4d3-41b1-8dfe-dcc1ea4c93cb"),

Guid.Parse("c35fb7c2-bebc-4209-98ba-62952c913ddf"),

Guid.Parse("5b0edc31-e994-4110-8af5-42a377231eb0"),

Guid.Parse("6f7acdb0-7e15-4ffb-b430-d2b904acfe5a"),

},
},
            new GuiduuidArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ef99093a-b4d9-4eb4-aff2-f02a64f233b8"),

Guid.Parse("a77f7db5-afa9-4bf7-8cdc-410b0e152c38"),

Guid.Parse("f566f723-705a-413c-9122-4bb90d8a423c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d48dbccc-54db-46a4-ad02-4c7d9f85dbea"),

Guid.Parse("2422e858-b2b2-49ca-b562-9bf686435b28"),

Guid.Parse("fae686dd-d1ba-4cad-9fa5-ed66e63ada11"),

Guid.Parse("25908c36-fdbe-4c7f-832d-306486c33099"),

},
},
            new GuiduuidArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("49b0290e-0789-42d8-944b-5c516350942c"),

Guid.Parse("17f88b50-2db1-4a84-a047-96cc582d87b0"),

Guid.Parse("4321d923-8b75-4d8b-b642-069e13972477"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1d652619-ddd7-40b5-87a5-1fab3a8c19fc"),

Guid.Parse("c0c562e4-4c5b-41fa-9044-3374d253d487"),

Guid.Parse("d76c9640-a6d5-4aaf-b7e0-309efe782477"),

Guid.Parse("5827558d-ff32-408a-85ad-344cba0477da"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("800e1ba7-5a60-481c-82e8-64d31324d263"),

Guid.Parse("4dd9727a-96bb-474b-b5a7-b0127930ccfb"),

Guid.Parse("f82af573-e3d9-4625-8fac-75071f74bd54"),

Guid.Parse("a41a5b08-5bfa-4751-a155-4cc918a516a6"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a95c92b3-66fa-47ff-8760-fd7423d46f1f"),

Guid.Parse("a4d23825-c7c0-4a2d-95dd-14d06082edd2"),

Guid.Parse("a82ba3dd-2b68-4ec8-846d-86c15288be1a"),

},
},
            new GuiduuidArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ed1d448b-8a57-4acc-9acf-66211f1855c6"),

Guid.Parse("2565a78e-f53c-4919-a646-820bbc877f11"),

Guid.Parse("3a5b122d-2bbc-45a5-93f2-e5e28409c9c9"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("015095ff-79d0-46a9-b14d-45b946a43c6a"),

Guid.Parse("3cc3467d-35c0-465d-8509-5caa08865153"),

Guid.Parse("5f1bef3e-ca1a-42b5-b7dd-fd49c640c0e9"),

Guid.Parse("fb1092ff-267b-43bb-8bf7-20f6271f3c63"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94238068-b52f-4c86-8326-be70510a7b2a"),

Guid.Parse("76315355-b3ce-40b2-b65c-9609c5350b51"),

Guid.Parse("e2f48615-3bc6-4341-a76c-231ca82713ad"),

Guid.Parse("113c11c4-7aef-495c-9d15-ddf9150e25ad"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("509b0310-b4c3-483b-8636-605d0a76930e"),

Guid.Parse("b13d471f-82bc-49df-869f-7c1f88500d0f"),

Guid.Parse("3dd6d918-ba18-41c5-a595-7c8cf7aa62f6"),

Guid.Parse("137f243e-9267-4a8c-a116-b6d1ba86c737"),

},
},
            new GuiduuidArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5e646b0-539e-4e40-a238-85197ead1e52"),

Guid.Parse("4e89baa2-4793-46f8-9061-0a9014a61405"),

Guid.Parse("641f7b57-7b75-4119-9481-5955b3ccc75a"),

Guid.Parse("04dddc7d-1163-4a4a-b31b-66eaeba91b90"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("29310f26-6b4d-4ac3-98d4-899c614f718c"),

Guid.Parse("09b38102-f079-4708-a62b-31d71cd99fa7"),

Guid.Parse("4ce90828-e098-4cc1-8b3c-554cbbbf1724"),

Guid.Parse("1e58ab93-aa30-4768-a7bc-53ad9189ba90"),

},
},
            new GuiduuidArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b550573c-f06a-47b1-a9a2-22aa49625389"),

Guid.Parse("3c926f65-e762-4967-9181-8b6e88f77722"),

Guid.Parse("c96b9320-9aaa-4dbd-bbc9-a39c45812f93"),

Guid.Parse("2fba8a9f-0128-44c5-b76f-50b6c5ad0c3d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ffb2a277-3c6b-457a-8ae0-ce5b319109a4"),

Guid.Parse("5a06366b-1266-4dac-a9a7-28dccba497eb"),

Guid.Parse("5f1a686c-604f-4db5-b942-0592c5b81bcd"),

Guid.Parse("7b54c355-c028-4c92-867e-badd568c2777"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bd4bd7c3-c189-4d9f-8462-f0a9ad220004"),

Guid.Parse("82a1d1b8-8430-4752-a878-4ad04c191ae7"),

Guid.Parse("d2aef8f8-a9ea-485b-8faf-0569e30eada2"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1823831b-7281-4db7-bd74-dcaec8c9ca7e"),

Guid.Parse("f808a106-b525-401d-9c15-4c3850af78d2"),

Guid.Parse("79169981-cb06-4093-9fa9-0f34f34790c0"),

Guid.Parse("049fc40c-973b-4be7-8f2a-50ac6e00e8c9"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("54fa036a-b0db-4134-8740-fa6ddbeceb42"),

Guid.Parse("eceea7c0-6933-45b0-8610-59d908536cf1"),

Guid.Parse("01cbca4d-390d-4add-9c68-d9b3b12143c8"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("48a466d8-260b-409f-b1bd-05592cc8220a"),

Guid.Parse("6ce8f01b-b0b5-4e16-83da-61a24859683e"),

Guid.Parse("e418d63e-97b1-43c0-bef3-3a074ff9543d"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fa9e66c7-8e9b-468c-8c30-c0033c62531f"),

Guid.Parse("48198b84-5e2d-4d9e-bca8-32d96ccb0297"),

Guid.Parse("c6eb1d9d-7c3f-4493-8d7a-9c9fb6c01cc5"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a00ab317-a216-4ffd-8a09-8103e53e4d04"),

Guid.Parse("22f987df-c2de-4a97-8c1c-b1c8baac9fb5"),

Guid.Parse("9771e0ee-20c4-45d5-a311-5f8288774d9f"),

Guid.Parse("16cbb344-37b9-4e73-a5df-15e1cb02139e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c2e42bc1-4be2-45a2-9296-b615ea6ad8c9"),

Guid.Parse("db02b930-afbc-4fc0-b402-f95d8518ec5e"),

Guid.Parse("d8fd3b28-640f-49ae-870c-806f5cd8375a"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9e733ed8-903c-4b10-ab23-750fc338ca63"),

Guid.Parse("f4131636-0bc4-42ba-b6cf-91cfdfb663a1"),

Guid.Parse("207afb3b-85d2-4d36-b127-e9936f16904b"),

Guid.Parse("96d58624-78d3-4838-8088-864eb754ff22"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5b1f0037-4c39-4292-a150-419164f86a76"),

Guid.Parse("f9fab556-302a-4492-a694-5560f9fe3797"),

Guid.Parse("223b6852-073c-4378-b591-f9f80f7605db"),

},
},
            new GuiduuidArray2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a4b2c0ef-49b1-4b06-a01f-47a07781d197"),

Guid.Parse("d33a1e3c-10f7-429a-9a87-08700b2af8fb"),

Guid.Parse("8a9e42fb-acf8-4831-b635-2bad1fd45ae3"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7ee14dab-ca0e-4adf-9700-844a1b6ee8c8"),

Guid.Parse("4000828b-cf2f-487c-9262-289bb472244e"),

Guid.Parse("0834a4e2-3661-4dba-bac1-d4411e4ea6de"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a6a999dc-6913-4ab4-bc61-1ecbedec4d14"),

Guid.Parse("be8c92a6-1726-4bdc-a40f-157a6a28eb8b"),

Guid.Parse("383a1ce2-0584-4cbb-b0cd-771955cc317b"),

},
},
            new GuiduuidArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cbdcb1bb-92bf-4658-9952-02bdbcff1223"),

Guid.Parse("1000d99a-6d1c-466c-ae87-37cedffa37cb"),

Guid.Parse("f35e3b63-22a9-445f-b4d1-de879d709a88"),

Guid.Parse("81a5f588-ddb4-4810-8387-f355a54c5a2f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ecb6169e-e165-486e-8d14-26005cfb9aca"),

Guid.Parse("02bd7628-2dd6-41e3-a33e-5e2c724a3a50"),

Guid.Parse("58e51396-c1b2-4785-994a-1eb57fae9823"),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2mi(
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
INSERT INTO public.guiduuidarray2mi(
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
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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

                changedRows =  ((IGuidListuuidArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidListuuidArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidListuuidArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidListuuidArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidListuuidArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidListuuidArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
            asPartInterface: typeof(IGuidListuuidArray)), 
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
                methodParametrName: "guiduuidarray2mi_id", 
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
                changedRows =  ((IGuidListuuidArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidListuuidArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidListuuidArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidListuuidArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                methodParametrName: "guiduuidarray2mi_id", 
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
                List<GuiduuidArray2M> models = null;

                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray2M> models = null;

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidListuuidArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidListuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidListuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidListuuidArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidListuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 170;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await((IGuidListuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        GuiduuidArray2M.AssertModel(models[0],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidArray2M.AssertModel(models[0],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[34], false);
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
                var models = ((IGuidListuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidArray2M.AssertModel(models[0],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidArray2M.AssertModel(models[0],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M), typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                await((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 72, query1, 170, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 91, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray2M>();
                var models2 = new List<FlatGuiduuidArray2M>();
                ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 35, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var firstItems2 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 126, query1, 82, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 61, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[34], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 74, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 91, query1, 170, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[34], false);
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
FROM public.guiduuidarray2m m
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
FROM public.guiduuidarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems1 = new List<FlatGuiduuidArray2M>();
                var secondItems2 = new List<FlatGuiduuidArray2M>();
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 18, query1, 126, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await((IGuidListuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 132, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidArray2M.AssertModel(models[0],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        GuiduuidArray2M.AssertModel(models[0],_testData[1], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[2], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[3], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[4], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[5], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[28],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[29],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[30],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[31],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[32],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[33],_testData[34], false);
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
                var models = ((IGuidListuuidArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 20, 99))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidArray2M.AssertModel(models[0],_testData[3], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[4], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[5], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[28],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[29],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[30],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        GuiduuidArray2M.AssertModel(models[0],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                GuiduuidArray2M.AssertModel(models[0],_testData[6], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[7], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[8], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[14], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[15], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[16], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[17], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[18], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[19], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[20], false);
                GuiduuidArray2M.AssertModel(models[15],_testData[21], false);
                GuiduuidArray2M.AssertModel(models[16],_testData[22], false);
                GuiduuidArray2M.AssertModel(models[17],_testData[23], false);
                GuiduuidArray2M.AssertModel(models[18],_testData[24], false);
                GuiduuidArray2M.AssertModel(models[19],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[20],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[21],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[22],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[23],_testData[29], false);
                GuiduuidArray2M.AssertModel(models[24],_testData[30], false);
                GuiduuidArray2M.AssertModel(models[25],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[26],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[27],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                GuiduuidArray2M.AssertModel(models[0],_testData[14], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[15], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[16], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[17], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[18], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[19], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[20], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[21], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[22], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[23], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[24], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[15],_testData[29], false);
                GuiduuidArray2M.AssertModel(models[16],_testData[30], false);
                GuiduuidArray2M.AssertModel(models[17],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[18],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[19],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[20],_testData[34], false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidArray2MIWA),
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
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidArray2MI),
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
            asPartInterface: typeof(IGuidListuuidArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidListuuidArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidArray2M),
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
            asPartInterface: typeof(IGuidListuuidArray))]
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
FROM public.binary_guiduuidarray2m m
LEFT JOIN public.binary_guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidListuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidListuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models =  ((IGuidListuuidArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA), typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                await ((IGuidListuuidArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                ((IGuidListuuidArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA), typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                await ((IGuidListuuidArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                ((IGuidListuuidArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models = await ((IGuidListuuidArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidarray2mi
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
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI), typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models1 = new List<GuiduuidArray2MI>();
                var models2 = new List<GuiduuidArray2MI>();
                await ((IGuidListuuidArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MI>();
                var models2 = new List<GuiduuidArray2MI>();
                ((IGuidListuuidArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)),
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
                var models = await ((IGuidListuuidArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA), typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                await ((IGuidListuuidArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray2MIWA>();
                var models2 = new List<GuiduuidArray2MIWA>();
                ((IGuidListuuidArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
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
                var models = await ((IGuidListuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


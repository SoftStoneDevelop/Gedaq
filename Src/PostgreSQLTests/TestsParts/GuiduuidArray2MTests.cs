

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("178aec42-9df9-40f0-9243-5a7a9ef7f527"),

Guid.Parse("716c2fcf-c1c9-4fa2-b7ad-8b3b1904f94f"),

Guid.Parse("273f1609-9329-45b6-9436-eea9c10862f9"),

Guid.Parse("d213b3ae-f33a-42e1-8304-e0352b691bb3"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c2e9654b-e1f0-47f8-a430-b8011fb86946"),

Guid.Parse("51c05b66-453a-4f62-a6cc-dd987a97ea0b"),

Guid.Parse("0358ea67-f2c1-4e5d-8fe9-794d128dd87d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("408f6f47-566f-404d-a6fc-888a1357c1db"),

Guid.Parse("d6934c50-14bc-4737-9501-3090414d3d16"),

Guid.Parse("479c8d6d-1061-43b5-9cb6-a99dcce09a03"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cceebd23-bebc-4e89-8301-5884372901bd"),

Guid.Parse("d68fc1ac-d2f7-45d4-aabe-38857d5dcda9"),

Guid.Parse("a98a7a26-00cf-4b61-84a1-95ed72e26091"),

Guid.Parse("957a4d75-26c2-496e-a3ac-248c2e8a5cc4"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("82d8e618-c43f-4345-b321-c1869f7f794c"),

Guid.Parse("49621049-b0d5-470f-9813-7e62344c5f82"),

Guid.Parse("315a611d-6e9a-4f3f-9bb1-8a7a0cc501c7"),

Guid.Parse("1c7994eb-fb8c-4523-ab52-5edf3e83961c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2943133-08fb-4739-9d14-dad6f301dfe7"),

Guid.Parse("c58b0fae-1dbc-4d12-8b8b-25dc2a595d73"),

Guid.Parse("d5ea9c05-2e1b-4b7e-9a26-0845c3cc722d"),

},
},
            new GuiduuidArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("de0237eb-fdb9-4dea-af0e-8ddf05ab6fba"),

Guid.Parse("028ce5d1-acb3-4bb4-8db7-2ba9d5c7b2af"),

Guid.Parse("e78758b9-5c52-4200-851e-b552a95733c4"),

Guid.Parse("a2d8a287-74c8-43a8-8394-27ce8f4ee859"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("65f414af-174a-44cb-a5ed-633a43a246cb"),

Guid.Parse("f244f12e-ef80-41e2-b56c-fccfebfd3ce0"),

Guid.Parse("ff4d8db1-651c-4ae8-a4b3-78b3b7bf21e6"),

Guid.Parse("3192fa4c-9f57-47fc-86d6-793f768b2593"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("356797f8-cb8c-4312-9724-5877607e5cb3"),

Guid.Parse("1e3f20d7-9eca-4a0a-8de2-20824cbdff32"),

Guid.Parse("49ac8859-f42e-47f0-9b11-a0051c430af9"),

Guid.Parse("654c1147-e299-4c59-805a-d123d29c5593"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fcaa5a2d-d6b0-4c13-8e02-191708ed0213"),

Guid.Parse("c41e7469-6fdb-4a3d-b686-8da6ac6cf3eb"),

Guid.Parse("5bf78631-05d0-407b-b617-eab5a9008c7e"),

Guid.Parse("b3efc9d4-2fb8-40a7-95eb-881f869ad211"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("94fe99e9-ad22-4b15-a785-4115dcc08b5a"),

Guid.Parse("e52a8983-c674-4b2c-bfe9-e9fac6083ff3"),

Guid.Parse("da50e5c6-f987-4a0b-b1ef-48e391732515"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("32050bf7-574a-4228-80fd-03c11c6fddb5"),

Guid.Parse("7598cc81-0b22-465f-9dbd-caf6d7c8f9fd"),

Guid.Parse("26c2dd26-efb4-4281-a2b6-618e5cdf639d"),

Guid.Parse("a9acc34d-db05-4ea7-acd3-26ab29167cfc"),

},
},
            new GuiduuidArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bbbe877a-2113-4f64-9af8-4596565d3e5b"),

Guid.Parse("60a79929-069e-438b-b728-e8c6fc40c33c"),

Guid.Parse("84d79e7d-8129-4bd1-865a-15748639b01d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1c11bfd2-a3b8-432a-bc25-3b6e1d5e2ca7"),

Guid.Parse("a99349ea-dbc8-4c3d-b662-adfe64208b96"),

Guid.Parse("e231af3d-e419-4cea-aecc-db46517fa412"),

Guid.Parse("0c130862-8707-4ff4-8e90-eb1a4f31c0f6"),

},
},
            new GuiduuidArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d6b6bd94-fa54-471f-8abe-4700a0e717bf"),

Guid.Parse("b955006a-5672-4a7f-8144-f3c0435062a6"),

Guid.Parse("6b97583a-3310-489d-b2fb-33814b7bb62a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8221e9ef-67a3-4ffd-82fa-8a396b486624"),

Guid.Parse("6050b115-3dad-4cfb-b2ee-cc6975a2213f"),

Guid.Parse("7247d712-8601-4e71-94f5-70db6befed26"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("69626532-7113-44a4-876c-c7d85c408c49"),

Guid.Parse("14326319-4acd-4e0b-ba23-465a24094c2c"),

Guid.Parse("9a167cc3-b354-47d4-86dd-24d2eee9224e"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a9556331-2c94-4635-b05d-1f7b62c0e52f"),

Guid.Parse("716af4e6-9c45-4d3a-ad6e-e2a55712af80"),

Guid.Parse("8103db70-743f-4bbe-b39f-4ac1c788d3c4"),

},
},
            new GuiduuidArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("03500d2f-3f4a-4cfd-863d-7a30a1610356"),

Guid.Parse("07cbab81-5f6a-458e-b3d1-266249fd9a59"),

Guid.Parse("4569d9dd-6b4c-436a-9235-a3133563c721"),

Guid.Parse("ecf3c244-a849-4544-ac3b-1e2735c9b000"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b48a6c75-39f1-4648-be65-09c68a1df688"),

Guid.Parse("69b5958c-d915-4005-a62f-907ffc75cc64"),

Guid.Parse("e7cc7f88-5075-4ed8-b4a4-f6d18ad1fc6c"),

Guid.Parse("f711c57c-bf52-4c96-beb9-b7d2f3918e6b"),

},
},
            new GuiduuidArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b9679736-070c-47da-afb5-b3ce9813b011"),

Guid.Parse("49c6f8fd-92d6-49f0-b909-3941eae7f538"),

Guid.Parse("04240f86-050e-4971-8389-966f3af17af1"),

Guid.Parse("99cfcb2c-e7e6-473f-bbf5-cd93e0526b51"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b2795e40-eca2-4686-a1c8-3ad9fcfa96aa"),

Guid.Parse("d11b09af-d5e6-4fdb-8275-7c07581cef96"),

Guid.Parse("42ac0980-5aa1-4db5-a306-36f79d85c3d4"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cc62246f-9ab9-47d7-ba6a-f9d082f4cb9f"),

Guid.Parse("cd630cb0-50d6-42ab-9c1c-77684cde5335"),

Guid.Parse("1086e454-2813-499c-a5cf-848c40ceb30e"),

Guid.Parse("870a7c09-3184-4319-9981-6120729c3ef3"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cb4b7368-32db-4df4-889d-d08f78597430"),

Guid.Parse("0b08f8f2-37f8-469f-89d8-1f6b21e4e81a"),

Guid.Parse("8363d5f1-3859-48ee-96cd-7973064dc582"),

},
},
            new GuiduuidArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("42692168-356c-469e-ac3a-c2ece4d9fc5d"),

Guid.Parse("b2b6485e-5c7b-48f1-862a-66547092b5c9"),

Guid.Parse("c91a4360-f046-4723-aca6-b1dd8518b7f4"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0955ea20-778a-432e-a2e9-817fa7748a38"),

Guid.Parse("9b2d4d8d-a11c-4fbc-947a-119e08252d16"),

Guid.Parse("240f8426-0b50-4ad1-bbfe-19500903222a"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("06576c3f-a7ae-42b7-b4d7-e5c6d96faac8"),

Guid.Parse("92ee5d29-4465-4ac5-a5d2-b92c613e5ac3"),

Guid.Parse("eab87a3d-28c8-4b46-9f50-8949ae6594bc"),

Guid.Parse("fd6eace0-12a5-49f2-89f1-d29b157066fc"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0abe60ab-5850-4be8-a27c-308c158bdc00"),

Guid.Parse("ec490960-f059-4859-85a4-205f2beaec8d"),

Guid.Parse("7357e2c0-8014-4383-a813-db284697ba48"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0598a9a5-6701-47b2-8854-9ed9a89bf588"),

Guid.Parse("576d693c-d19f-4edc-9377-5d9e3becd91b"),

Guid.Parse("8ad08c4c-bb4f-4e14-af8f-3d370a6b376f"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7aecda94-ba1a-47db-8351-b974c85dae1f"),

Guid.Parse("10aed4d0-70df-4bbe-b151-0da6022b80bc"),

Guid.Parse("0e08a975-1a4c-4846-b657-6707c1a6e162"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f7f3c33-3c1a-4129-9448-6221af125994"),

Guid.Parse("3de366fc-126a-4d87-8206-4ddafabd781e"),

Guid.Parse("36d22159-7c5e-4e54-9eda-d49bd7eb1e5d"),

Guid.Parse("250522ba-f366-43e7-bde4-3d3b4f52e620"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be649e34-1148-497e-8bb5-679b8543dd6a"),

Guid.Parse("85284367-77b3-4fd4-93a5-564fc8e4a5bb"),

Guid.Parse("6ff09ec9-4897-4667-aad9-ea16b038716e"),

},
},
            new GuiduuidArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ba69c6e6-607f-4c90-bfa8-36ad5f2dde59"),

Guid.Parse("247f7524-20fc-469b-9d34-ee33b8fa8f6f"),

Guid.Parse("2523a92f-182d-4a77-9cd1-664a4ebb790c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("93b67b3a-7800-48ef-82c2-19db0559cbec"),

Guid.Parse("96b22333-e355-4bb0-aef5-7840d36d5cb6"),

Guid.Parse("6e391feb-a82d-437f-85af-9ee9e7ab5117"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("02c5faa2-2f32-4577-a7ec-96cab73f15ad"),

Guid.Parse("0e8cf7fb-ca35-424e-870a-7438568f745c"),

Guid.Parse("9b04bf10-608e-4024-8e2f-9f7dff8b88b8"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("14c0c720-f6ba-40de-b747-c15d26f8bff6"),

Guid.Parse("6e930ed3-dc83-4d9e-aadd-1b2218cf2289"),

Guid.Parse("7e095557-cfc9-4211-aa92-605c00e7eca8"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9551130b-d6df-4aa6-b333-48cf9d2aa9db"),

Guid.Parse("8fb64c0b-d092-4cdd-a3cb-d27ba37988d1"),

Guid.Parse("d4b515c9-42dc-4c75-8f58-052d0bcf8022"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("59b01179-2bc0-4a36-8a2d-5ba5e8411fd0"),

Guid.Parse("fc42265b-5dfa-4b8c-b1ef-8eac0e461427"),

Guid.Parse("b6cc4c6d-1360-4473-af2e-1fe62cb71ce9"),

Guid.Parse("58c86d94-6905-488e-8d1a-d320b4eb03b3"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("71fb5a60-1472-427c-b807-bb21369285cb"),

Guid.Parse("3834c241-8b6f-4c49-b4e4-6dbd7098c617"),

Guid.Parse("6cb1fe22-b9c9-41c6-828b-c6cc626416ac"),

Guid.Parse("51ae8a6f-a9a1-40fc-9da1-ebf48f2b143c"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a002ab36-92d9-45bf-8b42-407983644da2"),

Guid.Parse("07fdedee-9ce9-4d34-b239-a89d2420b6e7"),

Guid.Parse("ca1a9b33-21bc-43eb-8a89-506c9c8e4795"),

},
},
            new GuiduuidArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("da2a2dbf-c977-43d0-8525-5117d0af9c44"),

Guid.Parse("cb95bb7f-272f-4384-97ec-2aa38e33e007"),

Guid.Parse("5798154a-8f46-4de3-a2b1-ea41064403cc"),

Guid.Parse("9742074f-2745-428f-8114-f0a53f68611b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("818cd669-fd75-459e-be97-23fdfeddb47c"),

Guid.Parse("b873feda-34fe-4ffb-a029-8b168c9efee9"),

Guid.Parse("d18ddf2a-d381-476a-9c3a-a8986557bfec"),

Guid.Parse("d2d4552d-5d8f-410d-a6b2-422d3e099f7d"),

},
},
            new GuiduuidArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0cf6a533-b024-405e-b930-030cd6420dcf"),

Guid.Parse("9dbf20b7-2b52-4eed-ba83-35f025650ae8"),

Guid.Parse("1565dd84-4c16-4e7f-a64e-94bef59b27c0"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4ce0cec8-01e5-416a-920a-2f4f1470b3bb"),

Guid.Parse("3be94687-0c20-4cfb-b823-96d0c921f325"),

Guid.Parse("ba2ec202-d297-4ce9-af86-9019f9067b47"),

Guid.Parse("caec53a3-86ea-4a84-84c1-25195c9a87c9"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eb3ed2d5-80f1-4792-9ab4-0391fdb71245"),

Guid.Parse("e77d1637-9da5-4507-bcc5-de8c91ccc21d"),

Guid.Parse("2dfef448-1e4a-454b-80a3-a9350bf3b471"),

},
},
            new GuiduuidArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b7fe0d98-9744-43d3-90f4-d9a58b536890"),

Guid.Parse("8b8bcc5e-47e1-45e2-9928-d73bbed5075b"),

Guid.Parse("c14dd385-8ffc-457b-ab45-f26446f55c96"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("65a5ef12-c49c-4f0f-8a43-d8777c05af17"),

Guid.Parse("eb632901-5386-4e87-8986-11f9b33932ac"),

Guid.Parse("aefb25c1-f318-42b3-a6b2-17f73df89c02"),

},
},
            new GuiduuidArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("070f1b5e-c275-4f1c-b70c-8e8bbf41b479"),

Guid.Parse("cdb34db7-2fa4-4db5-8815-7d226f5aeb98"),

Guid.Parse("df1b48c6-63be-4138-b025-1799617149a9"),

Guid.Parse("be708c4f-e838-4628-9f64-b1f2c9a5523d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a32275dd-2fcb-4895-b95e-cb6f5c1dd540"),

Guid.Parse("5b788319-a0a5-4ef1-b2f8-9c5bbc3b77d9"),

Guid.Parse("fb5459bb-d03a-4fbf-b1b7-e45fc6ffa34e"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("899c0402-7887-4894-a148-5403d4c82dbf"),

Guid.Parse("44f0cacc-0d1c-4591-9ec6-08bd79ac6d42"),

Guid.Parse("23896149-8a7e-4ddf-9ac5-f7b5ef8cf079"),

Guid.Parse("b25bf846-5508-43b2-a6c0-6cdad4d6c620"),

},
},
            new GuiduuidArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2c088041-f014-4c16-8e3a-c9a43bf37db7"),

Guid.Parse("88ad4402-d28e-4dfd-aa0f-348d8f0d0356"),

Guid.Parse("3e1ea222-9210-45e7-9b4a-06e59485e367"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9fa441cb-ba4b-4d16-b3e4-7eb486eea89f"),

Guid.Parse("a73851a5-c02c-4fd3-b746-9dbb185a42e9"),

Guid.Parse("667c4063-a8ec-4900-bb68-d2cca47eb088"),

Guid.Parse("96dec527-48a9-4e61-bd83-b6d6721b296f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9ca2be17-94c8-492e-bab6-d933fed26878"),

Guid.Parse("d8dfcecf-f9d3-4ae0-8536-ddec109f2db5"),

Guid.Parse("de565fc2-cc97-48d6-a723-66bd0667f7cd"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f07bc9aa-da56-447f-874d-38317b42644c"),

Guid.Parse("a260f4fc-48eb-4df3-bb2a-18394eb8a424"),

Guid.Parse("fb5af32a-dae9-492b-a448-d2b500d414c6"),

Guid.Parse("4f8bde79-f8bf-454e-ad8a-04f75f3b012a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f393f702-a751-459a-9d10-77346f31b199"),

Guid.Parse("e0ecb741-4dd0-4f2b-9036-b0e6bc7e49cd"),

Guid.Parse("1515d758-1a2b-488b-a25a-ceec55fc118d"),

Guid.Parse("01b9c0b9-236f-4b48-b6e9-f32fa5bad980"),

},
},
            new GuiduuidArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fa8e6aae-edbf-4044-b49f-72c7bcb4850a"),

Guid.Parse("defdf93d-8406-4714-8b82-d963994e78e2"),

Guid.Parse("5e41fb95-0779-48d0-89e2-0ae4ab9e852a"),

Guid.Parse("51a5babb-d8b2-4809-8657-a68cee8273ed"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("da7f26d0-f7bd-436a-bf42-fbca66c8826a"),

Guid.Parse("90ea449a-fce7-40cc-81ac-208b452518e1"),

Guid.Parse("f06ceab9-0774-4622-8bb2-f5086f71c583"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4f570869-edc1-40ae-9f50-86fe3640b072"),

Guid.Parse("82ec6162-af80-4912-9163-50d6e9fdf4f0"),

Guid.Parse("53d80bcc-25e9-493e-bb9f-227269f43717"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2f835a92-3b58-4903-a583-03b7b24f5aad"),

Guid.Parse("a4cd93aa-9dc5-4bb2-a18e-fc8466a3703e"),

Guid.Parse("590d7769-9469-4c2e-925c-960a6599ce21"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("efb8f3d1-02db-4f3a-a165-2e2082dffaed"),

Guid.Parse("c7cb6b8e-56d4-4cae-8f2f-72d73277b6a5"),

Guid.Parse("5f06f63a-67ba-4a17-ab5e-d384f3acec82"),

Guid.Parse("ccf598e5-114c-4dd6-a95e-a6ffb81f5a61"),

},
},
            new GuiduuidArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("67f591ee-2145-4d12-8c93-4ccd1ee48c8e"),

Guid.Parse("0df5a26f-f436-4f89-865d-1d0e54d24864"),

Guid.Parse("8ce13bf7-576b-44e7-b06c-f67b59afb38b"),

Guid.Parse("bfe34b90-1f02-41a8-99f2-a65f39b31fe8"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("846324d6-0895-491b-a789-dc266fe8d00b"),

Guid.Parse("5782661f-d1a5-462d-b6e2-e4d0bef7ce09"),

Guid.Parse("0b05abef-4c53-4303-8a3a-3434c5e6d4dd"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0f11bfc1-bfea-4191-93aa-9eb5ea21961e"),

Guid.Parse("0f82d68f-4e1c-43c1-b522-1d6135cc33b8"),

Guid.Parse("1ba51061-1a6e-406c-af82-9ae8675594ce"),

Guid.Parse("c60835ad-036b-4f20-a3c4-17f94bcda55a"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f6f3ea19-fcd9-447f-b87c-38e98e1eee2a"),

Guid.Parse("29b085a4-57b6-458f-9ca6-11ee09f7f0a7"),

Guid.Parse("428f36b1-8a40-4f56-a300-46cbab5c192f"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cc9a3dec-15f1-4956-8576-e2ce1729b6e0"),

Guid.Parse("01de8062-ebbe-4d9e-a3c9-84eef5d383f4"),

Guid.Parse("35c30f50-4e97-4428-931a-a6aa9cf87769"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("02789482-e7dd-48bb-a4c6-e73dcdb2a0b4"),

Guid.Parse("c2920a20-97bc-41c0-a6b1-1d8323674c22"),

Guid.Parse("fdd09581-ea7d-4891-a874-045e99679393"),

Guid.Parse("c74afcbe-b07d-4fea-b345-4e5c1794e51e"),

},
    NullableValue = null,
},
    NullableValue = null,
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[30], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[30], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 4;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidArray2M.AssertModel(models[0],_testData[2], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[3], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[4], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[5], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        GuiduuidArray2M.AssertModel(models[0],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 136, query1, 136, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[30], false);
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 90, query1, 127, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 109, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[30], false);
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 135, query1, 115, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 32, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[29], false);
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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 32, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 32, query1, 90, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[29], false);
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 11, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[30], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 81, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidArray2M.AssertModel(models[0],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 99, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 109);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
GuiduuidArray2M.AssertModel(models[0],_testData[20], false);GuiduuidArray2M.AssertModel(models[1],_testData[21], false);GuiduuidArray2M.AssertModel(models[2],_testData[22], false);GuiduuidArray2M.AssertModel(models[3],_testData[23], false);GuiduuidArray2M.AssertModel(models[4],_testData[24], false);GuiduuidArray2M.AssertModel(models[5],_testData[25], false);GuiduuidArray2M.AssertModel(models[6],_testData[26], false);GuiduuidArray2M.AssertModel(models[7],_testData[27], false);GuiduuidArray2M.AssertModel(models[8],_testData[28], false);GuiduuidArray2M.AssertModel(models[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 53);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
GuiduuidArray2M.AssertModel(models[0],_testData[11], false);GuiduuidArray2M.AssertModel(models[1],_testData[12], false);GuiduuidArray2M.AssertModel(models[2],_testData[13], false);GuiduuidArray2M.AssertModel(models[3],_testData[14], false);GuiduuidArray2M.AssertModel(models[4],_testData[15], false);GuiduuidArray2M.AssertModel(models[5],_testData[16], false);GuiduuidArray2M.AssertModel(models[6],_testData[17], false);GuiduuidArray2M.AssertModel(models[7],_testData[18], false);GuiduuidArray2M.AssertModel(models[8],_testData[19], false);GuiduuidArray2M.AssertModel(models[9],_testData[20], false);GuiduuidArray2M.AssertModel(models[10],_testData[21], false);GuiduuidArray2M.AssertModel(models[11],_testData[22], false);GuiduuidArray2M.AssertModel(models[12],_testData[23], false);GuiduuidArray2M.AssertModel(models[13],_testData[24], false);GuiduuidArray2M.AssertModel(models[14],_testData[25], false);GuiduuidArray2M.AssertModel(models[15],_testData[26], false);GuiduuidArray2M.AssertModel(models[16],_testData[27], false);GuiduuidArray2M.AssertModel(models[17],_testData[28], false);GuiduuidArray2M.AssertModel(models[18],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((IGuidListuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
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
                await ((IGuidListuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((IGuidListuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(GuiduuidArray2M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<GuiduuidArray2M>(15);

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
                ((IGuidListuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                GuiduuidArray2M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((IGuidListuuidArray)this).ImportModelAsync(connection, importCollection);
                models = await ((IGuidListuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                GuiduuidArray2M.AssertModel(models[0],_testData[0], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[1], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[2], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[3], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[4], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[5], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[6], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[7], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[8], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[14], false);
                GuiduuidArray2M.AssertModel(models[15],_testData[15], false);
                GuiduuidArray2M.AssertModel(models[16],_testData[16], false);
                GuiduuidArray2M.AssertModel(models[17],_testData[17], false);
                GuiduuidArray2M.AssertModel(models[18],_testData[18], false);
                GuiduuidArray2M.AssertModel(models[19],_testData[19], false);
                GuiduuidArray2M.AssertModel(models[20],_testData[20], false);
                GuiduuidArray2M.AssertModel(models[21],_testData[21], false);
                GuiduuidArray2M.AssertModel(models[22],_testData[22], false);
                GuiduuidArray2M.AssertModel(models[23],_testData[23], false);
                GuiduuidArray2M.AssertModel(models[24],_testData[24], false);
                GuiduuidArray2M.AssertModel(models[25],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[26],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[27],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[28],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidListuuidArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}




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
    Id = 1,
    Value = 
new System.Guid[,] { {
Guid.Parse("e31865bc-3eb3-4b84-bc42-190c1a5954f5"),
Guid.Parse("7e754779-75b4-44f1-884e-6d5e63b3a5eb"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Guid[,] { {
Guid.Parse("8e39b7a2-0fd5-4ac6-bce4-ffd06d9b5a5e"),
Guid.Parse("cec5e32c-9123-43f0-a550-46f4c1a8ba5f"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("da1ee266-5185-4e43-a121-4469426df06f"),
Guid.Parse("0f304420-9f45-4724-a8e0-836289ff2aa9"), } },
},
            new GuidMArrayD2E1M
{
    Id = 2,
    Value = 
new System.Guid[,] { {
Guid.Parse("c3ec931c-6362-4a93-bb7c-43931d3fe75c"),
Guid.Parse("9c45f04a-a376-47f0-8175-74e9c5b71c9a"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Guid[,] { {
Guid.Parse("f19efdfe-f8c9-41cd-91fc-5dd1c5ca714a"),
Guid.Parse("9353c740-06c5-42b3-8797-9044dc61b372"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("1677323f-3a5a-4c59-8588-fdbb706e98f3"),
Guid.Parse("d835b13c-cd47-4cbe-ad73-1bbcb61f231b"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("bc07bd91-e139-4640-8183-2f5660b9a5aa"),
Guid.Parse("e68c1425-32a6-42d5-b187-255677fdbac6"), } },
},
            new GuidMArrayD2E1M
{
    Id = 6,
    Value = 
new System.Guid[,] { {
Guid.Parse("37e4756b-e486-4f61-a2ae-ebc7474ef448"),
Guid.Parse("944f3e94-4bed-48b4-a2ff-c3a5a9da87c8"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Guid[,] { {
Guid.Parse("ca3ff895-e2d4-40fe-a951-0ee533f4d3cd"),
Guid.Parse("acd5d37b-d28e-41d1-9ef4-4c0e5966505b"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("95233a42-26d2-4e63-8778-5adeb3c33af1"),
Guid.Parse("9e44981f-1631-4d16-86a1-a9cd7dcd9dff"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("a96b2efd-460c-404c-9845-357e1c33e8da"),
Guid.Parse("57d49984-9227-49a2-807d-765240b5d8ca"), } },
},
            new GuidMArrayD2E1M
{
    Id = 10,
    Value = 
new System.Guid[,] { {
Guid.Parse("0192da8f-1ed5-4e6a-9b45-fce62817f9a3"),
Guid.Parse("35d364b3-3eb0-4774-a2c9-f4a1ed50004a"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Guid[,] { {
Guid.Parse("d74a0eda-f800-42bd-9fd9-eb9d7d62b18e"),
Guid.Parse("11739e91-8528-45df-9938-fc179da41a10"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("dfaed433-4189-4d74-a659-753c79fd372b"),
Guid.Parse("2b2076ce-d724-412a-8343-b5cc93808b95"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("b14b60b3-589a-4d19-ac82-af5787d79532"),
Guid.Parse("b6a8bf69-5680-4b92-b575-120d766d3478"), } },
},
            new GuidMArrayD2E1M
{
    Id = 17,
    Value = 
new System.Guid[,] { {
Guid.Parse("9e8da69e-54ac-4953-89af-a5492db2fb66"),
Guid.Parse("c224a406-ba3f-4f65-a1f4-86b59e3f5cdc"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 26,
    Value = 
new System.Guid[,] { {
Guid.Parse("1e0b097e-a51a-4108-8918-3dd9dd1ba7e4"),
Guid.Parse("f2a3cd3b-a366-4956-82fb-577a496655ed"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("566054aa-7dd2-4924-b432-2ac29691a4fc"),
Guid.Parse("9b3c28bc-d5e9-4390-8fd3-52759f4480e4"), } },
},
            new GuidMArrayD2E1M
{
    Id = 18,
    Value = 
new System.Guid[,] { {
Guid.Parse("8f75b134-6fd0-4649-8bc6-b47fa786f8a4"),
Guid.Parse("73343b08-b396-4912-8961-d44dd377bae6"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 33,
    Value = 
new System.Guid[,] { {
Guid.Parse("69d3d78e-0c5d-479f-97b8-cd6d6a4e0d45"),
Guid.Parse("a4f1a3e4-088c-414c-911c-7acf191e8c64"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("a0bdc75f-1340-4c77-9dbc-5b6ccef87edd"),
Guid.Parse("9755b164-5d36-4687-acf6-90a1c93cc3b8"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("e83a77c2-d19e-453b-bad7-b45a58981f69"),
Guid.Parse("11b5fa47-3184-4638-9a18-4b68dac92776"), } },
},
            new GuidMArrayD2E1M
{
    Id = 24,
    Value = 
new System.Guid[,] { {
Guid.Parse("823d3aa1-fb37-447b-ac7a-13391ae098ef"),
Guid.Parse("ace9d5ec-649e-4162-952d-b2fdeb480751"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Guid[,] { {
Guid.Parse("baf99895-033d-4f6c-bd29-b1b284de08ff"),
Guid.Parse("c33e5d73-49ae-4939-b89e-b9d0058e93d5"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("0a727dc3-a847-4665-8b29-fcd048bad2c3"),
Guid.Parse("c5026a58-4c14-4887-b51d-b1cae8192ba9"), } },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 30,
    Value = 
new System.Guid[,] { {
Guid.Parse("53e5a19e-d0f6-49af-857f-c06809e3e4cb"),
Guid.Parse("ff19b4e4-8d36-41af-8c2b-a58b95dee31c"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 36,
    Value = 
new System.Guid[,] { {
Guid.Parse("e61b6513-a925-43b1-afb0-7ffca00d0bc1"),
Guid.Parse("24bbe782-44cf-4ed3-b4cf-f22e78f69545"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("b64c6c3e-e138-4ed2-b4e9-8ec15ef98eb7"),
Guid.Parse("23d9b919-f09b-446a-ab32-1f1221edf896"), } },
},
            new GuidMArrayD2E1M
{
    Id = 32,
    Value = 
new System.Guid[,] { {
Guid.Parse("9c08f16e-566e-4603-aa88-89ed3ea31985"),
Guid.Parse("fe55d0ea-e066-4c6b-bdc8-9ad3f44d407f"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 44,
    Value = 
new System.Guid[,] { {
Guid.Parse("a755ba99-8a91-41bc-9447-dd5f1b075336"),
Guid.Parse("de5afb87-fedd-4bcd-a671-777b04c98bbd"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("9541ec62-6fcc-4f93-86cb-909a0e13d5ae"),
Guid.Parse("40288526-a4db-4345-9a87-f3f4b8daa124"), } },
},
            new GuidMArrayD2E1M
{
    Id = 40,
    Value = 
new System.Guid[,] { {
Guid.Parse("ce27a28c-8c6c-49f2-bbe6-cdde98c66546"),
Guid.Parse("437931d8-74ab-4070-900a-70a2d8613c1a"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Guid[,] { {
Guid.Parse("a3a323cb-8a63-4206-ac40-f2f1ba496da2"),
Guid.Parse("c770c242-6dd7-4c07-960b-91152f95f4ff"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("1222ec7f-5164-4119-9eb6-f44997e3f210"),
Guid.Parse("7449d10d-532a-4cc3-872a-b4da22aae89e"), } },
},
            new GuidMArrayD2E1M
{
    Id = 45,
    Value = 
new System.Guid[,] { {
Guid.Parse("5a21fd9d-daf3-4f9f-977e-b1a68dbb6ed2"),
Guid.Parse("f6596c8b-3a54-4c43-bc02-b70bcd2257f5"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 51,
    Value = 
new System.Guid[,] { {
Guid.Parse("d4fe093f-3f64-48a8-8f0f-3925b4eded84"),
Guid.Parse("962dc5b5-5fb4-49b2-bd0b-b9da2b556567"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("c1561734-14f1-4ef1-a8e5-21ab6112e8d4"),
Guid.Parse("32407328-96eb-4901-93a2-c1995216ef97"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("af2e6e68-0dc1-4dd7-836e-ba910de2311e"),
Guid.Parse("f55b22b2-9639-4796-808e-065b34c8861d"), } },
},
            new GuidMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Guid[,] { {
Guid.Parse("10afde97-92ba-415c-80ae-56a7308ca51a"),
Guid.Parse("6cb8ad20-6fb6-4aa0-ac51-3ce509e017b2"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 58,
    Value = 
new System.Guid[,] { {
Guid.Parse("a6c1888e-eda3-4d72-abea-aa921a43b8df"),
Guid.Parse("9eb71375-1422-40f4-b0d4-f27558a3e165"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Guid[,] { {
Guid.Parse("2ceb8f78-5b03-459e-b84a-1a895c7f00be"),
Guid.Parse("30504bb2-9878-4641-95b8-7e3b7b2352d0"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 66,
    Value = 
new System.Guid[,] { {
Guid.Parse("9dd352c0-218f-4b6d-b3d9-a653038934d2"),
Guid.Parse("742b2a28-1b44-4971-b4d8-5319e75cffd8"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("5089d9af-69e2-4fda-823d-650ed64169fb"),
Guid.Parse("c090039b-4816-424c-97a8-c26a11552794"), } },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Guid[,] { {
Guid.Parse("c5ca02c6-a36b-4ae7-b81d-8b5a23af9dcd"),
Guid.Parse("29298af9-fd98-4b1a-a48c-69214e15c645"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Guid[,] { {
Guid.Parse("a312d66a-4e9e-49a4-bbfc-fb7f7533a420"),
Guid.Parse("4ce81696-78b3-4186-8ebd-da1064e91eb9"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Guid[,] { {
Guid.Parse("db3ac9da-6ece-458a-a658-8b38a72d1de4"),
Guid.Parse("5b2fc15e-d69e-49a5-9180-395c179d3211"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 68,
    Value = 
new System.Guid[,] { {
Guid.Parse("ee968218-ec54-4ed8-876b-e352b5354811"),
Guid.Parse("7210019a-4ebf-4071-b2c5-9e6444b16ff5"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Guid[,] { {
Guid.Parse("203fe019-c639-4e59-87f4-43d6717d93df"),
Guid.Parse("9c2887a7-2a4f-4225-b0f0-5b1da0c9af34"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 74,
    Value = 
new System.Guid[,] { {
Guid.Parse("3f7fdf00-ec2c-4339-91f2-ca121dc1bd9d"),
Guid.Parse("1fa48298-8a26-4926-bf10-688fa81d2001"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("33507bb2-a2ba-4c3d-b1cc-e60fb9d9dc2b"),
Guid.Parse("bea1dadd-2711-4e48-832a-fcf0b73371ba"), } },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 68,
    Value = 
new System.Guid[,] { {
Guid.Parse("61a7a233-72c1-4103-a0dd-a61d86860335"),
Guid.Parse("a3a0d146-34b5-4cfd-86a0-723a3433ce8f"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Guid[,] { {
Guid.Parse("6a89ce86-403c-4a25-ba57-95a531c7ac33"),
Guid.Parse("86fe3045-f5d2-4ed1-b7eb-ddaae947955a"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("e9e74718-01d0-4c47-9e06-059d750b56b9"),
Guid.Parse("2d7b1b6a-ee5b-4fbc-9fac-8060ee23aa5e"), } },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 69,
    Value = 
new System.Guid[,] { {
Guid.Parse("eb4191a2-949f-4755-bd21-46c3b47b6a7e"),
Guid.Parse("386638cf-683d-47bb-aaf1-c1e35264a490"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Guid[,] { {
Guid.Parse("03d20399-d60c-4d2c-972f-3062ee9c3182"),
Guid.Parse("36135907-240e-497b-8753-16e702e9e5fd"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("388e19cc-092c-4f66-9771-2b8206d89d28"),
Guid.Parse("e3efb780-b5ad-4c3a-a8b6-a360fb62b989"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("5f05fe0e-8d86-427f-a815-d744c0e72558"),
Guid.Parse("6f7f03b8-f6b1-4e72-9699-93f3374b3dcb"), } },
},
            new GuidMArrayD2E1M
{
    Id = 70,
    Value = 
new System.Guid[,] { {
Guid.Parse("9ea48502-7c0e-4d5d-bcd5-197d93933a32"),
Guid.Parse("9466bc5e-68d0-4e3b-8ac5-16b4d3bb8015"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Guid[,] { {
Guid.Parse("0edb2c86-6532-4335-bedc-78aea4fd8067"),
Guid.Parse("c6c343a6-5c12-44ad-8000-0dc7e1f86665"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("08008678-5218-44b3-ac8f-a267ab5e06d2"),
Guid.Parse("98d10226-dfb4-4e69-8733-a469354f46ee"), } },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Guid[,] { {
Guid.Parse("6ddf57f5-a633-4dce-ae5e-a4f68d90afb3"),
Guid.Parse("569a85ec-c2c9-4749-b697-b91537c8b110"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 95,
    Value = 
new System.Guid[,] { {
Guid.Parse("3bb53cec-3ff6-46d5-888f-cfa0c656756f"),
Guid.Parse("9ebad4c6-c8a3-4560-9022-469c2aeeb9b9"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("fe9ec4f5-51cd-46f5-b3e0-64cb920293a0"),
Guid.Parse("2602f3f1-2c50-4f73-ac7f-f95827737985"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("7fa21921-6c05-4585-ad36-40111315bccd"),
Guid.Parse("d9befbd2-b5b2-4736-8059-bb937b8a9683"), } },
},
            new GuidMArrayD2E1M
{
    Id = 78,
    Value = 
new System.Guid[,] { {
Guid.Parse("0b788f3a-a0f8-4261-aaae-8d2315dec925"),
Guid.Parse("860f8c84-d461-4e1b-b69e-fdae9541adf7"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 100,
    Value = 
new System.Guid[,] { {
Guid.Parse("11097346-f96d-44da-8adb-5f0f8d3515a9"),
Guid.Parse("f285fb83-0223-46d8-a2e2-f40ab8bbc358"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("ce187fe4-3347-46e3-9371-1e4c4e90d992"),
Guid.Parse("8b34d70a-5437-45b6-98bd-fef3608bb9fc"), } },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 83,
    Value = 
new System.Guid[,] { {
Guid.Parse("9230d449-a98a-4207-a51c-082bf746c6f9"),
Guid.Parse("1ce8d8f7-165d-4c65-8774-a5a8a9c49df6"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 105,
    Value = 
new System.Guid[,] { {
Guid.Parse("3951bba2-261d-43a7-b21e-2bf55bdfa0a8"),
Guid.Parse("f730217d-7520-4069-81c1-59de712e00b8"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("b16f6ec6-ec26-4ef7-b291-73cea78a45ee"),
Guid.Parse("c50deecd-9f9d-4012-84e2-a9e0593391e6"), } },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 88,
    Value = 
new System.Guid[,] { {
Guid.Parse("f288ca6c-4ca4-414e-b363-f03ec4beac08"),
Guid.Parse("507564f6-de6f-48d9-9bd2-9dfe43a2b208"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 106,
    Value = 
new System.Guid[,] { {
Guid.Parse("872b215c-5868-45c9-b56c-8a84defbcb41"),
Guid.Parse("7b09cff4-1fc2-485f-9f52-c961a9e731bb"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 89,
    Value = 
new System.Guid[,] { {
Guid.Parse("3a9b2215-fe55-41c3-af95-9f456537524f"),
Guid.Parse("c4b84d8d-2411-4c83-91da-3467f9eba863"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 113,
    Value = 
new System.Guid[,] { {
Guid.Parse("7cbbe1e2-9d4b-4e15-878e-d789018d59cd"),
Guid.Parse("44e46634-7830-42f4-9cf3-b80d7b59f4e7"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Guid[,] { {
Guid.Parse("049d0876-ec85-4933-ac3f-1a2fd4742e98"),
Guid.Parse("91263e92-f5c5-403e-8a05-ab7ee38cf2af"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 117,
    Value = 
new System.Guid[,] { {
Guid.Parse("56c9fc3a-c9e9-4492-8ae4-a58f9e5945c9"),
Guid.Parse("d625311e-3722-4f8f-80a1-1e21ca2b55da"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("7c256322-5cc9-4843-89fb-b92d1700b1e0"),
Guid.Parse("c74a14d4-8f9c-41bd-ba1f-80db52a1ac06"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("2e38caf6-5c38-4cf7-826b-2843170facd5"),
Guid.Parse("bfd226dd-f60f-44ea-8f88-bbc9a5232f48"), } },
},
            new GuidMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Guid[,] { {
Guid.Parse("d15b208d-2857-4138-aceb-e68ca002aa07"),
Guid.Parse("89c7187a-b445-4f6d-a1e1-ecc2c5f8ba0f"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 119,
    Value = 
new System.Guid[,] { {
Guid.Parse("a5b97314-03cf-4716-b457-ca1c9d21946d"),
Guid.Parse("2daff5b8-4043-4ee1-9155-1c6e6b0ff53b"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("41d74fa5-2b5e-4387-9890-cfb4684f72e5"),
Guid.Parse("ad45696e-82ce-4dda-9653-17d37c1f4c2d"), } },
},
            new GuidMArrayD2E1M
{
    Id = 110,
    Value = 
new System.Guid[,] { {
Guid.Parse("644bfc38-6ae1-4fd7-bffd-603736d9a97f"),
Guid.Parse("2e906522-a898-4904-9d92-8dad459d21a2"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 126,
    Value = 
new System.Guid[,] { {
Guid.Parse("9948d4c6-546a-43ba-aa4b-192dd4c751e6"),
Guid.Parse("a5ead0d8-c46d-4ddc-bdcf-000d42ae6a0b"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 115,
    Value = 
new System.Guid[,] { {
Guid.Parse("df0f617e-4271-493f-abb2-6ba6e4cd42ad"),
Guid.Parse("40dd392e-4dca-4aca-aaee-058ee590902b"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Guid[,] { {
Guid.Parse("4022866b-fa2d-4bd8-8c18-d0dfefd68d7e"),
Guid.Parse("f4e680ca-f90c-45b2-8198-580235baa4da"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("63407afe-8b00-42a0-a983-8133db23bcc5"),
Guid.Parse("50b1ae43-6abb-49ae-a19b-4b15bbf1c7c8"), } },
},
            new GuidMArrayD2E1M
{
    Id = 120,
    Value = 
new System.Guid[,] { {
Guid.Parse("3ab8849a-47c4-4a99-8417-d47a6c47c859"),
Guid.Parse("25de93c7-c181-4539-9f14-e3d43f5c585d"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 137,
    Value = 
new System.Guid[,] { {
Guid.Parse("fae839b0-0702-4a32-828f-b6b783d13803"),
Guid.Parse("213cd2d5-7735-4a60-a5aa-a7f886fae3bb"), } },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("12cce6a0-96da-400a-8c35-31f6180472ec"),
Guid.Parse("8b20c9d7-5804-4e2f-b0c0-5ef55afcd15b"), } },
},
            new GuidMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Guid[,] { {
Guid.Parse("2ede7a53-1412-4bf9-a521-f583e71b0aa1"),
Guid.Parse("57e26357-f3e5-4012-b500-d177a323c9f0"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 139,
    Value = 
new System.Guid[,] { {
Guid.Parse("47184bc9-933d-480d-a52f-76ea4cb47582"),
Guid.Parse("3f8d6074-a0bb-45e7-bcc7-a75fece6daa6"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("499890fd-4ae8-4f6c-9e15-bfddcd657fce"),
Guid.Parse("333c6a38-f134-4e5d-99e9-bf6190fe6144"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("9e88c21b-1be0-41e4-b048-b644aea2957d"),
Guid.Parse("24bdc656-29b8-44e9-8bf6-98e6d2c7f094"), } },
},
            new GuidMArrayD2E1M
{
    Id = 127,
    Value = 
new System.Guid[,] { {
Guid.Parse("15e223db-ac8a-4314-9bec-3bb92dacf212"),
Guid.Parse("369b2564-8fd8-4b04-bfd4-121874a86f16"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 144,
    Value = 
new System.Guid[,] { {
Guid.Parse("aff79127-bdf6-4a4b-9a62-f6c2eeab877e"),
Guid.Parse("14fa1d51-0455-44a8-8a9d-3008e5224e33"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("840d7ca6-3f42-4a75-9859-4d7567e353a8"),
Guid.Parse("2eccee3c-fed2-405d-8d7c-f7713ed52842"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("44f562e3-173c-4c7d-9464-7fd55c0d0624"),
Guid.Parse("6c01a92b-b283-45e9-b2dd-1ab1b9566f00"), } },
},
            new GuidMArrayD2E1M
{
    Id = 135,
    Value = 
new System.Guid[,] { {
Guid.Parse("77d3545d-4417-430b-903c-41555abb6e67"),
Guid.Parse("e9e01c02-d910-4e40-9f48-38cb53e2360d"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 151,
    Value = 
new System.Guid[,] { {
Guid.Parse("554d5b5b-718d-4d17-b6c0-882ff8ea504f"),
Guid.Parse("9fc92dc8-321c-4e7b-96cc-f98ac9c3b47b"), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 144,
    Value = 
new System.Guid[,] { {
Guid.Parse("a1cb1e72-6d5d-426c-a3cd-a4eb175fe15f"),
Guid.Parse("5b59c24a-a76a-4c5a-aeea-6e0bfd9e5286"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 155,
    Value = 
new System.Guid[,] { {
Guid.Parse("9c871925-d9db-497d-a522-d1f87e5b23c2"),
Guid.Parse("be2d20de-d98d-40e5-a4f8-4535d4f6ea01"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("1fcc7412-84d5-4687-9bb8-941c54a15053"),
Guid.Parse("8e2e0e82-11cc-4795-8fa5-292b578cae23"), } },
},
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("b741e5a1-bbd2-44d9-bb62-dc053dd45c0b"),
Guid.Parse("4ea674d1-0775-4fa8-a52e-29665846734a"), } },
},
            new GuidMArrayD2E1M
{
    Id = 146,
    Value = 
new System.Guid[,] { {
Guid.Parse("63e92109-c2bf-4280-819e-7525549223fb"),
Guid.Parse("e7264b02-bfde-4a87-8410-e9f95ba43e31"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 163,
    Value = 
new System.Guid[,] { {
Guid.Parse("d566c064-1326-48c4-a298-50ae981ded85"),
Guid.Parse("fff5f4e5-9ee1-4d46-b707-359c336f55c8"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("c42951cf-dbcc-4581-9fff-140077f3c9a6"),
Guid.Parse("c26b2459-05b1-46c1-b71a-593ead5fa53b"), } },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 154,
    Value = 
new System.Guid[,] { {
Guid.Parse("39e5624a-3753-4dbd-ba86-0226ea5e2223"),
Guid.Parse("3a1c28ed-43ad-4a6e-9c83-2c375d9b3153"), } },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 170,
    Value = 
new System.Guid[,] { {
Guid.Parse("3e5568ff-214f-45b8-849b-84a8fd610caf"),
Guid.Parse("29f90179-c370-499d-9302-3f6f3e66d1a1"), } },
    NullableValue = 
new System.Guid[,] { {
Guid.Parse("d73530d9-f732-49ac-9459-a833a6e51024"),
Guid.Parse("91139958-66cf-4224-98db-4cb13e064bfb"), } },
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


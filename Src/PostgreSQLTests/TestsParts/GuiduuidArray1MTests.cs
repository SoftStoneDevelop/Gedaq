

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
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("d28719ab-edd3-4e6e-bf4f-1927b5edbc62"),
Guid.Parse("b4ff0ddc-4143-4836-844c-671bc5b8d4ad"),
Guid.Parse("a2eabeda-6984-47f7-8c26-c0f098018fd1"),
Guid.Parse("fcbe7091-3b14-4593-966f-db33caf8ff39"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5e9a91c4-d6d2-4dc4-8ea4-62c83e3f0374"),
Guid.Parse("59fc55af-74b9-4c82-a283-c7ee5a87fbf4"),
Guid.Parse("02b300a1-5960-4e1f-8256-9435347f6932"),
Guid.Parse("df19dddb-dba1-42a5-82bd-02dce015da3f"),
},
},
            new GuiduuidArray1M
{
    Id = 15,
    Value = 
new System.Guid[3]
{
Guid.Parse("43213a1c-0a9a-47ae-b3f0-7e75be9a2bdd"),
Guid.Parse("da190385-7513-4ebc-a837-75b697431cf2"),
Guid.Parse("f1c8662a-ed5f-48a1-ab83-9b71605be9c7"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 3,
    Value = 
new System.Guid[4]
{
Guid.Parse("71286e63-b95f-4978-83f9-6094e2993fee"),
Guid.Parse("d3c78691-c8f3-46aa-922d-ba8407fe582d"),
Guid.Parse("4252ace0-15a4-4ac1-b585-20363db8ac67"),
Guid.Parse("1510d9f8-4ea0-4d36-9810-7ff3906ae90c"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e461a9db-34ca-498b-b2d4-932259d7b1e5"),
Guid.Parse("b86cf33c-2802-4f41-a4b6-b1f3b3b83d6a"),
Guid.Parse("98834f62-2c76-4a84-8bbc-7433ebcf19a5"),
Guid.Parse("9a6492c7-eba6-4ae5-98ad-aafdb6426e63"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 22,
    Value = 
new System.Guid[3]
{
Guid.Parse("e396b19f-6c9c-4cbb-92ee-79ca74207542"),
Guid.Parse("e2867ac4-4373-42b1-9f49-9de9a8ffb375"),
Guid.Parse("dad1c1d1-e3fd-4b79-ba61-c04ef8b67f26"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 27,
    Value = 
new System.Guid[4]
{
Guid.Parse("d89bef53-9d63-447f-bfa2-fe729a734de0"),
Guid.Parse("bc1ae3e2-e198-4bb3-831d-4edaa7512309"),
Guid.Parse("1861bd57-ae9e-4d2d-95a6-9c000a59f658"),
Guid.Parse("5499e7ad-1ea8-4caa-96aa-4198272a1b7a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 5,
    Value = 
new System.Guid[3]
{
Guid.Parse("f90a7f74-e073-4e4a-bb6d-8b62359dd6c0"),
Guid.Parse("a08e82ad-ed9e-4583-aa63-89aea1aef131"),
Guid.Parse("dd993105-a9ae-49ad-9a5f-425a381287a5"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3a5b8d26-0f49-49a9-9113-a0484e772de3"),
Guid.Parse("01f30435-0326-4a5d-a0c4-cb0035cea920"),
Guid.Parse("61ce52c7-9fff-43c0-a505-0adc7f1224c9"),
Guid.Parse("1e0ee878-059d-4b48-aa26-301d7d8ff831"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 28,
    Value = 
new System.Guid[4]
{
Guid.Parse("ab9b038c-4967-4065-b635-35feffbd8f3e"),
Guid.Parse("5460139b-dcb1-44c1-bf57-127c2d1dd82d"),
Guid.Parse("1adefb61-adff-4f1c-be3c-28119d6142e0"),
Guid.Parse("b95e3691-aba9-4a41-89f9-08f1b79d94a0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 32,
    Value = 
new System.Guid[3]
{
Guid.Parse("b8be3ae7-61dc-4f78-9e39-d1501d6784b5"),
Guid.Parse("27218926-b067-4fb7-b44e-4812b91d4aa9"),
Guid.Parse("b796e962-f238-4d47-a3a6-92747d2bf60e"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 6,
    Value = 
new System.Guid[3]
{
Guid.Parse("51511864-2d83-4a88-8579-a9519daecd59"),
Guid.Parse("d352f64e-4910-4056-9c6e-a0c89b46ae20"),
Guid.Parse("3d82aee6-5bed-43a6-8654-d56b569c1e34"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("971c6382-ea92-4026-b4b3-f008b25f19f3"),
Guid.Parse("9881598a-889d-47d4-962b-5afa4d680eb9"),
Guid.Parse("60d5eb09-9776-4b1a-916e-bd4a6a1d0d91"),
Guid.Parse("3410d92f-e71b-4224-8604-5d70a7cdb666"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8a331826-d8d3-4376-9fdb-65944f2630f3"),
Guid.Parse("c498b095-c5b7-4c65-aad8-a1b820d4686f"),
Guid.Parse("c9ec0b23-6410-4ce2-9fd0-e19ad2278db9"),
Guid.Parse("01eefb67-727d-46da-beb2-2705001bbdc6"),
},
},
            new GuiduuidArray1M
{
    Id = 40,
    Value = 
new System.Guid[3]
{
Guid.Parse("5d1eacfd-cdbc-4fec-b916-065e0a76c384"),
Guid.Parse("74f1c64c-0e7d-4a4a-9a96-55a9c5f4b138"),
Guid.Parse("8c4c10f9-0ac7-4469-a59e-d98989714b1d"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fee3637a-c04f-4b32-811e-1d316e63e8ba"),
Guid.Parse("f3a81077-63f2-4ec0-b6bf-8eaf6469a5f5"),
Guid.Parse("4fa32cc6-d85d-4a08-b63b-e84590d48326"),
Guid.Parse("0bf801c6-e40f-413a-bd3d-eba4b2d9882e"),
},
},
            new GuiduuidArray1M
{
    Id = 45,
    Value = 
new System.Guid[4]
{
Guid.Parse("ac9761d4-4d5c-4cbd-97e0-8369e669eaa9"),
Guid.Parse("fb11b628-34c5-4971-b2bc-e15b512eca26"),
Guid.Parse("887cec3f-07be-4f5f-995b-8edac5be77be"),
Guid.Parse("a2a60ad0-cc09-4618-8634-4ddd1db293f8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("28cf8a5e-3f69-49bd-b91e-b6412c665b87"),
Guid.Parse("3fd77475-400f-4dc7-a889-9a7401efac77"),
Guid.Parse("94d393f1-772c-4120-8efb-33762415d52e"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 51,
    Value = 
new System.Guid[4]
{
Guid.Parse("cb048be4-4902-414e-ab98-65d049427d77"),
Guid.Parse("3fa39fd8-6300-4843-a9c5-f66ff33fd28a"),
Guid.Parse("c882e80b-2de9-49ff-9bca-b52e65b228b2"),
Guid.Parse("8ac9fdfc-6382-4a9a-bfc4-e272b1c0fab6"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("39928fce-1f21-4100-834f-cff0ee50ec42"),
Guid.Parse("8a968898-9cf5-4388-8a57-f2da4862998f"),
Guid.Parse("21c26b89-35e0-4d77-83c4-a2506472f76c"),
Guid.Parse("bac6e972-f19b-4455-9ebf-7a118d836e9f"),
},
},
            new GuiduuidArray1M
{
    Id = 56,
    Value = 
new System.Guid[4]
{
Guid.Parse("44706449-9aeb-4d54-acf9-53fd911a81e5"),
Guid.Parse("7925846b-0036-4f76-ad6a-991c6d6c78c1"),
Guid.Parse("6e2fb505-595e-4f11-99a4-d247b5185f60"),
Guid.Parse("03c9a58e-cc3e-4abd-9163-57894e8a881a"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 16,
    Value = 
new System.Guid[4]
{
Guid.Parse("92e46324-eb94-4cc7-9962-109816f93e1e"),
Guid.Parse("2ac56df0-6fbe-41ea-b91f-f6b9d987f5b0"),
Guid.Parse("97b5ae91-99b9-41bc-81b2-44731e35d698"),
Guid.Parse("c3a9f8e9-019a-483e-afbb-30f68850011b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("46c0f560-fdf0-4f12-8752-dfd25d5d66a0"),
Guid.Parse("7a0f70ea-9d1c-4287-8b81-3f8384e6eda2"),
Guid.Parse("ba76e881-b010-44a2-ac93-c56b28865587"),
},
},
            new GuiduuidArray1M
{
    Id = 60,
    Value = 
new System.Guid[3]
{
Guid.Parse("ab3a2645-1701-4358-b7cf-412bc745e228"),
Guid.Parse("513125db-b864-44f6-bf0d-90cf9caae7cd"),
Guid.Parse("d35283cb-9c21-4d81-b6c8-286a17fa439f"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 63,
    Value = 
new System.Guid[3]
{
Guid.Parse("bfbb5a8b-7623-46a3-9224-63ec5f2e5c86"),
Guid.Parse("029d8517-ae3f-4a68-83cf-f1870456eafb"),
Guid.Parse("92bd6421-0d64-4e12-a495-611c5f888d1d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 17,
    Value = 
new System.Guid[3]
{
Guid.Parse("1c2f826d-8205-40c9-bc42-aa9aaace6f57"),
Guid.Parse("41746237-c052-4378-86f7-c15ea6c41729"),
Guid.Parse("86936859-996d-4c25-a7b9-2f491908f79e"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("62f9cf69-e08b-4cf2-b53e-174134aeaca9"),
Guid.Parse("00fd0d6e-e153-4747-ac4f-1d16d3ff0710"),
Guid.Parse("540a859b-61ba-4289-afac-bd2934cc8885"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 72,
    Value = 
new System.Guid[4]
{
Guid.Parse("f5a3647a-1658-4b30-8c64-4b7cd4d1a0bd"),
Guid.Parse("7877bb46-a396-42db-9054-40faad4cce78"),
Guid.Parse("8537143f-eb86-4168-8ad0-10dc9e2ee6ab"),
Guid.Parse("9b814ca5-86cf-4cd6-941a-31f51a1212da"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("4405cc85-7b0c-4d45-8cea-e94f45835023"),
Guid.Parse("7f089dde-4134-4208-be56-f1a82306fb01"),
Guid.Parse("067aa314-ce1b-44e9-99be-a0388095ade1"),
},
},
            new GuiduuidArray1M
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("1b53dd54-cd4a-49d8-8991-da93f456d2f3"),
Guid.Parse("f712bb2d-76d8-4009-b0db-75827559305b"),
Guid.Parse("eee6e54c-e478-4131-a5e5-ca690b5bf576"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 25,
    Value = 
new System.Guid[4]
{
Guid.Parse("9ca37686-da9d-4333-be80-2a7a5dc4092b"),
Guid.Parse("8c88b36e-4e72-4ee1-88f4-88c711ae27ef"),
Guid.Parse("dec410b8-ef34-4c92-82f4-21a9fc526a26"),
Guid.Parse("7efc1679-813f-4e8c-acf0-46de5c76b1d4"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("00e76f49-0979-48f2-a8af-a7b0bae8a12d"),
Guid.Parse("dd32cc65-008a-45ae-b415-c8cafa6c46cd"),
Guid.Parse("e8e594e5-0d49-4785-9d72-725b6db336ea"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 80,
    Value = 
new System.Guid[4]
{
Guid.Parse("e64903aa-8700-451d-9386-9e86a39b0069"),
Guid.Parse("5ad76ca5-d41b-4e27-a83f-e7dfb9484e89"),
Guid.Parse("755bae92-24c1-4d8c-97ad-301c9a12b9fa"),
Guid.Parse("0c73d591-d107-4956-9dae-a84a872d51d1"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3b6bd547-6291-4507-a52b-67ca8bbc0325"),
Guid.Parse("2cdab2a3-4b0f-4de6-a32d-a3fc8e692db6"),
Guid.Parse("d3a3957c-4186-40d1-9a53-117d053b70b8"),
},
},
            new GuiduuidArray1M
{
    Id = 82,
    Value = 
new System.Guid[3]
{
Guid.Parse("079316b6-1d72-4301-892a-3d3d6dfa9b0b"),
Guid.Parse("16f29ca2-9719-4a84-9b3f-69b942106740"),
Guid.Parse("82df6cd9-126a-44e1-86a6-aabdc3f8a7a8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 32,
    Value = 
new System.Guid[3]
{
Guid.Parse("effdc5e4-41f8-4898-b790-2351c7481c87"),
Guid.Parse("db585202-5469-40b5-8a2d-3a8a5604c8c4"),
Guid.Parse("1b9dfff4-176d-463d-ab66-ca7df38a7e59"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("46e0fc53-0190-4573-8f57-8a7a1d15cdbc"),
Guid.Parse("057ea7bc-b9b8-46f4-abee-3aa5824f0d55"),
Guid.Parse("f9c46a3e-be50-43ea-a98c-cb3a1020c169"),
},
},
            new GuiduuidArray1M
{
    Id = 88,
    Value = 
new System.Guid[4]
{
Guid.Parse("d19d30be-718e-4e0c-8819-03b485b65a55"),
Guid.Parse("bb1fb811-fd38-4447-bb73-0de07d8b73b5"),
Guid.Parse("12628474-ef9f-4828-9fac-0bcc0528fd95"),
Guid.Parse("e26410b1-3561-4066-957f-d99d7bbecf07"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c1a2b30c-4aa3-4edb-9c97-ff95df315c96"),
Guid.Parse("e408ca3a-0cf6-46bb-b35e-2642cf59d881"),
Guid.Parse("d70511d4-ddd7-4162-98a5-8e1b8cd44715"),
},
},
            new GuiduuidArray1M
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("5b791c79-0b56-4fa5-9936-1f93638a6cd9"),
Guid.Parse("55c61805-0ff7-4f44-9f02-b02459d1e508"),
Guid.Parse("80239d79-79fc-4dde-957f-7e0a3b375a03"),
Guid.Parse("e20c99ea-92b3-4673-8d82-109dfcae26df"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 38,
    Value = 
new System.Guid[3]
{
Guid.Parse("cab5a443-00d0-48c2-aa2e-f82d864cb172"),
Guid.Parse("78181a62-0a41-42ca-93bd-4c12147ce86c"),
Guid.Parse("e8443e8f-b849-4854-bec2-0e230460cad6"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("09e29c3b-9a8b-4fd4-a933-ce5dae76a5f6"),
Guid.Parse("3102d6e3-71bc-4226-9e50-33a73a166c6d"),
Guid.Parse("34b60a58-47c3-4067-92a2-0226ef31e195"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("91c5f74c-6ad1-4ca8-9e15-a4e18843f3d2"),
Guid.Parse("fd3f3f99-df97-4227-ae50-6e1f18dc95cf"),
Guid.Parse("d7d09ab4-a5ee-4d1e-a703-2d0400854462"),
},
},
            new GuiduuidArray1M
{
    Id = 93,
    Value = 
new System.Guid[3]
{
Guid.Parse("2e03a114-c139-4591-b68d-862dbf2807d9"),
Guid.Parse("3634869d-1d23-495a-b199-7a4d374aca3a"),
Guid.Parse("f667cf23-33b2-43e2-9f05-1c2f5ea8ee05"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 101,
    Value = 
new System.Guid[4]
{
Guid.Parse("5fb9c97e-48a3-4f8d-9973-e19f5307ec2e"),
Guid.Parse("6569e01e-efac-47fd-ab35-5c0f65e75502"),
Guid.Parse("aa437297-834b-4a8b-aa6f-2554b75e3e43"),
Guid.Parse("983c4f7e-db20-4350-89b8-dc021ecfe4be"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 45,
    Value = 
new System.Guid[4]
{
Guid.Parse("2deb1512-352d-4a9f-acd4-71c03ce5fc26"),
Guid.Parse("33c06ff7-b88b-4e42-9894-520c563943d3"),
Guid.Parse("1a72222e-9107-476c-93fd-9e06d1f5fcd2"),
Guid.Parse("25e08c57-cdbd-435b-b783-91ebc690ea60"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 104,
    Value = 
new System.Guid[4]
{
Guid.Parse("98fe85a2-e13a-460f-a24d-47d19fd822ac"),
Guid.Parse("8e70894d-bd6b-4dfa-baee-5260ded144fb"),
Guid.Parse("114edec9-6daa-4b7c-a2b4-88a40b665bf4"),
Guid.Parse("96fb30ec-de84-4df0-b929-4346cc959864"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 108,
    Value = 
new System.Guid[3]
{
Guid.Parse("04bc3d67-818b-4c85-9706-00a8d8348d33"),
Guid.Parse("23cb3bab-496e-4e4e-9ffe-efca9e189790"),
Guid.Parse("0a79051b-1c5d-4a06-82de-9e40e81a1a49"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 49,
    Value = 
new System.Guid[4]
{
Guid.Parse("3d8ad1f7-429a-4e69-85f3-76a3918a8055"),
Guid.Parse("66e5ec6d-ac42-4b11-8a0f-5619a9c6ce10"),
Guid.Parse("5437a2c1-54b7-48c0-9a3b-66ced66e910a"),
Guid.Parse("57c74df3-53d4-41ed-b8ff-9b6e5ee626f6"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("169f1f8d-8de3-498f-b5fe-38382278dbe7"),
Guid.Parse("755b6691-58a9-4886-9c90-4051fa929916"),
Guid.Parse("46dc01a1-ab26-4617-bab6-7c4d5ec5dbbd"),
},
},
            new GuiduuidArray1M
{
    Id = 114,
    Value = 
new System.Guid[4]
{
Guid.Parse("7b0430ba-06ab-41bc-b5c6-0af273cf9cfc"),
Guid.Parse("d35980ae-0b35-454d-860c-0cea2e8e46ed"),
Guid.Parse("b4ecc6d9-4fa3-4750-84b5-fe4e7e3e8ebf"),
Guid.Parse("9667a80f-db52-4a85-83e2-65d20dcc827f"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 116,
    Value = 
new System.Guid[4]
{
Guid.Parse("c4961296-efc0-432a-bf2f-7b93daa28ab3"),
Guid.Parse("ad275218-0c87-47e6-9e8a-923bbfee40ea"),
Guid.Parse("024a4193-4b50-4f58-92cb-c08806c85b26"),
Guid.Parse("af74cf6d-d716-4ded-ba79-07de6ac284b8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("21edce74-c583-40b5-80d1-ddf9e3aaf26d"),
Guid.Parse("eddeb498-25b3-4d3b-ae30-f721e16a8ad7"),
Guid.Parse("79d7230e-96f6-47f4-8b94-b80cc31aad31"),
Guid.Parse("bb27d4de-62a4-4990-a42b-a3a129411453"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c5c5cc4c-b535-47c9-ba8b-fd14e27a4550"),
Guid.Parse("519e9ad4-72ab-4607-a1dc-b0188d7b3248"),
Guid.Parse("26acf38e-3a7d-4f3f-a9d9-23ae55f6d427"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b2a81050-a899-45a8-a769-49376b5eca63"),
Guid.Parse("5c03173c-c1b2-4bd9-8989-66d75802dcc6"),
Guid.Parse("fe3b496f-31c7-4305-990f-82506a2be61c"),
},
},
            new GuiduuidArray1M
{
    Id = 117,
    Value = 
new System.Guid[3]
{
Guid.Parse("669170a3-f00a-4925-87d3-c1cfdf3e3e15"),
Guid.Parse("dfadc801-4aee-4403-915d-5dd7ca78ec98"),
Guid.Parse("49efadd2-45eb-416a-a020-01ae9754ca72"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a90bf7ca-6ee9-4bc8-b007-4ca1229dae9b"),
Guid.Parse("d17bf73b-a0f8-421c-a0cc-09a9516f5228"),
Guid.Parse("8b863526-66e6-4878-93af-90afa8d248bd"),
},
},
            new GuiduuidArray1M
{
    Id = 119,
    Value = 
new System.Guid[4]
{
Guid.Parse("7024796b-5267-4aa0-b90c-518f81a2f4b1"),
Guid.Parse("4cdebb65-e83b-41f2-9c07-f9498b68f829"),
Guid.Parse("12844f8b-0d8a-425e-af66-78f9ee0c8597"),
Guid.Parse("73ba307f-d2e6-4d98-88e8-c9b104ac9631"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("b27436bd-5fee-4dad-8f28-b69008511dc4"),
Guid.Parse("ad2af24c-fc64-4a27-98e6-4681685bd598"),
Guid.Parse("6dc45f91-581b-4d8e-be89-26652fadd7e6"),
Guid.Parse("fa228812-4a55-4581-b36c-c381dd08b864"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b14c60d7-9c1a-4908-a942-8ef519428fc4"),
Guid.Parse("18ce7595-4fa6-4caf-944e-e1fb0bc915a3"),
Guid.Parse("69bbd6b9-0a22-4e89-ab67-04e78272b910"),
Guid.Parse("ad82b1f6-e1de-4537-8df1-4a2b7c1910be"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("05270b78-e428-48f4-b883-573871edefbf"),
Guid.Parse("c882b6c2-32e9-4183-b3db-9754b6835c59"),
Guid.Parse("b845fd9d-b990-4e8a-8ccb-fbb0c8712249"),
Guid.Parse("8a0e676f-12ab-4d45-9b83-210c71c6ea01"),
},
},
            new GuiduuidArray1M
{
    Id = 127,
    Value = 
new System.Guid[3]
{
Guid.Parse("0649f316-193c-48ca-bfa6-806bb959ca08"),
Guid.Parse("4b42491e-1174-47f1-bd0b-8e8e2d091426"),
Guid.Parse("6e685ef7-8e20-4073-9312-67f887eaf2b1"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 129,
    Value = 
new System.Guid[3]
{
Guid.Parse("1af16235-962e-4a60-926e-d429c20e72db"),
Guid.Parse("151a50c9-1d36-441c-a83b-2e9dace6e733"),
Guid.Parse("6ead1290-7590-455a-903f-467fd725de7f"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 64,
    Value = 
new System.Guid[4]
{
Guid.Parse("c322af6c-e1a8-4a99-a3e5-73b9adc84027"),
Guid.Parse("9e01367b-66ab-4ad2-914d-0ab6a497a336"),
Guid.Parse("e486a6c3-4901-4680-8f11-de37e028c5b3"),
Guid.Parse("1154dedb-56bb-4372-b3b7-712c601daef4"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("978fdc08-750e-4159-9eff-24691e99f892"),
Guid.Parse("669fd7e2-873e-4956-8d43-957249088b63"),
Guid.Parse("65203ba4-fe93-4fab-83df-cccc92f9977f"),
Guid.Parse("766dfcf2-8ada-4ce6-ac0f-5b0998ce6058"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("04e8eb49-8db5-405b-be20-5a9263c04391"),
Guid.Parse("be5dbf76-5409-4395-9b3f-4c7d2e43039d"),
Guid.Parse("db2fb4ae-9d16-4fc3-8870-fdc580b2b5d8"),
},
},
            new GuiduuidArray1M
{
    Id = 138,
    Value = 
new System.Guid[3]
{
Guid.Parse("896afa23-3847-4391-9716-27159a47d659"),
Guid.Parse("a6cf4899-e24c-42f8-ab7e-066ef8148a7e"),
Guid.Parse("7da6541c-aeb6-49a3-ad8c-2a37f2b31eb1"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 147,
    Value = 
new System.Guid[4]
{
Guid.Parse("ce81b6ae-5417-4b3d-a823-e1882270492a"),
Guid.Parse("fdff12ee-68e9-440e-a40c-103beb380816"),
Guid.Parse("aa4d15bd-bbac-4ce3-bdd0-7b35608a3168"),
Guid.Parse("674f242a-3b81-4d65-bb49-66b74a46a984"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 72,
    Value = 
new System.Guid[3]
{
Guid.Parse("d77080ad-24fd-4396-a90f-f10f60a42fe2"),
Guid.Parse("cecbaf7a-01fd-45af-9995-1e80a5f8c275"),
Guid.Parse("77605456-43b9-41aa-b54a-fd07f53850c6"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f1a65246-6a19-4e20-bfc3-7b75d8a786c9"),
Guid.Parse("65b4eafe-8696-4f4e-ae16-7a2be2060370"),
Guid.Parse("9b248d9d-d69b-441c-ae1a-45eaf1f0d83f"),
Guid.Parse("436702e1-802b-40c9-9869-172fc3502780"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b2212713-d3a8-47a8-8bba-ed598ab4dfbb"),
Guid.Parse("efee63bb-5d4a-4f38-afcd-e4567032fe1f"),
Guid.Parse("79573cdc-b333-417d-b110-e3b206e1169c"),
Guid.Parse("1b9e7ce8-d3e3-4dc1-b86e-dd661c21c0ae"),
},
},
            new GuiduuidArray1M
{
    Id = 156,
    Value = 
new System.Guid[3]
{
Guid.Parse("4ce608bd-1912-42b7-9a16-c665ae3c81ea"),
Guid.Parse("fe201faa-4172-44bb-a779-555c579eb6fe"),
Guid.Parse("e1656373-5157-42fc-a45b-47e017c92532"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 158,
    Value = 
new System.Guid[4]
{
Guid.Parse("5241fd26-eb79-49e9-bf3f-56a9ce8db4ac"),
Guid.Parse("1e954697-8e3d-4e3c-a657-c8b811c5c6de"),
Guid.Parse("720f4695-cb99-447d-a478-6dd02ad6c6ec"),
Guid.Parse("4836e732-ca83-4733-9164-6552012c875d"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 76,
    Value = 
new System.Guid[4]
{
Guid.Parse("e469c6c9-f744-4696-9ebc-a253ab681d97"),
Guid.Parse("0b17357b-45bb-4db9-bcbb-edf9151cf441"),
Guid.Parse("2b110ab6-ee53-4d30-963b-baa7f18bbe3c"),
Guid.Parse("c5bdfca2-6501-4b2f-8ce1-1dd9ceae2087"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ce123503-262a-445a-a3e0-7f2227f83ae4"),
Guid.Parse("94191c88-6296-4aad-aa41-f3751ae1bc17"),
Guid.Parse("15306dea-94e6-4b08-9144-e4b5e4231650"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 161,
    Value = 
new System.Guid[3]
{
Guid.Parse("3fcf493d-29d3-4037-b1dc-a55b5d5456e4"),
Guid.Parse("77a48871-e878-4054-8164-3d678093088c"),
Guid.Parse("5a684925-efd4-46a0-928e-ae63da8168bd"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1547b66b-4b16-4595-960c-00f4df0ccec1"),
Guid.Parse("3ebdf2c3-e4cf-432a-9c47-d67a00602e41"),
Guid.Parse("e3882d32-4cab-456a-ac3c-e7c3b4e7f718"),
Guid.Parse("c6c0fc1c-1e8c-4999-b527-58676742e6cc"),
},
},
            new GuiduuidArray1M
{
    Id = 163,
    Value = 
new System.Guid[4]
{
Guid.Parse("fcb6e9bb-9b6e-40e2-ae0d-0d800ee490dd"),
Guid.Parse("065b3ce4-2822-469c-bb3d-5a884014d170"),
Guid.Parse("9834107a-4671-445e-8390-dcd0060530ce"),
Guid.Parse("ba59e302-ba89-43ff-8cd7-5bce52cb12da"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 77,
    Value = 
new System.Guid[3]
{
Guid.Parse("c7d07127-072f-445a-afa8-c5584d5a1453"),
Guid.Parse("9d5cde43-1ac8-4ad7-b218-5f3e8ced259b"),
Guid.Parse("ce4fcd25-e6b7-43e8-92a8-35882bd98c8f"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 172,
    Value = 
new System.Guid[4]
{
Guid.Parse("4130994a-db64-4946-8ce6-3493842b048a"),
Guid.Parse("c7b8cca0-d716-4b90-bebd-250bc9a1ec56"),
Guid.Parse("6f9bb281-3149-4733-a3be-cbce30aded0b"),
Guid.Parse("712f0fca-7790-406a-9b32-eb202f9d1cb5"),
},
    ModelInner = null,
    NullableValue = null,
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

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
Guid.Parse("8a331826-d8d3-4376-9fdb-65944f2630f3"),
Guid.Parse("c498b095-c5b7-4c65-aad8-a1b820d4686f"),
Guid.Parse("c9ec0b23-6410-4ce2-9fd0-e19ad2278db9"),
Guid.Parse("01eefb67-727d-46da-beb2-2705001bbdc6"),
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
Guid.Parse("fee3637a-c04f-4b32-811e-1d316e63e8ba"),
Guid.Parse("f3a81077-63f2-4ec0-b6bf-8eaf6469a5f5"),
Guid.Parse("4fa32cc6-d85d-4a08-b63b-e84590d48326"),
Guid.Parse("0bf801c6-e40f-413a-bd3d-eba4b2d9882e"),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("39928fce-1f21-4100-834f-cff0ee50ec42"),
Guid.Parse("8a968898-9cf5-4388-8a57-f2da4862998f"),
Guid.Parse("21c26b89-35e0-4d77-83c4-a2506472f76c"),
Guid.Parse("bac6e972-f19b-4455-9ebf-7a118d836e9f"),
}));
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("46c0f560-fdf0-4f12-8752-dfd25d5d66a0"),
Guid.Parse("7a0f70ea-9d1c-4287-8b81-3f8384e6eda2"),
Guid.Parse("ba76e881-b010-44a2-ac93-c56b28865587"),
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
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
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
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
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
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 161;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 93;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
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
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidArray1M.AssertModel(models[0],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidArray1M.AssertModel(models[0],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidArray1M.AssertModel(models[0],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidArray1M.AssertModel(models[0],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 138, query1, 161, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 15, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
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
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 60, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 45, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 63, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[29],_testData[34], false);
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
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 45, query1, 28, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 129, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[34], false);
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
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 40, query1, 51, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 22, 117))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidArray1M.AssertModel(models[0],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidArray1M.AssertModel(models[0],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 22, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidArray1M.AssertModel(models[0],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

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
                        GuiduuidArray1M.AssertModel(models[13],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[34], false);
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
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 72);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
GuiduuidArray1M.AssertModel(models[0],_testData[13], false);GuiduuidArray1M.AssertModel(models[1],_testData[14], false);GuiduuidArray1M.AssertModel(models[2],_testData[15], false);GuiduuidArray1M.AssertModel(models[3],_testData[16], false);GuiduuidArray1M.AssertModel(models[4],_testData[17], false);GuiduuidArray1M.AssertModel(models[5],_testData[18], false);GuiduuidArray1M.AssertModel(models[6],_testData[19], false);GuiduuidArray1M.AssertModel(models[7],_testData[20], false);GuiduuidArray1M.AssertModel(models[8],_testData[21], false);GuiduuidArray1M.AssertModel(models[9],_testData[22], false);GuiduuidArray1M.AssertModel(models[10],_testData[23], false);GuiduuidArray1M.AssertModel(models[11],_testData[24], false);GuiduuidArray1M.AssertModel(models[12],_testData[25], false);GuiduuidArray1M.AssertModel(models[13],_testData[26], false);GuiduuidArray1M.AssertModel(models[14],_testData[27], false);GuiduuidArray1M.AssertModel(models[15],_testData[28], false);GuiduuidArray1M.AssertModel(models[16],_testData[29], false);GuiduuidArray1M.AssertModel(models[17],_testData[30], false);GuiduuidArray1M.AssertModel(models[18],_testData[31], false);GuiduuidArray1M.AssertModel(models[19],_testData[32], false);GuiduuidArray1M.AssertModel(models[20],_testData[33], false);GuiduuidArray1M.AssertModel(models[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));
GuiduuidArray1M.AssertModel(models[0],_testData[3], false);GuiduuidArray1M.AssertModel(models[1],_testData[4], false);GuiduuidArray1M.AssertModel(models[2],_testData[5], false);GuiduuidArray1M.AssertModel(models[3],_testData[6], false);GuiduuidArray1M.AssertModel(models[4],_testData[7], false);GuiduuidArray1M.AssertModel(models[5],_testData[8], false);GuiduuidArray1M.AssertModel(models[6],_testData[9], false);GuiduuidArray1M.AssertModel(models[7],_testData[10], false);GuiduuidArray1M.AssertModel(models[8],_testData[11], false);GuiduuidArray1M.AssertModel(models[9],_testData[12], false);GuiduuidArray1M.AssertModel(models[10],_testData[13], false);GuiduuidArray1M.AssertModel(models[11],_testData[14], false);GuiduuidArray1M.AssertModel(models[12],_testData[15], false);GuiduuidArray1M.AssertModel(models[13],_testData[16], false);GuiduuidArray1M.AssertModel(models[14],_testData[17], false);GuiduuidArray1M.AssertModel(models[15],_testData[18], false);GuiduuidArray1M.AssertModel(models[16],_testData[19], false);GuiduuidArray1M.AssertModel(models[17],_testData[20], false);GuiduuidArray1M.AssertModel(models[18],_testData[21], false);GuiduuidArray1M.AssertModel(models[19],_testData[22], false);GuiduuidArray1M.AssertModel(models[20],_testData[23], false);GuiduuidArray1M.AssertModel(models[21],_testData[24], false);GuiduuidArray1M.AssertModel(models[22],_testData[25], false);GuiduuidArray1M.AssertModel(models[23],_testData[26], false);GuiduuidArray1M.AssertModel(models[24],_testData[27], false);GuiduuidArray1M.AssertModel(models[25],_testData[28], false);GuiduuidArray1M.AssertModel(models[26],_testData[29], false);GuiduuidArray1M.AssertModel(models[27],_testData[30], false);GuiduuidArray1M.AssertModel(models[28],_testData[31], false);GuiduuidArray1M.AssertModel(models[29],_testData[32], false);GuiduuidArray1M.AssertModel(models[30],_testData[33], false);GuiduuidArray1M.AssertModel(models[31],_testData[34], false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidArrayuuidArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidArrayuuidArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidArray1MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidArrayuuidArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidArrayuuidArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(GuiduuidArray1M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidArrayuuidArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidArrayuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(13)]
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

        [Test, Order(13)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidArrayuuidArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IGuidArrayuuidArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(13)]
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

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((IGuidArrayuuidArray)this).ExportModelInner(connection).ToList();
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


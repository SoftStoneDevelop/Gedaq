

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
    Id = 5,
    Value = 
new System.Guid[4]
{
Guid.Parse("abac39b3-4dd2-44ad-82d0-f92d6e435f45"),
Guid.Parse("1e6a8113-1066-4fae-8d80-e0c3c6854445"),
Guid.Parse("c378a6b8-36a1-4b62-92bb-1d9098cf626b"),
Guid.Parse("c4b35912-359e-44de-acca-b2620efd00d2"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 2,
    Value = 
new System.Guid[4]
{
Guid.Parse("9f5c4887-809e-4013-82ef-6e82bf565c76"),
Guid.Parse("a64de5de-8244-469e-8ba6-7dedabb8ff67"),
Guid.Parse("5f29132c-f0da-49dc-81c8-5ed8e54ba7c2"),
Guid.Parse("c9d49083-24b2-4560-b7c2-e0f31a895da3"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a9520147-93d9-4b71-8ae9-bc5aa39a9f80"),
Guid.Parse("46a444cc-0052-4781-9b7c-491bf623887f"),
Guid.Parse("c318430a-71e9-4d06-9cda-edbbbc13946f"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("88c351dc-24dd-4520-8d37-1e94b6cc7f56"),
Guid.Parse("6803ee0e-8f70-4d3a-b168-0b967cab0e8c"),
Guid.Parse("b51db5c5-468d-4f6e-8925-4c78b6c9ed3f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 7,
    Value = 
new System.Guid[3]
{
Guid.Parse("e16239e9-d107-4281-a949-8f82e2add1bc"),
Guid.Parse("0412d661-3fac-4282-9797-36016273cbe1"),
Guid.Parse("9b6d6b83-ebb1-4fa1-86f2-84ac9ab2e53b"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 19,
    Value = 
new System.Guid[3]
{
Guid.Parse("befad775-c2a1-4d9b-a9b4-5680a77d8814"),
Guid.Parse("238d5c30-36d8-4c4b-a2a4-bab5eaff12f0"),
Guid.Parse("d75e0f59-676f-4f4d-8f0f-8e797d64f2b7"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("e66be534-3eaa-42c1-8edb-4663eb85acf5"),
Guid.Parse("c668e410-f1f0-44d0-ba32-bc9bc1c01617"),
Guid.Parse("9c8f5ee4-d146-4abe-b448-da8257be761b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("54f53bbc-e855-4662-9471-50f0fb263c52"),
Guid.Parse("e1018e24-5546-43fa-9a64-873613ec173c"),
Guid.Parse("d1899076-15d2-4e42-9f6a-ba761bb8360b"),
Guid.Parse("3a430e2d-5a85-4af2-bcfa-c7e9c833b79a"),
},
},
            new GuidMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Guid[3]
{
Guid.Parse("7b721b55-515b-4dfd-a017-c8099dd75ec4"),
Guid.Parse("ff2d2e35-0265-4620-afae-1112b96535e9"),
Guid.Parse("a439d8fe-085d-4646-bcf1-50fcf323c339"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 18,
    Value = 
new System.Guid[3]
{
Guid.Parse("27d7c53e-eb3d-42e8-b784-4f3c42af8e30"),
Guid.Parse("931aed7c-5446-45e1-b59e-82de7c52297e"),
Guid.Parse("3df3aa64-29f6-4c8f-879e-34152a66d4c4"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("17d5974e-cd9e-4e68-8036-d76731e05e37"),
Guid.Parse("464da950-0983-488b-8fe1-7658933dad79"),
Guid.Parse("5f0f5c4b-346a-4a27-a85f-41265a280dfb"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 34,
    Value = 
new System.Guid[3]
{
Guid.Parse("0e03804d-cfc6-4ab7-ac06-06893ff048a9"),
Guid.Parse("568c0627-3fc7-4e92-9bd2-937f059da2c7"),
Guid.Parse("ecfa9c86-d779-489e-8de3-93d9f6d34f68"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 27,
    Value = 
new System.Guid[4]
{
Guid.Parse("c5cdc449-e6b8-44c2-96d2-52e54048716c"),
Guid.Parse("7fed83cb-7a3d-4e67-a6de-a57bd9a550b2"),
Guid.Parse("b62c50eb-4af0-4b5a-94e4-56b82cef9997"),
Guid.Parse("4d163ec4-7395-420b-8fc9-b9887aedb679"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("61dbc686-eec3-4190-90b0-048cd98b73cc"),
Guid.Parse("00825430-749c-48e9-9ac9-afd011d91bca"),
Guid.Parse("a4ad5f67-9522-4cf1-8540-45d6ef1a832d"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Guid[4]
{
Guid.Parse("430a3737-39f6-4ba8-b545-970dfc38a07e"),
Guid.Parse("b2e883d9-fc85-4fa3-a822-530ef576b2d5"),
Guid.Parse("c66ffd16-cbd1-42cb-a0a2-f4580a5c2d00"),
Guid.Parse("4f68a4d3-6e03-41f0-94d0-6c7f920eb75b"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("ff032bed-ecf1-4d93-b827-7c942205575d"),
Guid.Parse("160733ca-b19d-40c5-8fec-90b0a4f06282"),
Guid.Parse("b30629a3-225e-4a5d-8a3d-a907864d7013"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ea8152b8-af4e-48fa-be78-fef73284891b"),
Guid.Parse("079e0d1b-c072-4424-9f9d-63a115d9983d"),
Guid.Parse("843c8f96-5818-435f-9c7e-fab98c9ea611"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Guid[3]
{
Guid.Parse("923e1cc7-ac37-4e2b-b7f1-c5df532f8cdb"),
Guid.Parse("633b907a-81a3-4f20-8f03-1586bca3b787"),
Guid.Parse("c5608fe0-bf95-4538-b116-f702e0cc0d82"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("df967d3c-cff4-46a8-827f-d56fe19a30f8"),
Guid.Parse("d111ab8c-7ba2-442b-88a1-09cd6c08e5af"),
Guid.Parse("a10862a9-1566-40ac-9ed7-df6dd4ba31c0"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 42,
    Value = 
new System.Guid[4]
{
Guid.Parse("4f9abd01-a677-4b97-9753-9b6d92abac92"),
Guid.Parse("4d19ab41-ce23-491b-97dc-e1098168e421"),
Guid.Parse("8340ac06-5e7c-4416-8d87-06f3bee36908"),
Guid.Parse("a505ab98-5e90-4882-8bf9-c014dbdbae56"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 39,
    Value = 
new System.Guid[4]
{
Guid.Parse("d502fa64-2dc9-4a87-b227-34ed6d708d3e"),
Guid.Parse("dcf0a5ca-2221-4796-9c75-8fdb784baac1"),
Guid.Parse("da62a037-8b84-4665-8e84-eee99c10fcde"),
Guid.Parse("8ae48e2b-f4bc-4bfc-b082-abbfe82ad71f"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("50e9dbfa-c8fb-466d-9994-89d97cd84140"),
Guid.Parse("225b8d3c-3ffb-4167-86a9-1f2b7f4a4d0e"),
Guid.Parse("4379c4f9-9e2f-4099-8099-36c621aa988b"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e26ef299-91ef-4aac-acd6-307572848c9c"),
Guid.Parse("7084e2e3-4b46-4329-b52b-bed2dee15ea9"),
Guid.Parse("e3d6d0b0-ed95-4a9a-aed3-34e85d4c4aca"),
Guid.Parse("02c1c5d5-16d6-4905-af00-ad7833261bc4"),
},
},
            new GuidMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Guid[4]
{
Guid.Parse("3e29a283-d71b-4c6a-84aa-81895bb61704"),
Guid.Parse("7480bb7e-433c-4052-aa00-f5b708409ce6"),
Guid.Parse("bb1ce394-161b-4962-b70c-d9f0ca4c4c0d"),
Guid.Parse("106c323f-460f-4d20-b46b-e2b340068e92"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 48,
    Value = 
new System.Guid[4]
{
Guid.Parse("d12ce8e9-d5b2-4114-a1a1-69cdb13f00df"),
Guid.Parse("89d3e4e3-c825-4992-a74f-bec42e7a632a"),
Guid.Parse("854fcda1-d3a8-4a8c-9191-d7dcdccd1249"),
Guid.Parse("4497648d-0c10-4d62-876b-c542002e44d9"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Guid[3]
{
Guid.Parse("2d726ca5-aabc-4314-a419-4c0e78a71b9e"),
Guid.Parse("b24ccb4d-c4be-4f0f-8187-b819d8a14acb"),
Guid.Parse("6dc2ff6f-558f-40aa-825c-6de2c305c9a2"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 52,
    Value = 
new System.Guid[4]
{
Guid.Parse("8c8fd292-635b-4aee-a6e3-26581c877556"),
Guid.Parse("4ef61a26-425c-40b0-8a12-f2a4916fcc2d"),
Guid.Parse("b0c2469d-2d56-42b0-ad60-a455b21fdc61"),
Guid.Parse("dad61536-18f6-469b-8337-41d0a8ab27cc"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 59,
    Value = 
new System.Guid[3]
{
Guid.Parse("2ebeb767-85d1-40a6-89e6-dfbf88662aa2"),
Guid.Parse("6ddfa7ca-48f9-4b88-b1c9-4b881fccb0e5"),
Guid.Parse("cb89db3a-037c-49a7-bd6c-af3f90dd500e"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("566d46e1-f0d6-4774-b239-004ff26a9d38"),
Guid.Parse("82e27fe6-1f6c-46df-8b78-6fafa6df6412"),
Guid.Parse("26d35758-b7e6-4032-874e-6b20cc697f16"),
Guid.Parse("27550165-817a-4752-8f6f-f854472a7514"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("60fdf9e3-6bfc-4a2d-8f44-8e091aa413c2"),
Guid.Parse("6825a88e-e5f7-489c-ad30-01920cf34239"),
Guid.Parse("37aff371-27f0-4db3-a818-5183f0e59f48"),
Guid.Parse("96ffa69e-0926-4324-8562-afddca255755"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 61,
    Value = 
new System.Guid[4]
{
Guid.Parse("f8edbddb-ee5f-4f4f-803c-e9c4e01cca16"),
Guid.Parse("5a6ecdb6-016e-4881-816a-4aae9f3d43c5"),
Guid.Parse("6da0b5ca-6adf-4a05-9575-dcebf6454975"),
Guid.Parse("93fe34ce-2127-4682-861d-58caab7eeffa"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Guid[3]
{
Guid.Parse("38e3341e-c249-4c92-a812-6a1483b35579"),
Guid.Parse("9be47165-a97c-4cf5-bca9-2e6435203ef8"),
Guid.Parse("cf87456f-cd1e-4a83-81d5-57b3f6a7c923"),
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
Guid.Parse("53b2c8bc-de34-441f-83bf-94b1ed52557d"),
Guid.Parse("d9325534-3e29-426f-945a-db932d10e022"),
Guid.Parse("438238f7-ffda-455e-b9f6-d050b3fdbb21"),
Guid.Parse("15604940-7cfd-4251-8175-9ce90ccb443d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Guid[3]
{
Guid.Parse("dbf0d4c3-5a22-44b9-b0f5-bcdc37c397ea"),
Guid.Parse("b4ab5dc6-6682-4de1-8122-e177e71f5071"),
Guid.Parse("111f018a-16d8-4e15-988f-025fa6b18e0c"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 70,
    Value = 
new System.Guid[4]
{
Guid.Parse("f4931b20-58bd-417c-9d11-b6a79b1ebbb1"),
Guid.Parse("a9e170c1-bcfc-4661-a65d-b1b23346a03c"),
Guid.Parse("cc1d99c0-0192-4c5f-82f9-5dbbe4ac457c"),
Guid.Parse("86f89e3e-3ae5-424c-bd20-33b245844e2b"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 68,
    Value = 
new System.Guid[4]
{
Guid.Parse("738d2453-c11b-4d0b-a780-af15559d6f42"),
Guid.Parse("e5eec851-e6a7-4724-9ad6-e166067e7921"),
Guid.Parse("12433605-9bf3-4084-88a4-91f8bed829d9"),
Guid.Parse("06479334-e24f-4936-8072-4d3eebb38252"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Guid[3]
{
Guid.Parse("0729c0bf-cadd-4a73-b3e4-c00585eb128d"),
Guid.Parse("5651b552-f49d-421e-9954-17b6b62c6d9f"),
Guid.Parse("3716cf30-e621-48a3-9281-37bef411177c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 76,
    Value = 
new System.Guid[3]
{
Guid.Parse("0ddf80fd-42fd-4818-9785-34375b65aefe"),
Guid.Parse("fb93ada9-e9e7-456e-95bd-3c6c69531591"),
Guid.Parse("20485be8-9398-45cf-a2a8-b6fe9c406d25"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("447cdc8d-ffb6-4d6d-a9c2-320ace36ef57"),
Guid.Parse("0ca01eb4-03ea-43b2-809c-eea44c413966"),
Guid.Parse("9b3af132-98b2-46a0-ae0f-74c535ab161a"),
Guid.Parse("5e7b5025-9de3-403b-8496-b01f38c5383d"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a5d386b0-c94e-42a1-9f70-07aad06acc9f"),
Guid.Parse("70170674-34ef-40bf-9c53-ff65e1cc35f4"),
Guid.Parse("e54d5b23-a5da-4054-832c-e05b1408aad4"),
Guid.Parse("57eefc0e-e0a7-42af-a064-58128bca82ec"),
},
},
            new GuidMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Guid[4]
{
Guid.Parse("798a21b9-7112-4aa2-9d43-a2fac328295f"),
Guid.Parse("efa488f6-a256-421b-aa22-eb7cb54b905b"),
Guid.Parse("50f57257-c267-417d-a823-c5d0d828e7db"),
Guid.Parse("e95957cc-3b60-482c-b2c0-f4bc8f159387"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 77,
    Value = 
new System.Guid[4]
{
Guid.Parse("37a987c0-3b3f-4e39-99f3-ef72c6754ed7"),
Guid.Parse("e4f83ec1-1971-4d6e-b3ec-ec12acea5fce"),
Guid.Parse("d55e1491-adda-42a9-a88e-293132917583"),
Guid.Parse("3b38ab1f-eefa-491a-95de-a4c931bc75d1"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9d5c7505-dda5-426c-8743-16b4c3973af3"),
Guid.Parse("0536edd5-26a8-4f22-8150-1510c2c12a72"),
Guid.Parse("82c5159e-ad83-45a5-9beb-05351fc6c912"),
Guid.Parse("b2c28f32-5264-4c4b-bc32-a591038cf446"),
},
},
            new GuidMArrayD1E1M
{
    Id = 81,
    Value = 
new System.Guid[3]
{
Guid.Parse("83b190f3-eb0e-4505-8249-ec175e5d5d69"),
Guid.Parse("6174356e-3b20-4edd-bd5b-303f2bc305ce"),
Guid.Parse("f644499d-5d69-40aa-b3b9-ee15f6d3099d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 81,
    Value = 
new System.Guid[3]
{
Guid.Parse("18075e81-d297-42ad-85c9-e6046503790d"),
Guid.Parse("b031b9a8-555e-492c-b258-40e4948b3317"),
Guid.Parse("76a4e8ee-e19a-413e-9e49-6222c889db7b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e6944061-8e15-4772-a11a-7587b24ea113"),
Guid.Parse("c6fc4e69-c505-4fe7-8f87-1f36c0d41c74"),
Guid.Parse("440353da-48ce-45bd-b889-7f4aca355e60"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ba746545-7a96-41c5-9978-5c5d33bba3dc"),
Guid.Parse("6af4f31e-eb7a-4061-94a1-fe44c242102c"),
Guid.Parse("1407efb1-7e04-43b0-b618-e56765a1f17c"),
Guid.Parse("fc0d7b3f-f363-4a9a-ad16-8aaaec3450a0"),
},
},
            new GuidMArrayD1E1M
{
    Id = 87,
    Value = 
new System.Guid[4]
{
Guid.Parse("7090e99f-015d-48c8-a6c6-69d5ebbed5bf"),
Guid.Parse("06effedf-9b20-4d2f-a5f8-f1e9c63d5f51"),
Guid.Parse("130b444d-0190-4387-b9ad-6188d01fa826"),
Guid.Parse("6d64aa8c-a6bb-4865-b962-baf4720fdd6b"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 86,
    Value = 
new System.Guid[3]
{
Guid.Parse("69ba04d8-6038-47ba-84a7-2b5033c5a01b"),
Guid.Parse("67fdb558-d61a-48df-9334-5ec154a90d78"),
Guid.Parse("98b01b92-1b3c-4140-8b12-0dc310d39c94"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 93,
    Value = 
new System.Guid[4]
{
Guid.Parse("c351fdff-f786-4984-ace4-298eb432c894"),
Guid.Parse("1c3ecddc-7fd3-4aea-a6d6-2f900014da21"),
Guid.Parse("72ef5d87-7f95-4dee-8449-b7d54207ee79"),
Guid.Parse("352d3c4c-5855-4523-912b-438a3199c98f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 90,
    Value = 
new System.Guid[3]
{
Guid.Parse("29de027b-3d0f-45d8-ac91-bb10e3836cb3"),
Guid.Parse("dbe807fe-a91a-4a38-af7e-e4ae183e1020"),
Guid.Parse("185431c2-08d6-475e-854d-2b9db9ace0dd"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("c213c204-7ffb-4789-861b-2bff8c6bc6d3"),
Guid.Parse("3ef3c4fc-0c7e-4c6e-b409-7c752b80b5ea"),
Guid.Parse("cde543e7-0f41-4f2e-b65c-7b9d9dc930e8"),
Guid.Parse("99200943-ad6a-4eac-8237-8e9d5f04b51e"),
},
},
            new GuidMArrayD1E1M
{
    Id = 101,
    Value = 
new System.Guid[3]
{
Guid.Parse("b7fa48be-7ccc-4241-8359-54eba9d7b8c0"),
Guid.Parse("0af99cfd-f3af-4f89-b05d-b942d4cc3608"),
Guid.Parse("5b6b109f-5c49-4309-954a-9d031355ba93"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 97,
    Value = 
new System.Guid[3]
{
Guid.Parse("089d3ebe-d34b-42dd-b3e2-529642971c66"),
Guid.Parse("05282f19-4ce9-40a9-a550-385b021c79c3"),
Guid.Parse("054b3851-c11c-40f8-bd0a-bea74983ff2c"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 106,
    Value = 
new System.Guid[4]
{
Guid.Parse("9c351dde-a730-4022-abd3-6eea903de283"),
Guid.Parse("32a26f06-2afd-4994-a406-aa99c9d2218b"),
Guid.Parse("025013df-8a09-46a3-8b50-80e42b28c995"),
Guid.Parse("ce5e741e-46fe-4dc3-89f2-a30d541942c1"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 101,
    Value = 
new System.Guid[4]
{
Guid.Parse("c9ccebad-6cd5-497b-8852-2285a22ecd48"),
Guid.Parse("8b66e201-f520-4857-9aeb-00edfc872c4e"),
Guid.Parse("8da262bc-c28f-4adc-ac75-87555a6daa65"),
Guid.Parse("6fe430eb-83f2-40de-a2a9-bdf1df642536"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5a4c0a6b-a2e1-4463-95e9-5aa05627bab6"),
Guid.Parse("ca92a5e2-5f47-4da9-a625-0a12e0065249"),
Guid.Parse("68ad079c-46d7-4b87-9d54-95ed342679ce"),
},
},
            new GuidMArrayD1E1M
{
    Id = 115,
    Value = 
new System.Guid[3]
{
Guid.Parse("e7cb9169-ba9f-44ca-8fb7-cfd4a854712b"),
Guid.Parse("59a1d53d-cd81-41cd-905f-96eb4cda1bb0"),
Guid.Parse("b9608a84-29a9-4fc5-8e85-624a50ae5df6"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 106,
    Value = 
new System.Guid[4]
{
Guid.Parse("4c7ba3bb-e85f-46f8-baa7-511e45ae0ff5"),
Guid.Parse("d9911a96-339b-4a28-8df9-2ce2732580f9"),
Guid.Parse("2cfa07d8-3d8e-4b2b-afce-bc39846f1d3f"),
Guid.Parse("62930001-3849-45f6-9c31-39e662de590f"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("bd7d0bac-e7dc-43f6-9082-1267eaa32b5c"),
Guid.Parse("bb983ec5-3424-418f-9891-7ce85c1ee40e"),
Guid.Parse("e713ce9c-189f-4c26-a074-329c305bec4c"),
Guid.Parse("b470f976-a355-48af-b4b0-efad02a40937"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ec419ba0-7473-4d90-815e-0380f350f526"),
Guid.Parse("6105b5f5-e0f8-4fe7-a4cd-a0b3a890a29e"),
Guid.Parse("31592aa4-486e-4a27-9ce8-29402f9a45c9"),
},
},
            new GuidMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Guid[3]
{
Guid.Parse("c28ed51b-6bc5-40d2-a369-b302def5d730"),
Guid.Parse("5e9d1af3-6af5-4712-9cd0-0826c31c2f4f"),
Guid.Parse("fe8df30a-713e-40e3-a01b-02b43fd2d040"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Guid[4]
{
Guid.Parse("288057c5-36be-49e4-89d9-99ee55bd5c50"),
Guid.Parse("43b36945-cf31-4be7-a721-8e23d7ce4338"),
Guid.Parse("a7b2df95-64b6-471e-b73e-b806e0a0f8e8"),
Guid.Parse("3b43cb56-aa5c-4cc8-aa10-b6d9f1f426a0"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("064c924e-7a75-4c7f-b652-64896860c71e"),
Guid.Parse("d0ad664f-327d-4afb-8c93-5debb0c7e38e"),
Guid.Parse("d6140e6e-0d95-4d31-84fe-024073d1ad52"),
Guid.Parse("41384195-4469-4149-8123-88de126f9afc"),
},
},
            new GuidMArrayD1E1M
{
    Id = 123,
    Value = 
new System.Guid[4]
{
Guid.Parse("da5d717e-9475-4004-8584-d51cd2b9bb08"),
Guid.Parse("99d18e50-6288-4e42-911d-857b08d8f8b0"),
Guid.Parse("f18bd908-3609-46e9-a5dd-9ffa8b46d03f"),
Guid.Parse("3b54806c-1479-473e-b13b-c76badff76eb"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 121,
    Value = 
new System.Guid[3]
{
Guid.Parse("3c76e238-e4b1-4441-a425-6535b92aeffd"),
Guid.Parse("0a84a4e8-8bc1-4547-9a60-c5d804974750"),
Guid.Parse("93435cb2-8103-4c02-bbd4-8e8424c2595f"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("22abfee8-0bc9-4bf4-91b8-8e0174873bae"),
Guid.Parse("a3193c09-9b72-48ea-bf00-41175a6676e8"),
Guid.Parse("4b980ef7-b94f-42a9-a777-a504ef6d0af6"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 126,
    Value = 
new System.Guid[4]
{
Guid.Parse("c4295992-7ed3-4f32-ae2d-f9eab84593d2"),
Guid.Parse("5f14f142-9d39-4b99-8112-214bccfdd380"),
Guid.Parse("cf95ce45-e29a-492a-9199-936fee4ab6a3"),
Guid.Parse("7d14226d-c5f1-4b6a-bbd8-0c812bb962ca"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 123,
    Value = 
new System.Guid[3]
{
Guid.Parse("96e5d63f-bc5c-4e28-be4c-a821e2abbb98"),
Guid.Parse("862427bd-e8ad-4b57-93fc-abb581510ede"),
Guid.Parse("94f428dd-62a3-4317-91e6-8d8d3cd60b2b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d2c4f25b-fe4a-4200-a8fe-b47a6b6ef106"),
Guid.Parse("bd30829d-5508-40a3-b5cc-29fb10dbb3fe"),
Guid.Parse("cf48943a-593b-44b6-a3f2-d5405c1c71a2"),
Guid.Parse("1de01a3e-e198-4a79-a1aa-485527d7f13b"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Guid[4]
{
Guid.Parse("618b9a95-b021-452b-bfc6-e88e042c3c02"),
Guid.Parse("fa8ccd40-41d1-4235-afac-3de091576eee"),
Guid.Parse("4e4fefb9-b780-4f94-909c-0ecb87529d0b"),
Guid.Parse("ea18c3eb-317d-4785-8e0a-eabb37695896"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 130,
    Value = 
new System.Guid[4]
{
Guid.Parse("d651f232-5efe-4aa6-87e6-a3741e75790f"),
Guid.Parse("cc9f6bdb-7fcb-4ec7-809b-3caabbc9bdfb"),
Guid.Parse("43070ec0-3684-4310-acf9-c35551ae9901"),
Guid.Parse("1fe18b9b-e6fd-4f6a-8bf1-96c49684b161"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2ca738fa-8387-4266-83bd-2ed284ad0fab"),
Guid.Parse("70313b3b-c1ce-48ba-a6a5-6cc11fbeaec3"),
Guid.Parse("742735c3-4139-4d92-9810-8d3fa84d8f03"),
Guid.Parse("0d1ca43b-0882-42a8-aecf-26ae82f1ec1d"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c3f7ef29-8713-495a-a55f-2a1b087ae3cf"),
Guid.Parse("5b6ce245-aea0-4f0d-8f50-1ff00905b912"),
Guid.Parse("a46a2c87-1fb3-4fe5-8677-cbbc6fb491e8"),
},
},
            new GuidMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Guid[3]
{
Guid.Parse("9508181f-dc61-4750-819a-6bd63f72e6e0"),
Guid.Parse("4caff70e-31bf-4004-a24b-f7c28bc95086"),
Guid.Parse("6b3b13b0-251d-448a-b68d-c44ac448777f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 139,
    Value = 
new System.Guid[4]
{
Guid.Parse("cf81a55f-3131-4d8b-8b78-388a2ad681a0"),
Guid.Parse("da6b2cb5-52d5-4757-88ac-3755894aa3a3"),
Guid.Parse("6df0c757-db66-4cb3-b302-19c9fdbac5a4"),
Guid.Parse("eb00fa5a-1fc9-49a1-afa7-7737ea1efac1"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("97488a6c-018b-4ea1-8006-3cacd071d52d"),
Guid.Parse("740c6340-b7c7-4a15-aa69-c7e155213c78"),
Guid.Parse("4fbb8280-53d2-4c38-bc45-cec51ca3db32"),
Guid.Parse("e98522a8-b8d0-4611-b44e-6dda9e1b00f5"),
},
},
            new GuidMArrayD1E1M
{
    Id = 148,
    Value = 
new System.Guid[3]
{
Guid.Parse("10fa3f11-8f46-44a2-b965-e5962e31995d"),
Guid.Parse("dfc9fa89-ae5d-4bcb-8602-30598f75f1b9"),
Guid.Parse("7fc4cd16-ffae-4a8a-93ac-4ce5f6ceff6f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 146,
    Value = 
new System.Guid[3]
{
Guid.Parse("f537fc6d-5e02-40ec-8a75-2b4ced7d839c"),
Guid.Parse("2eb1c4f3-cc8a-4573-81c8-d427627e1f1a"),
Guid.Parse("50852103-294e-4ee4-a51e-ffc5f91bf790"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1dc3557b-2856-494e-b7f5-be82a85c1146"),
Guid.Parse("687c9cf0-e1db-4f55-bc62-d85e5f338f51"),
Guid.Parse("a3ebcf15-f3ae-490e-8264-ee1a8b51d7d2"),
Guid.Parse("ed5e1680-3118-40ae-80d6-37481cf926f5"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 150,
    Value = 
new System.Guid[3]
{
Guid.Parse("98ac255c-bbd4-4169-b11a-dbb8654d0b2f"),
Guid.Parse("09b13319-1852-4f32-aa2a-79b050f5632b"),
Guid.Parse("06a38556-181c-4827-a0fa-ae7d400d5288"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 155,
    Value = 
new System.Guid[4]
{
Guid.Parse("c5969ca5-cfd6-4eaf-be50-a3e81cd7eef4"),
Guid.Parse("bed0e680-f2dd-400b-a7e6-14d08a079d1f"),
Guid.Parse("fb68dafa-649b-4197-8fe8-4d87b96d85c6"),
Guid.Parse("4848a1c7-b9fd-4020-9453-1b1f50c3bb26"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c28eeff1-9d9d-437e-bbc2-9994a5cf6e8d"),
Guid.Parse("5600c4b9-129e-4579-be87-f751394c8dde"),
Guid.Parse("73cfe248-04f7-43c9-a19a-b99ee827759c"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 156,
    Value = 
new System.Guid[4]
{
Guid.Parse("3e339351-7713-4e03-8a8a-76c2b7aaf6d3"),
Guid.Parse("17b2aa83-0a98-4d10-a433-d4e52e9a3239"),
Guid.Parse("a5cb26fd-7a18-456e-997f-dc7eaf353e2c"),
Guid.Parse("2256c2af-67a2-46ed-9715-b409bf224539"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 160,
    Value = 
new System.Guid[4]
{
Guid.Parse("5ad94de1-b095-40ba-ac7b-ecb55b7331e8"),
Guid.Parse("cb0750f4-963d-4ea7-a4ab-425108425afe"),
Guid.Parse("b6f9b865-7421-470a-8e31-0061cd65b6d6"),
Guid.Parse("143397c0-54d4-4365-ba90-a4736192b098"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("67a9f832-7a9e-4dcd-8412-f7f235a35214"),
Guid.Parse("ff25faf1-eb5f-4bdc-b6bf-0840abf25a4f"),
Guid.Parse("e56caded-4f2d-4694-929b-c0879a233b3b"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Guid[3]
{
Guid.Parse("660f2f5c-e427-4a6e-8b3b-ce9587840b2a"),
Guid.Parse("fc748e49-bf36-449f-8595-becf084bf4b5"),
Guid.Parse("da8fb1dc-6692-4e2e-b87a-d9a927fbcbe8"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 164,
    Value = 
new System.Guid[3]
{
Guid.Parse("2be425a5-1b4a-4c54-9d6e-660dbb4584f3"),
Guid.Parse("c9ae4a79-23e6-46a6-ae11-bca71ef8085c"),
Guid.Parse("15cae855-00d0-4323-8f2f-5903f2a0af30"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1a4ed276-55e2-4200-82ff-5a08ca6211f2"),
Guid.Parse("660c55df-0f9a-4008-ac1a-b2f2dc691c7a"),
Guid.Parse("9fc2db60-c3cd-4868-bd9e-505459f4fbd2"),
Guid.Parse("319c0b27-6d7a-4962-96d1-db6c5f818540"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Guid[3]
{
Guid.Parse("a0dcaa1c-76b4-483f-a516-8dad2f502dee"),
Guid.Parse("57f4dee5-fa62-4893-bea1-ed39a4f77e8e"),
Guid.Parse("4bfb6596-3089-4b04-a717-8248f167cd56"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 171,
    Value = 
new System.Guid[3]
{
Guid.Parse("4c9e6075-a63a-4d66-b5d9-1799498897a6"),
Guid.Parse("918c9f0e-6199-4821-b358-08b4f09d0f68"),
Guid.Parse("89218fe0-daf4-4151-b75e-bda744435434"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f35b6c83-8b20-47da-b416-480df2605c46"),
Guid.Parse("cbc8f1e3-8300-4d8c-b8f8-84cb852a8d64"),
Guid.Parse("67cc85db-1050-4cad-b2cb-ce0d45a19e8c"),
},
},
            new GuidMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Guid[4]
{
Guid.Parse("47d7b0d5-28cf-4a08-9a86-bf79518728a3"),
Guid.Parse("0c05db01-59e0-40d1-92d4-e8a28c9d7871"),
Guid.Parse("07d44169-0e0c-4787-a4f2-f9763db1d986"),
Guid.Parse("c2bbb956-0c4d-4173-856b-cffb12cedc62"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 174,
    Value = 
new System.Guid[4]
{
Guid.Parse("17c30ef2-1288-4f93-99b3-7dd25ee41ebb"),
Guid.Parse("17b305c0-3c5d-4396-a818-305940ae27dc"),
Guid.Parse("c2950640-e2fd-4bc7-bedb-52d92771e8fd"),
Guid.Parse("57347851-cd48-43b7-8ae3-aecb835284a7"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("68f0d9f5-0885-4d41-9697-4da02b50b280"),
Guid.Parse("65f68b97-cbda-4aab-bb38-2059f8a6b234"),
Guid.Parse("eecf0c98-3804-42bd-8400-670486f70c7c"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("41cdbc39-325b-4c98-bde3-7563f35a95bf"),
Guid.Parse("58df705a-d88f-40ae-baf8-a9388add582c"),
Guid.Parse("d8369642-05c6-4eb3-938e-77a4614d8f49"),
},
},
            new GuidMArrayD1E1M
{
    Id = 172,
    Value = 
new System.Guid[3]
{
Guid.Parse("74a102c0-bced-4ad1-9794-30052ca76b5e"),
Guid.Parse("b523a08b-e73c-4123-a3bf-1db27f54d56a"),
Guid.Parse("5c65cf6e-3129-431e-8c5b-2e6e06736a1c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 180,
    Value = 
new System.Guid[3]
{
Guid.Parse("87dc53cb-7400-490c-abdd-43e0bd723a4e"),
Guid.Parse("e4eba6fa-65a7-41ac-a459-08eef6cec95c"),
Guid.Parse("99ef9f37-7287-4892-a775-c7b58a5a5cdf"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0b6d0b64-b2d4-4a35-b38e-a72ba0e95e90"),
Guid.Parse("9afa9ae7-49ed-4bd1-8874-e0c018c0a488"),
Guid.Parse("5511eca8-88fd-4658-be01-2e9a46068c65"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("82c6000a-d140-476e-98e8-34f02e34defb"),
Guid.Parse("3cf09053-b94a-4875-a6bd-d3d4d8d7a635"),
Guid.Parse("e84136bd-fa04-4eb4-be4b-d0a6302bee1e"),
},
},
            new GuidMArrayD1E1M
{
    Id = 176,
    Value = 
new System.Guid[3]
{
Guid.Parse("316374fb-a7b3-4ff7-a5d5-ff9e1720ee64"),
Guid.Parse("afb9eb35-62fd-47d5-a8d6-d7d1bd226036"),
Guid.Parse("9d6de25f-f411-4ca0-bb15-daf7664d9074"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 181,
    Value = 
new System.Guid[4]
{
Guid.Parse("87d89bc9-c284-48d0-8fa5-6bb880d306d5"),
Guid.Parse("bf48d4b3-18b2-4df9-a9f7-5f709393fa40"),
Guid.Parse("e345d315-9f70-4452-a48f-25ca3397a800"),
Guid.Parse("336e10e0-cd35-436a-91bb-7135d7a7cffc"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b7ada978-ef52-436d-b062-9403a542e8a2"),
Guid.Parse("ab2344d6-4407-4308-9337-2a7c600059ed"),
Guid.Parse("7e54d2f6-bcb3-4824-8561-9b30e9ee5c4a"),
Guid.Parse("1f327e68-a7da-4fee-9ce4-cbe607c7df74"),
},
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


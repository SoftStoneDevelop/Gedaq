

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2df22403-330c-45d1-885c-816e18bffa78"),

Guid.Parse("81da78d9-11bd-4cf9-a434-f2510c83fdef"),

Guid.Parse("7dace7d8-f2ef-42db-9ef9-bc295bc419f6"),

Guid.Parse("2af7040a-bab6-4220-8b8d-01c810592115"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5e349e7f-da32-443c-8ec4-fd0c9de94d03"),

Guid.Parse("ee174c8b-3e0a-4061-b902-bc7fd0936ce4"),

Guid.Parse("8d0f66c3-e8ec-4458-850d-9d8e106dded6"),

Guid.Parse("fec2723e-9d87-4dce-bb1c-a91db0f3f52d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a43fc41d-69f1-4dc2-970c-9733471eb18c"),

Guid.Parse("e0f5c2d5-2bda-4976-9261-01d11f9bd46b"),

Guid.Parse("c597c69e-a508-4125-ba03-cb7853741220"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c55c1c99-ae7f-4a5e-97bc-a89427cfa49a"),

Guid.Parse("f4eb1186-a1cb-4c29-8314-69642bdba1b2"),

Guid.Parse("22cc00b5-6360-4969-b682-97f903451404"),

},
},
            new GuiduuidArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c8852fe4-4691-4083-add2-0178641b9420"),

Guid.Parse("88751405-d09e-468c-a58b-b45fb588b63e"),

Guid.Parse("45702222-7170-4937-9119-1da4904d6ecc"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("69fdd063-5434-4984-bb74-343d5bb68b43"),

Guid.Parse("24e21f17-20f5-4cd2-ac85-58ef3103a294"),

Guid.Parse("1cedd9c5-051f-4fbe-8bd6-382cb5b90a5e"),

Guid.Parse("6693ebeb-f2b5-4593-b121-17c17e986a29"),

},
},
            new GuiduuidArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("83d50293-b3af-431c-aa96-e3fc5fe40000"),

Guid.Parse("5e0622f8-0c3b-4840-927b-9382b12cc442"),

Guid.Parse("672f04b8-bb4f-4a57-b745-58db37b5d31b"),

Guid.Parse("1830ed74-3b77-430c-aa86-1d6f6332846e"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("31f5ea4a-f1a2-414c-b06b-ba89dd4739b7"),

Guid.Parse("64144308-1de3-4bab-a446-54a2053703bf"),

Guid.Parse("be1783ec-436c-4b7c-b65e-8b0565871b3f"),

Guid.Parse("f11b9ee3-0e69-472d-a5a9-e70a6d9a3e1e"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ed4675e7-349b-475b-b443-08adb9550080"),

Guid.Parse("99b75bbc-7542-4d91-9cce-3fec744ad661"),

Guid.Parse("397651e6-2312-4140-baca-4790ef795dde"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ec29c690-683a-41b7-a005-74fe36b4500b"),

Guid.Parse("cf6b98d2-134b-4bc1-ad03-2064b2940b67"),

Guid.Parse("8c3f0818-bcfc-49c4-a98d-fdc87165c4cf"),

},
},
            new GuiduuidArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6fc0e7f5-7c09-4ca7-895e-5416e6d6cf28"),

Guid.Parse("44774334-b2e3-4977-9a87-ed9790326495"),

Guid.Parse("0136938f-89e8-4197-ab45-d4e27f56f5ca"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("998c7980-98d1-4175-b146-29ad20ea6706"),

Guid.Parse("2ba60fd5-3fa7-4c54-807a-85b4a791ad8f"),

Guid.Parse("b14f5f3c-eae6-445b-88be-2bdfdb13ccdd"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bdebec86-a88c-4cb4-bafd-f04f3b23cce1"),

Guid.Parse("a2b5e247-5255-41ee-8919-748cc42be15f"),

Guid.Parse("5dba1114-d23e-4cde-92f8-7cbbf8ae1cdc"),

Guid.Parse("976136ac-734a-45f3-b758-4f193745ac7a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ed88b342-c998-452e-a776-28ccf6eb0f73"),

Guid.Parse("dd1edeef-c26f-4f6a-a42a-0f305a7b0d84"),

Guid.Parse("09acd7d7-ad76-41ac-aac4-5cdd3b91c19f"),

Guid.Parse("41d872b9-0cd4-4f3a-a034-d173d801fbbc"),

},
},
            new GuiduuidArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("430d898b-e6e3-473d-a430-b62e8feb6b26"),

Guid.Parse("9c502baa-d2b5-4e0d-bffa-892b73cbd555"),

Guid.Parse("e51c8731-7463-4671-9237-603cffb7bc2b"),

Guid.Parse("2a13a0ed-1e66-4f58-ba49-598981d61ce1"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c8b1012d-52f8-45b6-a929-c3ae801b6492"),

Guid.Parse("c4e2a8ff-aa78-4278-ab95-03d633c8192a"),

Guid.Parse("59266d01-6ab7-4dbe-8eb3-e70766c12801"),

Guid.Parse("31098910-123c-432b-adee-6b53eefd3a2d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("24cb42d4-f4b6-4277-89a8-75002489484b"),

Guid.Parse("1295bc77-e20d-45b8-bf94-bfdf9f1782be"),

Guid.Parse("b89d4387-fdaa-4eb3-91b2-caab9d139afc"),

Guid.Parse("2d4abd38-a329-46f7-9554-e62e2a06f0cc"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f10b2081-379c-422e-a387-d11df0f4ecca"),

Guid.Parse("c23f1941-5bdc-4a1d-80db-59ec47993080"),

Guid.Parse("b70a7105-ef81-413f-9fbd-a7337409be68"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f0598aa1-f466-44af-b445-3e2929479f6b"),

Guid.Parse("ac868588-cd18-4c79-ad2e-c99642fcd20d"),

Guid.Parse("fc9b7a49-0eb5-4f73-b2cc-5c585ad0456d"),

Guid.Parse("3f2537e2-8360-4ec8-b8e2-3019a2516552"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9f9fbfeb-908b-45b2-b026-e964c1d98d77"),

Guid.Parse("0361b329-8ac3-4a73-b09c-392946d0934b"),

Guid.Parse("a82ddff0-8bb5-4268-b5e8-69c14da06709"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("716fb9a3-0580-4630-a9f5-de473090be5f"),

Guid.Parse("f7af1771-ffef-475f-bfd9-6c823834a7f3"),

Guid.Parse("560dbd60-77f6-4206-a824-8098fc6b828b"),

Guid.Parse("bd37b085-3e58-4148-91e6-524f0379918b"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("39c1a6a8-5b41-44bf-8f1b-48f3f03e7cd7"),

Guid.Parse("6a56cf66-3baf-4113-a509-e84b8b871fe9"),

Guid.Parse("db8eddd0-1458-454b-bf1c-2e81af285c5e"),

Guid.Parse("0e8a9314-efaa-4982-bbbf-c077481e8227"),

},
},
            new GuiduuidArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0ca76c4f-f80a-4713-ae9a-ac4d2fc02710"),

Guid.Parse("6c6162c6-3de3-4067-99ee-eff627fac7a6"),

Guid.Parse("bfcc14c4-a9bf-42b2-9dfb-3b5920f95e82"),

Guid.Parse("9b5a9980-e4b5-4317-a1d4-41600ca34f00"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ca4fe1d9-cf75-43d0-bd72-7f80628f93cb"),

Guid.Parse("1bde00be-db45-44d7-9663-f7dffb14dded"),

Guid.Parse("edf10119-f953-4bd8-be5b-071a13d52ac1"),

Guid.Parse("d6bf5e10-4a4e-48a3-bfdc-d59c7b15fcc7"),

},
},
            new GuiduuidArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c08f3a25-bb5c-48c9-bfba-2a7850e61f10"),

Guid.Parse("dbd4f380-f780-4c5a-bda0-50d4d005076c"),

Guid.Parse("3b3cc462-5cc4-454b-990f-462132758cbb"),

Guid.Parse("79504bcd-a73e-43ff-b287-4af09a6fbd10"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("268fb6a7-35d2-46e7-8c43-7cfe0e65cb7f"),

Guid.Parse("932f3743-fd39-4598-834a-03aa43519d53"),

Guid.Parse("3e0c9b0c-85e7-43c3-86d1-f50c43f49131"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a6b73086-68ee-43d6-993e-781f83f96657"),

Guid.Parse("0e19eb60-81bf-444e-91c6-70fb1031bf87"),

Guid.Parse("bd73e67c-1564-4faf-99f9-6b905c52ad91"),

Guid.Parse("502aab9c-f575-43f1-ac30-c8f0a5a52b52"),

},
},
            new GuiduuidArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9657cf06-d5f5-4c91-b880-19b9bb40e1e1"),

Guid.Parse("82182b5c-4db6-4e12-86ea-8b3b9f0a3874"),

Guid.Parse("9de15cfc-191d-44ff-89dc-5fc8ac06ca84"),

Guid.Parse("2ea78ec2-5082-4297-aea9-73afbebf8308"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("391778cc-a441-46f9-9d8a-0b401b059f24"),

Guid.Parse("daca673f-0033-42a0-9cf0-740356245c0f"),

Guid.Parse("563c3f97-e440-4912-b30d-812155e9fa35"),

Guid.Parse("5f74cc10-64a2-4609-9456-c1bb8222a6a1"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c7d3dca8-a313-4f50-b2b6-81a1c9e31f02"),

Guid.Parse("48a1d1f7-9da6-4f41-ac10-dcdf89443dda"),

Guid.Parse("b37a03cc-9b32-4337-a5e0-b8f68b598058"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2db5bc1d-30dc-4756-9275-cd20afd3b8fe"),

Guid.Parse("d5aed98c-4af0-4bf7-856a-e85631ddc0ab"),

Guid.Parse("e815fc2d-3fa2-4d55-b008-73971e6cf874"),

Guid.Parse("652b91d2-a3fc-4835-a7d8-44a524478473"),

},
},
            new GuiduuidArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2b5776d7-7c57-454d-b62b-ce8f98d4a78a"),

Guid.Parse("361c4fb3-e06b-4322-a0f9-89114e173247"),

Guid.Parse("07c43525-8a91-46d9-8a41-484000ae36fe"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f5577471-efa2-446f-a527-dbec533a51eb"),

Guid.Parse("fe8eb19a-8973-4b3e-9fe8-27bbd3fbfec0"),

Guid.Parse("ab4de54d-ba5d-43b7-a055-63bb8296f246"),

},
},
            new GuiduuidArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c13f5a62-43f0-42d8-9dca-df2197235b93"),

Guid.Parse("8376bdfe-2134-47a0-acd7-6f14f432c078"),

Guid.Parse("37f9314a-0dd1-4427-bcb0-594521d26550"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a9d2a790-49e8-421d-a7d1-63c7282bb16a"),

Guid.Parse("12e45920-1e7d-4c9a-bec6-14957e0a9c1e"),

Guid.Parse("65ac7dee-9f74-4bdf-b973-b0fdeff15906"),

Guid.Parse("d80d8f9e-64f8-49dc-ae0d-2aba56a46834"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("29751e1a-2fba-47cd-8ac5-ca3535907422"),

Guid.Parse("10dc7152-2c2d-4bb8-911a-3199bb22e0bb"),

Guid.Parse("aeaab43e-672a-4c2a-a46c-af0b85a5046c"),

Guid.Parse("d479169c-d68c-42a6-b6a6-a2075f8baea9"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b5306403-d038-4711-a1a3-509ea8621015"),

Guid.Parse("add7b244-f28b-4fde-90bd-644839258853"),

Guid.Parse("4b0c172a-cd33-4986-9957-35117165f1aa"),

},
},
            new GuiduuidArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6cd042ea-0ed2-42a5-bcbe-c3d33c4716d9"),

Guid.Parse("95c5c915-3ca0-4d6e-b5fc-39eeacd5f5db"),

Guid.Parse("565ec88c-c681-4e6e-aa74-fc509384e26e"),

Guid.Parse("0acdbf7b-fb74-4d81-bc80-2a6c53a37b1a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("61efeaec-2597-4c6e-9865-b356d3781fcc"),

Guid.Parse("12e394a1-afbb-4e52-abe8-5b618417f3c6"),

Guid.Parse("980779d2-e199-43ea-9384-f1094eeb1ad2"),

Guid.Parse("bc3a244c-ae42-44f6-adc1-f717eb80e4ba"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("26a4ec79-5403-419e-a248-5e4f8e74b704"),

Guid.Parse("8a7dc443-f7e2-482a-805e-450a0568e054"),

Guid.Parse("3e1e0a5a-2488-430d-aeec-2d2b8c67d778"),

Guid.Parse("3a1e74ca-18da-4c84-81a6-6bde15e71bb6"),

},
},
            new GuiduuidArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a212fcb8-7cc5-4118-9693-cfb1276f6825"),

Guid.Parse("57a0169a-b44d-4156-9eae-efd4774572fc"),

Guid.Parse("df9d79c7-2092-467a-b8f1-b36b7c26fbcf"),

Guid.Parse("48609e0c-61f6-45d2-92ae-e6ecae6f56e1"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c4348f02-ef19-4028-8340-000ad99c8a3a"),

Guid.Parse("40e9ab98-fea7-4aa6-808f-276f98ff378a"),

Guid.Parse("28d055c2-4787-428c-a672-40683bf2f689"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cf3a013e-9810-4683-9288-c9e249049b65"),

Guid.Parse("33d4b084-89f8-4ece-9e67-c255ac768597"),

Guid.Parse("6c639e29-4eaa-4412-a4b0-6798a9384c6c"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c390c2c6-0547-4e11-8356-3a411d8f7e16"),

Guid.Parse("4febce2f-d4d3-42b3-be38-505a19e50616"),

Guid.Parse("613dc167-1903-4bc9-b9fe-3adaf6dab62e"),

Guid.Parse("887033c0-cd07-456d-82e5-3bb2471c586d"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("10e8b95c-5863-4f7f-b61f-a122a04fda5f"),

Guid.Parse("fe501855-88bb-4d38-8bda-3cc6f791ed01"),

Guid.Parse("95515c27-47ad-411f-bb1a-fcbe945080da"),

Guid.Parse("1f3bc137-d362-4f66-a312-1faee70124d1"),

},
},
            new GuiduuidArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fc07a7c6-b6bc-4c09-8add-beac3ef36527"),

Guid.Parse("95f3212c-e0b2-44c5-a39f-74c78b47f3a7"),

Guid.Parse("4cc61bf0-3ac6-4a77-8ba9-cf8ef1221b5f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c9f433c1-586f-4d49-beff-26a02be6d853"),

Guid.Parse("fc459aa1-6f7f-43e1-9583-ce0da16ce1bc"),

Guid.Parse("40a82b98-0bd7-46b1-bd31-feb34375e82d"),

Guid.Parse("0a26a86b-9fce-4dad-a4b4-aa9a9dfec0f8"),

},
},
            new GuiduuidArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6b5c3ab8-6f69-4f23-85ce-2371d17db03d"),

Guid.Parse("88e3a77e-3753-4f14-9a8e-fcc22e607867"),

Guid.Parse("5747efb2-3177-48ec-939e-394d98f12911"),

Guid.Parse("84e7bf3e-e7de-471c-8cc6-ff87bdc63e9c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d6a82d96-1eb5-4e98-9b2f-bd54b2c36545"),

Guid.Parse("d5afdc89-d069-46e4-966a-40ef9482fd66"),

Guid.Parse("f3b5132e-e242-4d8d-93a9-1b53f775c07b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8c2cdcf3-cec6-4b10-bc1e-ad4057ddeaa6"),

Guid.Parse("26113171-e99c-4891-a73b-c5aa6a25ff38"),

Guid.Parse("e9adad28-1f73-4bb5-a8d0-fc3245ce0fd6"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("10bbc444-e5f3-4f02-89aa-0e20613f6582"),

Guid.Parse("660aacc0-f1d4-428f-b833-24e634ad8669"),

Guid.Parse("c72227d0-5588-4ba5-b3ba-ff5fce9dd094"),

Guid.Parse("61b447b3-df86-4232-ace2-6cc80ba84f09"),

},
},
            new GuiduuidArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0cdd7e4b-af84-42b4-ace9-3004962f6094"),

Guid.Parse("a870546b-9794-4e63-b8b2-1bfb11323513"),

Guid.Parse("d3d7d4af-f4f0-4281-98c2-6aad8471f730"),

Guid.Parse("ee221b4c-4b89-4784-abcf-440266b19305"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("290d328a-8932-485d-8934-e7e07b9a875a"),

Guid.Parse("b73c0f6c-32cd-4404-aaa0-0d1d7523e36d"),

Guid.Parse("3c0d9d66-4315-4b49-b9be-5f8b7dcc61e6"),

},
},
            new GuiduuidArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("26e9d1ba-f7b1-434f-9b39-2d097efd7b50"),

Guid.Parse("b71bce63-bb4c-4b87-abc0-a3c5820aaad1"),

Guid.Parse("d323ba9a-f769-4859-8ee4-dfa70f3f03ad"),

Guid.Parse("d3b8e71b-c586-47a8-add1-0be5db12eb8f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("67798bab-f95f-4152-b1d0-ed0872adc030"),

Guid.Parse("6d0a9f08-7fb1-4fd3-8e47-e998a15b3ceb"),

Guid.Parse("2e5b20c5-2a16-42e6-8e99-7f97f03f5ec1"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b3bf30af-9695-4d14-b63f-da902f2de213"),

Guid.Parse("192cf43d-ce2f-47fd-834e-51e53916e51f"),

Guid.Parse("ed60f8c1-d5a1-404a-af92-1627b2a994bc"),

},
},
            new GuiduuidArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fbd7d39d-1cde-4e3f-a0a0-35ada9dc03e2"),

Guid.Parse("0841317b-6e65-42ca-a73a-6a2cb1f74cce"),

Guid.Parse("b4b952fe-794e-4a76-8c9d-23f5215ed48a"),

Guid.Parse("2142f613-cbbf-43d0-8f2e-819ab32057a6"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("caa2bb13-ecab-483a-a377-2308a48e582b"),

Guid.Parse("83fa36d0-313a-4003-8090-602aaab3479b"),

Guid.Parse("6e0edc88-a584-40a4-b85c-572c6b7c77d7"),

Guid.Parse("07d55f5c-ef40-470d-8984-42dd93a341f7"),

},
},
            new GuiduuidArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("726c48b2-ba65-408d-8eb0-c882bc3ef0da"),

Guid.Parse("69a2c7f6-1ef6-4e30-81db-5adf06e2a226"),

Guid.Parse("ec5a05f1-b6c6-4807-8524-bedb5dc54e3b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5c3ca404-7082-4f3d-bd64-d7ca680d531f"),

Guid.Parse("850c42aa-b9b0-454c-9ca2-c3d091acbecc"),

Guid.Parse("d6639313-6083-4b81-bdfa-2812e438d3a8"),

Guid.Parse("ee75fe57-c217-472f-857a-c60d5ac20ff9"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3358c3f-30f2-4f4e-8ca5-738aa2dceb1d"),

Guid.Parse("00c3df79-a143-4692-9906-59c51dea32c2"),

Guid.Parse("e19f805e-49c4-430a-a541-e1236b2f9185"),

Guid.Parse("aa1aa468-77d3-4732-855c-e4c4b8fc50b3"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8f790557-406d-434a-9ac2-4413536dcf05"),

Guid.Parse("6a9d93b6-fcb4-4357-9d22-bdef8a598bdb"),

Guid.Parse("e2558e3e-a62a-48ad-b193-c4cb1770969c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("496f2dcd-db2d-4345-9320-d8961c44d4b4"),

Guid.Parse("ee2cd69f-4184-4110-a1fc-4295235891fd"),

Guid.Parse("2ffef51b-695c-423a-a471-00a9d1f473c2"),

Guid.Parse("7e4acc37-9dfd-4f93-92e3-f70376cb2766"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9ed1c493-d570-4f62-bdca-049a3d62e061"),

Guid.Parse("a4696cb6-61f3-4da5-84d0-b1b3f0daf0ca"),

Guid.Parse("df28ea1c-d568-4e09-9ad1-2722b580ec3f"),

Guid.Parse("7664683e-40af-49d4-b62b-ac6b38e7003c"),

},
},
            new GuiduuidArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2652fa64-ef8a-4b75-96ea-f35dc38eddc3"),

Guid.Parse("1994ca96-8087-4047-90a5-fb2ab8483292"),

Guid.Parse("4d66994c-d79a-478e-93a1-1f8e3ba47b02"),

Guid.Parse("636ed9d5-4efc-4d6a-b9b2-16ed80fbc8c8"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2d5fa0d6-8475-4e30-8b38-fe55f8991f5b"),

Guid.Parse("0bf87ee5-5b06-4ed1-b304-2539a2b3989b"),

Guid.Parse("5aec4a4c-09b7-4c97-ace6-fe167dc10be7"),

},
},
            new GuiduuidArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("58ddaa29-5468-40af-9f67-48f9a01ef510"),

Guid.Parse("11be9320-79e3-440e-983c-17b44e7c3bea"),

Guid.Parse("9c428558-3728-48b9-823e-bdc5364d8001"),

Guid.Parse("ebf33f82-02b8-4cff-a519-79f0a65ee847"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2074714f-b8cb-4176-abeb-14cac7b33f53"),

Guid.Parse("51d68cbb-e9f6-479d-901d-3b9a84707f14"),

Guid.Parse("61f50811-2806-4cce-bc36-37b9d39ade9b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b350c4c5-feb7-4488-98dd-f33c7d91c0e0"),

Guid.Parse("ca445226-19d6-4059-b73b-009959c2b1f4"),

Guid.Parse("bbf63a26-74ef-49c9-bded-c3cc7001d82f"),

},
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((IGuidListuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((IGuidListuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((IGuidListuuidArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((IGuidListuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[29], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((IGuidListuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
GuiduuidArray2M.AssertModel(models[0],_testData[16], false);GuiduuidArray2M.AssertModel(models[1],_testData[17], false);GuiduuidArray2M.AssertModel(models[2],_testData[18], false);GuiduuidArray2M.AssertModel(models[3],_testData[19], false);GuiduuidArray2M.AssertModel(models[4],_testData[20], false);GuiduuidArray2M.AssertModel(models[5],_testData[21], false);GuiduuidArray2M.AssertModel(models[6],_testData[22], false);GuiduuidArray2M.AssertModel(models[7],_testData[23], false);GuiduuidArray2M.AssertModel(models[8],_testData[24], false);GuiduuidArray2M.AssertModel(models[9],_testData[25], false);GuiduuidArray2M.AssertModel(models[10],_testData[26], false);GuiduuidArray2M.AssertModel(models[11],_testData[27], false);GuiduuidArray2M.AssertModel(models[12],_testData[28], false);GuiduuidArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
GuiduuidArray2M.AssertModel(models[0],_testData[28], false);GuiduuidArray2M.AssertModel(models[1],_testData[29], false);
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

                var models =  ((IGuidListuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
GuiduuidArray2M.AssertModel(models[0],_testData[21], false);GuiduuidArray2M.AssertModel(models[1],_testData[22], false);GuiduuidArray2M.AssertModel(models[2],_testData[23], false);GuiduuidArray2M.AssertModel(models[3],_testData[24], false);GuiduuidArray2M.AssertModel(models[4],_testData[25], false);GuiduuidArray2M.AssertModel(models[5],_testData[26], false);GuiduuidArray2M.AssertModel(models[6],_testData[27], false);GuiduuidArray2M.AssertModel(models[7],_testData[28], false);GuiduuidArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
GuiduuidArray2M.AssertModel(models[0],_testData[28], false);GuiduuidArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray2M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 67, query1, 67, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[29], false);
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatGuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
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
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 5, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[1], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[2], false);FlatGuiduuidArray2M.AssertModel(models[2],_testData[3], false);FlatGuiduuidArray2M.AssertModel(models[3],_testData[4], false);FlatGuiduuidArray2M.AssertModel(models[4],_testData[5], false);FlatGuiduuidArray2M.AssertModel(models[5],_testData[6], false);FlatGuiduuidArray2M.AssertModel(models[6],_testData[7], false);FlatGuiduuidArray2M.AssertModel(models[7],_testData[8], false);FlatGuiduuidArray2M.AssertModel(models[8],_testData[9], false);FlatGuiduuidArray2M.AssertModel(models[9],_testData[10], false);FlatGuiduuidArray2M.AssertModel(models[10],_testData[11], false);FlatGuiduuidArray2M.AssertModel(models[11],_testData[12], false);FlatGuiduuidArray2M.AssertModel(models[12],_testData[13], false);FlatGuiduuidArray2M.AssertModel(models[13],_testData[14], false);FlatGuiduuidArray2M.AssertModel(models[14],_testData[15], false);FlatGuiduuidArray2M.AssertModel(models[15],_testData[16], false);FlatGuiduuidArray2M.AssertModel(models[16],_testData[17], false);FlatGuiduuidArray2M.AssertModel(models[17],_testData[18], false);FlatGuiduuidArray2M.AssertModel(models[18],_testData[19], false);FlatGuiduuidArray2M.AssertModel(models[19],_testData[20], false);FlatGuiduuidArray2M.AssertModel(models[20],_testData[21], false);FlatGuiduuidArray2M.AssertModel(models[21],_testData[22], false);FlatGuiduuidArray2M.AssertModel(models[22],_testData[23], false);FlatGuiduuidArray2M.AssertModel(models[23],_testData[24], false);FlatGuiduuidArray2M.AssertModel(models[24],_testData[25], false);FlatGuiduuidArray2M.AssertModel(models[25],_testData[26], false);FlatGuiduuidArray2M.AssertModel(models[26],_testData[27], false);FlatGuiduuidArray2M.AssertModel(models[27],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatGuiduuidArray2M.AssertModel(models[0],_testData[28], false);FlatGuiduuidArray2M.AssertModel(models[1],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 8, 92))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
GuiduuidArray2M.AssertModel(models[0],_testData[2], false);GuiduuidArray2M.AssertModel(models[1],_testData[3], false);GuiduuidArray2M.AssertModel(models[2],_testData[4], false);GuiduuidArray2M.AssertModel(models[3],_testData[5], false);GuiduuidArray2M.AssertModel(models[4],_testData[6], false);GuiduuidArray2M.AssertModel(models[5],_testData[7], false);GuiduuidArray2M.AssertModel(models[6],_testData[8], false);GuiduuidArray2M.AssertModel(models[7],_testData[9], false);GuiduuidArray2M.AssertModel(models[8],_testData[10], false);GuiduuidArray2M.AssertModel(models[9],_testData[11], false);GuiduuidArray2M.AssertModel(models[10],_testData[12], false);GuiduuidArray2M.AssertModel(models[11],_testData[13], false);GuiduuidArray2M.AssertModel(models[12],_testData[14], false);GuiduuidArray2M.AssertModel(models[13],_testData[15], false);GuiduuidArray2M.AssertModel(models[14],_testData[16], false);GuiduuidArray2M.AssertModel(models[15],_testData[17], false);GuiduuidArray2M.AssertModel(models[16],_testData[18], false);GuiduuidArray2M.AssertModel(models[17],_testData[19], false);GuiduuidArray2M.AssertModel(models[18],_testData[20], false);GuiduuidArray2M.AssertModel(models[19],_testData[21], false);GuiduuidArray2M.AssertModel(models[20],_testData[22], false);GuiduuidArray2M.AssertModel(models[21],_testData[23], false);GuiduuidArray2M.AssertModel(models[22],_testData[24], false);GuiduuidArray2M.AssertModel(models[23],_testData[25], false);GuiduuidArray2M.AssertModel(models[24],_testData[26], false);GuiduuidArray2M.AssertModel(models[25],_testData[27], false);GuiduuidArray2M.AssertModel(models[26],_testData[28], false);GuiduuidArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
GuiduuidArray2M.AssertModel(models[0],_testData[20], false);GuiduuidArray2M.AssertModel(models[1],_testData[21], false);GuiduuidArray2M.AssertModel(models[2],_testData[22], false);GuiduuidArray2M.AssertModel(models[3],_testData[23], false);GuiduuidArray2M.AssertModel(models[4],_testData[24], false);GuiduuidArray2M.AssertModel(models[5],_testData[25], false);GuiduuidArray2M.AssertModel(models[6],_testData[26], false);GuiduuidArray2M.AssertModel(models[7],_testData[27], false);GuiduuidArray2M.AssertModel(models[8],_testData[28], false);GuiduuidArray2M.AssertModel(models[9],_testData[29], false);
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
                var models =  ((IGuidListuuidArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    GuiduuidArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSelectModelBatch(connection, 8, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
GuiduuidArray2M.AssertModel(models[0],_testData[2], false);GuiduuidArray2M.AssertModel(models[1],_testData[3], false);GuiduuidArray2M.AssertModel(models[2],_testData[4], false);GuiduuidArray2M.AssertModel(models[3],_testData[5], false);GuiduuidArray2M.AssertModel(models[4],_testData[6], false);GuiduuidArray2M.AssertModel(models[5],_testData[7], false);GuiduuidArray2M.AssertModel(models[6],_testData[8], false);GuiduuidArray2M.AssertModel(models[7],_testData[9], false);GuiduuidArray2M.AssertModel(models[8],_testData[10], false);GuiduuidArray2M.AssertModel(models[9],_testData[11], false);GuiduuidArray2M.AssertModel(models[10],_testData[12], false);GuiduuidArray2M.AssertModel(models[11],_testData[13], false);GuiduuidArray2M.AssertModel(models[12],_testData[14], false);GuiduuidArray2M.AssertModel(models[13],_testData[15], false);GuiduuidArray2M.AssertModel(models[14],_testData[16], false);GuiduuidArray2M.AssertModel(models[15],_testData[17], false);GuiduuidArray2M.AssertModel(models[16],_testData[18], false);GuiduuidArray2M.AssertModel(models[17],_testData[19], false);GuiduuidArray2M.AssertModel(models[18],_testData[20], false);GuiduuidArray2M.AssertModel(models[19],_testData[21], false);GuiduuidArray2M.AssertModel(models[20],_testData[22], false);GuiduuidArray2M.AssertModel(models[21],_testData[23], false);GuiduuidArray2M.AssertModel(models[22],_testData[24], false);GuiduuidArray2M.AssertModel(models[23],_testData[25], false);GuiduuidArray2M.AssertModel(models[24],_testData[26], false);GuiduuidArray2M.AssertModel(models[25],_testData[27], false);GuiduuidArray2M.AssertModel(models[26],_testData[28], false);GuiduuidArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
GuiduuidArray2M.AssertModel(models[0],_testData[4], false);GuiduuidArray2M.AssertModel(models[1],_testData[5], false);GuiduuidArray2M.AssertModel(models[2],_testData[6], false);GuiduuidArray2M.AssertModel(models[3],_testData[7], false);GuiduuidArray2M.AssertModel(models[4],_testData[8], false);GuiduuidArray2M.AssertModel(models[5],_testData[9], false);GuiduuidArray2M.AssertModel(models[6],_testData[10], false);GuiduuidArray2M.AssertModel(models[7],_testData[11], false);GuiduuidArray2M.AssertModel(models[8],_testData[12], false);GuiduuidArray2M.AssertModel(models[9],_testData[13], false);GuiduuidArray2M.AssertModel(models[10],_testData[14], false);GuiduuidArray2M.AssertModel(models[11],_testData[15], false);GuiduuidArray2M.AssertModel(models[12],_testData[16], false);GuiduuidArray2M.AssertModel(models[13],_testData[17], false);GuiduuidArray2M.AssertModel(models[14],_testData[18], false);GuiduuidArray2M.AssertModel(models[15],_testData[19], false);GuiduuidArray2M.AssertModel(models[16],_testData[20], false);GuiduuidArray2M.AssertModel(models[17],_testData[21], false);GuiduuidArray2M.AssertModel(models[18],_testData[22], false);GuiduuidArray2M.AssertModel(models[19],_testData[23], false);GuiduuidArray2M.AssertModel(models[20],_testData[24], false);GuiduuidArray2M.AssertModel(models[21],_testData[25], false);GuiduuidArray2M.AssertModel(models[22],_testData[26], false);GuiduuidArray2M.AssertModel(models[23],_testData[27], false);GuiduuidArray2M.AssertModel(models[24],_testData[28], false);GuiduuidArray2M.AssertModel(models[25],_testData[29], false);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
GuiduuidArray2M.AssertModel(models[0],_testData[2], false);GuiduuidArray2M.AssertModel(models[1],_testData[3], false);GuiduuidArray2M.AssertModel(models[2],_testData[4], false);GuiduuidArray2M.AssertModel(models[3],_testData[5], false);GuiduuidArray2M.AssertModel(models[4],_testData[6], false);GuiduuidArray2M.AssertModel(models[5],_testData[7], false);GuiduuidArray2M.AssertModel(models[6],_testData[8], false);GuiduuidArray2M.AssertModel(models[7],_testData[9], false);GuiduuidArray2M.AssertModel(models[8],_testData[10], false);GuiduuidArray2M.AssertModel(models[9],_testData[11], false);GuiduuidArray2M.AssertModel(models[10],_testData[12], false);GuiduuidArray2M.AssertModel(models[11],_testData[13], false);GuiduuidArray2M.AssertModel(models[12],_testData[14], false);GuiduuidArray2M.AssertModel(models[13],_testData[15], false);GuiduuidArray2M.AssertModel(models[14],_testData[16], false);GuiduuidArray2M.AssertModel(models[15],_testData[17], false);GuiduuidArray2M.AssertModel(models[16],_testData[18], false);GuiduuidArray2M.AssertModel(models[17],_testData[19], false);GuiduuidArray2M.AssertModel(models[18],_testData[20], false);GuiduuidArray2M.AssertModel(models[19],_testData[21], false);GuiduuidArray2M.AssertModel(models[20],_testData[22], false);GuiduuidArray2M.AssertModel(models[21],_testData[23], false);GuiduuidArray2M.AssertModel(models[22],_testData[24], false);GuiduuidArray2M.AssertModel(models[23],_testData[25], false);GuiduuidArray2M.AssertModel(models[24],_testData[26], false);GuiduuidArray2M.AssertModel(models[25],_testData[27], false);GuiduuidArray2M.AssertModel(models[26],_testData[28], false);GuiduuidArray2M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 31);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
GuiduuidArray2M.AssertModel(models[0],_testData[6], false);GuiduuidArray2M.AssertModel(models[1],_testData[7], false);GuiduuidArray2M.AssertModel(models[2],_testData[8], false);GuiduuidArray2M.AssertModel(models[3],_testData[9], false);GuiduuidArray2M.AssertModel(models[4],_testData[10], false);GuiduuidArray2M.AssertModel(models[5],_testData[11], false);GuiduuidArray2M.AssertModel(models[6],_testData[12], false);GuiduuidArray2M.AssertModel(models[7],_testData[13], false);GuiduuidArray2M.AssertModel(models[8],_testData[14], false);GuiduuidArray2M.AssertModel(models[9],_testData[15], false);GuiduuidArray2M.AssertModel(models[10],_testData[16], false);GuiduuidArray2M.AssertModel(models[11],_testData[17], false);GuiduuidArray2M.AssertModel(models[12],_testData[18], false);GuiduuidArray2M.AssertModel(models[13],_testData[19], false);GuiduuidArray2M.AssertModel(models[14],_testData[20], false);GuiduuidArray2M.AssertModel(models[15],_testData[21], false);GuiduuidArray2M.AssertModel(models[16],_testData[22], false);GuiduuidArray2M.AssertModel(models[17],_testData[23], false);GuiduuidArray2M.AssertModel(models[18],_testData[24], false);GuiduuidArray2M.AssertModel(models[19],_testData[25], false);GuiduuidArray2M.AssertModel(models[20],_testData[26], false);GuiduuidArray2M.AssertModel(models[21],_testData[27], false);GuiduuidArray2M.AssertModel(models[22],_testData[28], false);GuiduuidArray2M.AssertModel(models[23],_testData[29], false);
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


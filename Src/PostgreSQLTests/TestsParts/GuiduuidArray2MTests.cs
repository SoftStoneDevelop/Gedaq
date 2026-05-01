

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8e02ec3e-cda1-4505-9a85-d9f102f14169"),

Guid.Parse("3503d9e0-b078-4a3d-a262-8a3f8a8c05ae"),

Guid.Parse("2ec52c3e-baba-4a1c-96c6-f834aeeb918c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("686f4af7-cb94-4939-af01-1852ccf714af"),

Guid.Parse("63138fa8-3e8b-4356-9a70-ef2cd6199b84"),

Guid.Parse("83afc22b-4b28-4abc-8c7d-f4f77a38ec3f"),

Guid.Parse("79985f7b-f80f-44d2-a491-ac14edb574e3"),

},
},
            new GuiduuidArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f547856f-fbd4-47e1-8a46-a6da41ffe2ca"),

Guid.Parse("ffc06cf7-aeb8-4632-a501-216c7b8e6e77"),

Guid.Parse("1390e160-c455-441a-86c0-261b2c5a4813"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6d67b432-275b-463a-bc14-1fdae0e3b529"),

Guid.Parse("85d4df01-518c-477a-82ba-83f9481859a3"),

Guid.Parse("aa5d440d-9f77-4069-9c80-18fb31a7fa3d"),

Guid.Parse("6f479515-5ba8-4177-9511-b09ec0e62372"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6bf8e2c3-bf7f-46fe-9f60-09cee1636267"),

Guid.Parse("97b920bc-8b22-4851-84f5-9cd8380968f2"),

Guid.Parse("53bcbd42-29ab-408c-b1e0-2b906cb91048"),

},
},
            new GuiduuidArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8c057f72-b54e-4c1a-8189-96ed2a6f6b46"),

Guid.Parse("da1f4179-d544-484b-944a-05d5ae710515"),

Guid.Parse("b5a45a75-2a2d-4225-872b-88c7a81d7218"),

Guid.Parse("e66b9101-1f8a-4de4-a07a-8a7e36257bbc"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("afd97281-8c65-445d-94fc-4a8c1b3ef187"),

Guid.Parse("b20aeb88-bbec-44ab-bc2f-5198842c14a4"),

Guid.Parse("0977a9dd-efaa-4fd5-b013-03aecf1b2d2e"),

},
},
            new GuiduuidArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4c493be3-31f5-443e-a1ec-a4fc38d0eb55"),

Guid.Parse("204195ab-4894-4f67-80bf-a98339d2b9db"),

Guid.Parse("4f7f4b07-752e-4daa-af3f-369b599d0f84"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e42cbb77-7968-479b-99c7-408a297364cb"),

Guid.Parse("e297e749-257b-41db-af1b-6572c0a7d3b1"),

Guid.Parse("0a96786b-3cde-4e78-a87f-da86494e971a"),

Guid.Parse("faf49b7c-c594-4e9d-8594-6ea46a55f532"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("76f95df7-321c-491e-ae03-776e8bb04c04"),

Guid.Parse("716ca1b2-8625-472d-9606-2499a506d531"),

Guid.Parse("9b460bba-e12b-406d-beea-54e6cc059d9a"),

Guid.Parse("933066f2-79da-4158-9f94-338d5cb8b162"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e29df257-4d24-43e8-96a4-2880d649cb4a"),

Guid.Parse("b321c3ba-6274-4362-92cd-ee0248522391"),

Guid.Parse("ebb18a17-c76e-4165-88e7-c6051e7b936a"),

Guid.Parse("63184e16-ddf1-4c00-97b7-9aef01e176d5"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("91aad71b-7d91-4d94-b2ed-d12c956cd270"),

Guid.Parse("5d993f27-b292-4c72-b6f4-9ecf80c30ffe"),

Guid.Parse("96be7e64-5ddd-40ec-ac13-dede89ecf05a"),

Guid.Parse("419b043f-fa7a-4d50-850e-3319cc0349c5"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6bdbec4f-9c6f-48a8-b65c-61aa19b7caaa"),

Guid.Parse("63b6e233-5f6a-42b5-b353-aa3b5f83c79b"),

Guid.Parse("8aaef231-49d7-48a3-a95d-eec2d72e337c"),

Guid.Parse("3781d541-9aab-4158-b53b-4e1922b5df2a"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0c391cc1-f3fc-4a77-9564-c11e1ce13638"),

Guid.Parse("60f2ec03-5259-4cfd-a37d-88ae01ff8e16"),

Guid.Parse("bfb60ac2-7b3a-46b7-aa7d-b3a6e8d48eac"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7910d713-9090-4e83-a831-cb49c09e3eb5"),

Guid.Parse("385a8d1b-9a8a-4537-9d8d-44c677901353"),

Guid.Parse("afaef364-6bd8-4d36-bdce-55e3d934186c"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cacc3cdd-7011-4264-b3bb-ca1a13e26b1c"),

Guid.Parse("6c904cc7-a7d0-4ece-b52c-38a49d51e091"),

Guid.Parse("afe9518b-0e70-43e3-a535-31c171e719d3"),

Guid.Parse("435d9f79-02bb-4942-8347-7a4b47a05fc7"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7babbcc5-784c-44a5-b925-a83338be47e7"),

Guid.Parse("ac14ad47-dc70-46b7-af4a-3d444e842e6d"),

Guid.Parse("f19dfd28-4406-4c20-aac3-a677a782e3c6"),

Guid.Parse("002171ca-6ec2-406f-b6f6-32736427bcd1"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("655cf000-bd0b-4db0-bdad-ba25dac797e4"),

Guid.Parse("373a6d47-37d8-4f58-a40c-4d967b62f434"),

Guid.Parse("1a79a588-5e00-47cb-96b2-480528d88973"),

},
},
            new GuiduuidArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1925f296-50eb-4abd-8714-946cf75e9cac"),

Guid.Parse("0846d5b4-5250-4673-95de-f04ba73b698a"),

Guid.Parse("e95178f3-0429-4e5d-bdea-23dc541e0246"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c4567b5d-17ea-422a-9426-f51fbc989679"),

Guid.Parse("4445c8a1-3938-49e8-a478-d312b904a4d6"),

Guid.Parse("6f33786e-5a8a-454b-a723-93fcb16d000f"),

Guid.Parse("0d79ea14-c4fd-4454-b758-a201b65c98ce"),

},
},
            new GuiduuidArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b3823ba2-5af6-4cd4-913b-53071caae8b8"),

Guid.Parse("da73c3cd-b01a-4eef-b5b3-6c6efb42841e"),

Guid.Parse("e4a14474-40cf-41f8-a002-afde5a752531"),

Guid.Parse("b5d1879f-a486-47b2-ba4c-d06c67a0805d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7ab49bac-f2ea-4427-8f4f-d3dbfb06ead6"),

Guid.Parse("3ae863f1-d54a-4deb-883e-f2061606a4fb"),

Guid.Parse("1a245c88-505f-459b-9149-ccfc666fe596"),

Guid.Parse("7f99125c-5c4c-498a-937c-15210f1ccc9b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1a86d807-fca9-4a0d-8aa9-bb16afa49e7d"),

Guid.Parse("3c0f4265-cf45-4399-9502-35c411fe0eae"),

Guid.Parse("5f2892b2-8e35-45c8-85e7-d6e667effa1d"),

Guid.Parse("9fbd4d43-fed9-41a0-ac36-c999c2717c1e"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("85dae3c8-0619-40dd-a0a0-2ee156a6ee27"),

Guid.Parse("2ba78cde-9859-44ed-bf4e-66e3846840b2"),

Guid.Parse("0cae4b20-9486-41a0-a87b-7797b618e744"),

Guid.Parse("c9e4574a-237a-4a51-805c-f8ad1f50e879"),

},
},
            new GuiduuidArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9185a84d-fdc3-498e-953a-61e3e313c6a2"),

Guid.Parse("3eb3e932-54e3-4830-831d-842325759dd1"),

Guid.Parse("002f5957-5cb0-4a59-9376-556dd00fdb1b"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35ee53fc-c144-4f04-856f-1d9302d3d4a0"),

Guid.Parse("6f8862f8-e626-4d2d-9b2a-771aa11fa6af"),

Guid.Parse("4b52056a-e7f0-4e2f-9145-9309b846d273"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e6ba1043-40fc-43d3-8c7a-377614bb7be0"),

Guid.Parse("da081b2c-56ac-41c8-aef5-cc343c870063"),

Guid.Parse("72f90776-1ae7-437f-95c4-9da0f14130bd"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c6f22b79-adbe-458f-9bae-1b0163d0f1c6"),

Guid.Parse("402798de-c55a-47ae-b158-dbf753514d53"),

Guid.Parse("a2d57e4f-34f7-4be1-9daa-cc109ab865cd"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("911ae628-78e1-4522-9a25-d4d1a9ed7da6"),

Guid.Parse("7ca37bcb-ef33-4917-903f-4fc9d0ae829c"),

Guid.Parse("56116e4f-e557-423c-9ad6-a3e0c8265170"),

Guid.Parse("4cddc2ef-2f83-47d3-9d17-80b27b0d5f76"),

},
},
            new GuiduuidArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("739179bd-ecc9-4334-aa4b-a897269f942f"),

Guid.Parse("3afda10f-d8df-4e7f-9ea8-ce03c5c061c7"),

Guid.Parse("e2054387-49fb-46da-af1c-848162c62796"),

Guid.Parse("67f422d0-36d1-40ea-9445-611e1ac4d997"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4b47bce7-9e7f-4189-91af-fb76d31b4d25"),

Guid.Parse("4903f21b-63c6-4a7d-be68-450c225acd42"),

Guid.Parse("628d6f0e-e96f-47fb-a09f-2c4570b03a0b"),

Guid.Parse("0946a544-e940-42bf-b898-e52193ffd0f0"),

},
},
            new GuiduuidArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b5821898-11f6-40db-9176-8588d4e8f9ee"),

Guid.Parse("d679ad76-75d9-4525-9e86-40b8873965b2"),

Guid.Parse("5aa8f25f-749a-40e5-8aca-8f5c7f8e5b07"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f7790f86-029e-4af5-aed5-fecba407cc36"),

Guid.Parse("0c146ac5-58e5-425d-bee4-059c863e341b"),

Guid.Parse("6b593481-fce8-4dfc-b587-68afd19190bc"),

Guid.Parse("d762cbe2-7b71-44a4-9399-7a8912e49748"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d968c347-10d9-42e1-bfdb-fe23ac38f732"),

Guid.Parse("8defd45c-a753-4797-93d7-80cabab32540"),

Guid.Parse("cd1bb7b9-78e5-4a86-a93d-b0aaa2dc4772"),

Guid.Parse("3275b66b-20e9-4903-b9ae-6bbf3ccac19c"),

},
},
            new GuiduuidArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e06773ea-0d0f-430a-8c09-eaa9ff3883bf"),

Guid.Parse("535ef0b5-b6f2-4a17-92d7-9dbeb285cce7"),

Guid.Parse("1e4bba4d-c532-4d25-96ae-557fdad18823"),

Guid.Parse("be1587af-02a5-466d-a3ea-a42e93b92532"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d9b56652-14b3-4a97-ac25-eb4b02bb1fd5"),

Guid.Parse("7e44db12-4ef3-4441-8aef-94f1f1bb82cd"),

Guid.Parse("5370919f-5789-4556-8ad1-b5bbf96c96eb"),

Guid.Parse("bd97004b-e378-4976-befb-6e2327fd37dd"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f69145c9-2c23-4207-9444-84aefb8dd220"),

Guid.Parse("5bea5594-e672-42d2-8025-2bf3d36bd8ea"),

Guid.Parse("366838ad-06b9-4376-acee-b306cd63a23c"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("510ae75c-e97d-4997-b454-844e07e52d76"),

Guid.Parse("e5205ba8-5281-4ae1-8b12-547fbc72845c"),

Guid.Parse("bc0555c9-7cfd-4a69-a63b-d5b4fd531867"),

Guid.Parse("b9007d69-1140-4527-8590-b0035f0efd85"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ac09e4e8-600b-4f0b-af89-dd65fa8f187e"),

Guid.Parse("90ff3bc2-7fa9-40ad-a04a-b4cdbfa4804c"),

Guid.Parse("ee1179da-21ab-4207-a4dd-1fa66c7d52d6"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("60ae3a4c-2412-4a63-b6d1-419a9500da29"),

Guid.Parse("4056c021-65ed-40f7-8bda-838746dbc6c4"),

Guid.Parse("9350864a-1786-459f-90f3-2529d248e56d"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("97f43de2-fe89-435a-9174-1247ca1cbad2"),

Guid.Parse("a2ce5ca0-3cdf-42c8-acda-cf0832b0c51c"),

Guid.Parse("a2045bdf-aa35-45c5-aaea-bb7f2af82210"),

Guid.Parse("e97a0c7a-73f4-4424-970a-e15524005959"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9c6bbeb9-ced5-4682-9db3-88ec46e8c38d"),

Guid.Parse("d737f9a6-169a-46ba-bf33-33c0a1b1ba2a"),

Guid.Parse("56bea050-464c-4d3b-bc69-bc1a732675c3"),

},
},
            new GuiduuidArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("591384d0-e980-4702-bf53-fac608ecdd1c"),

Guid.Parse("678216f2-3a90-471c-9c9d-1e455856902e"),

Guid.Parse("8fb9391a-5898-4c3c-86cf-12d3d281043a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("42a7a40e-920b-41ee-9b69-60157c178b66"),

Guid.Parse("afd8d51c-e99d-460f-bffb-f56dc378a13d"),

Guid.Parse("021ee468-5200-46cc-a91d-b8ed5817b8ae"),

Guid.Parse("1ec4702b-dfee-45f4-b0ab-84b115bfad98"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("adbc2592-0e60-4891-9078-f7ff659c3c7d"),

Guid.Parse("caa1b1b1-6f55-4d9f-8745-4225daef8e19"),

Guid.Parse("9a57ef79-f585-4c68-bdc0-8418595a5c94"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d8f6ae6b-e18e-4c91-aeea-1a4d64a8aad8"),

Guid.Parse("d0c495ec-fe71-469b-ba9b-162c6b1a0c5f"),

Guid.Parse("a4240a1d-0826-47ed-b6ed-9d24dc346d3e"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("404776ff-7c2e-46f0-93e1-6967fa12f479"),

Guid.Parse("894b196f-b36f-463d-8ba2-0e31cb768072"),

Guid.Parse("382e6802-426d-439a-86b5-5d07dc4fd1f6"),

},
},
            new GuiduuidArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("44b89fee-ebd4-432f-a4a3-2783be01af46"),

Guid.Parse("81f136a1-b3c7-46b3-a864-c9b5e2fe0b9f"),

Guid.Parse("1a5a8bdd-fbf4-4f36-bfbd-fad079801cec"),

Guid.Parse("be20165b-bc0f-4ba7-9040-10726b524f7e"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fdada047-f294-4e43-9f72-322a28d3bcac"),

Guid.Parse("46b2e8b9-19d6-45ce-bb35-71785e4430cb"),

Guid.Parse("a01141ab-ff6e-4d22-86e6-5a816971477d"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7f43b7ad-0bb6-4819-a29b-0e6af78ee9b4"),

Guid.Parse("178e9d3e-e51a-465c-9a69-a868c24a146b"),

Guid.Parse("ebbe874a-4b12-44ce-9242-d9c2c08de63b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("02ddedb8-18a9-4bb3-8dd3-3042d446c1bc"),

Guid.Parse("676cb5fc-02fd-4b39-be82-e990af0df36d"),

Guid.Parse("15586583-333e-480d-b024-60a907a8d02d"),

},
},
            new GuiduuidArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5476f44c-37e8-4ad7-9eea-543972e41613"),

Guid.Parse("cf76bc98-57dd-4c31-a02c-0b95b7345d65"),

Guid.Parse("b9b6dc50-d4f8-4adb-aaa7-577a8c686379"),

Guid.Parse("6fe268cb-1bfb-49d8-b8ae-d0a7324bbe48"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("76083bd8-179d-48cd-8c0b-137ea81cd64a"),

Guid.Parse("3ecd7f0a-81ef-48a6-a1f9-38353d4b5ef1"),

Guid.Parse("dcdc4897-00e9-46e5-9733-6f349fe769c7"),

Guid.Parse("1df716eb-5399-4b14-ad0b-02d222e26285"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c02c92f6-1f37-4340-a927-c381de69941b"),

Guid.Parse("18c705ac-e157-48b0-9f71-3a7b4446cc80"),

Guid.Parse("6425a3ca-cfdd-4fdf-9659-ee72a8f2cf95"),

Guid.Parse("f8755176-a3c8-414c-bd71-80ada15fab77"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("89c161ce-9713-4ecb-9d55-08982db701fb"),

Guid.Parse("264391f4-ace9-4bdb-96fe-1a320a1ff77a"),

Guid.Parse("1ec1f6c4-32fc-40cb-af25-3c9f8c5e9b46"),

},
},
            new GuiduuidArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("dce55761-b754-4087-862b-513721219b0c"),

Guid.Parse("9d5c1dc8-d66c-4adc-b26d-5b626658714f"),

Guid.Parse("7240d25d-3dd4-4799-9e9d-1f5efa97f252"),

Guid.Parse("932c8b84-17c9-44e5-ab34-4bae763e963a"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cc39ee5d-5bee-4948-abc7-057d932931ad"),

Guid.Parse("9368c649-0929-4dc4-8d06-10bf691da1d6"),

Guid.Parse("f934232a-75ca-4dfe-ba83-7851d1df667e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3e0af50a-8d46-4553-abde-db16b0d35ae9"),

Guid.Parse("c6c3310c-099e-4c45-9695-bb6b30c12b43"),

Guid.Parse("d3556f18-3372-46bb-94c8-0cedd7736a8f"),

Guid.Parse("67dbb407-3176-498e-9063-353dcd1df924"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9c85835d-9bd8-4344-8a44-e68ace5284bb"),

Guid.Parse("7a033bde-7926-4a1e-a941-0870a2daf52d"),

Guid.Parse("68245559-11b2-4d1f-aeef-7dac8397dc29"),

Guid.Parse("00683ee7-b22a-4b6b-8a24-2c01f58dc937"),

},
},
            new GuiduuidArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b902c54f-577b-44d0-b83e-c3430110585c"),

Guid.Parse("0900766e-d3cb-4add-a1bc-9bcfa676ffa6"),

Guid.Parse("e15a0d04-c4ad-4a81-8889-425d4a5f7937"),

Guid.Parse("7a203ab1-d6a6-4fb7-b7a1-aa4ff0b0cba6"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("59ad93a1-8c41-49cd-a269-528d4fb9a7ea"),

Guid.Parse("65fc5ac4-3063-43cb-94d0-79fa4ccf30be"),

Guid.Parse("dd6c094d-6f31-410a-b38c-cd5317856319"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("db58bf75-e4ba-4f3d-bb1d-dbe2c0b08536"),

Guid.Parse("900fd74d-8927-4fd4-8489-55f5697b3748"),

Guid.Parse("c374607c-2685-4623-a7df-30e063e27f34"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f2a12342-f0f2-49c8-9ea7-2ec566f20f0c"),

Guid.Parse("61e3f5ef-1505-4bde-aa62-aad5ac50c709"),

Guid.Parse("08508330-f8d8-4815-b367-173e0c6ee079"),

Guid.Parse("6d07971a-c73f-4cb7-b34a-30a353abccb5"),

},
},
            new GuiduuidArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cb55220b-3161-44ae-93e6-c86548ad4b01"),

Guid.Parse("8ea4ed90-369d-461b-a4d6-fca3701ccf5d"),

Guid.Parse("d2a2e238-8b22-49dc-81ff-fb8d7c90bd79"),

Guid.Parse("902114ee-ece0-4c6c-a6ff-dfa7d49c33d5"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f3a4ac54-4cdf-481b-ac4b-ec28c91defe1"),

Guid.Parse("596eb2c2-7f3b-4c4a-85a2-a2a8c14ad807"),

Guid.Parse("e28fe975-7430-4505-a812-2b41f61afc8e"),

Guid.Parse("99a77647-8265-40cd-a59f-78c3e7b82b7e"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("69394511-2480-49da-84b5-549dd659eec4"),

Guid.Parse("5d2cf10a-dff5-4543-88bd-a430af24e667"),

Guid.Parse("9a4d2451-6914-4cb3-a978-33b3ab2afcef"),

Guid.Parse("f20af45e-0e1f-4e7c-b1e5-4fdc52646ac6"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dac4715d-76ae-4dca-a450-cc6ed96a54e0"),

Guid.Parse("366d66a6-791b-40b1-9586-f05a56f1f74e"),

Guid.Parse("3c8db843-9873-4512-8721-a621a8aa814b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("07b02454-ba70-4aaf-a8f9-cfb47f42a7db"),

Guid.Parse("143eb692-596c-46fc-b5ce-9f1effce2478"),

Guid.Parse("9b2710d4-8df4-46e3-ab5b-ff37428aab49"),

},
},
            new GuiduuidArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("aadd6e75-5cb7-414f-a1dc-ffd5532e1860"),

Guid.Parse("0c898aad-183b-4004-b2e4-4a049665e045"),

Guid.Parse("55e4321a-486a-4f47-a1ae-a960ac8b8377"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fdbe6a91-bf63-45a3-8392-778e6d3c6701"),

Guid.Parse("7fa5a57f-edf1-44f5-87a0-afea84c95c6d"),

Guid.Parse("87be8eac-4d18-406a-8ba9-04beacd7a3b5"),

Guid.Parse("434ccea6-f385-4f2e-b21a-baa5bb49551e"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("90f98fd7-8acb-43e6-87b2-d59fd48d6e93"),

Guid.Parse("a5ad11ff-1a1a-4cd5-9197-5e9a9ecda687"),

Guid.Parse("898cf6cd-b638-4f82-b68e-132c57125a37"),

Guid.Parse("730ba5d4-5620-4b3b-b44e-39f60239a793"),

},
},
            new GuiduuidArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f97e6f35-bbc0-44a9-a5ae-c2ae57b3909c"),

Guid.Parse("bb416d62-74aa-4398-bf44-d1ea921d2f77"),

Guid.Parse("f0801c11-8578-4f57-af7f-7fc751df6c9c"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3356ec9c-3b51-4942-b0f9-1be605fd7c76"),

Guid.Parse("5d12c451-0f34-4bdb-91af-0ea36023b8f4"),

Guid.Parse("18a33322-ecf8-40f2-bca6-3917301394fc"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb446fb5-7486-4676-b907-e5cce141d1f0"),

Guid.Parse("ef32ca5a-5344-41ac-b8ce-5ad8dfa5b735"),

Guid.Parse("35a28b57-ddc6-4c77-830e-26c298dc9020"),

Guid.Parse("825e4f0a-679a-4028-9d81-75d9fd7af3b9"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f569cb47-5943-4b8e-9a4c-0119771e6504"),

Guid.Parse("c8c1ebe6-f032-4465-968e-34515686ba9f"),

Guid.Parse("b8642926-f6f1-4534-853b-d654fea3b113"),

Guid.Parse("7383c809-6351-4e14-8967-c60bbeefd918"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e5e0599f-8e7b-4aea-be8d-0d6b383b4021"),

Guid.Parse("9dbf088e-3990-41de-9525-93f017e54caf"),

Guid.Parse("8a3a8b77-5b38-4653-8fc8-c535cfda9a99"),

},
    ModelInner = null,
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 107;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[34], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
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
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[34], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                        Assert.That(models, Has.Count.EqualTo(33));

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
                        FlatGuiduuidArray2M.AssertModel(models[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[34], false);
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(28));

                        GuiduuidArray2M.AssertModel(models[0],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        GuiduuidArray2M.AssertModel(models[0],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 123, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 43, query1, 107, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 93, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 40, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 115, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 103, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 140, query1, 43, query2))
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
                        Assert.That(models, Has.Count.EqualTo(25));

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
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[24],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 22, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 51, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        GuiduuidArray2M.AssertModel(models[18],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidArray2M.AssertModel(models[0],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 116, 36))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidArray2M.AssertModel(models[0],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        GuiduuidArray2M.AssertModel(models[0],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[34], false);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));

                GuiduuidArray2M.AssertModel(models[0],_testData[4], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[5], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[6], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[7], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[8], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[14], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[15], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[16], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[17], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[18], false);
                GuiduuidArray2M.AssertModel(models[15],_testData[19], false);
                GuiduuidArray2M.AssertModel(models[16],_testData[20], false);
                GuiduuidArray2M.AssertModel(models[17],_testData[21], false);
                GuiduuidArray2M.AssertModel(models[18],_testData[22], false);
                GuiduuidArray2M.AssertModel(models[19],_testData[23], false);
                GuiduuidArray2M.AssertModel(models[20],_testData[24], false);
                GuiduuidArray2M.AssertModel(models[21],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[22],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[23],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[24],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[25],_testData[29], false);
                GuiduuidArray2M.AssertModel(models[26],_testData[30], false);
                GuiduuidArray2M.AssertModel(models[27],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[28],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[29],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 103);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                GuiduuidArray2M.AssertModel(models[0],_testData[22], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[23], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[24], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[29], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[30], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[34], false);
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


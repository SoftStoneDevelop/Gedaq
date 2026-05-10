

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2b71e0fc-34f3-49e6-b6c9-609a16b7ec1e"),

Guid.Parse("0697fac4-8fff-45c8-b138-afe6e10a5ab3"),

Guid.Parse("d2c22a26-030a-41c7-a46f-319384dd8221"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e7d3c1ec-7234-43fa-8856-7a0c6d7ec19d"),

Guid.Parse("8d47d817-dc89-4353-b10c-e303b1136d7a"),

Guid.Parse("dc5316e5-40d2-49f7-bb9d-d04f336e67dc"),

Guid.Parse("c3ab8de8-4b26-4a67-a063-311632b20c19"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("90c4cb4f-d716-476b-bce1-c18511492974"),

Guid.Parse("a8b67ee6-7660-4e70-b25f-bb41feee81d6"),

Guid.Parse("401a44ab-7a9f-488c-93f1-9b8a8a11407d"),

Guid.Parse("3b5d3c4c-e9ab-4112-a3d2-c95e13f41fb4"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4867e083-e096-4d26-b50f-29cacba2142c"),

Guid.Parse("f0a41246-c896-4aa3-b262-42db548dfab6"),

Guid.Parse("9a0cde8e-c37e-4239-803e-b055d3fbb5b2"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5be30fef-140d-4090-b063-65e8732457f5"),

Guid.Parse("1781d23e-481d-4d1e-9105-f6aa2c10d8cb"),

Guid.Parse("405c9c27-7f67-49ca-b166-f2fa86ef06bf"),

Guid.Parse("7bd41fc9-6701-408e-8c1b-a1e4d74a4ecc"),

},
},
            new GuiduuidArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("76213fb2-a1db-4c54-9b8b-22dc66266fa9"),

Guid.Parse("2b811f16-7c07-4106-850a-de6aee7cf633"),

Guid.Parse("fa5f159c-5c72-4c1f-b9da-b0c7b63a9281"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f81eb896-f7fe-4167-8ede-1969aa50cbda"),

Guid.Parse("ed7e2801-296b-4fbb-a376-2782792a39cd"),

Guid.Parse("27b03a05-b25c-470e-a24f-75b869831aec"),

Guid.Parse("e8134e57-4cdb-4dd0-8a39-df15fd2c85ea"),

},
},
            new GuiduuidArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5cebce29-d381-4ff9-b8a5-aa1d0df2ff65"),

Guid.Parse("f3316d03-7cba-4c19-b8a1-80924f97fdd5"),

Guid.Parse("681c151e-d349-479c-b4ad-81157456e5d9"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c6ffa681-feb3-462f-b3c2-53a1d240030c"),

Guid.Parse("ea1ee827-d95d-4b23-8793-38577dc8798d"),

Guid.Parse("ba3ed57f-53cc-4cc2-9f9d-43e5d96974bf"),

Guid.Parse("fb09e1c1-ace6-476b-b4c3-1e8313b734d5"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c80ec6df-9bdc-4388-9697-56f6796a655f"),

Guid.Parse("bd3b2594-0f90-4704-ad52-0a720a606eeb"),

Guid.Parse("d28320d7-a2e9-4535-85b3-9299b0ebe898"),

Guid.Parse("3d56618a-76fa-4877-a49c-43b33a907d78"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c2db98b2-6579-4497-818e-3b8ec2a6df50"),

Guid.Parse("54e8b5a7-c60f-4378-9907-7b3644126e23"),

Guid.Parse("cfaa1074-f2f2-4bd6-8554-f4e9d889639c"),

Guid.Parse("f6067f92-66b9-4460-97d5-8815f85339ee"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a5cc6985-ea2c-495f-8ebf-11cba8dd0bff"),

Guid.Parse("d36f0edf-c0e3-4d4f-ae28-7a95af634835"),

Guid.Parse("654116ca-87c0-488b-80a6-36395a82165f"),

},
},
            new GuiduuidArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5ea65286-0ea3-402b-a497-e902c8990465"),

Guid.Parse("16276384-1b5c-45c4-8c6c-082e5bdea5c2"),

Guid.Parse("819a9467-39c9-4c56-9a6c-00b2813f95c5"),

Guid.Parse("8d1b20d9-a855-49f6-865c-eecc9e3b734b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("994a05ef-d4a6-40b8-b6d8-b2c1bb6e6850"),

Guid.Parse("0ae21a40-aeaa-4c76-802d-ccd87335f351"),

Guid.Parse("fcb8c5df-a5f0-4487-90a6-7898a8f2d740"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("704c2cdc-243b-407f-9fb9-5a4ec3ff3ee1"),

Guid.Parse("2affb97a-33ea-4e3b-a5d8-40258432e715"),

Guid.Parse("4265bf54-03c9-4c0f-86a1-3670e5736d17"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("491056eb-1ce9-4680-98da-3af4a615a7a5"),

Guid.Parse("c999ea56-ab67-435b-8854-d418628475a4"),

Guid.Parse("f762996d-960e-42ac-b8ca-97c7bb0d845c"),

Guid.Parse("3cb84511-67ac-4619-a729-3674c6167339"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("acb42e5c-09e5-4324-b848-fbf5a769d777"),

Guid.Parse("1ddcad8a-5766-4044-9f6e-2e8b09210972"),

Guid.Parse("7f743aa1-cc7d-45ec-8a91-a1c8a94ca6cf"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("46df4518-b0b2-4cee-a433-abb2593831c6"),

Guid.Parse("0b431108-6671-46f0-a424-5ab179ad4c46"),

Guid.Parse("6748c9c8-d8b2-41b8-8179-74f42c29133f"),

Guid.Parse("d4dcf195-28a6-4164-8373-aa8c116aee6f"),

},
},
            new GuiduuidArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("28c1cf3f-5003-4ab4-ac57-374509ede96c"),

Guid.Parse("6ff5cdd9-9398-4102-a209-0e317d4a1e7f"),

Guid.Parse("9cfce63c-6cdd-4622-91df-d0e641c2e4a7"),

Guid.Parse("399c1d17-c8e2-44d9-bca7-bf8f119d794e"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("aaafead3-1707-4e18-8efa-abb2821c702c"),

Guid.Parse("91afe1a2-ff50-4599-a6d1-3c7fd7bf353b"),

Guid.Parse("c586f368-34c3-4738-91f3-c50e8571f621"),

Guid.Parse("aec1e853-d121-4d88-9f87-066c582659cb"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9a531ac3-d05e-4e57-9645-501cf6884741"),

Guid.Parse("fa5c9158-e774-438e-8344-9c1f3cdf4acf"),

Guid.Parse("6de71615-ebb5-4938-97ab-e6217b750f1f"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8f4b75c6-00e3-489c-8f64-71658263dac2"),

Guid.Parse("1f41e0e0-d746-45c0-8b17-42de246ac927"),

Guid.Parse("c19836a9-51d2-42a3-b400-49ff97d297ef"),

},
},
            new GuiduuidArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8a256bdd-dc0c-4eca-a937-e744688af212"),

Guid.Parse("bc49882b-1f40-4003-aed6-5ccc80573aa5"),

Guid.Parse("e817d679-4c9b-4c9c-964d-9e7d5a428035"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("110c6ac0-5c59-479b-9900-17d48d8ddfcc"),

Guid.Parse("6362023e-f72b-4d4b-baf1-8d73f689ef5a"),

Guid.Parse("54a01638-4fd3-48c9-9811-baebd1dd71a9"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9324b3df-7185-45bb-a24c-383620812ea3"),

Guid.Parse("14454cf1-892e-4dea-8c8e-077ac4dedea0"),

Guid.Parse("5bc46b69-bab6-4810-a86d-ea0cc7f83b5a"),

Guid.Parse("379185d6-b339-4fb9-b972-668599644ec4"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a95f4000-607b-4223-bd21-d6d14f26c73c"),

Guid.Parse("a196efce-adb7-4275-bfec-b90176dd32d3"),

Guid.Parse("55f8a1de-a6c1-4d23-ae09-b77a2382a625"),

Guid.Parse("3c706bf6-cf3b-4c95-9cd0-7df59928dc5c"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0a7f20c1-1d72-442f-be9f-bfde99222137"),

Guid.Parse("81a7dca7-9553-4048-9b1e-cb3bf2a7d82f"),

Guid.Parse("e3944b5f-46a7-49b1-a31e-1edb9331d7af"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3b439851-dcc9-4be6-812a-3ae1a92fe965"),

Guid.Parse("f4406614-ab53-47ac-8853-e3cb268ef00e"),

Guid.Parse("e768137d-841f-4d39-b436-ec91a17d0b45"),

Guid.Parse("b71d849e-b74f-4920-8d09-1114f2ecca18"),

},
},
            new GuiduuidArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0ee1d44f-bd92-4f6d-a69d-6d6688d160ae"),

Guid.Parse("c9bb3ba3-563c-488a-8192-e0ecddcdff40"),

Guid.Parse("d43c4bb8-f741-4885-be8c-adcbf9c7a5a8"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("51b29d0b-1722-4c75-8805-aa63ce53bcdf"),

Guid.Parse("8849d833-56e3-49c7-92d7-8cf720c127c6"),

Guid.Parse("16b37125-bfc2-4b18-8158-e3631bc29a1d"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d98e2a72-1b6d-480b-9866-56361122e7a7"),

Guid.Parse("fd27ffbb-7820-41d9-b53c-953facf9f231"),

Guid.Parse("b7a693f9-00d6-4646-839f-3a870da11d8e"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("00b33ac7-985d-4e47-8d2a-b8a410f1f208"),

Guid.Parse("ac3af93c-fe95-41d7-965c-2a7b79e81351"),

Guid.Parse("8dd176fe-930f-4920-94f3-38c3e67691f6"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3a60c9a2-4c07-4b63-befe-8ed1871f4211"),

Guid.Parse("2bfbf8b3-99b9-4a0f-bad2-3ef2d971d4be"),

Guid.Parse("f39c12c7-4dbe-4045-a26a-f831c55f5516"),

Guid.Parse("e6c454a7-1467-4f83-89dd-d0768744848a"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("182bcf76-1a63-4f37-b302-f12b63117b23"),

Guid.Parse("bb03d31f-c5c5-4d1c-886c-a87e8f5a65f0"),

Guid.Parse("bd438020-2f22-4777-81ae-c1194da61955"),

Guid.Parse("3837c11f-e8e5-44c1-b2b3-a99ae7924ed7"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41fd9466-15b5-4bb2-badf-c12b77f69ca9"),

Guid.Parse("c09d2c5c-526b-4c95-a15c-6609253ee9b8"),

Guid.Parse("15242562-6f82-4d41-ae07-71991f6e31b4"),

Guid.Parse("49b848f5-0c14-4544-b781-5276633b3895"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("644b21c7-e514-41e6-8046-15230dcce80c"),

Guid.Parse("d3bff0a6-4a19-4a25-81a7-9c6ea0561c37"),

Guid.Parse("1a8dcf5a-e17b-4b73-a212-ca732aefb14e"),

Guid.Parse("4966aa94-cf1f-4734-a844-0f4745e8f0c3"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b1c44bd5-9e87-4109-a437-43c2bf781427"),

Guid.Parse("b23d2110-8119-4957-bd09-6b5d5c8367cc"),

Guid.Parse("b4585e34-88fd-4a0b-a39b-063de5df3af0"),

Guid.Parse("111bbe23-3d48-4788-8234-21410784a4a6"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("14befcac-dfda-47dd-8d0e-f5c5f72932b9"),

Guid.Parse("7cc412ce-a34c-457c-a0c4-2cbd06f10d87"),

Guid.Parse("0d95ad54-719c-470e-a563-84e09843d837"),

Guid.Parse("cc279a8b-c09f-4a39-80fe-d9b1c5955ac9"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("39e1eca9-ce35-4ed6-99d1-275b7da545d1"),

Guid.Parse("a951fb22-9a43-4eb6-a5c1-6b61b4f15db6"),

Guid.Parse("81bedba2-392c-4ac7-bd9e-f8f7575d0fcc"),

Guid.Parse("c5440b7c-e414-4abd-9e4b-ea81cdb20ff3"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6c508480-aefc-451b-8260-b622cb993123"),

Guid.Parse("9a9aea1b-b148-4138-847b-d00e11e1eda5"),

Guid.Parse("35608aa4-42e0-4649-8b66-e3f2511b9340"),

},
},
            new GuiduuidArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e119bbc2-dc78-4658-ac14-fee7c5761f2b"),

Guid.Parse("ef21f7d4-7710-4738-beb5-daa6027165d8"),

Guid.Parse("ec4b493b-c77f-4619-8abe-925ba128a54d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("56f8b2f9-e141-4fa6-b877-656cd4b6fbc2"),

Guid.Parse("8ddf77e8-3d12-4815-9491-eaaf9ba228da"),

Guid.Parse("62b67442-e355-40fe-b6f6-3ab4cbb35577"),

Guid.Parse("0346c7f0-f8e2-47ea-8d1f-3edb7f778751"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("24d8a32c-48da-493a-8936-d98d65188124"),

Guid.Parse("485025a0-ff3e-4c50-8ccf-61a879132a6a"),

Guid.Parse("d75b3c3d-9f2b-4182-b305-12b924f4183c"),

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
Guid.Parse("f127c94d-5e4c-4b4d-b419-8bc6ee9793c8"),

Guid.Parse("48968cb1-6489-4f4e-833d-5e6ae450833e"),

Guid.Parse("35e9244a-e0fe-4e5a-9ebc-e15c65691193"),

Guid.Parse("d8149975-9328-4f32-b53e-1a4f9108c383"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0e227e20-96e9-4ea0-bdbc-ad4bed7ae86c"),

Guid.Parse("083f9303-5ab3-416d-9ca0-a9cef59b3355"),

Guid.Parse("74bbd517-f90c-4a89-b06b-6abd66d4ce41"),

Guid.Parse("4ec8221c-6ada-477a-ac49-7a9188e68d6a"),

},
},
            new GuiduuidArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("aedd7751-ab41-4db9-91d0-0ee6c2a2aa29"),

Guid.Parse("97494316-6816-418b-aaa7-fe7b8eb2fa99"),

Guid.Parse("37b4a6f1-85c4-4bcd-9d60-b56c5f633ea1"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ebe2af97-d22b-493b-82f8-82fe73b82727"),

Guid.Parse("73e70f50-5ed5-4fde-b8fa-ea0c0502febb"),

Guid.Parse("5b37164b-ad7d-4090-8077-9ca5ddb27407"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("11538b47-3fa5-43b3-8fd8-08a3f5da8aad"),

Guid.Parse("e902bfa6-03b7-4267-acd7-728048d0866a"),

Guid.Parse("3743eec4-a539-47a3-9463-880f075732d3"),

},
},
            new GuiduuidArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0d9ab1f9-3491-45a3-88f3-a36256140a95"),

Guid.Parse("343d6899-84a5-4501-9cf9-a9eb8acdd561"),

Guid.Parse("46b57081-9343-46f2-8e85-a14a3cf0ce4b"),

Guid.Parse("d75f4daa-801a-4fec-b72e-119928135695"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4da22cc1-5b20-43b0-af66-66bc44848e63"),

Guid.Parse("dc7768ef-d1dc-4456-a263-ac3c9099421b"),

Guid.Parse("8161adbe-f513-46cc-a770-cebb2e172034"),

Guid.Parse("e79c9df2-0383-4c8d-b658-60844e170592"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1bc25fd0-805c-4b5c-92a6-5906d157a8ac"),

Guid.Parse("ea5cbf2b-fc93-4ece-9001-97d747066c46"),

Guid.Parse("bb63ad08-d595-4ef5-8f7a-07595cc234b8"),

Guid.Parse("9a1702cd-68fe-488c-995b-d081badaf57b"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("103f8a09-e7e7-4104-b139-6974e024a165"),

Guid.Parse("6bff5270-1965-4eb6-8035-fafc2d281331"),

Guid.Parse("d7b8746d-5f90-4b27-893c-bb53c2e3069f"),

Guid.Parse("95b0792b-a6ea-49f2-b979-b2a0381385b5"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f42b6530-a535-401c-b37e-bdabec30d427"),

Guid.Parse("20a2dc35-8ab2-4f60-9063-2e49075f444f"),

Guid.Parse("0a929dc9-43f1-4c99-b67c-8d36e678e793"),

Guid.Parse("f0fb2605-a79a-4bf5-8f79-4043338dc3aa"),

},
},
            new GuiduuidArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("91c7a465-353e-4854-bb1d-4f174cf02f10"),

Guid.Parse("ae102d76-c2fb-4b93-a185-090410558c41"),

Guid.Parse("8377a6f5-dd99-440e-b091-02717cc92497"),

Guid.Parse("54abee81-110e-4459-8732-1d54a885db2b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("73ca9375-c468-4fb3-a188-f42c539a7b02"),

Guid.Parse("c51383ac-949d-4d21-ab8b-9d35f8d7b9a2"),

Guid.Parse("adb8d9f7-261a-44a3-ba89-224e62965c7b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05ed6843-0062-4f87-a6de-4f6cac982733"),

Guid.Parse("026015d0-5b66-4a01-b5f0-379559d5b4b1"),

Guid.Parse("fbfac6f3-b70b-45de-8651-7476fcdf5a4e"),

Guid.Parse("b669ff16-b2fb-4338-93b0-a59e5542b346"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a1a72f4f-e750-458d-b67e-eb552257a03e"),

Guid.Parse("b237aa6a-392a-4ec1-8488-147c2541287c"),

Guid.Parse("aaabc3ff-c948-4145-9c8e-49e3adc893bf"),

},
},
            new GuiduuidArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("eb3f3669-2a87-4a3b-95de-efc77276c8f5"),

Guid.Parse("103c29b9-354a-4ae9-8617-fc0a0143f419"),

Guid.Parse("262c5d5c-4dc6-4840-85fe-490418b1c3da"),

Guid.Parse("fa2f129c-4fdd-45ca-899b-c29cf17c2110"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("483c76b6-e042-43fb-97ec-fc1acffabc18"),

Guid.Parse("8824075d-253c-4d10-896d-8490a922b773"),

Guid.Parse("d2e35409-b1ce-4653-80fa-916d72f7d577"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("49a9ce76-e4ef-4dae-afa5-3dfc7aac82a4"),

Guid.Parse("511d0722-3687-4b46-9821-d9ccc87c2258"),

Guid.Parse("87946d5a-c1ce-446b-bff2-d4e2b5a8cd9b"),

Guid.Parse("e0e81dd1-983b-4651-8f57-b97a7996d3a2"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2ad66319-0d15-4cf5-b1cf-3ebc1a487202"),

Guid.Parse("d7b99e24-894e-4600-92f7-a316bca18710"),

Guid.Parse("3fb22b6c-7d40-44a9-b889-b13e7c14f40a"),

Guid.Parse("870495e8-f488-46f9-b912-bf4d4003ea16"),

},
},
            new GuiduuidArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1604abd6-835c-4716-849a-358df01ac7cf"),

Guid.Parse("0ca83b65-6cf1-47e3-8860-dd7c924d266e"),

Guid.Parse("00e424b9-90ed-4a47-bf7f-bc0b47570b10"),

Guid.Parse("7efd0124-4b7a-4495-9927-0e2dcb9a3538"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f9984104-cb3c-41fd-aa67-5455733d6962"),

Guid.Parse("bc0cea0b-3d20-4f1f-800a-6386979bd9ff"),

Guid.Parse("17d99313-dbc0-4ba5-a02b-c7ff9ae39615"),

Guid.Parse("c8ed21f9-a045-430e-880d-70191312d478"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("247c05c8-e80d-4feb-84a2-75f5fe1a5ab8"),

Guid.Parse("27d37964-a05c-4fce-8896-40cd49544af0"),

Guid.Parse("b3ee2b44-3996-4e51-9172-c1d4b8683edf"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f24b5174-34f3-4f27-bf09-33c35eb92435"),

Guid.Parse("023b0622-bbcf-40b4-a7f7-070daa84ad79"),

Guid.Parse("f4872096-1dff-449e-ab83-ad22c098264e"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b62ef87c-251c-48f7-930a-8dccef9ce77f"),

Guid.Parse("c912fb32-4994-473f-ae27-6130f156440a"),

Guid.Parse("ef07ce33-64c7-49c1-82a8-e3af8d0181f5"),

},
},
            new GuiduuidArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("54c1adbd-e178-4053-9e36-f2a6d24b383e"),

Guid.Parse("e306dbad-f158-46f4-baae-babf5c7b92ce"),

Guid.Parse("9b034f0a-bde0-4b05-b50d-9003d6667a7b"),

Guid.Parse("c96b8fe7-64c4-4d52-a72b-a3789b728e5f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b2535636-232e-4579-a98d-cc54c346ee98"),

Guid.Parse("ad1b9c5b-615f-4045-8b9b-5bb5ada87ab2"),

Guid.Parse("47b88d00-317d-49b0-a811-ff266cb761b9"),

},
},
            new GuiduuidArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b9da6a57-4e87-44a7-b757-169f08745f39"),

Guid.Parse("85c3406a-d8ee-427f-8ec6-136c73d5b058"),

Guid.Parse("92f3836f-3ead-41c1-bd2c-639d98a02f3d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("354032ed-2f94-4427-9742-f2d25421c1b9"),

Guid.Parse("c4b8722f-9bae-40f3-8224-d73ff64b36a1"),

Guid.Parse("23813721-4c09-445f-b7ce-dbc791b40850"),

Guid.Parse("07ea81c1-a007-4421-ab2a-69e5564fb165"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7c703899-7cb6-4cde-834d-d2412ce57049"),

Guid.Parse("1b07bc88-f893-4e03-9602-518a9651ee3c"),

Guid.Parse("354bf9e6-f983-4d84-9e13-a69d679c2c32"),

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
Guid.Parse("0f384da9-e1f5-4241-a3cf-490171af10bd"),

Guid.Parse("7c5667d3-9c86-4094-bb97-aa5f5dad1ed0"),

Guid.Parse("587dc7df-9c09-4977-8981-eb8692a5edbc"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d1316acd-798e-4934-8e08-4d1d6d80e01f"),

Guid.Parse("8672469c-f5f8-4d25-8f1b-3de119b4204d"),

Guid.Parse("657ecb6c-72bd-4e27-ad67-e1b7ffa6288d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9b0c6059-0181-4e17-bec3-b032117e3b51"),

Guid.Parse("a4befabe-7e60-430e-8913-b295ef6586ff"),

Guid.Parse("7bf2d06b-d537-47b8-a5a1-da166fc1bf41"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8c03b612-6d9a-4f4c-8ba0-4756af60bb03"),

Guid.Parse("e9b3aed2-c74d-4422-b529-3fe895a8f183"),

Guid.Parse("c27648f1-745c-469d-9c38-a48a23018bb2"),

Guid.Parse("400a6e91-8454-46ee-9ef0-d4cb9ba7797c"),

},
},
            new GuiduuidArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0178d57-b8e4-434e-ab1d-2c523aeff8ea"),

Guid.Parse("cb80b3a6-25be-4c10-8a9f-b1c870ef9171"),

Guid.Parse("c95b2062-57f5-489f-87f4-21bf5cf6ee20"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4a3ae23c-e131-494f-83b3-ae277f385c1b"),

Guid.Parse("fd8f8068-7a4b-4b66-bfc1-2ca0dbebd185"),

Guid.Parse("6cb68294-23d8-454f-a9a1-4ea6d8036627"),

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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
                parametr1.Value = 30;
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
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
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
                parametr1.Value = 22;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        GuiduuidArray2M.AssertModel(models[15],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduuidArray2M.AssertModel(models[0],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        GuiduuidArray2M.AssertModel(models[0],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 99, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 50, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 146, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 22, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 115, query1, 32, query2))
                {
                    if(++resultIndex == 1)
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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 158, query1, 158, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 43, query1, 137, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 43, query1, 150, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
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
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 30, 12))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 71, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        GuiduuidArray2M.AssertModel(models[0],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[34], false);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 117);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 16);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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


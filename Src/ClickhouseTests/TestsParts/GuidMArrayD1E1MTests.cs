

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
    Id = 4,
    Value = 
new System.Guid[4]
{
Guid.Parse("6e148f74-3553-43af-9e6e-5afbd970237a"),
Guid.Parse("0172c8c9-9d3f-4492-956e-c8475651410d"),
Guid.Parse("2a517f29-4191-44f3-894f-0d5b97951ec7"),
Guid.Parse("cbc97273-0cea-4eb6-96d8-9062c2483920"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 2,
    Value = 
new System.Guid[3]
{
Guid.Parse("f4f74da6-f49c-42a0-a874-e9ba5d779538"),
Guid.Parse("5260710b-8a46-46f8-954a-31c13262b1ec"),
Guid.Parse("29afe8f4-1aea-49a0-93cb-65793beac3b3"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3a424838-79ac-48c9-a063-10bc08ac671d"),
Guid.Parse("67f5922d-ecbb-4645-bc3d-760a63240a6a"),
Guid.Parse("47da5255-5854-4974-9906-20a1097468a9"),
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
Guid.Parse("0a28b73d-4a01-4aa2-bcf3-2c8d6267d0d4"),
Guid.Parse("b38b11e2-5922-415d-b5ee-c5073eb6b61c"),
Guid.Parse("51e00185-30c6-40b5-8305-db5fae6ff2b8"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 5,
    Value = 
new System.Guid[3]
{
Guid.Parse("39a3c098-78f9-4945-8dd4-df507c44c83c"),
Guid.Parse("21bdb574-0400-423e-be4b-0426c1c637f2"),
Guid.Parse("67b77d51-7908-4501-8e5b-a5c1808adc2c"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 14,
    Value = 
new System.Guid[3]
{
Guid.Parse("f4efff5f-3946-49ba-83fd-f3003d133c2a"),
Guid.Parse("4b66e203-4269-4e3f-8e11-5212f4a0422b"),
Guid.Parse("07430bf4-bdd6-4da7-8004-c960fd02e4ed"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Guid[3]
{
Guid.Parse("c07e0aec-38c9-453d-a43e-7013295361ab"),
Guid.Parse("87c1d50c-0a56-42a5-ba9e-d9374ca09a05"),
Guid.Parse("80d95dd5-c7be-44b8-8d86-86b5506f9f61"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 18,
    Value = 
new System.Guid[4]
{
Guid.Parse("e027303d-11f7-4d31-9881-9441d20f29bd"),
Guid.Parse("d338e95b-9eef-433a-a29e-785c23eff502"),
Guid.Parse("69cc7c30-9ffc-402b-a92a-54affcb28e75"),
Guid.Parse("1e0bdde1-012b-4f5d-b387-967fe34d76d7"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 14,
    Value = 
new System.Guid[4]
{
Guid.Parse("07b5b379-1769-4fc8-8e65-1802644c9881"),
Guid.Parse("59f089ca-f91e-41e5-803f-40537f045080"),
Guid.Parse("30587140-a21d-43d0-a5c2-53e1702b9a3e"),
Guid.Parse("c666bc79-0b75-4f51-97a8-f461da72506b"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 21,
    Value = 
new System.Guid[3]
{
Guid.Parse("619cfc77-7c61-4644-bd23-99a243b3b04a"),
Guid.Parse("86b5b6e5-65b1-45ba-b3ec-a94af03bae9c"),
Guid.Parse("a6f669ea-31ca-4f4b-86b7-8e08f2acd19b"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 17,
    Value = 
new System.Guid[3]
{
Guid.Parse("fc658bbf-008d-477b-8e3f-abca4efdeac6"),
Guid.Parse("5d0c73cc-130f-4a72-b67c-c41936561dfa"),
Guid.Parse("6f73bb05-310b-4140-a979-b36d39c76233"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4b67b0ed-0df9-40bb-a555-d4180fd1acc4"),
Guid.Parse("35e8de64-e11b-44f1-9406-01e664a88752"),
Guid.Parse("f6e862cb-9c25-4d17-80df-f3a78c8ccb2e"),
Guid.Parse("e7d29a53-849c-4ad1-aad3-773ae905aa2e"),
},
},
            new GuidMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Guid[4]
{
Guid.Parse("763f3b38-da7c-41d5-9a2a-f6932d8f8855"),
Guid.Parse("fa6f604a-bd86-4c8d-a4c4-9538141b738c"),
Guid.Parse("2cd8c14f-9da8-4d88-aae5-30a1aa759237"),
Guid.Parse("86de03e4-aef4-4f97-8c24-ef2d1f3ffa62"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 22,
    Value = 
new System.Guid[4]
{
Guid.Parse("d6e4e24d-d7f0-4d95-aa8e-3165a77124e4"),
Guid.Parse("f9469d52-85f6-408a-8413-089fbc3024d3"),
Guid.Parse("83033983-1f7f-46ad-abd3-fe3a46ab37e8"),
Guid.Parse("8422656a-3440-4d13-bb35-6a191c736371"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("28a2eeaa-9706-4164-abdb-fde6f6306794"),
Guid.Parse("e7d93196-d6e4-4036-b452-2ebd931f2b10"),
Guid.Parse("4a94ea01-cf73-43d2-9c33-3fa200e136bc"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a8f81cf2-2a2b-4f1e-9f43-da6ac610b81a"),
Guid.Parse("0f8b3aa4-bad7-4317-9519-7c37a1777fd3"),
Guid.Parse("b341bdd0-4ccd-4189-b3b9-e456848c82ae"),
Guid.Parse("6ba4ec23-ea09-4ebe-b3f0-4be9c10f31ad"),
},
},
            new GuidMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Guid[4]
{
Guid.Parse("076cc507-f54d-4064-a7f9-a59da5fb8498"),
Guid.Parse("3d04e31e-48a0-4d53-8b4d-a2da657e00c8"),
Guid.Parse("9499c42c-7233-4c2d-a5cd-d3628b3f06e2"),
Guid.Parse("551b172d-c26c-44ab-9a57-88ecaaa390d1"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Guid[3]
{
Guid.Parse("7c6366c9-ae4b-4457-86e5-c386124bb189"),
Guid.Parse("d8d151c6-4243-40a7-b2fd-cb7eddaa976b"),
Guid.Parse("045ccc8d-3f82-4dcd-9d18-83b018516498"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 29,
    Value = 
new System.Guid[3]
{
Guid.Parse("7486d733-24d2-4fe7-bda1-c4b22f450297"),
Guid.Parse("698dc5fa-b480-488a-9387-8c6da1313e4d"),
Guid.Parse("d9658927-3d05-463e-bbd9-e0ac78cc0ca9"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 25,
    Value = 
new System.Guid[3]
{
Guid.Parse("2e12f532-8581-4b2e-8b73-a049b015dbbf"),
Guid.Parse("5d3d62b0-9fc4-490a-86b3-f1f8df957ddb"),
Guid.Parse("9e0c3cad-07cd-4ab9-b117-1ed12254efa2"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 35,
    Value = 
new System.Guid[4]
{
Guid.Parse("4f837353-d51d-4a88-b038-dfb596970232"),
Guid.Parse("06caf7c4-5aa6-4a08-a601-627f827d9e3a"),
Guid.Parse("25d20ef4-c871-4b5a-8990-5217bc4fdf14"),
Guid.Parse("b7ab9cfb-64e1-4a6a-a0a4-0e5c7411349f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Guid[3]
{
Guid.Parse("442b4fd0-cf14-48e5-80a0-1bab5835d352"),
Guid.Parse("a9303370-c6e7-4c8e-a779-a341fc54d812"),
Guid.Parse("f2e7aae6-db97-4a80-9ea9-f74ba5872ecf"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 44,
    Value = 
new System.Guid[3]
{
Guid.Parse("8935c75c-c904-40ac-ad77-56943822b37b"),
Guid.Parse("9747f066-a3a7-468a-8c35-193e6e933d76"),
Guid.Parse("720432b7-b035-43b4-bb80-0b25bd679068"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 36,
    Value = 
new System.Guid[4]
{
Guid.Parse("6ec41284-d397-4ec9-8bce-1e291ae9c75f"),
Guid.Parse("a9101585-7336-48f7-962c-45080cb142fd"),
Guid.Parse("5c501dc5-9173-42e2-ad0a-c533f1b13684"),
Guid.Parse("8d8ed92b-75bc-47a4-a8eb-1f7934409001"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 47,
    Value = 
new System.Guid[4]
{
Guid.Parse("8da04595-0415-48a4-80e3-bcaa570c9ccd"),
Guid.Parse("deee3d71-ce13-4b52-9f6e-c92e37f8ef3a"),
Guid.Parse("eec31ade-b145-4065-99e4-a39d5da92602"),
Guid.Parse("559b5481-5dbb-4826-b826-91910689cbb8"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 41,
    Value = 
new System.Guid[4]
{
Guid.Parse("7e794b78-9642-41e2-83b3-03b166186c08"),
Guid.Parse("94c466ea-dd55-41f0-8f02-1df7dc28e530"),
Guid.Parse("680cc30d-a60e-4866-a445-34f388bdfcda"),
Guid.Parse("fb97d61d-8bd1-48b4-8103-e33013efd2e1"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("96c958eb-71f2-40c3-b000-8313903792cd"),
Guid.Parse("e52e7a8d-657e-4146-b6ef-59cb0798cb4d"),
Guid.Parse("0c15a700-d5d1-47f6-b062-d2c1cd769640"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("18299999-bebe-4e11-bc77-3eb35563a980"),
Guid.Parse("c99ed3b8-5b69-4824-9c8b-232a7ef16542"),
Guid.Parse("760de648-793b-4608-826e-aa488d862c15"),
},
},
            new GuidMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("bef00448-988c-45a4-b824-bf5769ab14d0"),
Guid.Parse("0160b094-2810-4982-9bd8-aa8b9677459c"),
Guid.Parse("77d4b0c7-9fde-498c-8f88-62c60d2839f6"),
Guid.Parse("984b1b2e-d7f9-4908-aab7-e2a2f303268d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("05026261-a477-42be-84d7-04e49f470367"),
Guid.Parse("452e799b-0850-4504-94eb-e26e3deaf693"),
Guid.Parse("46612c1d-e448-4551-9db8-43c2ce49f083"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 56,
    Value = 
new System.Guid[4]
{
Guid.Parse("57852f5b-619d-4e0c-82d0-3f2c5881277c"),
Guid.Parse("97fb5211-2231-4d09-b31b-1d98bb8e86a0"),
Guid.Parse("bff8871e-21c3-49b9-896f-54fe52f5cdf5"),
Guid.Parse("cf73d8be-e940-4ea6-a3c6-d40fa9a148d0"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("d0aff06e-85bb-49e8-89a7-8f1b2da78ece"),
Guid.Parse("2f676b65-c761-486e-832c-ea991cc2ea2c"),
Guid.Parse("6ec21c61-0bd0-4b77-9480-f16c04731574"),
Guid.Parse("a39bbf32-867e-46b6-a3cd-b7ad3bdf332d"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e228480f-4771-4ff0-9658-42db05c65551"),
Guid.Parse("eb53084d-a705-4cb8-bbbd-986eb8b7c751"),
Guid.Parse("b64a4c45-49c5-4a7b-9a53-dd4ba3e68a6b"),
Guid.Parse("084ec14d-a309-4018-a78f-04f8fc5fb841"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Guid[3]
{
Guid.Parse("43d262f2-756d-44c6-b645-05c8eeba56e1"),
Guid.Parse("f43065ab-bedc-4ce5-89e7-ee161b11d554"),
Guid.Parse("b28f9893-69b0-4427-a400-31d6e23df26f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 56,
    Value = 
new System.Guid[3]
{
Guid.Parse("0e8b0d96-3114-4df8-9586-577e7abd64dc"),
Guid.Parse("e28230d2-7c64-42d5-9988-a6366126110a"),
Guid.Parse("4cd441eb-78d9-4954-aeef-ea245c7794e5"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("43993839-2b19-4679-adc8-b33ae5bf2dac"),
Guid.Parse("9b1e63b3-aed5-4ed0-aff5-3687686340b3"),
Guid.Parse("74086450-b6bf-4b81-9dd0-85e38d5845d7"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5708857d-83e3-4321-ada0-595dc7603aab"),
Guid.Parse("4993443b-3ff4-498a-9543-bc9b7b137b1d"),
Guid.Parse("ad5be9df-5b11-411d-ba1a-dcf2d5a6980c"),
Guid.Parse("5110004a-ae18-4426-8fbf-007f78e30b52"),
},
},
            new GuidMArrayD1E1M
{
    Id = 66,
    Value = 
new System.Guid[4]
{
Guid.Parse("a151d85c-f99f-46cd-8a7f-c7c36936a268"),
Guid.Parse("dc998ff6-cef3-477b-8cf7-ead6afcf75ae"),
Guid.Parse("396d5655-73e9-4355-93b7-36f7f014cc6b"),
Guid.Parse("3ee6410f-b097-438e-90b6-cec20068e306"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Guid[4]
{
Guid.Parse("50b2afc3-f82b-492e-8238-0fb383357894"),
Guid.Parse("87a5cd7d-ca1a-47ef-b5eb-7b3f66bf76a4"),
Guid.Parse("9001489d-7543-4e3f-81a0-c3dcb887056a"),
Guid.Parse("0508fd26-3ab3-4307-bc10-6e7c340f8cc3"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ed88378b-2405-4d84-a78a-7619788d0d09"),
Guid.Parse("0ad2304e-ac39-4981-8a6b-86bba7bdd98d"),
Guid.Parse("dc977c15-5dd9-4b53-90d6-513b745f6f69"),
Guid.Parse("3f0f66e5-2e84-4f59-b06d-61c7609f6691"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 75,
    Value = 
new System.Guid[4]
{
Guid.Parse("7c8e8275-1fa7-49c9-b69a-a0fa4a1beb35"),
Guid.Parse("e4d07b24-dfab-42c1-a8e3-f1ccadd13c54"),
Guid.Parse("1b4d631c-fc49-4f03-8bc4-4efb3af28f8d"),
Guid.Parse("a0b4e04e-323e-4b00-b927-d424e178db93"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 63,
    Value = 
new System.Guid[3]
{
Guid.Parse("f6fc44ce-1d3e-47e1-bce4-32a9a28ee972"),
Guid.Parse("21cda0ae-a56a-432d-a2e7-383bca7c94fd"),
Guid.Parse("9f2262c5-cb5f-425a-ae32-f6d2349e726d"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 78,
    Value = 
new System.Guid[4]
{
Guid.Parse("75903b46-22b1-46f8-8310-107c9f7729aa"),
Guid.Parse("d1345a24-a412-437c-9966-da496591195f"),
Guid.Parse("e649ca41-fcd8-4574-a81f-015807972911"),
Guid.Parse("5b5f10d3-ad88-4080-b3fe-0878608fad27"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 67,
    Value = 
new System.Guid[3]
{
Guid.Parse("854ae6b4-0f4e-411b-a272-576737e02e62"),
Guid.Parse("2391f6e8-9638-494e-880b-5a509293e2b4"),
Guid.Parse("ed041ec0-c120-4eb0-8941-2d66cfde6b5c"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 83,
    Value = 
new System.Guid[3]
{
Guid.Parse("6a4eb9f5-76c9-4876-8bfc-e2ef8ff542ea"),
Guid.Parse("b44de076-5d73-4f75-a0ff-72ddc110d083"),
Guid.Parse("9bcdec86-2c8c-4460-8108-940d4d409e88"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("516899f3-00b5-4d52-8bc2-b3ff94866a08"),
Guid.Parse("493b2474-970f-4d16-ac14-de8bbaba74ab"),
Guid.Parse("50b62a3e-4622-483f-bd88-782462a6f60e"),
Guid.Parse("c17816ba-6654-4091-8050-4cf982eb4f03"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("227ee8ff-0be6-4440-b64f-eebaf42df6f2"),
Guid.Parse("ddd29721-8070-43a8-9977-d406b0e03415"),
Guid.Parse("dadefcf2-a5b3-4f69-8382-f097b73d3558"),
Guid.Parse("a103942a-c463-468b-bcdd-0d1c8b17659f"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3624d9be-eb8a-449d-8768-4890e2603e92"),
Guid.Parse("419844da-5e2a-4a27-bb4d-3c1c02df0299"),
Guid.Parse("6fcc2b4b-79ac-41bb-9988-4a29a0f40cd6"),
},
},
            new GuidMArrayD1E1M
{
    Id = 84,
    Value = 
new System.Guid[4]
{
Guid.Parse("ae210f27-f5c6-4dfe-99d2-e29e057f93af"),
Guid.Parse("195adaed-1d87-4066-bf48-984f058d6412"),
Guid.Parse("0464ef48-5c45-4353-989f-21f4a77129a7"),
Guid.Parse("d12f8019-4a31-42bd-b0fa-e7ae1b75b993"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 75,
    Value = 
new System.Guid[4]
{
Guid.Parse("6c309ba6-ba23-44f9-bd1c-bbe482a02b6a"),
Guid.Parse("4bcf74a6-17cf-4f3e-b188-a5e637f459fa"),
Guid.Parse("64f65973-6d44-454a-b538-c139e179c97d"),
Guid.Parse("56f1d692-7883-446d-92cf-53c36505adb5"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("45491fbe-c82a-4d37-bd98-73197ef79111"),
Guid.Parse("f7c5ad16-a47f-4e75-8def-9bf75ac388fc"),
Guid.Parse("3b5eaff2-0034-4b63-8dc8-67e844011bdb"),
},
},
            new GuidMArrayD1E1M
{
    Id = 93,
    Value = 
new System.Guid[4]
{
Guid.Parse("d436d5a0-42cc-4b7c-a1ed-0b9ce0a9abf4"),
Guid.Parse("974ef3db-4270-416c-91b9-24d74e7080db"),
Guid.Parse("6357aab7-b12b-4fc1-ac18-2236fb57c655"),
Guid.Parse("677a3bdf-4f88-476e-8827-cad390b87e00"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 84,
    Value = 
new System.Guid[3]
{
Guid.Parse("ad840c9b-8066-4d52-ae6f-aa6d19b5e21b"),
Guid.Parse("781be850-d88c-43fd-b165-e98488fca609"),
Guid.Parse("8e78663e-6a30-4303-b4f5-23bcc759465b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("620aab15-d973-44b2-872d-fa21a536a7f3"),
Guid.Parse("d53df1be-6540-4357-a0a1-6bbd9dc91b8c"),
Guid.Parse("7239fc15-a910-4ca7-9e89-68005357a843"),
Guid.Parse("b2448a08-ebde-4bc2-aa8f-c24e9356f746"),
},
},
            new GuidMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Guid[3]
{
Guid.Parse("5907f6f7-a036-40e7-a1d7-848e9eb5ed73"),
Guid.Parse("ba8b9c56-97df-4706-b690-9ac2b105716d"),
Guid.Parse("e7c4c63f-6ac9-4f6c-88c4-c9364f9734f6"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 87,
    Value = 
new System.Guid[3]
{
Guid.Parse("99361696-ed78-4990-b62c-c5f11a218677"),
Guid.Parse("64a43b06-a09e-4f90-b02c-393f1b410738"),
Guid.Parse("9822e112-d8af-4921-95d6-e94c0696dfdc"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 107,
    Value = 
new System.Guid[3]
{
Guid.Parse("e8563fea-f6c2-4e44-868a-341f49247072"),
Guid.Parse("0ee1e40e-4b78-4f1e-90e1-e63ba7d68365"),
Guid.Parse("6598f5b1-e0e5-4b9b-b984-7b4dc9717a17"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 93,
    Value = 
new System.Guid[3]
{
Guid.Parse("c8dd0793-5d7b-47ce-b917-bce198301cac"),
Guid.Parse("91355731-b9c4-46d9-a1cd-f03574d4f9d5"),
Guid.Parse("a41acf43-7bb3-424e-bea1-c1b3a75b9252"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 110,
    Value = 
new System.Guid[4]
{
Guid.Parse("340f3a0e-9c0f-4a88-80c1-6427f48db1a3"),
Guid.Parse("e5a7ea22-5de5-4433-8a55-8d4dcd9105ef"),
Guid.Parse("f5ab1d16-9ab4-44df-9660-c92f3379edc4"),
Guid.Parse("2634b5aa-d9c6-4b29-be0c-a3cbc409effc"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 97,
    Value = 
new System.Guid[3]
{
Guid.Parse("1d19efb6-3690-45ba-86e0-d8493d0e8a95"),
Guid.Parse("04c8a104-4f43-46e0-ac54-27d9c4e71adb"),
Guid.Parse("1fdff3fe-3ba8-4de1-8209-45d89ad6c220"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 114,
    Value = 
new System.Guid[4]
{
Guid.Parse("af283494-ea79-46c1-8aec-9710628f649a"),
Guid.Parse("deda6dc9-6553-4eaf-93db-d83847ddd9dd"),
Guid.Parse("84aca75c-d23f-4406-b988-2d3f6c0632d7"),
Guid.Parse("0fafe4b4-51ee-4692-b52c-80cb6d6594b7"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 103,
    Value = 
new System.Guid[4]
{
Guid.Parse("017a872b-c521-453a-812e-b1ccf5fdb230"),
Guid.Parse("916a9772-1664-4ad5-b458-a906b7786209"),
Guid.Parse("174553bf-db34-4fa3-af79-009ad3d2472d"),
Guid.Parse("16cc3f23-7dca-43c3-844d-f8a76f7bb957"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6fe9ff1d-2b72-4ede-beb6-17f4dcc19ed8"),
Guid.Parse("04d12f0f-ba02-45b3-8f23-411604ec0dbb"),
Guid.Parse("5659d199-cde7-4670-b0ef-dfcb40b6fc3d"),
Guid.Parse("9c616706-e12d-4e84-b5c3-bbcc51068ee4"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("071c7b3d-5fd0-4adf-9569-939446bfbcfe"),
Guid.Parse("fb2ce928-21d1-47f2-8b25-cefdc31d42e9"),
Guid.Parse("da2fe90a-9d88-4ad3-b820-a5dfd5f0a287"),
Guid.Parse("6577bf88-96eb-4f3f-88b2-a6839633088f"),
},
},
            new GuidMArrayD1E1M
{
    Id = 121,
    Value = 
new System.Guid[4]
{
Guid.Parse("246abdf8-2d70-429f-a475-c7a602645d6a"),
Guid.Parse("829b9e96-951f-4619-8fdb-136d2bc8685e"),
Guid.Parse("ae89aba7-d6ad-41e0-9078-800fc70dcd16"),
Guid.Parse("26ec777a-98dc-4e44-b7cc-78e6dffe34c9"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 109,
    Value = 
new System.Guid[3]
{
Guid.Parse("92cadc35-6034-4f8f-aa3d-c40dc0e1f464"),
Guid.Parse("c4304f2a-0eda-421e-a2f4-e6ffd0922f0e"),
Guid.Parse("468ff9a7-c1c4-4a83-a220-28ecb33eee93"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f95e2def-ea79-456c-bfc3-059cfe6b1b64"),
Guid.Parse("e2248704-21a1-4805-903d-e6511258a0a7"),
Guid.Parse("73299f54-529f-4e93-8fc5-d665f26c8bac"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Guid[4]
{
Guid.Parse("f8f22f5a-ce78-420b-8e8a-6dba6c52adbb"),
Guid.Parse("1f5c6457-d63d-42eb-88f7-21ac0c9df603"),
Guid.Parse("bd4b5940-583a-473d-a7d4-6d7721e90f83"),
Guid.Parse("14deba8c-a38f-46d1-8eb7-1ea94078ec9f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 114,
    Value = 
new System.Guid[4]
{
Guid.Parse("71f8c7f9-7ec2-40bd-8c11-21d5980200c6"),
Guid.Parse("04e6ffa9-50f4-4511-aace-c2f21fc0430c"),
Guid.Parse("11dc5e1d-4308-4f03-8ae4-bf32614ede17"),
Guid.Parse("398b1886-033e-495a-ae20-a86e7e8780ee"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4c9fe2d4-dfd5-4f97-829e-35cceb25369e"),
Guid.Parse("bf4abc08-7583-4fa1-863d-563eab57e873"),
Guid.Parse("53c3b2cf-dff1-48b5-80ed-7bd27d96b822"),
Guid.Parse("7b3adc0e-2c35-43a1-b940-8f2dffd4962e"),
},
},
            new GuidMArrayD1E1M
{
    Id = 134,
    Value = 
new System.Guid[4]
{
Guid.Parse("d0895f2b-86d3-4b2a-9750-e34b6b1b184b"),
Guid.Parse("5fb68e52-a805-4098-bf74-de4789b8f5d3"),
Guid.Parse("d94f3648-ac60-4797-a4a5-4828aa8b4702"),
Guid.Parse("257fe1a2-0a5f-4a5f-8bf8-324befdc05e9"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 119,
    Value = 
new System.Guid[4]
{
Guid.Parse("a9fceaa9-cf18-477d-b010-804f52c3ee53"),
Guid.Parse("718195a7-d2bc-412e-8366-9084ebb31e62"),
Guid.Parse("077843eb-c1d8-4934-b070-3bc9e1f7cc5e"),
Guid.Parse("1c990dee-1b02-4b09-bcda-32fa3bfc42b4"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f058d662-4ae5-4e22-aa29-d8c8a989356c"),
Guid.Parse("43198874-1f4d-442e-8c45-0d8b7659a4c4"),
Guid.Parse("53c89042-3048-4275-a529-af92e5b6be4a"),
Guid.Parse("1a776719-44b6-4b7c-8a98-937944b0eca3"),
},
},
            new GuidMArrayD1E1M
{
    Id = 143,
    Value = 
new System.Guid[4]
{
Guid.Parse("669b502f-65da-4459-ab3f-1318d9126fd7"),
Guid.Parse("db3901b3-3120-43ce-9210-7eaf014259cf"),
Guid.Parse("2ae9f359-5a98-46f1-9a1a-55748aa48e53"),
Guid.Parse("5313b4b9-3b17-4dd9-b6e9-e0b53a3fc54c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Guid[4]
{
Guid.Parse("7dae2e03-eb15-4815-9a7d-3963f58fab1d"),
Guid.Parse("96a1901c-1028-4cf6-9ef7-49a440fd684d"),
Guid.Parse("ca6e239f-19da-4f71-bca4-5d23e22e4b22"),
Guid.Parse("7bbbf0a9-75ca-45fc-85b7-02d443ec301f"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("51044ef0-fa8f-4bb9-b0a0-0911b2462e8a"),
Guid.Parse("af9bedc9-9f0d-4575-aec0-a4cbdefd8be6"),
Guid.Parse("9995515c-4f50-413b-8fc8-6606982f044a"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Guid[3]
{
Guid.Parse("259ca2fa-ce24-410a-8582-8eadf8e26626"),
Guid.Parse("3fedd01c-fac1-48bf-b5e2-03415d8a0b16"),
Guid.Parse("da7b4764-2ebf-41fc-ba7e-8556d445a23c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 123,
    Value = 
new System.Guid[4]
{
Guid.Parse("79312374-ff36-4e3d-820a-f02fd95b07d1"),
Guid.Parse("f460e06a-ba3c-48b3-9d1d-a24bce90b2b4"),
Guid.Parse("364c5c64-05ff-49f2-a083-0fc54ca188c9"),
Guid.Parse("ba6edfa0-a5e8-4578-a123-9d59217a13be"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 153,
    Value = 
new System.Guid[3]
{
Guid.Parse("e383c4ac-d083-4ea7-b71f-3872656c3fe5"),
Guid.Parse("1ed352d4-bd7f-4953-9350-000671fe1fc5"),
Guid.Parse("b7113ced-c699-4ee3-b4fc-b91f186e9541"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 124,
    Value = 
new System.Guid[3]
{
Guid.Parse("f16c2c5d-643d-42c5-941c-d9eab2e14580"),
Guid.Parse("6228b316-bb7c-4b2a-8e09-0e0bd12104b5"),
Guid.Parse("fc19db19-7dd9-4dcd-bb4e-6d940a2d3497"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0b20d773-441a-40e7-a425-b17ad722831d"),
Guid.Parse("fd49bb50-e5c5-4de7-9e15-9481f703aedb"),
Guid.Parse("b2d322fa-fa18-4721-b763-2f613a54e624"),
},
},
            new GuidMArrayD1E1M
{
    Id = 157,
    Value = 
new System.Guid[4]
{
Guid.Parse("129957c5-bffc-40e8-8a0a-dedf6b09b852"),
Guid.Parse("2c737b6d-3176-4156-b0a5-37379b3d4bfc"),
Guid.Parse("00871fdc-1df2-4f26-a976-e216fbfaae3f"),
Guid.Parse("d791b80c-6e29-480d-95d6-f6f8cf4c75a6"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 131,
    Value = 
new System.Guid[3]
{
Guid.Parse("23c32201-f2db-4183-8f4e-0759229d7d6f"),
Guid.Parse("6a73cbe7-f52c-47a4-a9b0-67a366cc3710"),
Guid.Parse("5cd504e5-234f-4f50-9468-37eb626d1f22"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0414e8f9-4ebb-42fb-b7f3-93e5144668a8"),
Guid.Parse("ed89808d-6e44-4600-8c4c-9a19bc4221a4"),
Guid.Parse("e9d26518-2704-4f65-ae8e-2ef94a2e3e46"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 163,
    Value = 
new System.Guid[3]
{
Guid.Parse("b0891692-f36b-4caa-9c46-469e355774fb"),
Guid.Parse("15875cc6-382a-499b-86e4-7254dcf7ef65"),
Guid.Parse("b7a4d547-50fa-470e-9e10-3a485bc97148"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 137,
    Value = 
new System.Guid[3]
{
Guid.Parse("ffb97f93-7399-40e1-8d36-73550ee43d9d"),
Guid.Parse("b85fd78d-5282-4512-a644-e3080bdf9143"),
Guid.Parse("a724c5aa-a3b6-4520-a892-6600fdb63462"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 170,
    Value = 
new System.Guid[3]
{
Guid.Parse("8f89312d-84b4-4902-9c6e-d20021f0aa0f"),
Guid.Parse("7c0f2aef-c4dd-487a-afe2-83a79a240429"),
Guid.Parse("cb45341f-cd50-4c74-9946-5b580ae9f4c6"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 143,
    Value = 
new System.Guid[4]
{
Guid.Parse("0134286f-bc17-446c-8595-866a39de43c0"),
Guid.Parse("5bd1b0d7-b819-49db-86ed-208f72f40a1b"),
Guid.Parse("cac23926-3a03-44fa-a502-3d412306704d"),
Guid.Parse("4025c42f-2b25-4be2-a366-1c54240e425a"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("e162b4fc-a4d3-470c-82a2-c5d90ea27416"),
Guid.Parse("2524c363-a0b8-413c-bcbc-21e3720f86d2"),
Guid.Parse("afa91e27-4329-4454-a2e3-db5817814939"),
Guid.Parse("1d7ac610-45e3-4f82-a711-41eae636b3cc"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 176,
    Value = 
new System.Guid[4]
{
Guid.Parse("e05d4ac6-fc67-44a2-9480-3a95add7ffcb"),
Guid.Parse("df9937a8-04fc-46b6-a8bc-176e3acf9865"),
Guid.Parse("0f920d2a-914c-4b89-8cfa-fb8a6bdec39e"),
Guid.Parse("49833759-feab-4b6a-b94c-5d396f1ca91b"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 149,
    Value = 
new System.Guid[4]
{
Guid.Parse("b87e68ba-aff3-452f-9b70-3f5c53ee13a2"),
Guid.Parse("4c064918-4c45-425a-abe1-7044fa40ceb6"),
Guid.Parse("9d095d59-1418-41af-998a-928393f74964"),
Guid.Parse("2248a069-8ba1-42fc-8d1e-9714cacff63e"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5b53dfb8-84d7-4053-ba0a-ad33368d1f7b"),
Guid.Parse("78ade7ee-e2ba-4818-a700-209a92e8018c"),
Guid.Parse("fab2dcf6-812d-4224-8b56-f3a09f57156d"),
Guid.Parse("1e2ac3dd-51f5-4783-8286-450a41006092"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 178,
    Value = 
new System.Guid[4]
{
Guid.Parse("788aa720-537f-459b-9c5f-b691106f87d3"),
Guid.Parse("9185471b-a921-471a-8f18-ea6d03be364f"),
Guid.Parse("b90fec62-6c9b-400b-be28-264becb1468c"),
Guid.Parse("2f38d350-348d-4bbf-91d6-3aac2ff92b76"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 152,
    Value = 
new System.Guid[3]
{
Guid.Parse("e9712bea-c505-4677-bfec-6bb5300b7007"),
Guid.Parse("485e838e-7a02-46a4-a6f5-ed93c212e4c2"),
Guid.Parse("4377eb18-62b3-4453-8d44-444f707324d3"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5d202e1c-b2de-4de2-9c6a-7e7e53705d75"),
Guid.Parse("99a849a0-6ebe-40c8-98d6-e5757139cd6c"),
Guid.Parse("ed5a992d-bc49-43d0-aa7c-3eae1083ce29"),
Guid.Parse("047811f2-744d-4bd4-9e6f-78dc194e9963"),
},
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


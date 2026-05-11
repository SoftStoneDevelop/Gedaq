

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
    internal partial interface IGuidMArrayuuidMMArrayD1
    {
    }
    
    internal partial class GuidMArrayuuidMMArrayD1 : IGuidMArrayuuidMMArrayD1
    {


#region TestData

        private readonly GuiduuidMMArrayD1E1M[] _testData = new GuiduuidMMArrayD1E1M[]
        {
            new GuiduuidMMArrayD1E1M
{
    Id = 1,
    Value = 
new System.Guid[4]
{
Guid.Parse("0b2f30f8-be56-41c8-9274-d7f840556902"),
Guid.Parse("a1d9f7d2-f04d-404b-a784-e00e70a62996"),
Guid.Parse("8adaf7d8-da75-48de-a1cd-b0dab82b5d57"),
Guid.Parse("9f407756-37d6-40d5-82b7-6d61a3300de9"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("a6c0aa93-dff8-4730-b28f-64a088e3eaab"),
Guid.Parse("8006587b-d1f2-4459-aa1f-45e269a70c02"),
Guid.Parse("c121f409-0bc5-48c8-a1c0-66da109d887b"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 4,
    Value = 
new System.Guid[4]
{
Guid.Parse("35e6e150-ae80-4af4-9fb5-f1c4a6c0f854"),
Guid.Parse("2d4f151d-6992-48d8-83f1-c91b1aeab93b"),
Guid.Parse("5a101849-ab52-4fc0-b138-408cae5fc40d"),
Guid.Parse("fd3c1751-81ad-4b9a-8d24-7b79d5cfb0a0"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 3,
    Value = 
new System.Guid[3]
{
Guid.Parse("e079838f-53a7-4f59-9eca-53894c427a54"),
Guid.Parse("3d2f9d28-b841-4b7b-9bb2-003d48b0da26"),
Guid.Parse("610b2f91-b66b-4a20-8301-f7704ce65112"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("5cd0e244-9d5b-49d0-8c3c-7cb3656d1763"),
Guid.Parse("415d2cf9-4f53-4b64-bea6-f7df2cc29702"),
Guid.Parse("714e0166-6a35-4c02-b275-7c4ff46d6da8"),
Guid.Parse("285fe7f1-0954-451c-99ec-734131b47ecc"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 7,
    Value = 
new System.Guid[3]
{
Guid.Parse("4772f2af-17e4-44f8-95cb-63a9fe57eb81"),
Guid.Parse("0591df6d-215f-42e6-841f-0ecceeb4499e"),
Guid.Parse("7df230a3-54b7-4d1d-93e4-60d54ce7c2a9"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Guid[4]
{
Guid.Parse("16494309-bcdb-4626-a080-ba71051229db"),
Guid.Parse("c8f0123c-d074-4302-8ec9-705720c81361"),
Guid.Parse("ea8847f9-cefa-445a-bda5-e26f8d114fa4"),
Guid.Parse("5622b529-6317-476b-8e8d-85eaac6d309e"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 10,
    Value = 
new System.Guid[4]
{
Guid.Parse("5fa800ee-a783-449b-9598-77c7e9068b43"),
Guid.Parse("54db2ca7-1bb2-4c28-994e-1add1f58b542"),
Guid.Parse("f9bbf119-f40b-496f-8f13-f0d24b76cd49"),
Guid.Parse("a9425110-0eda-4d0f-a829-10ed2d30b579"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 13,
    Value = 
new System.Guid[4]
{
Guid.Parse("f7580ca3-a372-4d82-8a59-4a3431418d56"),
Guid.Parse("e7c4de8e-8e8f-4aba-aa5c-3a15ca5780e3"),
Guid.Parse("ed2a6293-1275-4e14-aa95-9a416e7023e5"),
Guid.Parse("b7fc9fd2-5714-4bba-90fc-e05cc521a1ed"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("691aac86-1b6d-4846-a32f-b41dc72eb8b4"),
Guid.Parse("b598ed71-dc77-46fd-a670-0bdbd801bf9e"),
Guid.Parse("cbc608d2-a875-4e7d-8bcf-5b86c2d1439e"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 17,
    Value = 
new System.Guid[4]
{
Guid.Parse("f90d78b8-1526-4710-b8eb-e72e81b96bbd"),
Guid.Parse("9f6d3027-363c-447d-899c-c7247b5b6aae"),
Guid.Parse("ba56bf4e-c242-4a50-ba64-ff5f889dc4d2"),
Guid.Parse("bf555ed9-05ba-4fa5-ac57-d2c0b81b2ecb"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 12,
    Value = 
new System.Guid[3]
{
Guid.Parse("f536ca13-81df-4e6d-a0b4-a14350054c92"),
Guid.Parse("d849a0cd-45e4-435f-bec6-77b9c65f0f05"),
Guid.Parse("ed445d0d-904e-4dce-a985-42d85d440011"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("401c4d70-cf16-4e3a-bbe0-6b836ee04331"),
Guid.Parse("89de9a9e-3e38-4208-a2e0-dba730da0c0f"),
Guid.Parse("6382472c-fdd8-4257-a1f5-8d89e274caa8"),
Guid.Parse("9d4e38bb-6ccb-4989-8173-265698d228ad"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 22,
    Value = 
new System.Guid[4]
{
Guid.Parse("2c4269e9-e36d-4930-9a2b-baa8ffbe735c"),
Guid.Parse("11d49edc-cd8c-4e39-82e7-7e21b87d308e"),
Guid.Parse("bd47dd35-7b7d-42c0-a0f7-cf31822a0daf"),
Guid.Parse("b099195b-7a2e-4777-9a17-5b33e4a0ac86"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d13b53ba-af6f-49ad-a8d4-97cd2b90cb59"),
Guid.Parse("3d7e4af4-a7fe-4903-b34f-03319ef60557"),
Guid.Parse("60195ebb-7384-4aef-8890-3764109290c9"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Guid[4]
{
Guid.Parse("c2c28356-ea36-4745-911c-f86d9bda6f3e"),
Guid.Parse("8e17ff46-3f1f-48cd-8406-6561b502b4bb"),
Guid.Parse("89a13e2b-e233-4c4f-a465-5a9cadb88132"),
Guid.Parse("666f0f2a-666c-477f-ac0e-4d8f0853c59a"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Guid[3]
{
Guid.Parse("699162bb-8bbb-4b9a-98cc-84f4e3faaaf1"),
Guid.Parse("96fde6c3-66a6-4910-a8f9-4febbaab68c3"),
Guid.Parse("2721fc5b-6b35-4cae-ac03-177e35ea72f2"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 30,
    Value = 
new System.Guid[4]
{
Guid.Parse("8fe1e2b6-fda8-4cba-b251-6e681b88be1f"),
Guid.Parse("bf82bcad-e24f-47dd-8ddc-5297b27a8cdb"),
Guid.Parse("920d9dab-ba5e-408f-8981-937ab48d53e8"),
Guid.Parse("e03957c5-0039-4114-b0b2-f7e695d1a4ae"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("382e3090-5f2a-4a3b-badd-03ede1b36b1d"),
Guid.Parse("1e81ef94-1dbe-4d39-805b-0c38f29d1b96"),
Guid.Parse("42e21c5e-ed86-4c56-a2fd-d1f73779e1a8"),
Guid.Parse("a3d9a223-ee3b-4f7b-a799-fdf06d20e6de"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 36,
    Value = 
new System.Guid[4]
{
Guid.Parse("fe0ca579-71b5-48f8-92c0-6b9136083913"),
Guid.Parse("9fdbba48-526c-424b-8097-f38e4d9e8f53"),
Guid.Parse("fda9e797-6c72-4329-8c0d-f3362d88f302"),
Guid.Parse("662acc88-4a7d-41d7-9790-7dd8f5f5b9fd"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 19,
    Value = 
new System.Guid[3]
{
Guid.Parse("03919176-ad0c-4cbe-9da7-5f8d3fc7b201"),
Guid.Parse("62810cb1-d402-4875-b05f-2508e4b39fb7"),
Guid.Parse("75fcf65b-aa99-4f13-aaa3-0666db8ded8b"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("72c4ada0-cde4-4039-858a-23bcc8b727c1"),
Guid.Parse("5585548b-959c-4bdb-a3aa-9ad0c8c12793"),
Guid.Parse("eaccb240-6b98-4852-8346-1a0fe88a8848"),
Guid.Parse("326ab261-3b00-49a9-8918-b400b930cf0c"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7c741486-136a-4000-80f8-8bbc048832ee"),
Guid.Parse("edbd8af5-80eb-41df-98b7-a6030e6e93d4"),
Guid.Parse("085f2a26-ddd6-462b-a7bd-060921c53fc1"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 39,
    Value = 
new System.Guid[4]
{
Guid.Parse("1ffca841-b2bc-441c-bbb1-c6fcef5e979e"),
Guid.Parse("cf23fd56-0a64-45b5-ab3b-e416485b1699"),
Guid.Parse("c9c5b406-26f4-40d0-97db-a91371929fb2"),
Guid.Parse("efc58314-a952-452b-a1dc-faeeec2db622"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 41,
    Value = 
new System.Guid[3]
{
Guid.Parse("2b0bb954-3202-4a13-994d-ac29417c46f3"),
Guid.Parse("853e2bd0-8f45-4115-aaad-c9ebeab6c87e"),
Guid.Parse("cc39c10c-2002-4999-b143-8a6ebd391a75"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 26,
    Value = 
new System.Guid[3]
{
Guid.Parse("3e0d2db8-9769-4980-9ef8-a12d3e0b73f4"),
Guid.Parse("c1a219ed-09f8-4b96-bdc0-a77c9569653a"),
Guid.Parse("823201f0-c5cc-44ed-9bb2-81f589d91e37"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6d26bc9c-64b1-4bf2-a962-252450e7cc86"),
Guid.Parse("14576133-3f2d-4b39-916d-f9fb06b72a1e"),
Guid.Parse("8658b783-6de6-4418-8499-0e4ca15a7eb3"),
Guid.Parse("69bd5242-5996-4d2c-a61c-2be430ca1926"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("3b8b7f84-8f5c-4b80-9f8a-ac299398bbac"),
Guid.Parse("904a28c0-ec44-4f44-9543-1eb8234d9003"),
Guid.Parse("0d756580-e441-4804-a9c0-ff6957667364"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 44,
    Value = 
new System.Guid[3]
{
Guid.Parse("6cb11d49-3b68-41d9-afcc-911e2588a69f"),
Guid.Parse("133b957f-6b8a-4858-80a7-d01fc31cc9de"),
Guid.Parse("4577a3d5-2a6c-45bd-8c26-0b300a1fc2fc"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 48,
    Value = 
new System.Guid[3]
{
Guid.Parse("3128e808-01a2-472b-a429-74cfc27ea819"),
Guid.Parse("520ad81e-1d2f-4cf1-8f20-3d1b40815ae2"),
Guid.Parse("0311edb2-ff7d-4826-b38b-5feb42951e16"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Guid[3]
{
Guid.Parse("985af664-2c3b-4785-92f9-0748589b63f3"),
Guid.Parse("3ba314ee-4457-4098-a47a-89f4337b224c"),
Guid.Parse("2f136fb5-57f0-4663-b777-95b18be2e573"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 53,
    Value = 
new System.Guid[4]
{
Guid.Parse("7fc938ac-35c1-4a4d-961a-5ce04f57e332"),
Guid.Parse("557ed540-3baf-49c3-872a-2e5accf7cce6"),
Guid.Parse("4a983de4-5808-447b-b32b-d882ae518900"),
Guid.Parse("bc9bce06-f79e-461c-8ba4-d854d65460b6"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("71605741-6533-4f0b-a1ac-031d9714a7de"),
Guid.Parse("0ba6dbf4-0a1c-442f-9057-39ec57fa4f61"),
Guid.Parse("77211d25-62d7-414e-a28a-a043051b2458"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Guid[3]
{
Guid.Parse("6fdab4a5-795f-4e82-96e5-e81d464f95a5"),
Guid.Parse("6d37db0b-65e3-4771-b765-2241ff0ff951"),
Guid.Parse("7ad22e7e-5d29-489d-aca9-102a1b0a1bde"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("fe8b5ea8-7dbf-427f-9ee7-ed0d7c11376d"),
Guid.Parse("43eb4cef-02ba-487a-bf75-9e95c94bbb77"),
Guid.Parse("ce212e0b-1459-41eb-9a80-1dd76bb837d0"),
Guid.Parse("9b8f2641-5d98-4510-927d-e6cbb87a9c9a"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("55620afa-02e7-48e1-8c99-b66189ea3c45"),
Guid.Parse("87b8d710-4f9a-4821-b901-6a124d0e7786"),
Guid.Parse("88014d12-5863-4bb0-af03-64d65197718a"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Guid[4]
{
Guid.Parse("b66773e0-4418-46e1-9643-05d9b96b09d2"),
Guid.Parse("c42c0bb7-c464-4a10-8283-377c557dda10"),
Guid.Parse("79d5f682-c33e-46db-bae5-1070eb194c5b"),
Guid.Parse("4a692d64-9e71-45b8-9ac6-bc1b99aa7640"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 68,
    Value = 
new System.Guid[4]
{
Guid.Parse("9e3ab275-c866-4b5e-9bcb-62a1c8a561d6"),
Guid.Parse("93e3dcbc-2896-48f5-8cc3-df4465e51b5e"),
Guid.Parse("f37ade85-7fcf-4219-886b-951c73a485dc"),
Guid.Parse("3a244816-b3b1-4752-9f8e-cc5f07c5ae0f"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Guid[3]
{
Guid.Parse("6c03310b-73dc-4887-8c4b-9a891aa3a257"),
Guid.Parse("4c2fa759-83fa-4c0d-8461-3bf3190c8d4f"),
Guid.Parse("5f182497-1a5a-44cb-ac19-6b6909681030"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 73,
    Value = 
new System.Guid[4]
{
Guid.Parse("41fb5dfb-00e1-489f-a02d-2e64f5847976"),
Guid.Parse("de774523-9388-489f-bdc6-66cec3333843"),
Guid.Parse("f7209783-ac49-4c3f-97b1-84e4842ad7cd"),
Guid.Parse("21d0792b-2480-4b02-8e89-43f01e5f87fd"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 80,
    Value = 
new System.Guid[3]
{
Guid.Parse("29870cc0-9eb1-4509-bd80-9ccdf8e3845d"),
Guid.Parse("7d968329-4216-4974-b7b8-780697254d0e"),
Guid.Parse("2a780e33-2f6d-4aea-adc0-65de0b6ae8be"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 45,
    Value = 
new System.Guid[4]
{
Guid.Parse("07a7c4e9-bd15-40f9-ae01-3a547eb8bb77"),
Guid.Parse("9af5aa91-dd6d-4837-bba8-27aac5c6d889"),
Guid.Parse("ba8c718e-e6ff-4454-8e4d-f1bfe59e212d"),
Guid.Parse("f96ae43e-c3b9-4a4b-8438-0f0b2084da92"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("33e80bd7-d218-499c-9891-6bbd5a282b14"),
Guid.Parse("f0586d40-c7a5-4968-98d7-2a1a89b5b781"),
Guid.Parse("c564dfa4-661d-4104-9009-25111c8d80aa"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 88,
    Value = 
new System.Guid[3]
{
Guid.Parse("ede60e47-951e-4f85-9d5e-3d58e947e818"),
Guid.Parse("5fc1a34b-52d7-439f-9312-fa650ed549b5"),
Guid.Parse("b750d3bb-c169-4361-ad9b-99ce6abcb4d0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 91,
    Value = 
new System.Guid[4]
{
Guid.Parse("13afd766-ac1b-42ea-9b50-2af81a6419ef"),
Guid.Parse("41729a21-ba07-4e21-b209-c423ed5243da"),
Guid.Parse("459035d6-e793-4116-91b1-6f69df952088"),
Guid.Parse("40e08ed3-00ff-4d76-af83-727245589791"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Guid[4]
{
Guid.Parse("5d790aac-93f0-4311-94c0-b4a74c9fae8f"),
Guid.Parse("00c3a3a8-2a95-4d5e-b0a2-035923e0ea8e"),
Guid.Parse("423f53fa-cb50-4bd1-b66b-b4271d09b026"),
Guid.Parse("952be8b5-e8ba-4931-af40-959c12f63b8d"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("abbb9af1-a178-4e36-aceb-6a7a8b76ab34"),
Guid.Parse("24e96621-f4bb-4e8b-8c75-1f16cf09d3bc"),
Guid.Parse("3c4bfdbc-eca4-48f3-88c2-ad0df46575ef"),
Guid.Parse("c9a74b30-931c-4c99-8e36-cbe209ce34a3"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 100,
    Value = 
new System.Guid[3]
{
Guid.Parse("013e4abd-756e-447c-b05f-d78b9be646c2"),
Guid.Parse("6a5be655-d594-4f34-a24e-2358f060b75f"),
Guid.Parse("81fb383c-41f8-4d02-aade-b8fb5b78ab7e"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e2b4d569-97f9-4ae5-9516-7da99849ff78"),
Guid.Parse("5ca59de5-fbe1-45ce-845b-8af0c751562e"),
Guid.Parse("fbdf9772-6cc2-4a79-a3b7-2e98667a9480"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 106,
    Value = 
new System.Guid[4]
{
Guid.Parse("0c4dc8d7-03c2-40cd-99ac-c2f768f51f8b"),
Guid.Parse("220ca74a-623d-47c2-89a4-7ff035aa0a11"),
Guid.Parse("c37559df-5287-4a36-bece-e65ea9c49dda"),
Guid.Parse("41587e2e-ac73-4fec-8b7c-21dd7dde1df6"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 51,
    Value = 
new System.Guid[3]
{
Guid.Parse("2fa090ae-a3a7-4dd0-9387-0f9953e54591"),
Guid.Parse("d87e4fa8-68ea-472d-99a6-9049e654e393"),
Guid.Parse("f61d801a-8635-4a64-ac90-5a4499cc92c7"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 112,
    Value = 
new System.Guid[3]
{
Guid.Parse("4dcc341b-181d-4968-a8bd-eddd8e8a4055"),
Guid.Parse("9fe422d2-d08c-4a6b-87c7-58530ea83e86"),
Guid.Parse("2680bf9f-0643-45b1-8fa7-f0ca561476cd"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 118,
    Value = 
new System.Guid[3]
{
Guid.Parse("503a2669-8142-4590-955c-0da33255cdcc"),
Guid.Parse("0073021d-afec-47b7-96ed-678061d944d7"),
Guid.Parse("034161da-3c99-46d5-b71d-55bca32daee7"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 59,
    Value = 
new System.Guid[4]
{
Guid.Parse("ca3dcc8c-1b51-4b33-9b27-f05eb73c77db"),
Guid.Parse("9b448139-dca3-4626-8a91-0a480ae8d2b6"),
Guid.Parse("be6f13f0-c904-4d2a-9203-47f9bf41f494"),
Guid.Parse("e66e319e-deaf-422b-b37c-eac3150cffe6"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fa456834-5dd6-4045-ab54-6bd1f8f14eb8"),
Guid.Parse("eef47066-6312-408a-91a3-35d095a51c5c"),
Guid.Parse("ed6a0e70-daf7-42ab-86e0-ab7c9ebb37b2"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("bc6a7c6c-cc10-455f-b543-0200a0758cee"),
Guid.Parse("6078857d-f732-4699-b497-204ae51174cb"),
Guid.Parse("6ac81d5c-a26e-4911-b7bf-897a22c709b5"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 124,
    Value = 
new System.Guid[4]
{
Guid.Parse("a6cc6d45-d3da-4a54-ac4e-a55d984cb4af"),
Guid.Parse("c08c361e-0e1f-4ec4-ad12-1c5144427e82"),
Guid.Parse("4b9ad556-f9b6-4305-931d-07cf7c9d8137"),
Guid.Parse("75bcbba1-59bd-4454-bad7-858b50419a59"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 130,
    Value = 
new System.Guid[4]
{
Guid.Parse("d1585021-5322-4534-b993-228e9212dedd"),
Guid.Parse("1299028f-abfa-4223-9445-1a3a54fd5a4a"),
Guid.Parse("16f4cd0c-ddb5-408c-a7b1-4030c08626ee"),
Guid.Parse("6d3d702b-6e6a-4199-81f3-2adb9e162fcc"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 64,
    Value = 
new System.Guid[4]
{
Guid.Parse("e02ac06d-7270-47a4-a43f-c50b7cbd2450"),
Guid.Parse("5462a5d2-384f-49bd-8d6b-54cb7eef24cf"),
Guid.Parse("e30716d0-fc32-478b-8648-61c3c526e9b7"),
Guid.Parse("5eee92a1-5e61-4d22-9bc0-f563db6e0b8a"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fba69af6-ef0a-4eeb-8972-c7a85d17f42f"),
Guid.Parse("de5e4af4-13fe-4b2c-8ac0-a0ca9d08d096"),
Guid.Parse("489ea23b-b518-445a-b022-2d6b41480fdd"),
Guid.Parse("f9ea44d1-2a90-4a61-b583-1f68bfdf345f"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 138,
    Value = 
new System.Guid[4]
{
Guid.Parse("cb7fae92-f560-4974-8375-2eb71a145345"),
Guid.Parse("b76f622b-9a6d-45fb-b848-1b2ae5e17361"),
Guid.Parse("336462ef-6ce8-443a-b332-5d5bb3a53114"),
Guid.Parse("83eef086-9c08-49fc-a865-07b9b003d6fa"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Guid[3]
{
Guid.Parse("46d0ea5d-b409-4b49-9d04-457413b91f6b"),
Guid.Parse("13bf1f78-f39b-4268-be76-df14daefde0b"),
Guid.Parse("edd7af7d-c34a-4d03-85f9-ec4892b797c1"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 73,
    Value = 
new System.Guid[4]
{
Guid.Parse("6596b5bd-b2b5-48c9-826e-83d5e63bc0c5"),
Guid.Parse("df31b64f-4fe7-4656-a424-52ec2dddf10e"),
Guid.Parse("703957f8-da54-4d50-80c6-2780a6f44716"),
Guid.Parse("9e124aa6-ccd1-442a-a0db-d3ff68809e14"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a209bbba-dfe9-47e4-86d0-6b1d1955d066"),
Guid.Parse("d64ae693-445a-42a5-a795-8ee6ad54dcca"),
Guid.Parse("02302661-ad72-49f4-bbdc-94e5137b5189"),
Guid.Parse("ab590d0e-8cbb-47c0-b0d9-2b0df783fa38"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 155,
    Value = 
new System.Guid[4]
{
Guid.Parse("73789581-0189-43a4-8d97-64c180f689c8"),
Guid.Parse("a03a5ec4-e35e-497f-8166-524d14c9cf25"),
Guid.Parse("9f32104b-588f-46da-abed-e8ef15b3962c"),
Guid.Parse("49f9ec14-1adb-404f-a895-50424c928f72"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c19a097d-0027-497f-ba27-26e9b4118694"),
Guid.Parse("13e1dab7-683e-4637-9c90-dd612ed9b992"),
Guid.Parse("b2e88cb3-d941-4426-94ee-bab8d9822157"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 162,
    Value = 
new System.Guid[4]
{
Guid.Parse("64128ea7-e62b-416d-86b6-ba266ecc3b79"),
Guid.Parse("b0333e07-845e-4fa8-881b-c4d1e3ed7400"),
Guid.Parse("b86050fe-cb30-48b6-b881-9fc9f2696ddd"),
Guid.Parse("da958b80-59d0-45b4-b2ac-61fed78ddf56"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Guid[4]
{
Guid.Parse("67a01d7f-6599-48ec-aa9f-00e302b7ce20"),
Guid.Parse("5655aa10-6dbf-4430-bde4-80d49c873a0e"),
Guid.Parse("cf5652d9-7a99-4db2-9e40-75e38894bca4"),
Guid.Parse("d6104e0f-f318-4cd7-add1-bbe315bde699"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("88bf2ee3-17e1-42c0-a4b8-3da10e2cfbb6"),
Guid.Parse("0a9eee88-7a41-4a2e-a6f8-03a03c8841e3"),
Guid.Parse("c873df65-d837-4be7-97b5-7eb7f66e019c"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("1ff74193-ee19-4d39-ab20-004f7ec45ca0"),
Guid.Parse("18c0b7d2-3295-4e50-8df6-93f02fd9de9d"),
Guid.Parse("171b2e0e-7f07-49e0-99ea-0fc060203c05"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 167,
    Value = 
new System.Guid[3]
{
Guid.Parse("8d673950-0fca-45c7-b5a1-915ec53452ec"),
Guid.Parse("f537c2cf-7787-49af-985a-db42f99655f6"),
Guid.Parse("02e3ee05-ebbd-404f-a0cd-1c276d2f3be5"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("91e808d6-3ab1-46e3-b3ed-ac0d5974f8a5"),
Guid.Parse("96fca185-f8f4-4730-a9f3-a9ea4fa325c3"),
Guid.Parse("a52ac6c1-96a4-4baf-bc5f-17e7d1218ba5"),
Guid.Parse("182b1b47-a89b-4872-a3af-5764bf28cce7"),
},
},
            new GuiduuidMMArrayD1E1M
{
    Id = 175,
    Value = 
new System.Guid[4]
{
Guid.Parse("0af6a8bb-412e-40f5-b6b7-7c3c11336763"),
Guid.Parse("1e2a0898-02ae-4638-8e63-59387ee7c4c8"),
Guid.Parse("14234642-91f2-438c-99db-c1c8b0965b11"),
Guid.Parse("46d511ca-6f67-45f4-a7f6-d136bd705aee"),
},
    ModelInner = new GuiduuidMMArrayD1E1MI
{
    Id = 86,
    Value = 
new System.Guid[4]
{
Guid.Parse("422502a3-a4e0-40b1-89d8-1f3102968a6f"),
Guid.Parse("0e88aa8f-47f3-43e9-9324-8c8c28900737"),
Guid.Parse("75352465-a8cd-4e10-8e67-eaa507033d0c"),
Guid.Parse("7982d7f9-899e-44bf-ab62-84ba694b60ad"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("767d5378-4f4d-42e0-b131-eca149bb1769"),
Guid.Parse("b920d68f-5c76-47d7-be70-34f0e9bcf154"),
Guid.Parse("b98892ed-9c67-4b7a-b5c1-4de5e9be8b09"),
Guid.Parse("794662bb-7f24-422a-84b6-0a23940e1b52"),
},
},
    NullableValue = null,
},
            new GuiduuidMMArrayD1E1M
{
    Id = 181,
    Value = 
new System.Guid[4]
{
Guid.Parse("6f61f200-729d-4f71-9e30-3bafe669bd81"),
Guid.Parse("4314e3e9-9546-4f21-b72c-c0c498cb41eb"),
Guid.Parse("8c1a7b29-f2ca-451f-9efc-4a9da926101d"),
Guid.Parse("4b6f2943-fc09-468f-af52-7dcb160b6e57"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8c0be57f-5fe3-46ca-b3fa-221b75c8ba76"),
Guid.Parse("bf6701e6-1da3-4a00-a3d9-1203ac381818"),
Guid.Parse("d27ebfb3-2dec-4d5e-96aa-f359eff9b4c0"),
Guid.Parse("f2eed685-7781-496d-ad13-6d312192b955"),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1mi(
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
INSERT INTO public.guiduuidmmarrayd1e1mi(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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

                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)), 
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
                methodParametrName: "guiduuidmmarrayd1e1mi_id", 
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
                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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

                    nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("691aac86-1b6d-4846-a32f-b41dc72eb8b4"),
Guid.Parse("b598ed71-dc77-46fd-a670-0bdbd801bf9e"),
Guid.Parse("cbc608d2-a875-4e7d-8bcf-5b86c2d1439e"),
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

                    nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("401c4d70-cf16-4e3a-bbe0-6b836ee04331"),
Guid.Parse("89de9a9e-3e38-4208-a2e0-dba730da0c0f"),
Guid.Parse("6382472c-fdd8-4257-a1f5-8d89e274caa8"),
Guid.Parse("9d4e38bb-6ccb-4989-8173-265698d228ad"),
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

                    nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("d13b53ba-af6f-49ad-a8d4-97cd2b90cb59"),
Guid.Parse("3d7e4af4-a7fe-4903-b34f-03319ef60557"),
Guid.Parse("60195ebb-7384-4aef-8890-3764109290c9"),
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

                    nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd1e1mi_id
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
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                methodParametrName: "guiduuidmmarrayd1e1mi_id", 
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
                nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("382e3090-5f2a-4a3b-badd-03ede1b36b1d"),
Guid.Parse("1e81ef94-1dbe-4d39-805b-0c38f29d1b96"),
Guid.Parse("42e21c5e-ed86-4c56-a2fd-d1f73779e1a8"),
Guid.Parse("a3d9a223-ee3b-4f7b-a799-fdf06d20e6de"),
}));
                nullable =  ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("7c741486-136a-4000-80f8-8bbc048832ee"),
Guid.Parse("edbd8af5-80eb-41df-98b7-a6030e6e93d4"),
Guid.Parse("085f2a26-ddd6-462b-a7bd-060921c53fc1"),
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
                nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidMArrayuuidMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("3b8b7f84-8f5c-4b80-9f8a-ac299398bbac"),
Guid.Parse("904a28c0-ec44-4f44-9543-1eb8234d9003"),
Guid.Parse("0d756580-e441-4804-a9c0-ff6957667364"),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD1E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD1E1M> models = null;

                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 30;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 54;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[6], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[7], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[8], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[9], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M), typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 36, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD1E1M>();
                ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 80, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 155, query1, 88, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 39, query1, 48, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 13, query1, 112, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 41, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
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
FROM public.guiduuidmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD1E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD1E1M>();
                 ((IGuidMArrayuuidMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 9, query1, 112, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidMMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuidmmarrayd1e1m m
LEFT JOIN public.guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 36, 112))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 9, 130))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                await using var cmd = await ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 48);
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                GuiduuidMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                GuiduuidMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MI),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidMMArrayD1E1M),
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
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
FROM public.binary_guiduuidmmarrayd1e1m m
LEFT JOIN public.binary_guiduuidmmarrayd1e1mi mi ON mi.id = m.guiduuidmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models =  ((IGuidMArrayuuidMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd1e1mi
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
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI), typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models1 = new List<GuiduuidMMArrayD1E1MI>();
                var models2 = new List<GuiduuidMMArrayD1E1MI>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MI>();
                var models2 = new List<GuiduuidMMArrayD1E1MI>();
                ((IGuidMArrayuuidMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1)),
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA), typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidMMArrayD1E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD1E1MIWA>();
                ((IGuidMArrayuuidMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD1))]
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
                var models = await ((IGuidMArrayuuidMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidMArrayuuidMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


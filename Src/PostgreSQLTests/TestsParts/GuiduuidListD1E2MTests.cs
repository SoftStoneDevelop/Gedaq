

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
    internal partial interface IGuidListuuidListD1
    {
    }
    
    internal partial class GuidListuuidListD1 : IGuidListuuidListD1
    {


#region TestData

        private readonly GuiduuidListD1E2M[] _testData = new GuiduuidListD1E2M[]
        {
            new GuiduuidListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a9dec066-bdd8-43d2-8aea-dfe2b2dde037"),

Guid.Parse("568e6c27-e973-42fb-aafd-963d394144fd"),

Guid.Parse("66de0b99-6747-4e8e-a13e-071ca30ae33b"),

Guid.Parse("1a051588-d269-4a8e-84fb-243df89a7a6b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("56c85a71-7974-4b5b-b758-9dad74f7b59a"),

Guid.Parse("31930ba9-6ccd-47de-b1f0-0de698ab9f9c"),

Guid.Parse("dcc72d5f-065a-4454-b17f-d704c3f885cc"),

},
},
            new GuiduuidListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ba005205-564e-4cf4-81fa-9f560cb92d97"),

Guid.Parse("62fe8cb2-1a06-4d73-a6ed-a4ef0e3abab3"),

Guid.Parse("4a5f58be-2e23-4678-8e8f-622609157235"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("572cd6b8-322d-4c4d-883e-ef12c37dd650"),

Guid.Parse("06a94e00-eb96-4fad-9a88-f03446423fa5"),

Guid.Parse("5523419b-091b-41f1-864b-37f3d06c0aae"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9815e93f-f391-406a-a9b9-d011cee25dc2"),

Guid.Parse("34e55a4b-c747-45f2-80bd-96c1c43e1b27"),

Guid.Parse("1902e7ac-553c-4b46-929c-2e69277c0aa1"),

Guid.Parse("41a42a85-f7e5-498c-af5a-fbdc17f8da52"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3f020103-c83b-4295-822d-fe85ecca12c2"),

Guid.Parse("a369528c-d52d-4a02-8c9e-2e93c9c041c6"),

Guid.Parse("034658a1-dc55-42a6-99b2-c0c3e1699796"),

Guid.Parse("91f1d132-9697-4d2e-915b-a765b27f69f8"),

},
},
            new GuiduuidListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9b3bdfdd-231b-4258-a9ea-407b33e0ae5c"),

Guid.Parse("d6f67e56-2d49-43ce-8fa4-30fcfaccc8a2"),

Guid.Parse("cba3fd55-9da1-46ef-9b2e-108a69beb5f7"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6de68b49-bc2e-4c35-bf05-b720fa88f84e"),

Guid.Parse("6862deec-f302-4bbd-8f00-7fc532bb7cff"),

Guid.Parse("3ec09c14-176a-45e3-a6bb-0b454c0ed143"),

},
},
            new GuiduuidListD1E2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("03ffa9b1-3af1-46ae-a174-27ceb59d31c8"),

Guid.Parse("88fd7146-b5fa-45ab-8265-db3f53003c11"),

Guid.Parse("ed004aa6-86fe-4026-9327-50db8fc4ef51"),

Guid.Parse("0f0e8956-05a2-40fb-ad1a-c5f560a621b4"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2696c236-13b3-4541-ae00-77b5061f4ec9"),

Guid.Parse("831ebdd4-0b61-4a37-8e0d-3fd1808d2d68"),

Guid.Parse("5e06b111-951c-4409-9554-526ab30cef4f"),

Guid.Parse("dc26c718-b0e3-4bc3-8481-11306e19ba26"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bc1be8ab-67e2-42e9-b4b1-7b58577425a9"),

Guid.Parse("57f1ece1-fa35-448d-b653-fcc5bccbbe4c"),

Guid.Parse("7eb65523-0064-4dee-b0a4-bea3430205be"),

Guid.Parse("7dd5c94d-911d-4c1f-ae24-db7ffa905d29"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("89e1c086-9eb0-4380-b6ba-c4b1467f92e8"),

Guid.Parse("b7d60d8e-7569-4f25-becb-20eafd6c45f8"),

Guid.Parse("4e3f098c-8f96-4e19-85d2-d1c09832e8e6"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d1f45dd5-7b18-494a-ac4b-b7121beaa95f"),

Guid.Parse("b7cc42cc-9053-43cd-bb6b-f817ac087789"),

Guid.Parse("cf6ece8e-8de2-4f8a-8845-be89bbf23057"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6f92ec0a-f94a-4e47-99d0-8d31aa8ba3f9"),

Guid.Parse("f88adc9d-99dd-456f-ac2f-28289a7507a6"),

Guid.Parse("01a85eef-a25c-44af-8f3c-927067d7d006"),

Guid.Parse("04089f5d-03d8-4236-83a7-80a0035dbb50"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b7d239a7-e070-4b10-a930-9a828596e5af"),

Guid.Parse("3a080197-e5de-4544-9781-6296d27e806c"),

Guid.Parse("3584bd4c-6984-4c7c-98cf-e3cb96ae5644"),

Guid.Parse("7a8b2f50-6bb8-443a-ac86-dceb96ca7c8a"),

},
},
            new GuiduuidListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f6bdf10f-4cae-4769-944e-c34223ce6099"),

Guid.Parse("a1db256b-f98c-4e87-a7ba-d263d3e4cfc2"),

Guid.Parse("95c4b8a5-f6d8-4178-b963-66c9f2733a1b"),

Guid.Parse("d0eb36fe-7105-43b1-8b91-a039bee3f754"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1ff8fc39-8e20-49f0-abf9-0b4eb011be1a"),

Guid.Parse("bb3202ac-c06b-45cb-9454-03fcf247b385"),

Guid.Parse("3c7ab70a-8402-403e-9d99-79cc55f6566a"),

Guid.Parse("5aa06ccf-cf34-4adb-81a0-a8c8ff8929f7"),

},
},
            new GuiduuidListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5a88a090-3db3-41f7-9726-32cd3d805a3e"),

Guid.Parse("71bd84ac-9140-4c75-8863-8fa0a851c458"),

Guid.Parse("04576db0-b3f0-4d0f-9d44-c90efb62ed71"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3a651b92-5ab1-4f77-9bb0-0acb2c85ad2d"),

Guid.Parse("568d6be1-ba81-4a96-89dd-f5f075d04107"),

Guid.Parse("6acee31d-8326-46d5-b45a-38d85554fcc3"),

Guid.Parse("889856fd-94c0-47b0-ae09-e8936697c56a"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bbd31b79-11a4-450c-9ac2-fccea1c84ffd"),

Guid.Parse("027e223b-4572-4c8d-97e0-88bc0e2c09f7"),

Guid.Parse("11e9c97e-a5fe-4638-a8ea-200479b880db"),

},
},
            new GuiduuidListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("00ee6b10-59b6-4465-8a96-543515542c76"),

Guid.Parse("6ff83bac-a227-438c-95dd-2b257568997f"),

Guid.Parse("1e4791cf-d1f7-441f-9f4f-18617a5dde2b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("da3e1c61-cbb3-486e-a7ac-01fb0dfb35e3"),

Guid.Parse("e59abf91-4e99-4a48-a37e-fc4a37534319"),

Guid.Parse("0666bdcb-16ae-4f94-8bdb-ac8482a96300"),

Guid.Parse("c6e30e27-d58b-4352-858a-589e255a7763"),

},
},
            new GuiduuidListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cac788c9-b9f4-4997-805d-71ffa37b1975"),

Guid.Parse("9250a904-43e7-41ae-aaac-f10b58711e21"),

Guid.Parse("649fdd2a-1dfa-4193-989c-36789df66d29"),

Guid.Parse("3849c349-1d51-4572-89d3-855af4954199"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("314d777e-f316-4fab-a856-9c4f0bbe8d47"),

Guid.Parse("2a5ae5da-90fc-495c-b558-23172bca84fc"),

Guid.Parse("794d1ed9-0c6d-469f-9833-9b627962f4c6"),

Guid.Parse("45980a4e-bdb0-4ce5-88ad-dfa4cb740668"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0563aacc-e2db-466a-9058-09447acc61c5"),

Guid.Parse("dee5beee-214f-4e7d-b71c-72a92abe037a"),

Guid.Parse("7e81e63f-7d2e-4444-8029-eb55df63c540"),

Guid.Parse("40a245c0-5a04-44a0-8462-fc1814bce281"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("826d7d4d-a6b3-4cd5-9ad1-a064c99888ec"),

Guid.Parse("96758729-7d07-4780-ade6-bf87692dffd2"),

Guid.Parse("f8ac1fff-8d0f-434a-be3e-5e906aa05931"),

Guid.Parse("ed3a43d6-f3ef-4e9a-8dff-33b4edcbda9f"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("06df8ed4-3c8e-4ad2-ab42-505531985f04"),

Guid.Parse("e5e75ad9-cbdd-4d70-aa77-05c37bcd0acc"),

Guid.Parse("a840a84c-8d59-41bc-b6a8-8d3b55a123fc"),

Guid.Parse("ef57c727-7b02-4a5a-a7cb-e27c93d866e7"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e6bc84af-fcd2-48f4-a221-6e98ae367083"),

Guid.Parse("ad83862f-1be2-45ee-8ae7-d03f0b9627b0"),

Guid.Parse("e52d871e-9e97-41e1-b9ef-7fc39a277198"),

Guid.Parse("7eb34cf4-fdaf-4ff5-b2e0-f9c44a01cbf0"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e036a565-c36c-4d1d-8fd1-85fe79525931"),

Guid.Parse("8d9e5ff7-e6d5-454d-8312-6f4a5b353d00"),

Guid.Parse("9994c2ec-5acf-45a4-b1db-1b6ce583e99e"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b40ade6a-00e5-476a-a4e0-5b39d2a71ab2"),

Guid.Parse("fe42591f-6a0d-4e56-a510-ae804c1625ee"),

Guid.Parse("edd8d87b-c516-4f1a-9277-e12be49cf95b"),

},
},
            new GuiduuidListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0e6b5a0b-de97-4f6b-89f8-e19f95cd133e"),

Guid.Parse("121cad11-4da2-4f3e-a878-6feb944c8353"),

Guid.Parse("c5cef14b-1692-4769-b7c6-7418136c513a"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5345e549-c3bb-4717-824c-b669fce13517"),

Guid.Parse("61687ae1-5ff7-49f7-98b2-f338a23ae7fd"),

Guid.Parse("a65f68b3-ee6f-4c6e-a4e9-9af8860655fb"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cb8a1a27-c63f-450d-bff2-6576c34dca05"),

Guid.Parse("7510a36e-0f33-4d70-83b6-1b59bcf6b447"),

Guid.Parse("8e36b199-793b-42d2-a9ab-273d06ee5f2f"),

Guid.Parse("2f4a44a5-d6c3-4269-9970-032891a209ec"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb6acdcb-a610-4027-b847-a952f97be2f4"),

Guid.Parse("1bc2b353-e4b8-4744-88b0-0b7c56370105"),

Guid.Parse("a4795073-0828-4f01-9337-c7e7fe5a483f"),

Guid.Parse("face0f6f-eff7-4460-ac94-2030126148a4"),

},
},
            new GuiduuidListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c45f0782-d341-45f8-86d6-5d95e91c6c59"),

Guid.Parse("2e5af875-3714-43f0-80be-b0612abe6a3a"),

Guid.Parse("e76698a6-3d9d-4020-af60-7b9b0dd3027d"),

Guid.Parse("a672bfb4-0fd6-4d0c-85ed-1ba350da227b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3313efd9-a17a-477c-8dbd-fbbdcbbaf137"),

Guid.Parse("35d45411-8a61-48ac-bbae-b9b9464078a4"),

Guid.Parse("3c1e4b76-8e3c-4fbb-b383-c7fa2a0af69d"),

Guid.Parse("654859eb-248e-4956-bac4-b34af5ec7dfe"),

},
},
            new GuiduuidListD1E2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1a4f4330-d85c-43ca-ad06-44a4755d1ac9"),

Guid.Parse("b0d54ed5-af78-47ab-9ad7-ce3f42f101df"),

Guid.Parse("ab2632e7-2a2f-4dd2-bcad-e691735b09f4"),

Guid.Parse("97f77307-f557-4e86-9e18-a87ff1b81267"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("64a26e27-bcc1-46bf-ad75-c37c31aa4679"),

Guid.Parse("030bae23-a7de-4c83-863d-3b9d152cfc74"),

Guid.Parse("1c6c653f-a528-48b5-9e3e-45fa666f8da8"),

Guid.Parse("60928f6c-2fdc-43b5-b1d5-0f2abdc1e3f6"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("569366d2-6b8a-4f89-a89d-646beb3894fc"),

Guid.Parse("21f32fd3-478b-4485-a91a-90428ed08d61"),

Guid.Parse("d14ba031-9bc8-4681-a752-11533cb5cf55"),

},
},
            new GuiduuidListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("16d11c3a-551c-40c7-9d30-1b2c3c773f67"),

Guid.Parse("f74e6186-f601-4344-80db-96858876d5cc"),

Guid.Parse("a727e84b-caa2-4c65-ae88-7ed3d7b47ed5"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dcb0a5c7-fca5-4854-8fc7-c270a948ce67"),

Guid.Parse("a433dcd3-f67f-4fd4-be2a-2655cc289b69"),

Guid.Parse("91461baa-54b1-4af9-b324-82bc75790394"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ff2dc876-b2a6-4875-88a2-0ba1db0527bc"),

Guid.Parse("ef54e108-6f5f-44cf-a9aa-c4308ab0ac99"),

Guid.Parse("290b4f82-b133-4e8f-9058-52b1d3427611"),

Guid.Parse("f1f2963a-406f-4a26-abdf-dfcd5d5bdc52"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d170a810-4898-4b51-a6f1-521477089662"),

Guid.Parse("3327a1ec-f5be-43fe-899d-91f70ee071e5"),

Guid.Parse("7f0e78a6-cf03-4b9a-bad1-65f68b212325"),

Guid.Parse("3ba03d7f-f66f-4f7b-bee5-8fdacb8625ec"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("672dd26a-a586-446d-bbf7-23c3c2a471aa"),

Guid.Parse("f3c05c94-9ee4-48b2-800a-e3ed455ba051"),

Guid.Parse("6aa39905-5b94-4761-b637-87eb8703ff8f"),

Guid.Parse("a2bac045-aaa1-49d6-9ab2-a1c1cd56bf1a"),

},
},
            new GuiduuidListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("deb49960-b08f-4ac1-9475-143b175c60ad"),

Guid.Parse("3deea5ac-5829-4382-ae35-718534d027d7"),

Guid.Parse("1c14b069-de27-4995-89a5-49c7df3c3972"),

Guid.Parse("16e87d4c-e7e9-4a1b-ad84-b2fbbefe6b33"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6839c363-8c9d-4c47-9950-68de4aa0a293"),

Guid.Parse("b64d534a-71be-4152-bedd-3f40c32e8689"),

Guid.Parse("ddf6cd4d-3fb0-46cd-9f90-54a65046df82"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("060428b9-624f-4045-bfb6-ac9fb4a6725f"),

Guid.Parse("b5ec1829-8017-4fa5-93d6-de0fd86f5d38"),

Guid.Parse("b49a973c-7dc4-4ed8-a791-12c12c700579"),

Guid.Parse("cd67aee0-c6b3-4f6b-9ae8-3af997909d1a"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("eca8a6e7-7123-4bb1-9bf1-1f3221e8de04"),

Guid.Parse("eac97678-e5f2-478f-b20d-5b375b3999fc"),

Guid.Parse("cda07771-8948-4e80-8aee-4f9018061fd5"),

Guid.Parse("06914801-dc07-42be-8af3-7bd0d51db5fe"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9e7e65f9-404d-4cd6-a601-390070d48a86"),

Guid.Parse("60c26c33-a4db-4625-ab2a-a8ab3694c7de"),

Guid.Parse("731a88c6-6194-4659-a2ca-55ec25da2b6c"),

Guid.Parse("e368baa8-7a76-47e1-94f7-aea2cddb99ea"),

},
},
            new GuiduuidListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("81c43649-a907-4532-a26e-0ff4b4f31138"),

Guid.Parse("fc812a65-dedf-4206-97f3-69e07a0c109e"),

Guid.Parse("9d3228de-2510-485e-88b8-f1bb458af163"),

Guid.Parse("778a9971-4aed-4b17-b9bb-a5483aa56b9f"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6ce68b2f-64ae-4a23-b88c-6021b248a023"),

Guid.Parse("5b99bd83-7473-4799-a4dc-b892f8dc3aca"),

Guid.Parse("ece1674a-5cf6-4e94-b6ba-1c6834c6ba95"),

Guid.Parse("67a92078-0b5f-4a29-8f44-19b669c87bea"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("493cabe5-4cc8-4a95-8fc2-98bf10216296"),

Guid.Parse("4a22e182-e27d-470c-95c8-342bd2aff30c"),

Guid.Parse("6e800776-bd14-4cda-9205-3f0b4eafbe5c"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5197b509-b8ef-4ced-a0ba-262cc8deae18"),

Guid.Parse("9c1581f9-79a7-4420-8df0-b642ee3f91ad"),

Guid.Parse("dac30e8c-51a7-418d-b76f-5302bd320850"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3aeb1a32-b614-4503-9f22-573335e7ede7"),

Guid.Parse("73451bd6-039b-46b0-930b-4e61d8bbc371"),

Guid.Parse("5a04e1e4-cebf-4055-b6ae-424b5b8d9991"),

Guid.Parse("7b9e621d-28dd-4d9e-a634-fadfb0570bd0"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("00857540-5c4e-413b-bdbc-ae08eb213a4c"),

Guid.Parse("b966e623-9722-4ef4-b772-def518811d9b"),

Guid.Parse("2e0e2eec-e8e1-4afe-bf34-7b2ae8f21828"),

Guid.Parse("345ff3d7-c420-4a75-b0c6-e8066ddb7e50"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8f73791c-22f7-4026-8219-109e87aa713c"),

Guid.Parse("6b242fc3-f2f0-4a5f-8c96-101bca1e4df4"),

Guid.Parse("f20fcfcb-9936-4552-b581-ecc3a516fb2c"),

Guid.Parse("35587319-3d4a-454a-9e6e-0b476d97ed91"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9a724436-3d91-4f0c-bbb5-f3899792563a"),

Guid.Parse("6121df91-5d93-4ab5-8ec8-d2c7f4084c27"),

Guid.Parse("59a0a7b9-1747-44e6-9246-b1dec82fe574"),

Guid.Parse("0437ace7-4f30-4443-81e9-afba9d4ac665"),

},
},
            new GuiduuidListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1ace1f1e-f50b-453d-b896-37eac7f17029"),

Guid.Parse("53fbf0d5-0990-4e5b-bb63-5f83aee3008c"),

Guid.Parse("7d15262a-c297-41b6-86d9-7c1fc22274ce"),

Guid.Parse("c16db65d-b3c9-4ea6-8e2b-9d9415437bd5"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("416b0f01-f640-4060-8442-0b72bc96e9f8"),

Guid.Parse("a01d189d-c5c3-40ac-9a99-bdcae6d5c637"),

Guid.Parse("7adc38d7-e4be-47a3-957c-2e119092f417"),

Guid.Parse("c67e450e-d61b-4226-a4d6-71356ca5178d"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b375761c-0b4f-43dd-a6d6-ac6cbcbaba49"),

Guid.Parse("95739350-1c07-4750-ba48-a441b27caf70"),

Guid.Parse("ce6f9f6e-1061-43ce-9cf2-4e19a3ce045d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("676d3095-2cd7-4cba-ba80-de77b7b6a856"),

Guid.Parse("8edaddd8-7c60-4aa2-989b-70ef6bc8927d"),

Guid.Parse("4b7bd563-b223-4679-8c38-fc46c2575759"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("817632f4-066e-458c-8a69-c35d7e6cbe86"),

Guid.Parse("1497d133-e40a-4896-88f0-d160df9cdb2b"),

Guid.Parse("bc30763f-f52e-4859-81ed-378400a6ce45"),

Guid.Parse("3a6e134a-deb4-4341-9536-981ab81fbb26"),

},
},
            new GuiduuidListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2bddc578-ef21-4644-93ac-2c1e8c297790"),

Guid.Parse("7f07776b-2eab-4376-b6f5-7cbd7ae46868"),

Guid.Parse("a2ceb7cf-dd83-479e-ba65-f5fe7ad325fd"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b73bc457-a28b-4c78-8181-b7435977156e"),

Guid.Parse("fb7fb7af-b2d1-43f3-82f7-e320277a7f79"),

Guid.Parse("a327a8e2-ff49-4f7a-99c8-e6d946044969"),

Guid.Parse("67bf0499-2013-44f0-ade3-bd95ead9da7d"),

},
},
            new GuiduuidListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9ea54572-5db8-4456-accc-cf065bd59487"),

Guid.Parse("3d76f156-0899-479a-bcb2-134a74e827bb"),

Guid.Parse("39c79810-056f-482d-91d6-0634802e230c"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("78adaae8-bef0-48d6-8f21-28bc39960266"),

Guid.Parse("a42df538-5561-4160-b22b-9a53d3b506e5"),

Guid.Parse("5a61e277-869b-472f-a3d8-354336a4756e"),

Guid.Parse("4a3ddbf8-8f91-4843-880f-2fd1d9d9bee3"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("08049d95-df84-437d-a8da-87d15ff47d84"),

Guid.Parse("4965c9e7-68e0-486e-a3c4-c82a0d6d6cec"),

Guid.Parse("c86ba0f7-5808-4729-a91f-aa44ef8a5abd"),

Guid.Parse("1c4d35cf-83c7-41ad-beff-8cdca61c8edd"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("614314aa-7114-44c2-87ce-209d5e0baeeb"),

Guid.Parse("22513ba8-f6b1-4105-b2df-9f291ce3ea84"),

Guid.Parse("34dc4ca2-43c7-4aef-9722-e0a91789def8"),

Guid.Parse("69b21aca-61f8-4c2e-bc89-3ff4801977ee"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("daf09315-1e4e-4e0d-9e7c-e736cde6294b"),

Guid.Parse("1e4f1bd3-eb53-49f6-a38e-49ff0e35e3c3"),

Guid.Parse("70730643-b46a-4ea4-a812-117537ef660e"),

},
},
            new GuiduuidListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("afa8b920-b627-41de-acc1-b236cfc14b6b"),

Guid.Parse("248570c0-31ee-43af-be29-c06ae5b723fd"),

Guid.Parse("cb0cd7d1-54a3-4c70-a48e-116f95a92744"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b01fbd5e-8d69-47a1-b9f4-46af98db16a0"),

Guid.Parse("a33b28b7-38d8-412b-a7d4-a02a92dafd53"),

Guid.Parse("fb847541-9ac6-41af-909a-23a9b38dcf5c"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("30477b6b-6458-4a92-9175-bf139d11f337"),

Guid.Parse("6a23176d-9333-4430-995e-451b07b80c57"),

Guid.Parse("3ede13e2-f85f-434d-947e-fbc4ac1f0950"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d9e0a253-28d9-416a-8f2b-e26f558a4483"),

Guid.Parse("d2531e25-04f4-4ff4-9f99-ea2ecca73fb3"),

Guid.Parse("02ca0b90-df56-4958-97a6-ac80a8375b5a"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4c0c53c7-56c5-47d9-975f-b8128407e96b"),

Guid.Parse("412176a6-f2fd-4f29-91e6-25dca5ff8199"),

Guid.Parse("39fb615c-3e00-4148-bd9a-6838028ac661"),

Guid.Parse("d5e6bac3-8b5a-42ca-a237-c34a626aa301"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("903ec271-66e7-474e-826a-e463d9952a0e"),

Guid.Parse("8ee5816c-7859-4b83-9aa5-2ab1d4249a89"),

Guid.Parse("8ab32627-b3a3-4e53-bcb3-406fa35e5106"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9fb3d228-9c66-4713-a2a0-9984dcb94924"),

Guid.Parse("0fb4c877-c3f8-4c0f-9a17-dd8209a61ba1"),

Guid.Parse("03cbb38c-05ed-4799-aa24-d37fe71ba262"),

Guid.Parse("6f5537de-43f0-409c-bd78-ab485cd836b2"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9c457417-44ad-4865-87a1-e7a11526e314"),

Guid.Parse("cf90d475-6f62-428d-a302-9bc2d4a5f054"),

Guid.Parse("97bc2a44-430f-4e82-87b8-104688df1dae"),

},
},
            new GuiduuidListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f88ee88c-1d4e-458f-ae46-1af9e50189a2"),

Guid.Parse("ede2e11d-dd21-4835-8e95-f0e90ad6ce22"),

Guid.Parse("9f572a25-916e-411e-a817-f586c11235fd"),

Guid.Parse("ed2a2bea-a037-4535-9b60-c16444e2309f"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("de92c9c6-5d91-4618-a547-1b7b3d688fc0"),

Guid.Parse("b904b85c-4e66-4032-967e-05267b281b42"),

Guid.Parse("c4a4eecf-ced0-49a5-8fb7-ce2d46217631"),

Guid.Parse("2c103f12-c48e-40ed-83df-c7ed02cb93ad"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a52d41e3-0e3a-40bd-9100-3b30215eea94"),

Guid.Parse("6dd2e9d2-9dab-43d1-b912-eda85a80c909"),

Guid.Parse("db91e556-2eac-4df9-bc5b-e8df31abbf43"),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2mi(
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
INSERT INTO public.guiduuidlistd1e2mi(
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
            queryMapTypes: [typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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

                changedRows =  ((IGuidListuuidListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidListuuidListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidListuuidListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidListuuidListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidListuuidListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidListuuidListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guiduuidlistd1e2mi_id
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
            asPartInterface: typeof(IGuidListuuidListD1)), 
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
                methodParametrName: "guiduuidlistd1e2mi_id", 
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
                changedRows =  ((IGuidListuuidListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidListuuidListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidListuuidListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidListuuidListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guiduuidlistd1e2mi_id
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
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guiduuidlistd1e2mi_id
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
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                methodParametrName: "guiduuidlistd1e2mi_id", 
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
                List<GuiduuidListD1E2M> models = null;

                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidListD1E2M> models = null;

                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidListuuidListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidListuuidListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidListuuidListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await((IGuidListuuidListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[34], false);
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
                var models = ((IGuidListuuidListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[10], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[6], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[7], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[8], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[9], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[10], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[24],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[25],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[26],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[27],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 145, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 75, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 71, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 72, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 27, query1, 150, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[26],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[27],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 158, query1, 103, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 68, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 158, query1, 127, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await((IGuidListuuidListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 89, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[34], false);
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
                var models = ((IGuidListuuidListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatch(connection, 145, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[34], false);
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
                await using var cmd = await ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 57);
                var models = await ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                GuiduuidListD1E2M.AssertModel(models[0],_testData[12], false);
                GuiduuidListD1E2M.AssertModel(models[1],_testData[13], false);
                GuiduuidListD1E2M.AssertModel(models[2],_testData[14], false);
                GuiduuidListD1E2M.AssertModel(models[3],_testData[15], false);
                GuiduuidListD1E2M.AssertModel(models[4],_testData[16], false);
                GuiduuidListD1E2M.AssertModel(models[5],_testData[17], false);
                GuiduuidListD1E2M.AssertModel(models[6],_testData[18], false);
                GuiduuidListD1E2M.AssertModel(models[7],_testData[19], false);
                GuiduuidListD1E2M.AssertModel(models[8],_testData[20], false);
                GuiduuidListD1E2M.AssertModel(models[9],_testData[21], false);
                GuiduuidListD1E2M.AssertModel(models[10],_testData[22], false);
                GuiduuidListD1E2M.AssertModel(models[11],_testData[23], false);
                GuiduuidListD1E2M.AssertModel(models[12],_testData[24], false);
                GuiduuidListD1E2M.AssertModel(models[13],_testData[25], false);
                GuiduuidListD1E2M.AssertModel(models[14],_testData[26], false);
                GuiduuidListD1E2M.AssertModel(models[15],_testData[27], false);
                GuiduuidListD1E2M.AssertModel(models[16],_testData[28], false);
                GuiduuidListD1E2M.AssertModel(models[17],_testData[29], false);
                GuiduuidListD1E2M.AssertModel(models[18],_testData[30], false);
                GuiduuidListD1E2M.AssertModel(models[19],_testData[31], false);
                GuiduuidListD1E2M.AssertModel(models[20],_testData[32], false);
                GuiduuidListD1E2M.AssertModel(models[21],_testData[33], false);
                GuiduuidListD1E2M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 52);
                var models =  ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                GuiduuidListD1E2M.AssertModel(models[0],_testData[11], false);
                GuiduuidListD1E2M.AssertModel(models[1],_testData[12], false);
                GuiduuidListD1E2M.AssertModel(models[2],_testData[13], false);
                GuiduuidListD1E2M.AssertModel(models[3],_testData[14], false);
                GuiduuidListD1E2M.AssertModel(models[4],_testData[15], false);
                GuiduuidListD1E2M.AssertModel(models[5],_testData[16], false);
                GuiduuidListD1E2M.AssertModel(models[6],_testData[17], false);
                GuiduuidListD1E2M.AssertModel(models[7],_testData[18], false);
                GuiduuidListD1E2M.AssertModel(models[8],_testData[19], false);
                GuiduuidListD1E2M.AssertModel(models[9],_testData[20], false);
                GuiduuidListD1E2M.AssertModel(models[10],_testData[21], false);
                GuiduuidListD1E2M.AssertModel(models[11],_testData[22], false);
                GuiduuidListD1E2M.AssertModel(models[12],_testData[23], false);
                GuiduuidListD1E2M.AssertModel(models[13],_testData[24], false);
                GuiduuidListD1E2M.AssertModel(models[14],_testData[25], false);
                GuiduuidListD1E2M.AssertModel(models[15],_testData[26], false);
                GuiduuidListD1E2M.AssertModel(models[16],_testData[27], false);
                GuiduuidListD1E2M.AssertModel(models[17],_testData[28], false);
                GuiduuidListD1E2M.AssertModel(models[18],_testData[29], false);
                GuiduuidListD1E2M.AssertModel(models[19],_testData[30], false);
                GuiduuidListD1E2M.AssertModel(models[20],_testData[31], false);
                GuiduuidListD1E2M.AssertModel(models[21],_testData[32], false);
                GuiduuidListD1E2M.AssertModel(models[22],_testData[33], false);
                GuiduuidListD1E2M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MIWA),
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
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MI),
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
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidListuuidListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidListD1E2M),
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
            asPartInterface: typeof(IGuidListuuidListD1))]
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
FROM public.binary_guiduuidlistd1e2m m
LEFT JOIN public.binary_guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidListuuidListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidListuuidListD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models =  ((IGuidListuuidListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA), typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                await ((IGuidListuuidListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                ((IGuidListuuidListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA), typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                await ((IGuidListuuidListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                ((IGuidListuuidListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models = await ((IGuidListuuidListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MI), typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models1 = new List<GuiduuidListD1E2MI>();
                var models2 = new List<GuiduuidListD1E2MI>();
                await ((IGuidListuuidListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MI>();
                var models2 = new List<GuiduuidListD1E2MI>();
                ((IGuidListuuidListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA), typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                await ((IGuidListuuidListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                ((IGuidListuuidListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models = await ((IGuidListuuidListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}




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
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe637c03-cbb2-4873-8f36-3e3ea60dd9c1"),

Guid.Parse("6154c340-6ae8-4076-8e42-c236c1de68bf"),

Guid.Parse("c56cdfc9-1b0c-4c2e-927e-c1de3c489224"),

Guid.Parse("4f5cc6a3-38cd-4f57-a165-a11a98017efd"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("eed88c56-8a56-409c-b574-337e2ee99b1b"),

Guid.Parse("073063a1-36c9-4b11-8465-74adeae5eda5"),

Guid.Parse("51730460-fa14-4711-869c-9ac84a1c3c16"),

Guid.Parse("0e481290-68f9-4006-b29b-4860f3060299"),

},
},
            new GuiduuidArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("29461a6b-d7f0-4e18-96d6-7060a29b8156"),

Guid.Parse("35b61c57-fb7b-424e-a2a4-c47b54295ca4"),

Guid.Parse("24e2eb79-deed-46e9-8de7-9a9823b38922"),

Guid.Parse("0cb9b254-cb78-4c0b-b6b5-5ff0d9453718"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9f09adb3-b729-4174-b180-a261bcf51414"),

Guid.Parse("5c33b5ef-2b09-4e41-91de-f4d545c02ce7"),

Guid.Parse("65bc1600-76b8-44f8-8811-90692694781e"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5f303dc2-2018-47f6-a07c-f09d51a08bcd"),

Guid.Parse("ed92e503-a394-465e-a4d6-eb206f30e862"),

Guid.Parse("23d93fb9-87aa-4b19-a9c4-d90e41d95131"),

Guid.Parse("b1dd8164-6931-4bff-a9a8-39ab1683dd3a"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7195001c-8d4f-4b1a-8d0c-f74089fd110f"),

Guid.Parse("9e708b0b-1c79-43e4-9190-e96b89e90f78"),

Guid.Parse("89b43e94-7ae9-4fea-988c-7092e03bee2a"),

Guid.Parse("47dce056-9720-4d1b-81c9-e33efb8a1ce7"),

},
},
            new GuiduuidArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a79c1433-a33c-4d39-8e44-f45790d03a67"),

Guid.Parse("97634c99-0420-4ea4-812b-42e2540cb2fa"),

Guid.Parse("fc910a75-9949-4688-8d7c-ab732fd97248"),

Guid.Parse("8db4b8d2-3ee2-4c7f-95e5-4e1011932189"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("411f4829-b721-4550-b59a-b60cdad9d3ac"),

Guid.Parse("8a240c5d-7016-4cda-9000-87e7ad0f5f23"),

Guid.Parse("39e3822f-fa3a-4d9a-b60b-ed9ae15054e0"),

Guid.Parse("c7ab17b1-cd7f-4b6e-9203-4da5c2d198df"),

},
},
            new GuiduuidArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0c594a91-cf64-448b-bd5d-8ed300000558"),

Guid.Parse("c65a6b65-1e88-4bc1-825e-3c650804c06b"),

Guid.Parse("b3dda16e-b19f-4879-93d5-9f92de0d58a3"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e62a3a2d-ba84-4e72-8a24-0037bd6a758c"),

Guid.Parse("25e8b177-4a24-490f-be92-0c6d9f6b4a99"),

Guid.Parse("0673ecde-54f5-47be-a88b-bf8a1f6b0a75"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6e21a7aa-b053-4f06-944a-a9fa827ee5d6"),

Guid.Parse("f2204920-684b-4772-8d61-f92191135a74"),

Guid.Parse("52341d45-f652-4c64-befd-a7e1aa1f558e"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9c62aba5-69ab-4d8b-9cc9-3ad78a36cd60"),

Guid.Parse("5d1671bb-30eb-44be-955b-a8838fe5ae8b"),

Guid.Parse("76d17a97-68d4-4b58-bad0-a868fc318084"),

Guid.Parse("a2d48321-918e-423f-ace2-32ec900e9ff5"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e1244df-1a30-44f2-8b0f-997fca9f4895"),

Guid.Parse("d6b2850c-2ac7-4c5c-9f51-f043a92922a4"),

Guid.Parse("fa61b3e0-26e7-4209-be61-4a61f7d1bc0c"),

},
},
            new GuiduuidArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9a08c065-a780-4011-9bc2-451f70f2d0f5"),

Guid.Parse("8f2578e2-c6d5-4c04-bae7-10a1b17321b6"),

Guid.Parse("c5616dd6-d1ad-4bed-a39f-12b8071ce1bd"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("dc8a0583-f199-4a03-96a7-c7b4a3b3046d"),

Guid.Parse("f3c7d4ec-9395-4a4d-b19a-250104b48667"),

Guid.Parse("2da5ac64-15c6-403f-9300-05c5b538825a"),

Guid.Parse("d5e734fe-e4ee-4029-94a3-82e414697ad1"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5997e24c-349d-4332-b2ed-ed688d5f1e2c"),

Guid.Parse("8cdc8c58-c9d0-4cd1-86d1-d13146262a5d"),

Guid.Parse("073dc1bd-bf68-4d0b-9760-32377f58cc5d"),

},
},
            new GuiduuidArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3a9d9cda-9fde-4c5a-9f1b-828cfd442408"),

Guid.Parse("7a22cbe7-92d5-4695-925b-3d23ec77760b"),

Guid.Parse("4ef65592-938d-4799-8949-a18f9124bf54"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("30211e8b-2531-4d8d-86ff-da8a620a5290"),

Guid.Parse("f0f3a94a-eefd-4dfb-ba10-5c79b1b112ee"),

Guid.Parse("b8f13623-9713-4754-813e-e589d84c26ab"),

Guid.Parse("621d21d5-d003-4274-add4-dfbe0242226c"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5fa613df-d3d5-4775-b8b5-cf2bcb03b28b"),

Guid.Parse("6147db3d-0f2a-4f7f-87c9-662b303f3d06"),

Guid.Parse("4b5a084b-26b7-447b-8e7c-9353b78cbf6c"),

Guid.Parse("18ef44af-ec19-4d6d-b33b-3616dca5e4d1"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("771d455d-6221-4058-a2a2-b1ad7b919c5c"),

Guid.Parse("46085633-97b4-4a66-b156-e1cbc1a4a1b0"),

Guid.Parse("95c6cb19-f072-4b33-af22-95d4cae0bffe"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9989cecf-e2e4-442c-b334-fe29b4a7b392"),

Guid.Parse("8c29ad6c-452f-4803-9889-85320c6720cf"),

Guid.Parse("b463c261-88ed-4385-94f5-6735ebbb55f9"),

},
},
            new GuiduuidArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5992a1b8-81a0-4105-9c9f-219209f06637"),

Guid.Parse("fb4cb350-a818-41a8-a9a5-606e66aa824c"),

Guid.Parse("ab484506-92e2-4f75-9021-adb0982ed5e4"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1b28bb3c-6123-4861-aefc-b2abeac73a09"),

Guid.Parse("7f4262fc-ca58-4492-9b6a-7299c4a12c3b"),

Guid.Parse("abc4e3b8-4d8d-4380-aff3-059467a631bf"),

Guid.Parse("3147a3be-232f-434d-9a2e-15ae84aac998"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3105c5fd-5b0e-4fca-9f87-3a8071913d0f"),

Guid.Parse("98649a8d-d11b-4aa2-974f-b939a9a7e28e"),

Guid.Parse("e4b247c3-c547-45c8-b6e9-6e79f2e704bd"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cdaac91a-395f-410a-9ac3-4ab260998569"),

Guid.Parse("2043decb-3516-4139-8139-bbbbd8bca0f0"),

Guid.Parse("d614d7a1-fdde-4892-910e-9d8872d21d60"),

},
},
            new GuiduuidArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8716048e-ef5b-466c-bc4e-86d35043e775"),

Guid.Parse("a5f78065-bb42-4ad7-97a4-792ae6d832f0"),

Guid.Parse("c772c4e2-558f-425e-a505-30b3546032ac"),

Guid.Parse("9c2bd19b-d385-47eb-bb40-9b24065f7a21"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("87f320bf-a00c-4c24-b74a-8f56e04598da"),

Guid.Parse("ef0564df-569f-4c8b-9000-4c1ac3f115f8"),

Guid.Parse("0f94dcd1-b937-4b07-a44b-79e4fede9bad"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3425bbd-946c-40e6-8f85-6c050d925e62"),

Guid.Parse("b0e8bb3c-1d43-47bf-9a66-67471807d994"),

Guid.Parse("63df9e41-f23f-4fc4-9274-8166d746d35f"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6e5b1b05-f4bb-4972-9896-9b63c35ccbd1"),

Guid.Parse("38eabd84-ed7d-413d-9ec4-b996e34f54f4"),

Guid.Parse("fdb1c5d4-b2a1-44b0-a85c-1b7a79747878"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9f46bb19-eb1c-4794-a411-08e82bfdd1bb"),

Guid.Parse("9b0bbebf-b158-4393-84ba-49826ac7246a"),

Guid.Parse("fd038a4d-6fef-445b-86e8-edf9a80ab15d"),

},
},
            new GuiduuidArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8bb3a112-acf7-4fa8-9fe8-aeb3f4287a6a"),

Guid.Parse("9ef5647f-acf9-4e58-b019-15f0bdd268dc"),

Guid.Parse("f7e3ce86-0323-4f53-979d-f7d8890b07b1"),

Guid.Parse("92da86c8-e34d-4d4c-a4ae-3f1aacd0619e"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9e78732e-bf07-44d3-8aca-4d6dca2a086d"),

Guid.Parse("c5993d59-ace3-4801-8f56-47d796e739b9"),

Guid.Parse("000a6087-b792-43f9-92a2-6f5babe9fe18"),

Guid.Parse("948b7b5a-e423-4ff7-85a7-fbcb535861a5"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6d35a583-3d80-4954-8708-e51ae14ce593"),

Guid.Parse("7381537e-8efa-4384-8c70-b0349673c6cf"),

Guid.Parse("38abfdcc-b316-4646-91af-627543e1d91b"),

},
},
            new GuiduuidArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("39248b89-98dd-4da6-9ce6-4ae971461eee"),

Guid.Parse("19248939-892e-4c9a-82a3-f796b66739b5"),

Guid.Parse("dfa48179-63e8-4e7a-a5d6-1591a3c4d07d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f41ffd9f-0c01-4677-9563-2f2cd4f6bb3e"),

Guid.Parse("65c99524-780a-4c44-9d0a-941d1f1cab34"),

Guid.Parse("d02a78e8-a4aa-4e09-a266-821f7fb1022b"),

Guid.Parse("f3479fb0-91f3-4c38-8f1f-18f370be4c83"),

},
},
            new GuiduuidArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d49ff74f-228d-41b8-b54d-33866c6b1142"),

Guid.Parse("8f991fa1-2c69-4a0b-8051-d237d35740d9"),

Guid.Parse("20d0f60a-c9cf-431e-93cb-d885251d5cf4"),

Guid.Parse("7ccdd94a-707d-4975-a892-cb8706dcbab5"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9521a6c0-66df-4787-b7ff-60233f33ab90"),

Guid.Parse("ad579df3-3ef8-48bb-b895-f0070d6d199a"),

Guid.Parse("74b70fb6-b08a-4217-b13f-ab36256105c8"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fee129e1-4552-4c74-90cc-5cc2edad796f"),

Guid.Parse("01c98ba7-1367-4c9d-9d2b-300847bc97f8"),

Guid.Parse("9a97c06a-ddfd-40e2-aa44-f3532690a866"),

Guid.Parse("93ada631-9d66-4744-913c-8de8b05b3c60"),

},
},
            new GuiduuidArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("62b6cbe6-6ce5-474b-ae9d-780f626813b6"),

Guid.Parse("2aadc64f-a05f-42ec-ac6b-de2b9a806456"),

Guid.Parse("184d72aa-39f6-4744-b27c-ffa6db8dbf7d"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7b045d60-2d20-4a7a-ae1b-b975dfa15311"),

Guid.Parse("f00103bc-c877-43f3-8028-fdda059ef71e"),

Guid.Parse("9082f618-ca0b-4c8f-b5c4-333619d33636"),

Guid.Parse("4e87718f-679e-4653-a14f-7790e42bc813"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ad45960f-b596-4771-a620-5841b038fc1d"),

Guid.Parse("ec378183-77c1-4018-8d05-cbadd9344dd1"),

Guid.Parse("3db8742e-171f-45fd-ab23-675594fe9a86"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9ac2dba9-a5dd-4894-9921-6f12d018990e"),

Guid.Parse("50886a91-7bd0-40aa-86ab-d5001c2b2866"),

Guid.Parse("04530a6c-3981-4915-869b-12e28c7dbc1c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ff759027-2315-4588-b9fc-8454f00c1414"),

Guid.Parse("52e7b93f-5a2b-4a0e-8929-34c61a220807"),

Guid.Parse("b7bf5418-4c6a-42d9-a843-a7b5e84ade8d"),

},
},
            new GuiduuidArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccac999c-42a3-4981-8b9e-6518b356fb99"),

Guid.Parse("44c72e31-d0bf-4e6b-b493-467fcf8e9b8b"),

Guid.Parse("714fcc1c-5ea9-40f0-bbb4-9c493433303f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("58b33895-9868-4ac4-9b3d-7c8f9653099d"),

Guid.Parse("c431238d-d2fb-4494-94c8-b741ac26ee73"),

Guid.Parse("e81c8d9f-531e-4e53-8ce2-0e95691fa8c9"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("085e5fc3-cd9a-46cc-a636-11286b85b0dc"),

Guid.Parse("cc2d7cab-cf10-4d54-ac21-3eeedc903689"),

Guid.Parse("a542fe82-6ae9-4822-9d06-8a8b078cd732"),

Guid.Parse("c55f36e7-7ae3-49e7-ae7b-05cc2b533a69"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("663ae829-dcab-4fcf-8b66-b899d6f7fd88"),

Guid.Parse("a657a6aa-d18b-4a35-ab73-ff46ed9d8a36"),

Guid.Parse("21417984-01ee-4e56-a61c-67617a005642"),

},
},
            new GuiduuidArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9859d5b3-ca3c-4888-a7aa-6b31ff5ba2b9"),

Guid.Parse("9892b54f-a69a-469c-874f-cd648f672999"),

Guid.Parse("d4ea7d3c-b58c-4148-8d6e-eea206839982"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("19686a74-a3f8-4b51-86ce-4fe3875be8ad"),

Guid.Parse("b7174477-2ff2-4a5d-9bdd-b12c6480e0ee"),

Guid.Parse("f48ae865-6e14-404c-871f-84739f3e8e9e"),

},
},
            new GuiduuidArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c6f6266d-e767-4e40-9d8b-c7ec97f20941"),

Guid.Parse("aea42036-0ce5-4847-baa6-c11956d35f60"),

Guid.Parse("ff3f4bcd-0a8e-4457-a963-8f9f2c0668e4"),

Guid.Parse("f8227e9b-db55-4ede-a5d4-22fb61f6fd74"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("08d1503a-ee80-4f78-bd6f-c2c10c84b97d"),

Guid.Parse("baafe85b-1b57-47fe-a13b-74ea97776f07"),

Guid.Parse("845c547a-60c8-4b03-a8b3-d47224a856c1"),

Guid.Parse("56126975-9dcf-46bf-9282-51ebd8de79b8"),

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
Guid.Parse("1a042d64-99a2-40d9-b984-f20cf6172335"),

Guid.Parse("913f6172-dc5c-40f3-a87a-432e95f73242"),

Guid.Parse("32576911-1d5f-47eb-bf76-0bab79f63e4c"),

Guid.Parse("cbf5fdba-1330-4bcb-a200-5dddf888941a"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("957ff320-a92b-4253-8bc3-811e4b587f6a"),

Guid.Parse("e3d52de1-9e7c-4e6a-b55c-ec6e2093414b"),

Guid.Parse("5047ed6f-fb07-42d2-a79c-07a9434316ae"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4d405834-b551-4393-8aa0-6eae796109d2"),

Guid.Parse("b47bfd69-a077-4f57-b6b5-7567c04c5a47"),

Guid.Parse("5e0d2c87-ace0-4904-a9c7-054349644aba"),

Guid.Parse("4cf42b63-e68e-4c90-826f-6e4abc8a31cd"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6048058c-6ad5-4cfb-84ba-9221d016716e"),

Guid.Parse("7ed99d64-ed0e-4f27-b449-4cf340d76d72"),

Guid.Parse("c2bc0850-9d4b-45d5-832e-73d10944d073"),

},
},
            new GuiduuidArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("07228846-1ea7-4bff-af0f-71bc722d10b6"),

Guid.Parse("f728d65b-91e3-4763-8c5a-12c7ab5d55c0"),

Guid.Parse("b8d2cbd9-b117-4279-b932-33424adcb172"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bc80511d-1af9-4823-9081-68947e0f7ffe"),

Guid.Parse("35713d64-219b-4635-afb7-6c624afaccb9"),

Guid.Parse("b86adf55-eb8d-47d3-83ca-d101f92877d5"),

Guid.Parse("86c9d62e-385e-499e-b78b-ce1da5e45d50"),

},
},
            new GuiduuidArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("26063419-1126-4b78-a704-1561923d764f"),

Guid.Parse("b6752a34-0aef-45e9-9e1f-f32b49c29a56"),

Guid.Parse("5d14f8e1-9302-43b6-84b0-7d94a79567e1"),

Guid.Parse("0c6c262b-25ef-4e29-ad26-79edc13c8f2f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2504c8a9-7110-45b4-a8f5-a19a654b42f6"),

Guid.Parse("e8537542-79c8-4376-83d7-78799ff62357"),

Guid.Parse("4362e89e-e24d-4db5-98c9-38fc0b0b4514"),

Guid.Parse("90633b4d-3732-44d5-9d2c-a0b20e32f4c4"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c591fd70-075d-4e5c-b4b0-67e51f466fe0"),

Guid.Parse("4bf0a5c8-12da-4a4a-b83d-9aa69e7c8bc0"),

Guid.Parse("950389bf-51f0-43d8-9185-e46b0abc7799"),

Guid.Parse("2d6b9746-914e-4d48-9c4f-fa82c2276182"),

},
},
            new GuiduuidArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c2eccca0-39f1-4afb-b0ae-6b2383f7a967"),

Guid.Parse("370589f4-dea4-43b8-a0f1-c115e26b81bf"),

Guid.Parse("e3e3b6de-9a6d-436d-a856-124c81b7112c"),

Guid.Parse("4c6d29e0-6977-4c64-8040-4a3a2f1bc74b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("720004ef-9f07-4abc-9799-93b5b6dae1cd"),

Guid.Parse("364e3c18-9af7-4944-95fd-69c45bd7bd05"),

Guid.Parse("00b9b914-ac45-4fae-b735-9069c80d9af0"),

},
},
            new GuiduuidArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("80031951-d3b0-4bca-95f0-ee599d9b554b"),

Guid.Parse("14f83098-ffb6-4247-9b92-12bce04af90a"),

Guid.Parse("42dfe39c-a1c0-4db1-967f-537ed516db80"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0d6747c4-39a2-4216-b59c-60768fcdcbfe"),

Guid.Parse("0dfe023b-5dfc-4028-b9a0-1f814fa14446"),

Guid.Parse("afb92a06-ddab-4db3-a3f9-6c8c125b0177"),

Guid.Parse("7dc14d29-b6ea-4197-8bc1-7abd1f3c04aa"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("048668e5-cb6e-4ec2-8657-6433f0543393"),

Guid.Parse("e8d1d07c-0d91-4482-b5f0-b31228ae29dc"),

Guid.Parse("b35da698-57a4-4f81-a0ed-bf70a263d0f9"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3d6db3b4-882d-4991-8cf9-ff4d3d819ac2"),

Guid.Parse("7e315fe0-e13c-4abb-91a1-61444567825d"),

Guid.Parse("d8a00820-e6b2-4df8-b14c-c482bc8c05c5"),

},
},
            new GuiduuidArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("aaa32789-42d6-462f-a277-b020ce9ef1f1"),

Guid.Parse("544fc6c2-97ca-499e-9578-8a20039f8028"),

Guid.Parse("ee84a59c-4795-4d78-82fc-d6213bf0a044"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6ce31aa9-225f-4637-8d9d-4bcbd795afc5"),

Guid.Parse("7125ff89-f323-4e51-b69c-066f55e03527"),

Guid.Parse("18d8934d-0759-4932-8cdc-c6c3016f0ad9"),

Guid.Parse("666bea66-d92e-4622-9a07-a8042edd0fbf"),

},
},
            new GuiduuidArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0adecafa-2bd7-4b1f-8cec-1ce75575d9d4"),

Guid.Parse("349ad21e-e310-4ea6-8f0f-679f787499b8"),

Guid.Parse("69f025dd-8745-42db-9691-1eec4dcb66d1"),

Guid.Parse("51be47e4-d23c-4dce-a33f-af3b4667e5a5"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("424a76a4-8cb7-4df6-b086-eec47001cb7d"),

Guid.Parse("0af1506e-4c46-4fcf-a293-90432665f1e2"),

Guid.Parse("653a2316-0906-4121-891b-ce964536cc0e"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("884d70d3-ef3c-4c43-832c-bc7df9cf1414"),

Guid.Parse("638c90f3-0fcc-4613-84a6-e8768e8c2ca4"),

Guid.Parse("5ec1c3b3-915e-4f21-91cd-cabc36ac1cb3"),

Guid.Parse("beb68747-d37c-4d3d-85dc-5b3957eb60d4"),

},
},
            new GuiduuidArray2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("351d3204-b027-4ad7-8361-3d34ac9a7315"),

Guid.Parse("67be893b-f27f-4b5a-8dc1-c3eb34cc7e75"),

Guid.Parse("05870778-809b-48c1-a0fd-c92efe46356a"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("cbd70bdb-e55b-4980-b870-ed20d90f3d89"),

Guid.Parse("3214fa35-a762-4c3f-ab88-707a516f8a6c"),

Guid.Parse("c19c9609-5db8-490a-81df-7a966a93d1ba"),

Guid.Parse("c6e13153-e53f-4e6d-bb85-8b4520319087"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0bfbdbe9-6838-4fca-ad02-f7f7cb337a56"),

Guid.Parse("e355043b-1ee2-4929-b60c-9520dcd0cb4e"),

Guid.Parse("8341efa3-5b56-4fc3-ac76-c94d015f8e56"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c266087d-1340-49b7-9678-a38cccdb152a"),

Guid.Parse("7ef5fed3-069b-4338-9c83-bfb440a0bfd5"),

Guid.Parse("672d9cba-ce96-4d5b-bc81-7a59d235b99e"),

Guid.Parse("74b8cd91-b427-453c-8974-ef5834986d69"),

},
},
            new GuiduuidArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3ee02336-cf65-4b3b-a06b-b60e322de6fc"),

Guid.Parse("f6462437-8303-40ec-a884-231263891bab"),

Guid.Parse("2d72cf89-d4cc-4716-a6b8-5d3031d21401"),

Guid.Parse("2e733a90-dc9a-48ef-bc00-d528c64ee381"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("83a4d160-149c-4a5a-b8d1-207b3a800e81"),

Guid.Parse("adbe22a7-a6f6-49b7-ad27-abdf00b817a7"),

Guid.Parse("c2a50417-6833-4c28-8c1a-ce08128e0d48"),

},
},
            new GuiduuidArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3f214494-62dc-418d-b5f3-b811c83efe68"),

Guid.Parse("05016fa3-a5f1-4c7b-bfab-d1f47fffae68"),

Guid.Parse("780f4781-9e8c-454e-a4b1-43d2bcf63fdf"),

Guid.Parse("3d6537ac-1b1f-4773-97dd-504a457a8876"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("84318cc4-9326-4343-9016-e3eaa308a3d6"),

Guid.Parse("a7fa6030-5fd4-4d3c-867f-01fc2d2f9003"),

Guid.Parse("acf3963a-a328-41be-a5cd-6747d106bfbe"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("20c87b9f-810c-4355-93c9-cb8124fd213c"),

Guid.Parse("01a7c2d3-cfe3-4ae9-9262-a637a1b782a3"),

Guid.Parse("93f0f7ec-7774-4774-b0f3-506472cdcdb2"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3a850d9c-670c-4005-9c2f-96749bb80c7c"),

Guid.Parse("325fb993-74f5-443a-b779-c9810e839be6"),

Guid.Parse("768824e9-1cf3-44a2-a0e1-ff00e7ad5ad7"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("81096979-21b3-4e1e-8a86-1d8ee1842e43"),

Guid.Parse("d0cf2b14-a0d1-42e5-b3ce-f2233b54fc92"),

Guid.Parse("97a83034-2bd2-41f1-af43-6b1d035c0c59"),

Guid.Parse("409549b1-94ab-448e-b49e-6c604d328824"),

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
                parametr1.Value = 72;
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[34], false);
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
                parametr1.Value = 157;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
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
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[34], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[19],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[20],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 155;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[34], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidArray2M.AssertModel(models[0],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        GuiduuidArray2M.AssertModel(models[0],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 157, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 72, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 122, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 52, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 46, query1, 153, query2))
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 87, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 101, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 70, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 43, 30))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        GuiduuidArray2M.AssertModel(models[0],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidArray2M.AssertModel(models[0],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[28],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 55, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidArray2M.AssertModel(models[0],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 43);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                GuiduuidArray2M.AssertModel(models[0],_testData[9], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[10], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[11], false);
                GuiduuidArray2M.AssertModel(models[3],_testData[12], false);
                GuiduuidArray2M.AssertModel(models[4],_testData[13], false);
                GuiduuidArray2M.AssertModel(models[5],_testData[14], false);
                GuiduuidArray2M.AssertModel(models[6],_testData[15], false);
                GuiduuidArray2M.AssertModel(models[7],_testData[16], false);
                GuiduuidArray2M.AssertModel(models[8],_testData[17], false);
                GuiduuidArray2M.AssertModel(models[9],_testData[18], false);
                GuiduuidArray2M.AssertModel(models[10],_testData[19], false);
                GuiduuidArray2M.AssertModel(models[11],_testData[20], false);
                GuiduuidArray2M.AssertModel(models[12],_testData[21], false);
                GuiduuidArray2M.AssertModel(models[13],_testData[22], false);
                GuiduuidArray2M.AssertModel(models[14],_testData[23], false);
                GuiduuidArray2M.AssertModel(models[15],_testData[24], false);
                GuiduuidArray2M.AssertModel(models[16],_testData[25], false);
                GuiduuidArray2M.AssertModel(models[17],_testData[26], false);
                GuiduuidArray2M.AssertModel(models[18],_testData[27], false);
                GuiduuidArray2M.AssertModel(models[19],_testData[28], false);
                GuiduuidArray2M.AssertModel(models[20],_testData[29], false);
                GuiduuidArray2M.AssertModel(models[21],_testData[30], false);
                GuiduuidArray2M.AssertModel(models[22],_testData[31], false);
                GuiduuidArray2M.AssertModel(models[23],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[24],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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


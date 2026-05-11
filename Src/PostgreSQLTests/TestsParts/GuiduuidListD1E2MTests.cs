

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f7820c87-24b6-46e4-ae51-561ca66e04be"),

Guid.Parse("b1dbf6d7-3405-451b-bb16-5b26f7c37a82"),

Guid.Parse("5c10955c-3dc7-4019-b482-590dd2ecca30"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("17c66057-fd9d-4ba2-8ed6-5a5407f2dea8"),

Guid.Parse("2f2e11a3-3730-48ea-a9b7-dbdddf999422"),

Guid.Parse("96f3db4f-f5df-46b0-8b45-e72ed7fb3e04"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("289b669c-d03e-417c-9f26-2f46658ccb6c"),

Guid.Parse("5fcb61f2-7690-4d60-adf9-742364ef0ca9"),

Guid.Parse("1a05d95e-cfc7-4111-a2a9-01be1f112e5b"),

Guid.Parse("1a86b61b-f721-43e7-9b8c-c70fb11d3a86"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("cdc93864-cfbe-44cb-b4e1-e3438b3964aa"),

Guid.Parse("dcf00f58-9e75-4e48-acb1-ec578c79c440"),

Guid.Parse("51a25bf1-43e1-4813-a2a3-53f0a95654f3"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5a622813-a8d0-4107-ad7c-82f4ea43c7d6"),

Guid.Parse("e81dba28-7898-4cec-b2b9-3fe1543cf49b"),

Guid.Parse("f2f05d66-93b5-45dd-a9a7-ba714d651c04"),

Guid.Parse("70cde5b9-f266-4d19-899b-c98d8e9a525d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("eaf45867-ca0f-485f-9a08-98c5e91c37cd"),

Guid.Parse("83e5c5d8-2737-4727-8244-ff81a6d72c7e"),

Guid.Parse("ddfcc093-1a7f-48bc-b108-3cdee5e0d275"),

Guid.Parse("fdec0b61-ae57-4f5e-8c73-b0de5012443d"),

},
},
            new GuiduuidListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("16fa7016-f0db-4951-b04c-c254202fce7a"),

Guid.Parse("b512fc4c-5a32-4630-8684-6f99e53a286d"),

Guid.Parse("d1a8c6c6-95e9-4522-a132-293900f4ab28"),

Guid.Parse("8b56d04c-af7c-4f52-809e-646e507dc78f"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("32ba390e-9945-4b77-8096-59262d8ba9cb"),

Guid.Parse("51abae89-8bcd-4330-be58-154393172382"),

Guid.Parse("33b20c65-2aa9-47fb-a1f2-bbf59cacb533"),

Guid.Parse("052ce0a3-d73f-42a5-b371-b9c8e18ecbfd"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5fb0872b-c1c9-4be5-aef0-0be7d281d372"),

Guid.Parse("a3c3acbf-aaa3-4911-a62a-7904b332a282"),

Guid.Parse("155aeee5-2678-4178-8105-76e842c666c3"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("587dfae7-4211-4771-a098-ea7019f21b8c"),

Guid.Parse("29c3d71b-9a38-44cb-abbe-ab5a4bae7914"),

Guid.Parse("f4c1ea85-cd72-42c6-abd5-c4ab2c3e3067"),

},
},
            new GuiduuidListD1E2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4aa28f46-bf4a-4af1-ae66-157e3064362e"),

Guid.Parse("eae83522-29f4-4be2-a5a3-d6455f55c4cb"),

Guid.Parse("ab2c4c6e-b0da-48c3-8862-1bb43897152d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3b279673-bb22-4d7d-8b41-b6e4236e9689"),

Guid.Parse("4ad60133-81dc-49d1-b948-b1774c51eb4d"),

Guid.Parse("bcbd3a99-fbc4-43c4-802e-82de75ae726b"),

},
},
            new GuiduuidListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("811bf257-e514-46fb-9409-12179341f5f4"),

Guid.Parse("d5274af7-1121-4fe7-afbe-1f47e9ac678e"),

Guid.Parse("c8a117c1-3361-4d71-b0cc-ff94fad1d12e"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("07ff4b40-6b6b-4919-b517-ff724e6686c5"),

Guid.Parse("723a0383-fb83-4539-b675-a3ffccd4edc4"),

Guid.Parse("f2725d52-4fc5-4df1-bc6a-9b70e59be455"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9bfa246d-40e8-45a0-911d-9904657ab23a"),

Guid.Parse("70120a3a-6c93-4962-af3f-e87184c61ea9"),

Guid.Parse("deffec63-d257-4716-82b9-d65ae9d3d1db"),

Guid.Parse("c3d72415-f92f-40b0-848c-dc5528be6ad7"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3560ef71-4e96-4cb7-8cba-c83fc6025a4b"),

Guid.Parse("ede5755d-99a6-437a-8025-0fb4b4411afb"),

Guid.Parse("ecdb43aa-86c1-48e8-aa76-1de4aa28c46d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ac05afe0-1dbb-4992-8b7c-ac67badd6e8f"),

Guid.Parse("8e161e8e-924c-4d1b-b709-911a48214c29"),

Guid.Parse("2176e2a9-03a1-4cef-aab9-3e6df82a6b23"),

},
},
            new GuiduuidListD1E2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("249d0344-f956-45ac-9a2b-c9582edf1d1d"),

Guid.Parse("87008636-bd42-47a9-b468-b9928e9d5e08"),

Guid.Parse("705f4128-0064-48f7-ab5a-233b7acb6051"),

Guid.Parse("bf857dec-0b4d-49f5-a07a-9b8186e8c18c"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c0456648-7c3f-4de1-9b08-2e677d290b21"),

Guid.Parse("a13e734c-5715-446e-b713-b75b5a225128"),

Guid.Parse("1df589cf-d13b-4986-9b10-ba7be2786de6"),

Guid.Parse("878ce1b3-acae-4dc4-95d6-6bb3c5a9b6cc"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e899ec5a-5362-4784-adda-6b938dee6da6"),

Guid.Parse("cda92f8a-7b59-435a-9371-1eb7332ddc39"),

Guid.Parse("d8578331-6385-45b5-a7b2-7d4b8b63345e"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5828032e-95de-4e97-9a50-9db88844c101"),

Guid.Parse("70c3581c-1701-449f-8013-261e4a594e7c"),

Guid.Parse("6d90a7d6-e335-4131-a2d9-efda0d2567ed"),

Guid.Parse("4f824ddf-cfdb-41fa-a60e-6c7874ad8153"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64309843-83ad-4005-abc4-23f25da53202"),

Guid.Parse("e3340b0e-2706-4325-9b67-82f6c3db9e07"),

Guid.Parse("92b438ad-4bb7-4dac-b45b-9798d8410275"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0af1513e-baf9-4b6a-bbeb-803337999727"),

Guid.Parse("d8c2128a-a2b2-48fc-8ff2-dbc79bed733a"),

Guid.Parse("b4128eea-9261-4813-a128-904255e6ef6d"),

Guid.Parse("b498fb37-2720-4113-b940-56ed915e919e"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("52e1d9f0-5418-4dc1-a962-b235d366e948"),

Guid.Parse("7a136d2f-6360-4894-b30e-16875bef0d85"),

Guid.Parse("30e70701-a07b-485c-b805-00aab405f633"),

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
Guid.Parse("6dbedd1c-0e2b-45ed-85ca-a2256987267b"),

Guid.Parse("af7c1941-ea1b-4835-996e-8aa8e95071a9"),

Guid.Parse("15612a50-4fe8-43f4-b9df-4432509bb1af"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f68cb07-4413-4770-84a1-2db548aa199f"),

Guid.Parse("4a8dc14e-3fd5-42ed-a657-157c7a33b79f"),

Guid.Parse("8ae6b7dd-f99e-4cf8-a1c1-0e065a6b3410"),

Guid.Parse("bf20486b-d877-497e-b4f3-352eb9e97b9b"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("24fe6250-fcfb-4a86-8eaf-85ec280eac89"),

Guid.Parse("34d7d040-0ffd-4653-b6a1-4b2e5f4cb435"),

Guid.Parse("216a0042-78e6-40c4-8aaf-96506d7473cd"),

Guid.Parse("7e99298c-5c1c-401c-8e9c-ff3f3025954e"),

},
},
            new GuiduuidListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b91107ac-5c5a-4266-9e13-553df39541c6"),

Guid.Parse("71266db5-49d7-45fa-a3f7-563ab686b2f9"),

Guid.Parse("27faf421-99a3-4c93-8a51-b193e857ed8b"),

Guid.Parse("261ce93b-505d-4b1d-ab98-023da38b7475"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c954e14c-8b32-4f57-8b70-fbf330ed2626"),

Guid.Parse("b384228c-4480-47a0-9306-ad36a4d963b9"),

Guid.Parse("a2971d05-ecb9-41d0-9a2b-dca08402467d"),

Guid.Parse("948dd07d-faf7-45d3-85cf-99ff764fd517"),

},
},
            new GuiduuidListD1E2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d61066d7-38ab-4fa5-bfc7-55e48b28a13e"),

Guid.Parse("6812b378-7a99-46b6-ad41-a808a26c4c80"),

Guid.Parse("329969f8-39a6-4bca-a230-4b5cef31a815"),

Guid.Parse("687ee07d-fe12-4432-a8f9-ccfb3eaf5f73"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1d9091db-0411-41a0-87f7-c6d718a40cd8"),

Guid.Parse("53c5007f-951d-4b5f-b488-2628dfc81599"),

Guid.Parse("185da136-deee-443e-a57f-fb77634dfdc1"),

Guid.Parse("721cf768-b6eb-4928-9b3a-440e660f652e"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1829e212-46bf-46c0-93e5-70be0b94fcd5"),

Guid.Parse("10a28ba5-3529-4285-8105-e95f773227f4"),

Guid.Parse("0431a554-cae3-4c69-885b-6f3239f94de5"),

},
},
            new GuiduuidListD1E2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e2e69449-2fc7-45c5-a690-2e19f6b54330"),

Guid.Parse("e77da0fe-306e-41fb-a6b5-ee9a49aa1c2c"),

Guid.Parse("d758269a-d096-492b-b2cf-f3a838990641"),

Guid.Parse("64e0d6bf-5ccb-445d-8b92-10677e215ec3"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a5889f4f-3b6d-4d8a-9b16-b210d3928132"),

Guid.Parse("52e2cd9e-9998-41ce-9dc3-c5048cacb3db"),

Guid.Parse("4a1da788-69ea-4ddc-8c57-85a341937419"),

Guid.Parse("a37b2def-55e8-4816-be4d-35a4be6dfd99"),

},
},
            new GuiduuidListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("036fd6d3-5600-4b1b-b319-a6e0f64403f3"),

Guid.Parse("d28145cb-1bfc-4d47-8cdb-deb6a7eb9917"),

Guid.Parse("d196bc64-0ada-4533-8990-198b7a7c8577"),

Guid.Parse("fc33a981-1cb0-412a-b88b-68302d6c8f1c"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fae694a2-5998-4981-b0e1-bbf802148056"),

Guid.Parse("1a84116c-693e-4164-a6ef-22bbb7a0f861"),

Guid.Parse("128fe842-d4db-4747-a7da-306f34e27271"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7ebbadf8-b5ca-474c-8fc4-2f1e25419f83"),

Guid.Parse("52f1a368-c742-4b4a-a58b-18123400ba9a"),

Guid.Parse("8f4a39f1-63e9-43e6-8002-83cab5b0e0fd"),

Guid.Parse("2d9e5dc2-3074-4cf2-aad5-10ab10554dab"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c83ec7c8-9f84-4d99-9d84-cdb9b7af5916"),

Guid.Parse("b760c5e0-b7c4-45be-95a7-0d6f59a1f663"),

Guid.Parse("3b3abdda-ca52-42dd-b891-0e9cbfe062a9"),

Guid.Parse("dee4d228-953f-43d2-ab9c-d6aab35bfaab"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3dc1101-6bd3-4625-9d3f-86794acd25f7"),

Guid.Parse("fb28648d-58c2-46c0-b8e5-c52a67b58bd4"),

Guid.Parse("5c975b34-920b-483d-8738-09831c75f3a5"),

},
},
            new GuiduuidListD1E2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8e8c9d37-3f66-4817-acaf-816ef96a7b18"),

Guid.Parse("422eb690-aa54-4baf-ad31-b86ea8ab013b"),

Guid.Parse("57921fe4-8436-4d5b-9db4-a5af25581ce6"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2ceb7326-d17c-47f5-9d9b-104c5cec448f"),

Guid.Parse("64f78a3d-848f-4a33-874d-5d264775ab9b"),

Guid.Parse("a1bd08c9-c936-446e-be60-1ac046177859"),

Guid.Parse("5b5570bb-c34b-44d9-9f85-32325d3d0071"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("877dddcb-fab7-4917-854b-4a4e254139fe"),

Guid.Parse("b5e6b72b-acc3-4090-b859-dd8df460c2bd"),

Guid.Parse("2dc0e7d3-7e85-4dd2-a7f5-b574866d8fd8"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("0f02b4b9-0c32-4043-a8f0-82497311b6e0"),

Guid.Parse("66346eb2-85d3-4c03-b973-a51f00f8e5c7"),

Guid.Parse("495926b9-cc5e-4cfe-82f1-5fb059dd124d"),

},
},
            new GuiduuidListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5956e4f2-c20d-47b7-ab87-9e4d8fb1468b"),

Guid.Parse("380a1994-b6b0-4eb0-a009-7ff4a79805a2"),

Guid.Parse("4a7e2d4b-e4ee-4e0c-9183-169525d3daf3"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("10631dbf-fd78-4246-98e1-881f53f4e14e"),

Guid.Parse("1df39b1a-05d1-4c21-9c9d-8a038325371e"),

Guid.Parse("28ec09a2-f7e3-4e7e-970d-a75661880bce"),

Guid.Parse("e8646a6a-0816-4dc1-a3ce-cb072e2f4602"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("eaefcebc-b7e2-4667-99a5-48f4e0b8efa0"),

Guid.Parse("c86f02b0-04f2-438a-9127-c0103ecf1870"),

Guid.Parse("c7d749d3-b736-462d-9c1a-3ff4221d76c1"),

Guid.Parse("ade53bef-84b6-4113-ab1d-7636745bc9d8"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("516ef932-f523-4aa8-b72d-297628bb0813"),

Guid.Parse("e64903bf-f96a-4df4-ad05-08713e5d2af3"),

Guid.Parse("259e3c4d-e11d-4662-8dc1-0b833714a50e"),

},
},
            new GuiduuidListD1E2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2bafbbe6-e0ca-4a0f-baa8-e3aa3023fa0d"),

Guid.Parse("37bdf538-6ce4-4be3-9f2f-96ee1608da36"),

Guid.Parse("e14d1fa2-b75d-459a-abae-3bd81924a679"),

Guid.Parse("ec6a180b-21a7-4e0d-ae97-955e5f43ac5a"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c7f255da-5867-4af6-83f3-3639238f16e5"),

Guid.Parse("79019a7c-a066-452a-879f-008dede41343"),

Guid.Parse("b13b6b16-a6d0-4a81-a84d-fd331025cc56"),

},
},
            new GuiduuidListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05f19dec-227c-40c4-9997-9508ab26452b"),

Guid.Parse("de97513c-7ee4-4c90-9f32-9218649c056c"),

Guid.Parse("f3b03719-8e6c-495b-8755-3af07f4e6e67"),

Guid.Parse("057769db-d607-4940-bd7f-a80778ac3715"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f4036c09-444b-45a0-905f-f26caf14d360"),

Guid.Parse("4af9613a-9619-4f15-a6d9-6ca5acf84e58"),

Guid.Parse("d7dcfcd3-6e8d-434f-b75b-57be8e498a34"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("23aab9f3-aaa5-4dfe-ae09-d00ad70b29ce"),

Guid.Parse("d0d97976-73e8-4df0-adf2-6d4822a3d837"),

Guid.Parse("633328ed-5054-4043-8bdc-d8140267de3b"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e62a99d2-302b-4cf2-9822-bc990a433d43"),

Guid.Parse("d92205eb-1684-4028-95ff-9546e9ecd639"),

Guid.Parse("2e7a7a96-32e7-450f-bec0-6d3c4e79d3e0"),

Guid.Parse("d6309e1a-bb5e-4c20-9378-4f62576b8875"),

},
},
            new GuiduuidListD1E2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9bab613a-b171-4bb5-9840-4878ced40215"),

Guid.Parse("2dc8b77a-f85a-4edc-8287-de0dd6e86eb7"),

Guid.Parse("9e2f40a6-d315-4b81-b462-ec646523d6f5"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9072d488-c961-43a8-9aac-c73e2d74e4d0"),

Guid.Parse("f3cacf33-fb85-44ba-94f1-33eb93ad4799"),

Guid.Parse("888fc8c6-4519-4f32-a6d3-980a0db57d9f"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("944582de-6631-46a8-b890-40a42ec81678"),

Guid.Parse("4d44a379-692a-4142-b4f7-93583b29ca4a"),

Guid.Parse("eae3431c-a990-4989-a8a9-9e4600a9178c"),

},
},
            new GuiduuidListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8d44ca15-a2c9-4a9c-bbc5-0180e9a2ef3e"),

Guid.Parse("fe8891d9-3e03-47e4-8f21-266335c77c56"),

Guid.Parse("1f2b3a86-2602-4dd6-96ae-1f63df32ba07"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("36cc6960-f76a-4b34-973e-9f936c0e3a2a"),

Guid.Parse("1b160858-a627-43a5-8e9e-86423e01f0c4"),

Guid.Parse("a276a665-74c9-40ca-b6c6-cc030cc844d3"),

},
},
            new GuiduuidListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("66990a60-870d-4444-9521-bc639e717b06"),

Guid.Parse("68080236-3fe7-4ac7-8d56-4b6888595a70"),

Guid.Parse("e3fa2bc5-7084-4981-b844-ba9617cb5c38"),

Guid.Parse("1b3111f8-8f99-4eac-839d-1f41453b1d7d"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ef497f68-d247-477a-bb3f-51e9ff95c211"),

Guid.Parse("727f1ae1-bbb5-43d9-bf47-c589b08e7f98"),

Guid.Parse("0157676d-6b49-494a-b286-4c22415968a6"),

Guid.Parse("f79e05c1-d7fa-47c9-a27f-cff3bb3060e8"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3d7fcec-0457-48a1-bc18-455fc53be920"),

Guid.Parse("3c689f6d-fd3c-4d2b-893a-eee66710d7b1"),

Guid.Parse("64861dbb-275a-4295-85ac-15454029347a"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("92f4fc59-7162-4fc3-89d6-b458153f9609"),

Guid.Parse("bc95926c-aade-4e7e-82e6-41275de0f10b"),

Guid.Parse("6725f4dc-7161-4628-8a95-922401bcb88d"),

Guid.Parse("eafc0a79-2896-4d35-8b3f-e0e258b95795"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6c17b298-cb40-4733-a76e-b08e7e8c3e30"),

Guid.Parse("f10f0afa-1701-4e68-9142-26ec589447a1"),

Guid.Parse("6061f650-f5ef-43ac-bf32-372b3e180c38"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c2a02fc7-8907-48d6-b995-befc0cb605d8"),

Guid.Parse("91b7ee4a-0541-4467-baeb-835c1b02e0a8"),

Guid.Parse("9e4a59db-1d4d-449d-a118-04b4f334cc03"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2b92322c-9134-4dfe-85f8-c03300107e02"),

Guid.Parse("35828a1a-31e8-4b5c-a440-27a84711ab33"),

Guid.Parse("4dcc373d-1635-45e4-9900-9c16c08e17bd"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("82286924-a9c0-43c6-9e95-6b2cb7d331db"),

Guid.Parse("a2ecb4b6-c7c1-49ca-8114-63a84fbc9f14"),

Guid.Parse("49901c23-1953-480d-aaa6-ad255c53f986"),

},
},
            new GuiduuidListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c54b0fa8-3629-49a1-bb51-1918d5865982"),

Guid.Parse("20a63543-f962-44ca-bdd7-189bdfb13f2e"),

Guid.Parse("a532d267-0d22-4807-94ed-b0f05e736b6a"),

Guid.Parse("9ada9684-cd5d-482e-add6-b565bd22719d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("023d8437-a748-4ebc-b0ee-aa5d547b78b9"),

Guid.Parse("309ce1a6-338b-496d-b5c1-05bb214a74cd"),

Guid.Parse("bd63cba8-4d0f-45f7-a4c6-acf8b03b211d"),

Guid.Parse("237ec872-dfdf-417a-a5d8-d20167f92f6a"),

},
},
            new GuiduuidListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1c8bc778-8753-45fc-99b6-3099d4c50dd9"),

Guid.Parse("6b1eba98-4135-4a9a-94d1-43ef57e8b43b"),

Guid.Parse("afcc682f-f1ee-4d5b-a17a-4e01befb27b8"),

Guid.Parse("f890aaf3-9ec1-437c-876c-6227a8fc39e1"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f6a2503f-cfc5-4a62-955e-8e1c3ef6f981"),

Guid.Parse("930004a1-712f-4e3e-90ad-5df96f7c2809"),

Guid.Parse("f672ccaf-22bb-4e5f-b03e-26fc72f30a92"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a26e7de0-508c-471a-8e39-d34b9763c9ed"),

Guid.Parse("6d8562aa-c152-4a28-9474-6a0d75ee6792"),

Guid.Parse("23ef9022-8824-40e2-a49f-281e03e37087"),

Guid.Parse("aa4a55dc-b00f-4d32-994f-50af5d3399a5"),

},
},
            new GuiduuidListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("647ea468-03b8-4740-ad44-a23e356c241f"),

Guid.Parse("a59bd076-390c-4197-aacb-06b73ec4593c"),

Guid.Parse("42138e4c-2e0f-4ffd-8680-f91a982bf641"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("245afdc6-b3b8-429a-a64e-7a45b4893955"),

Guid.Parse("44bd4a7a-2487-4f27-b502-9c1fda6c7167"),

Guid.Parse("6a589cd5-144c-48c7-ac7f-3d044ebf38ca"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ffa2acb1-81b4-4fa0-95b3-52d8388fb90b"),

Guid.Parse("d17034cb-e71b-4466-8b60-2156ecd9e130"),

Guid.Parse("988ef215-615e-49fe-9801-9e09341ff037"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("15eea40c-46a1-4d9b-853b-c66baf53da85"),

Guid.Parse("c24af956-8909-4b11-b701-1bc9ab1ed396"),

Guid.Parse("a9aa3a54-0ee0-4e16-ac05-000b36783019"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d46cbfdc-6d1e-4fef-9df1-ec32f1a6aeb3"),

Guid.Parse("0ad5d4f8-3d31-4ba8-b6a8-1b2d4fcfb88e"),

Guid.Parse("4e654360-f324-423d-86c5-a7587bf44952"),

Guid.Parse("f7c3e4d5-112d-456b-9e73-ff5fc7dbd0c9"),

},
},
            new GuiduuidListD1E2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("00c37528-f5a7-43ee-9655-0a8341792d97"),

Guid.Parse("f383bfbc-2998-4e89-9db4-1a3d11d4f8b2"),

Guid.Parse("57a64348-2a8c-4580-8ac8-bee5c50b3313"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f5478820-f956-4263-8493-5c3b57e121c9"),

Guid.Parse("fcc01640-a008-403f-9898-d3ca02e41226"),

Guid.Parse("eb4f8190-473f-4670-a152-0aa5c52e8647"),

Guid.Parse("1ce6445b-3e83-44eb-877b-2ede8ba2ed18"),

},
    ModelInner = new GuiduuidListD12MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27910b8d-fa80-48aa-8be1-d8371c0cb9a6"),

Guid.Parse("67af52ee-96c4-487e-9cd5-0d8c1a945868"),

Guid.Parse("53918fa4-9535-4619-90b4-4e41dba9ed9b"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8eae0db9-d4c7-4e91-b791-5e285b3e51fa"),

Guid.Parse("bc56347b-5ea6-403b-822b-9e5bd337c400"),

Guid.Parse("41964d70-3413-48ac-8c3d-8425a6b1c01a"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a56dd449-ed46-49b7-aa3c-8703e5222555"),

Guid.Parse("1b606b56-7d87-42d7-aa94-6cac6124d709"),

Guid.Parse("24fe5724-a02e-45bc-acbb-c83293815ed5"),

Guid.Parse("e02236d8-632b-46af-bc3c-4c06374a1b58"),

},
},
            new GuiduuidListD1E2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("92d033e0-e696-472c-8171-4b8ed7fc3e3d"),

Guid.Parse("18f4c34a-8a72-4411-829f-6d009d34739c"),

Guid.Parse("37a45025-2c57-47be-8f33-fc2e409658df"),

Guid.Parse("413a600e-9ced-452e-ace3-dcfa148367f8"),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd12mi(
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
INSERT INTO public.guiduuidlistd12mi(
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
            queryMapTypes: [typeof(GuiduuidListD12MI)],
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
    guiduuidlistd12mi_id
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
                methodParametrName: "guiduuidlistd12mi_id", 
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
    guiduuidlistd12mi_id
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
    guiduuidlistd12mi_id,
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
    guiduuidlistd12mi_id
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
    guiduuidlistd12mi_id,
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
                methodParametrName: "guiduuidlistd12mi_id", 
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
LEFT JOIN public.guiduuidlistd12mi mi ON mi.id = m.guiduuidlistd12mi_id
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
LEFT JOIN public.guiduuidlistd12mi mi ON mi.id = m.guiduuidlistd12mi_id
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
                parametr1.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
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
                parametr1.Value = 108;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
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
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[34], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[34], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[34], false);
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
                parametr1.Value = 38;
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
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
LEFT JOIN public.guiduuidlistd12mi mi ON mi.id = m.guiduuidlistd12mi_id
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
                parametr1.Value = 104;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[34], false);
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
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 53, query1, 58, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
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
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 166, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 129, query1, 73, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 53, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 3, query1, 147, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[34], false);
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
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 175, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 157, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[34], false);
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
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 63, query1, 137, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
LEFT JOIN public.guiduuidlistd12mi mi ON mi.id = m.guiduuidlistd12mi_id
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 20, 129))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[4], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[5], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[6], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[7], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[8], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[9], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[10], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[24],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[25],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[26],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[27],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[28],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[29],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatch(connection, 119, 111))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 59);
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
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 175);
                var models =  ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                GuiduuidListD1E2M.AssertModel(models[0],_testData[33], false);
                GuiduuidListD1E2M.AssertModel(models[1],_testData[34], false);
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
FROM public.binary_guiduuidlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD12MIWA)],
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
            queryMapType: typeof(GuiduuidListD12MIWA),
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
                var importCollection = new List<GuiduuidListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidlistd12mi
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
                    GuiduuidListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidlistd12mi
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
                    GuiduuidListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD12MIWA)],
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
            queryMapType: typeof(GuiduuidListD12MIWA),
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
                var importCollection = new List<GuiduuidListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidlistd12mi
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
                    GuiduuidListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidlistd12mi
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
                    GuiduuidListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD12MI)],
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
COPY public.binary_guiduuidlistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidListD12MI),
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
                var importCollection = new List<GuiduuidListD12MI>(2);
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
                    GuiduuidListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD12MI>(2);
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
                    GuiduuidListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD12MIWA)],
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
COPY public.binary_guiduuidlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidListD12MIWA),
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
                var importCollection = new List<GuiduuidListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD12MIWA
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
                    GuiduuidListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD12MIWA
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
                    GuiduuidListD12MIWA.AssertModel(actual, expect, false);
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
guiduuidlistd12mi_id,
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
LEFT JOIN public.binary_guiduuidlistd12mi mi ON mi.id = m.guiduuidlistd12mi_id
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
    guiduuidlistd12mi_id,
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
            queryMapTypes: [typeof(GuiduuidListD12MIWA), typeof(GuiduuidListD12MIWA)],
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
                var models1 = new List<GuiduuidListD12MIWA>();
                var models2 = new List<GuiduuidListD12MIWA>();
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
    FROM public.binary_guiduuidlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD12MIWA>();
                var models2 = new List<GuiduuidListD12MIWA>();
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
    FROM public.binary_guiduuidlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD12MIWA)],
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
COPY public.binary_guiduuidlistd12mi
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
                    GuiduuidListD12MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_guiduuidlistd12mi
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
                    GuiduuidListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD12MIWA), typeof(GuiduuidListD12MIWA)],
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
                var models1 = new List<GuiduuidListD12MIWA>();
                var models2 = new List<GuiduuidListD12MIWA>();
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
    FROM public.binary_guiduuidlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD12MIWA>();
                var models2 = new List<GuiduuidListD12MIWA>();
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
    FROM public.binary_guiduuidlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD12MIWA)],
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
COPY public.binary_guiduuidlistd12mi
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
                    GuiduuidListD12MIWA.AssertModel(model, expectedModel, false);
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
COPY public.binary_guiduuidlistd12mi
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
                    GuiduuidListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD12MI), typeof(GuiduuidListD12MI)],
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
                var models1 = new List<GuiduuidListD12MI>();
                var models2 = new List<GuiduuidListD12MI>();
                await ((IGuidListuuidListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD12MI>();
                var models2 = new List<GuiduuidListD12MI>();
                ((IGuidListuuidListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD12MI)],
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
                    GuiduuidListD12MI.AssertModel(model, expectedModel, false);
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
                    GuiduuidListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD12MIWA), typeof(GuiduuidListD12MIWA)],
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
                var models1 = new List<GuiduuidListD12MIWA>();
                var models2 = new List<GuiduuidListD12MIWA>();
                await ((IGuidListuuidListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD12MIWA>();
                var models2 = new List<GuiduuidListD12MIWA>();
                ((IGuidListuuidListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD12MIWA)],
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
                    GuiduuidListD12MIWA.AssertModel(model, expectedModel, false);
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
                    GuiduuidListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}


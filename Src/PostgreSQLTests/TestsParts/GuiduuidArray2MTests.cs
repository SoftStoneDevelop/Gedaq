

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
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("df32f13c-d8af-404c-a3b3-5f9c6423a4a4"),

Guid.Parse("9686f9b6-4a67-4c06-acb2-879e60fd37c8"),

Guid.Parse("85de7b2d-d2d3-4f2b-8357-f63b064a15a7"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("82540189-ef27-43a9-af03-e92d476038f3"),

Guid.Parse("92ef9bf3-723e-41fb-8cd1-3e4b0809615a"),

Guid.Parse("d242c416-6ccf-4c5e-8479-18d1800ab831"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("93598682-04cd-46d6-8010-3b7fec3e1bc2"),

Guid.Parse("3d339b34-d554-4ccf-a6e4-5e080bcafc04"),

Guid.Parse("c536f9e0-c57c-49bc-8c61-8822df2f7998"),

Guid.Parse("16d82633-14f9-439b-9d21-9cda990edf13"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3b1b16fa-0bf7-40b4-872d-b41f31157247"),

Guid.Parse("1d892425-fe92-4d5a-9d33-98a35e3f70f3"),

Guid.Parse("d4f7388f-e38d-45d0-a8ca-20a1b5da8b18"),

Guid.Parse("506f0007-6c46-4f12-9e79-fe066764c7c8"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("87129baa-70ad-4397-aa7e-c13626c8e8a4"),

Guid.Parse("e46ecd38-e4e5-459f-8391-31416b9f7319"),

Guid.Parse("e584605f-1e02-4a46-9152-4931ea8c7e5c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f7783a8f-b5f4-4ed2-a3f4-cdfc808153ff"),

Guid.Parse("9cd7e130-f09c-4049-8ee5-4b75cc64fed0"),

Guid.Parse("bf4b7844-3740-4393-8d22-e0b43a41966b"),

},
},
            new GuiduuidArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9a8c8a29-f773-4a0b-be19-be783a7d7709"),

Guid.Parse("e7b3a53f-6593-44d8-830c-75dc4e9294ad"),

Guid.Parse("f391aca1-8c3c-4647-a67e-03fa42c27335"),

Guid.Parse("8f5ff2f2-1f39-4011-929a-5b2d2335fec9"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6d54f830-7cda-43c1-b458-47f8637a3188"),

Guid.Parse("38cdab13-47ef-445c-9536-c19b5ab9fcfa"),

Guid.Parse("cc50f542-9351-46c9-923c-b756fcf0f346"),

Guid.Parse("84464dcc-4adf-4e2e-a834-7721e0903d16"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("90007c92-34af-4198-9036-2ef65a8f8f7a"),

Guid.Parse("edb36e23-7506-4452-bd5a-d95ba982aaca"),

Guid.Parse("d86e8fbf-5af5-412b-acf5-45a06359eb7c"),

},
},
            new GuiduuidArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("27d30378-b175-49ca-8770-f0bcfd7bf55b"),

Guid.Parse("b190fc3e-d8ad-44d8-9ffb-66576427f9e2"),

Guid.Parse("2aadcfa0-0954-4cc9-b5c7-2f2fbbe99947"),

Guid.Parse("5aad7533-f65d-49a5-98fd-95f3810a9f95"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("eeea9c4f-250a-416b-ad42-0a9fa5b85958"),

Guid.Parse("f813063f-3f64-487b-a4d2-eac4096350f3"),

Guid.Parse("5ae0eae7-e7e5-445e-9b9d-5f83c20131f8"),

Guid.Parse("402bf977-c3f7-4167-9a92-f89bcbaa4b62"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d6add850-5178-493a-b5e8-43bc9db40ca3"),

Guid.Parse("752d0cf9-466a-40b6-b50b-a797325bb8fe"),

Guid.Parse("6eadda9f-0c96-4780-b7c7-e26bb7ca88a3"),

Guid.Parse("1f472618-a07a-42d3-9038-708666e46c53"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63b49afa-8a5d-43ff-89c9-29e7131d8d97"),

Guid.Parse("0c905bf0-cd91-4a91-bbc1-a239a2f3f60b"),

Guid.Parse("ba454496-7a34-4518-abe2-1c394503a14c"),

Guid.Parse("71ce6b44-4517-41ba-a696-a8f7685aa9fa"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("fd6bbd11-cfc6-4590-a27f-5e57ca513fe6"),

Guid.Parse("2dbc40f1-d6a3-44ee-87d2-f2918938e91b"),

Guid.Parse("2d2ee409-7674-448e-9413-20d01ace6d0d"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("099b4c08-d8c8-4118-ae25-5b0b646e99cf"),

Guid.Parse("1b99e126-5ac0-440b-84ad-b012edfe12e6"),

Guid.Parse("2dd278e3-e05d-499a-b3cf-e7451f6533b0"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ec10fb15-c205-41d6-a510-f8c0fe549378"),

Guid.Parse("c651202d-97a7-40b5-bf41-ba0d1af58fed"),

Guid.Parse("e1a58a4e-3591-4819-a94e-c8d77d53edf3"),

Guid.Parse("bd162990-7276-4473-8c88-037989c20925"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("833eb0ab-72cd-4f1d-81c6-684f10ec0944"),

Guid.Parse("5e4eda83-49b8-4824-bd5f-609d191202ed"),

Guid.Parse("d815d280-6e3b-41df-b0fa-0648e631945b"),

Guid.Parse("1e9d6199-d397-42cd-bec5-5401ae7dee8f"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5cce622a-816b-4791-b437-a3acfd13575d"),

Guid.Parse("ff3c0703-6de1-4db9-b39b-2100f1070ef9"),

Guid.Parse("e0c94540-62d1-486c-b7a2-65516fd4a8fb"),

Guid.Parse("3834cfa3-cf61-44b3-aa45-a8e4b4e8603f"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("18f2d514-c272-4505-b9c5-768815388333"),

Guid.Parse("76b37693-57ef-4de6-9f26-f0a65c8f60c9"),

Guid.Parse("d7461ddd-acf5-463c-b82d-00f9e943b44d"),

},
},
            new GuiduuidArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("424ce221-5e17-4236-a878-cda3cb8adf36"),

Guid.Parse("eee391a1-a858-491e-b9d4-d7ace81cd9f6"),

Guid.Parse("b334581b-aed8-439d-b01f-b7529a703180"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a456a0cc-deb3-4769-b1f9-9828e81eecfd"),

Guid.Parse("aa4c84b4-65bd-475e-9601-363d9bf3748f"),

Guid.Parse("b3027d49-be9d-42f7-bf3e-d787fb346d8a"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e562043c-132f-43e8-a77e-6690ecfb3e9e"),

Guid.Parse("40016973-049b-4836-8e5b-da538d7be253"),

Guid.Parse("1ad2a6ad-234a-4480-9191-2612dd9604d2"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("25642cb4-daaf-403d-a8bc-21ad55b39ff2"),

Guid.Parse("3343f6a4-16aa-4b43-a6dd-6eedb3999345"),

Guid.Parse("c2d83fe4-09da-44ef-a777-e18a962158f4"),

Guid.Parse("24327cc1-672c-4bbb-8c42-b9b13deba4d6"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8980dae3-a63e-41a3-9a5e-461088220461"),

Guid.Parse("4d3ce988-ee7e-4825-9a13-4e792e417230"),

Guid.Parse("efc9bb31-490b-4aba-ace2-bde054043f1b"),

},
},
            new GuiduuidArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("177411b9-2b2b-4b7c-b337-f4c5c954952a"),

Guid.Parse("5d01b343-9728-486d-87b5-80194875a670"),

Guid.Parse("1834c4ed-6ac2-4265-9ae8-e05ac452cbb3"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8bbb5847-bb1f-4eee-830c-7ddd5fe3b462"),

Guid.Parse("6f5cad95-d90e-468d-ad99-a54bd55e3fe3"),

Guid.Parse("add4cfde-e961-4a56-85ac-8b0b1d95bbdf"),

Guid.Parse("c832845f-fcee-4211-bc54-57f34a4b7e4d"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35da86cd-d6fc-43e5-82c5-3e4d256645b3"),

Guid.Parse("5720678a-1819-4bd9-86ed-4740376938a0"),

Guid.Parse("76d278c8-cfee-4e3c-a835-aefd95be1693"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("93d3f59f-0531-4b89-95a6-2931a16d6607"),

Guid.Parse("fcd04d9f-8907-4d5d-b38f-657138181ead"),

Guid.Parse("b3a354f4-5dac-4a17-ad54-ab9f4ec02c71"),

Guid.Parse("be3fc276-c130-49d0-b364-782b6ee2d941"),

},
},
            new GuiduuidArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("871ceb47-9a8e-44b4-b3b9-c18af02a27e3"),

Guid.Parse("6718dd47-3743-40c2-9c3f-6513b8741662"),

Guid.Parse("b51b8eb2-4ed4-400b-ac5e-10997158bfdb"),

Guid.Parse("0bb15f23-3566-49a9-ab77-b7eb443bd969"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c26db166-e1d1-4627-9de4-28aee0ca584b"),

Guid.Parse("fb6cf81c-96a0-45f9-8536-2e16c277df1a"),

Guid.Parse("0b136561-2743-4179-8665-85f19649a7ef"),

Guid.Parse("de55c677-e1e9-4c7b-b556-3ac81a35e5c6"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3adf0e78-287e-4a86-8361-898517e22b4f"),

Guid.Parse("fdc54d39-34b0-4570-a1ee-1cc656a36bef"),

Guid.Parse("547f3b58-741e-4203-8094-3283611ec9c7"),

Guid.Parse("b4e63079-99e9-4a72-b2ab-f2ea752465ed"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1eb16af1-2d82-4013-b5a1-4f40b02d7c00"),

Guid.Parse("21ab7020-524c-4465-a0bf-d0e32ec53965"),

Guid.Parse("cbdf9fa1-fa7f-4da0-a0b5-81ce4651e3a9"),

Guid.Parse("062a6d75-0728-4d7f-8a1a-f2541abc6a92"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5e1c0976-6fb3-407a-87c7-1f80e3c347aa"),

Guid.Parse("956e3994-bb18-4457-9b7a-781a3c9f10f8"),

Guid.Parse("d88dd8ba-eaf9-42af-827c-05d75809e301"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("091c5035-87b2-4381-ae04-133ab16c4f93"),

Guid.Parse("c13fdbff-6260-42e8-a4d9-1d25ce7bde67"),

Guid.Parse("46a86345-6d97-48da-9d45-ece06005768d"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d8726e38-217d-4df8-9973-a90721f5ba1a"),

Guid.Parse("b14b1a54-fef8-4417-ac11-8e4734fa73a2"),

Guid.Parse("7b0cfcac-35a5-42de-a154-61171c16ae65"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3f17229e-d25b-452f-8dd4-9eec91e868d7"),

Guid.Parse("a4f2d5bc-d9eb-406e-a6c4-6d5d2bfaa4bd"),

Guid.Parse("86acd4e3-a518-4349-b5c5-be93d4a8a9d7"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bdafe2b8-9b15-40a0-b1e5-14fda94edd21"),

Guid.Parse("409d5194-68e2-4de6-a018-4b7d627932b4"),

Guid.Parse("087ac9df-24b3-4d24-95fe-60d731aacd01"),

},
},
            new GuiduuidArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("62d57bd8-b273-4617-9173-a26137aff208"),

Guid.Parse("dc4adf96-cf7f-4f06-9410-bb816f0bbf49"),

Guid.Parse("283f2be3-ca7f-40fe-9b45-0cfc2b2c0a0d"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("637b064c-2696-487c-8e69-c40b86ca28c3"),

Guid.Parse("7fd27c60-08c0-4ed8-ad9c-069f1a5513f8"),

Guid.Parse("f2e5fa89-54ca-4e30-b4ae-62672eedfa05"),

Guid.Parse("c7971a93-8c41-4828-87af-8530687aa761"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7467854c-81bd-4656-821f-879e28931dd3"),

Guid.Parse("6b1ca1a0-9a9d-4405-9905-0ed8ea8a3b23"),

Guid.Parse("90773e1f-654e-40a6-9c53-2ed2c035993b"),

Guid.Parse("a3ea52c0-e764-469e-935e-d4ff452a9961"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a9a66041-52ca-4694-b427-9fca9c9cfd77"),

Guid.Parse("e630910e-7088-4c94-aad5-6eddd6203678"),

Guid.Parse("2f295205-5c5d-46a1-a361-37646d8052b5"),

},
},
            new GuiduuidArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7f91fed0-e1f0-44e0-896d-cc987c4421ee"),

Guid.Parse("af89fd2c-e5a7-43f2-a99c-ff7e4fa56ecc"),

Guid.Parse("49396675-4e63-4544-8d86-041150f079a8"),

Guid.Parse("3b14d081-2f22-4031-99ef-6b57c73bc195"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("114715dc-ae46-443f-80af-9b6f4e7ee697"),

Guid.Parse("ea1dc2d6-82cd-4bac-b9dc-55d4bf341e19"),

Guid.Parse("8837dbb0-e40d-42e8-a014-f3e76d782868"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a0772029-b367-48f6-b931-1ee25fbda51c"),

Guid.Parse("3e052088-9eb6-40ee-9b50-a75dbe7ff08b"),

Guid.Parse("b00e04d7-1aaa-404f-88a4-344334bd8de0"),

Guid.Parse("2c9524d2-68d7-42b5-8dbb-106bb4ee825f"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("090e313d-1c6f-45d6-b1da-b391051da114"),

Guid.Parse("ce308235-2012-499a-be43-2943b687c3ea"),

Guid.Parse("ae9ebf5e-7135-4ad0-827d-bba58cfb0690"),

},
},
            new GuiduuidArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("75a32081-ee73-49a7-97b8-2dbde5a5237a"),

Guid.Parse("8a61ab56-760d-4004-a768-4c85b5f77246"),

Guid.Parse("a375f741-748d-43d9-b9b3-31233e8be2bc"),

Guid.Parse("dc76edde-057b-4b41-9882-48c3c4b49c78"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5ec6236c-13d3-48af-b670-03c3d60da826"),

Guid.Parse("5896809e-f0ae-4976-96a4-9eb665c5b0ee"),

Guid.Parse("d5494a0f-aa3c-4a60-b379-65e9fa24173e"),

Guid.Parse("0af2a447-6bac-4755-b422-e8710a24feb4"),

},
},
            new GuiduuidArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("134847b9-0ee7-4755-b3bf-d029479dbbb3"),

Guid.Parse("d401e4c3-571c-4049-8e20-ec90cd48d92c"),

Guid.Parse("e0ba4ebb-9f8b-4268-96f1-2d58f6e3837b"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7eb200f5-dd4c-4c6a-8e8e-baf3460a5bbd"),

Guid.Parse("b9d9e339-cf13-46a3-b94a-69a72ebcbef0"),

Guid.Parse("5324a6f8-abfb-43fb-a5e0-ab6be3c7b6bb"),

Guid.Parse("d727d6ce-934d-4ad3-bc31-48f33828e9b6"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("6724b07f-57f6-4757-b647-599839e0931c"),

Guid.Parse("85cccdd2-8bb5-422c-8ede-bb0bb75f8c6b"),

Guid.Parse("90aef7a9-5a8e-4d34-9b04-8dd69788c6f0"),

Guid.Parse("5d89a0cb-5791-42e1-af8e-66806350d7e0"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e57919cf-02f6-4b4e-9519-9e1ae2fca2cb"),

Guid.Parse("0850b371-786e-4a55-89c9-1d0e0ea06354"),

Guid.Parse("17a36a25-c44e-40e9-86d8-f8ab11324b24"),

},
},
            new GuiduuidArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4323e907-8199-4c90-a5f7-20474bbac755"),

Guid.Parse("841eabd3-1921-4e4d-82cb-f575c29a19f6"),

Guid.Parse("50b942cd-5dc5-4788-8c2a-855ee37eefe1"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7d562b97-9110-47ea-89f4-3f83b40758a7"),

Guid.Parse("1ec98a9b-17ac-4ae4-837a-b62b0cdf0af9"),

Guid.Parse("75841276-4d63-4a44-bef9-c24fe87504bb"),

Guid.Parse("2667c14c-934c-4216-8d58-fcfc73c957a5"),

},
},
            new GuiduuidArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4138b97e-1338-4ba0-9e98-dc949cce2d82"),

Guid.Parse("294c5b5e-c614-49d8-af95-d7b109ab25ea"),

Guid.Parse("2728f64e-179c-4a48-9460-e30fc6058743"),

Guid.Parse("054badc0-8d36-42a5-bcd3-bd1085590a5f"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ab14a6a2-9ce8-432e-ba09-96c6fcccaf28"),

Guid.Parse("beef6f68-9df8-4ba1-8564-18dbae11e6b3"),

Guid.Parse("51051405-1d9c-417e-9c10-6b30964282f8"),

Guid.Parse("68d94859-da50-4894-8b14-b24e0de95f99"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c2db244d-4650-42a6-b25c-38dd3a3aeeae"),

Guid.Parse("f7dea3d7-044d-46be-adae-b6cb4ea02434"),

Guid.Parse("2eabf3f0-a548-4bb4-96d1-499097cee461"),

Guid.Parse("b2d76343-62cc-48d7-8c00-9b69e3cfba3d"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0b254507-7067-4469-9138-861af6a3ef4d"),

Guid.Parse("90ce21e8-9a5f-4d06-b8a4-e09697ff5cdb"),

Guid.Parse("20ad4868-fa43-4408-9623-b8ab861f7337"),

Guid.Parse("0ff25cbf-b502-4668-b8e0-1a0c542fd571"),

},
},
            new GuiduuidArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9fd15a9c-cd73-4548-9c88-708593db4453"),

Guid.Parse("52f67c7d-7069-48c7-9291-504bcce62b18"),

Guid.Parse("304ed95d-03d9-4f3e-b5e2-af3e78ccdd33"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7485dd73-e234-47e3-8804-dd1ff75f61d0"),

Guid.Parse("a24f8db1-81c1-49a1-ab5e-d98b9a6895f9"),

Guid.Parse("64bffc9c-e046-407f-bfe8-19f15c841908"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1834fa56-660b-4c1e-8aa3-9d0f45c4e354"),

Guid.Parse("294d127d-459b-42bb-bb90-552069102799"),

Guid.Parse("fa4c701b-0b1c-423c-a83e-9f72f7840947"),

Guid.Parse("de37f4bc-7737-425d-a60f-ab9d35187120"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e3a92d1-2c7e-49b5-a579-561e702f5ae1"),

Guid.Parse("debcfd8b-3839-4254-a475-f9fe290f8164"),

Guid.Parse("b379b107-4437-4e2b-83b1-f2bb26041b9e"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c9f6a3ef-dfc4-43d9-a391-5f267e30fff7"),

Guid.Parse("7b48697a-a233-469e-a16b-218737fe200e"),

Guid.Parse("7b9c8d0c-e44f-4fb6-bab0-d3f24b13dfaa"),

Guid.Parse("5b3fcd30-284c-4e0b-ad78-02d989db3ce7"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b133686e-d489-409c-828f-e92e036ede5b"),

Guid.Parse("db492712-222a-448a-898a-57a7136de2b3"),

Guid.Parse("16f8b6e5-bae3-4a36-bab7-d8c18f45ca35"),

Guid.Parse("b65b2626-e52d-42ce-b2f3-cd2458070c32"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("d8aaef7a-3142-499e-8b2e-3b310221b3af"),

Guid.Parse("6d075f95-a230-485f-8cf9-eea5473d9aee"),

Guid.Parse("dae0cca8-acf9-491b-a501-1b49a89f0cb7"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f0614c21-8b9b-4f34-85fa-0f64e6a79541"),

Guid.Parse("90c4e1b4-b88f-4a3e-bed3-bb11d521f54f"),

Guid.Parse("d3d7061e-85ae-46c0-b443-e69475bf765e"),

Guid.Parse("fb6c5849-54f8-4f27-b3ff-d27c04b9390e"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bbe12e26-9be9-44a7-9965-3c374b475975"),

Guid.Parse("52f9a60e-3cd3-4aa3-ba9f-20975042603f"),

Guid.Parse("cabf4145-8444-42e5-9fa8-00516e0b32e9"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f07b6159-990a-4e26-8231-3fce39e72a45"),

Guid.Parse("fbfb11b6-752a-4e20-a4f5-0377c5d6c211"),

Guid.Parse("801c44ec-d0dd-4b6d-8ff7-796506d24de7"),

},
},
            new GuiduuidArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("17780489-f100-4163-88b8-223622ec5d21"),

Guid.Parse("a109926d-2739-45db-96c8-d7824049f987"),

Guid.Parse("c009875b-3319-4aa7-8949-9da89d7de63d"),

Guid.Parse("1cd721e8-0631-48f9-a219-70243be1d757"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("824b6b9c-039e-482c-84ba-b85030fd1684"),

Guid.Parse("afb5f409-1169-4321-9a72-411c04517522"),

Guid.Parse("b18689ed-4550-412d-af7f-02d24d5ea578"),

Guid.Parse("835b357a-d945-4d0c-be76-b56b03d64fa2"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("8976c726-47c6-4833-a24a-70eeac9fb539"),

Guid.Parse("2647dbcb-7fbb-4645-b2ba-def6cc8a03c3"),

Guid.Parse("eae0d4c7-d111-4e22-afe6-be874dc82232"),

Guid.Parse("65f2c898-664a-4308-a46c-05862f3929aa"),

},
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5401b378-691d-426f-ba89-85bf224e244f"),

Guid.Parse("307780e6-ce20-4414-adeb-dc227fda9086"),

Guid.Parse("ef210a63-5a21-42b7-9196-74de9b504dbc"),

Guid.Parse("10188665-c20d-4201-ac07-e8ab8289c9e8"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1d0c38e5-f2cf-4881-b46a-9e8ae04efcc1"),

Guid.Parse("c6eb16d1-6512-4521-9f36-3ad579e23d3f"),

Guid.Parse("35603020-72e4-4ea5-b733-752f356a5831"),

Guid.Parse("1009ffb7-a997-4f79-81d3-c0ca1baf56c1"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("651122cd-4bc5-4fb9-87c7-7171da6e07db"),

Guid.Parse("f5b6ffa2-bb34-486b-90d9-dbc06b54df84"),

Guid.Parse("14364e95-aa0f-4366-91b0-789d122b46d9"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7df85c96-0aa1-44cb-ba02-7367ccf21673"),

Guid.Parse("c38e72c9-bef6-4a36-bb18-a7622285718d"),

Guid.Parse("d341d2cc-ef4f-4bb7-96c5-0396bb606509"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a8a543ab-8c3e-46cb-8cb7-9a0cca4f74d7"),

Guid.Parse("dbf2ef91-bfcd-4f2a-a446-e4abf508125b"),

Guid.Parse("ce037130-0523-4da2-9cb6-333a9c12c5ea"),

},
},
            new GuiduuidArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("03419e02-c99f-4bc7-96cb-4e043afdb0d7"),

Guid.Parse("819eb4ac-f5fb-45c4-a202-e6c2231688f5"),

Guid.Parse("4818f03a-c7fc-499d-aeac-1204536d6daa"),

Guid.Parse("5990e70e-d1a7-4b54-8bfa-27df2fe6be26"),

},
    ModelInner = new GuiduuidArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("69e3cef5-8f1a-4ecd-ab0b-94bdb1a381db"),

Guid.Parse("fe2f948b-0b6c-4caa-9fe7-f3f2f4d3eda7"),

Guid.Parse("6ba26763-cdca-4dc0-888e-5f6d36385620"),

Guid.Parse("32dd2286-8e7d-4971-8619-6b07389ee74c"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f19c5838-42df-4c40-8807-8aa0e4b93c8b"),

Guid.Parse("006b80ac-18d6-43e5-84bf-18333094a77d"),

Guid.Parse("8fd3f7cc-928a-4bf8-a862-5fd6654597c2"),

Guid.Parse("d478fdab-a1b4-492e-ac31-2d8a74e2c1d3"),

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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
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
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
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
                parametr1.Value = 9;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        GuiduuidArray2M.AssertModel(models[0],_testData[1], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[2], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[3], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[4], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[5], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[6], false);
                        GuiduuidArray2M.AssertModel(models[6],_testData[7], false);
                        GuiduuidArray2M.AssertModel(models[7],_testData[8], false);
                        GuiduuidArray2M.AssertModel(models[8],_testData[9], false);
                        GuiduuidArray2M.AssertModel(models[9],_testData[10], false);
                        GuiduuidArray2M.AssertModel(models[10],_testData[11], false);
                        GuiduuidArray2M.AssertModel(models[11],_testData[12], false);
                        GuiduuidArray2M.AssertModel(models[12],_testData[13], false);
                        GuiduuidArray2M.AssertModel(models[13],_testData[14], false);
                        GuiduuidArray2M.AssertModel(models[14],_testData[15], false);
                        GuiduuidArray2M.AssertModel(models[15],_testData[16], false);
                        GuiduuidArray2M.AssertModel(models[16],_testData[17], false);
                        GuiduuidArray2M.AssertModel(models[17],_testData[18], false);
                        GuiduuidArray2M.AssertModel(models[18],_testData[19], false);
                        GuiduuidArray2M.AssertModel(models[19],_testData[20], false);
                        GuiduuidArray2M.AssertModel(models[20],_testData[21], false);
                        GuiduuidArray2M.AssertModel(models[21],_testData[22], false);
                        GuiduuidArray2M.AssertModel(models[22],_testData[23], false);
                        GuiduuidArray2M.AssertModel(models[23],_testData[24], false);
                        GuiduuidArray2M.AssertModel(models[24],_testData[25], false);
                        GuiduuidArray2M.AssertModel(models[25],_testData[26], false);
                        GuiduuidArray2M.AssertModel(models[26],_testData[27], false);
                        GuiduuidArray2M.AssertModel(models[27],_testData[28], false);
                        GuiduuidArray2M.AssertModel(models[28],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[29],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[30],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[31],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[32],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                parametr1.Value = 153;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        GuiduuidArray2M.AssertModel(models[0],_testData[29], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 127, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
                await ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 35, query1, 50, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 169, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 81, query1, 84, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 71, query1, 64, query2))
                {
                    if(++resultIndex == 1)
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
                await ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 127, query1, 16, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 147, query1, 90, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidArray2M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidArray2M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidArray2M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidArray2M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidArray2M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(models[18],_testData[34], false);
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
                 ((IGuidListuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 134, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuiduuidArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 26, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
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
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((IGuidListuuidArray)this).DbConnectionSTSelectModelBatch(connection, 18, 158))
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        GuiduuidArray2M.AssertModel(models[0],_testData[30], false);
                        GuiduuidArray2M.AssertModel(models[1],_testData[31], false);
                        GuiduuidArray2M.AssertModel(models[2],_testData[32], false);
                        GuiduuidArray2M.AssertModel(models[3],_testData[33], false);
                        GuiduuidArray2M.AssertModel(models[4],_testData[34], false);
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
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 164);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                GuiduuidArray2M.AssertModel(models[0],_testData[32], false);
                GuiduuidArray2M.AssertModel(models[1],_testData[33], false);
                GuiduuidArray2M.AssertModel(models[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

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


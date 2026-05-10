

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
    internal partial interface IGuidArrayuuidArray
    {
    }
    
    internal partial class GuidArrayuuidArray : IGuidArrayuuidArray
    {


#region TestData

        private readonly GuiduuidArray1M[] _testData = new GuiduuidArray1M[]
        {
            new GuiduuidArray1M
{
    Id = 8,
    Value = 
new System.Guid[3]
{
Guid.Parse("4562a26c-cd90-4ae6-8374-b6ff0898cda6"),
Guid.Parse("34f43faf-91f1-489f-87b2-c0fd875d98dd"),
Guid.Parse("5fde1c1c-c557-4947-9684-710bbc2866d8"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 14,
    Value = 
new System.Guid[4]
{
Guid.Parse("212d28f6-9171-495b-ab00-e32025fdd8fe"),
Guid.Parse("1956ca3e-7879-4c64-8549-9b217bad0250"),
Guid.Parse("b3adefa9-1cc8-479c-9e63-7d39598db708"),
Guid.Parse("39929795-5f67-41e4-8159-0877aedb4670"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 4,
    Value = 
new System.Guid[4]
{
Guid.Parse("8a8b276f-c496-45f3-86a6-81ff423b1c15"),
Guid.Parse("1062b12c-a32f-41b2-84b1-7ec053143744"),
Guid.Parse("c294585d-d871-4382-97c4-5721cb9ac857"),
Guid.Parse("e59ac2c1-e964-4b6e-8d55-acdae479b7b7"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("b4e2bb85-b796-4413-b809-7020559fe857"),
Guid.Parse("6e39a496-dd5a-416a-a44b-384d3696f11a"),
Guid.Parse("c19f6080-b26b-4958-9509-0311ed60b0e0"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0ba55450-7e36-47d3-b00f-de3e7c5ad099"),
Guid.Parse("2cbf0a6b-04ce-4205-ae30-a0645f292681"),
Guid.Parse("91f32ec8-453b-4c18-9c79-9543d06ed1f1"),
Guid.Parse("3dfeb947-1a22-463b-b010-943c35a66d30"),
},
},
            new GuiduuidArray1M
{
    Id = 15,
    Value = 
new System.Guid[3]
{
Guid.Parse("77d27806-4463-4f61-a69a-880c8d8a6786"),
Guid.Parse("73ea9910-2a3f-4d19-aa29-2efc2cb344ab"),
Guid.Parse("a2149eaa-d69b-4eba-9706-73f1d3c38d57"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 23,
    Value = 
new System.Guid[4]
{
Guid.Parse("4f4e2cfb-0abd-4aa6-8f4b-1ee188ea7c81"),
Guid.Parse("e29ae6d1-cea8-4d59-b4f2-214c17fa7f94"),
Guid.Parse("ffa98091-30fb-4c7e-a6e3-5b51023b29c6"),
Guid.Parse("333b75ea-8967-496c-b762-e521738a2a71"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 13,
    Value = 
new System.Guid[3]
{
Guid.Parse("9c108446-2ba2-4038-9fa8-569ec7ce049b"),
Guid.Parse("7d30fa07-b511-4505-bfe4-d1b067ccab26"),
Guid.Parse("f8cc59b1-b054-47c6-81aa-5bf42a1d741c"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0100122e-fed8-48dc-8016-cbefb9f82a9f"),
Guid.Parse("86f32b74-0d0c-43b8-a5af-03096e89f19e"),
Guid.Parse("56083355-9d20-4c4c-9605-f5f3bcbdd7b9"),
Guid.Parse("537b52c5-2fce-4e91-8e21-0f9799c0a81b"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("15ca9157-a0d0-4815-b68c-fe1a397192f0"),
Guid.Parse("e6916613-df4c-457e-ab0d-c2c899a544f9"),
Guid.Parse("c4699ba8-16b4-469d-9c54-93b16f6701d3"),
},
},
            new GuiduuidArray1M
{
    Id = 30,
    Value = 
new System.Guid[3]
{
Guid.Parse("6ebc6f61-825e-4f36-b687-471c7b60b76c"),
Guid.Parse("567b7eb3-bb50-458b-82f0-30f03d31ea71"),
Guid.Parse("d0b0ae8d-17bd-44e2-a46d-0c12c27da653"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ea61b3f5-17a7-4016-a9c4-91a0fc1bcbac"),
Guid.Parse("734c95a8-94c5-4dfe-be8c-7ecdb9d60fd3"),
Guid.Parse("f9422c12-caef-43c5-9b8c-7bb0ca934871"),
Guid.Parse("4a51b356-65bc-4c1b-91e8-03600177d6dc"),
},
},
            new GuiduuidArray1M
{
    Id = 33,
    Value = 
new System.Guid[4]
{
Guid.Parse("0236178d-b2e3-4a78-a0f6-84994ca0ec59"),
Guid.Parse("0343a993-b7b9-4d99-8bd4-6ad320bb4b51"),
Guid.Parse("d3f4197f-3b70-4cac-8839-768426a55855"),
Guid.Parse("3cb502c6-0fda-484e-88a3-55677d2865f3"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 20,
    Value = 
new System.Guid[3]
{
Guid.Parse("80273471-ae8f-406c-af9e-c7b767171667"),
Guid.Parse("c97c5c41-ef77-411e-ae6c-9a4641ffe908"),
Guid.Parse("91d6f709-b26b-4714-a17a-0900a994a6b7"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9917caa2-7b74-479b-bcc7-ac3e5a06b945"),
Guid.Parse("353d7573-2cc7-45cb-9937-7cbcb6c67e97"),
Guid.Parse("217731ff-7c28-41e0-bc57-1ba2f6ed7c12"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ae1e5772-38e2-4606-bb2f-70eec76d7069"),
Guid.Parse("c662b852-2db0-421d-949c-f91575d2469b"),
Guid.Parse("a33d6bcc-7ea0-4077-9146-c36a8ab25ee4"),
},
},
            new GuiduuidArray1M
{
    Id = 34,
    Value = 
new System.Guid[4]
{
Guid.Parse("6d32a713-4c22-4008-b08e-13ade3b130d3"),
Guid.Parse("a88f0f25-5bd5-421a-9df2-583a66863277"),
Guid.Parse("31c2d68d-25e8-4c24-91b3-0239c6c319df"),
Guid.Parse("6ee885c3-4568-4d95-be99-599f8c6b7004"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 36,
    Value = 
new System.Guid[4]
{
Guid.Parse("0ab5b806-b721-4a4f-ba20-2ee1a6ece430"),
Guid.Parse("68678950-156d-4f7f-9fcd-ee7a943ab487"),
Guid.Parse("f8eaf7da-0e3b-4f02-8606-ad6b1e84fe37"),
Guid.Parse("20e3fc83-9b91-4696-9d42-82eba6030bd8"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 28,
    Value = 
new System.Guid[4]
{
Guid.Parse("13ef00b7-09f7-4d03-87f1-259856ea73fa"),
Guid.Parse("8917f7ff-eb9a-461e-9de9-5ffe99527bf8"),
Guid.Parse("646b94cb-c598-423f-ad91-b21d4a9ab7ba"),
Guid.Parse("185be4bf-3a07-4ad0-9d09-76b1d693ff59"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d66ab587-b48f-4f1b-a1b1-6eb516d9f65e"),
Guid.Parse("41be280b-34ff-48c3-a152-2a7524e4b92a"),
Guid.Parse("d9902c28-7371-4689-99de-37db7d212f59"),
Guid.Parse("829a092b-1187-4525-916f-2779296fa118"),
},
},
            new GuiduuidArray1M
{
    Id = 41,
    Value = 
new System.Guid[3]
{
Guid.Parse("cf151bfe-bc49-4971-9824-924f452fd6ee"),
Guid.Parse("f289e2f6-1ca1-43bd-ae20-9c4f96aacb74"),
Guid.Parse("38087137-bb71-417e-a7f3-0940d67010a0"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 48,
    Value = 
new System.Guid[4]
{
Guid.Parse("9fac72f3-c1da-44c6-bce2-77a7f4c9b1f6"),
Guid.Parse("54a1e52f-96b2-4d84-b9d4-f14769b1fd8a"),
Guid.Parse("53a1a343-ae13-48d1-a4c3-dba65e4ec370"),
Guid.Parse("d995e254-ce7a-4b2a-9c8d-ee143c49b00b"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 35,
    Value = 
new System.Guid[4]
{
Guid.Parse("a885c43a-ad87-4ceb-93f5-5a03908e4710"),
Guid.Parse("2443788d-bc56-4bbc-9264-c589ab2c8f4c"),
Guid.Parse("780feaba-00fd-481b-92fd-beaf070a957d"),
Guid.Parse("6256fea7-758e-4753-bf8c-17f19fb3f612"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 56,
    Value = 
new System.Guid[3]
{
Guid.Parse("0765706f-641d-4d5c-a837-aa5289114b4f"),
Guid.Parse("b8542a93-17e5-4ea3-be7e-543633b64051"),
Guid.Parse("0b5a3573-b737-42d5-baa5-b8714a465d46"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 57,
    Value = 
new System.Guid[3]
{
Guid.Parse("4f4e8b2e-2835-42b7-a937-633ae747e1e8"),
Guid.Parse("35e6caca-043f-41f3-92c2-0b69ef32621b"),
Guid.Parse("94da437e-31d1-44f2-9997-633371afecf2"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 43,
    Value = 
new System.Guid[4]
{
Guid.Parse("805bf5ae-d662-469a-8681-dc5311bab2e4"),
Guid.Parse("8ba1809f-cef5-498a-9473-1d614d48b1b1"),
Guid.Parse("ecbda51b-06f0-4de1-99ee-52b174f54c36"),
Guid.Parse("bd472abd-3b8c-4426-a462-7a049991f692"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 63,
    Value = 
new System.Guid[3]
{
Guid.Parse("6ad56530-c929-4437-a47e-525347a3d75e"),
Guid.Parse("ffd456e5-5f76-40f2-b5e5-0570eab7618a"),
Guid.Parse("cca7d738-3ba3-4b92-8926-ffa43f887ed9"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ca2c4e4d-90e8-406f-8ca0-1ee9e61f0baa"),
Guid.Parse("cb3dd5de-f828-438a-b318-c9373bb935e5"),
Guid.Parse("908b69b8-fcbc-4674-abda-3f6c36c94939"),
},
},
            new GuiduuidArray1M
{
    Id = 68,
    Value = 
new System.Guid[4]
{
Guid.Parse("42b20985-d705-4c21-880e-6833d0320549"),
Guid.Parse("b377cc3a-bfbe-42f0-a003-ce935fe70d01"),
Guid.Parse("174a9fd1-673f-496d-92c9-cd3b21889d90"),
Guid.Parse("0396b255-9755-47a4-a7f4-6bd31a305549"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 49,
    Value = 
new System.Guid[4]
{
Guid.Parse("3c1d3adb-621f-4885-9e21-e78d952b75a8"),
Guid.Parse("8d9ab589-665f-4367-80d7-f0f0901d9fd6"),
Guid.Parse("fc106030-bf60-4b18-a1a8-b5ee8c9e78e4"),
Guid.Parse("7cf3fa90-83ac-47cb-819e-0610c036420f"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("6bc06b8e-76e0-423d-acce-dccfdded8ef1"),
Guid.Parse("07bb1eab-9655-48bb-83ef-27a73f82e6fa"),
Guid.Parse("e7f86ed4-e1f8-442e-9c3a-48d1c9f401c1"),
Guid.Parse("1df7a1ac-d9ca-4adc-97ff-7a65fb355868"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 75,
    Value = 
new System.Guid[3]
{
Guid.Parse("9fb5d9b1-2106-4b12-a0f7-ca18e2885414"),
Guid.Parse("3fae03f2-71fd-4319-b8ca-f1cbf7ff9b72"),
Guid.Parse("7e1c7cf6-a4ef-4bbf-870c-e35f83033323"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 56,
    Value = 
new System.Guid[4]
{
Guid.Parse("b5398e3b-2813-415d-a64e-ed176a2e128a"),
Guid.Parse("34ec748a-0057-496d-ace7-f9331ae0c6ef"),
Guid.Parse("dfab12b1-e58b-46dc-9a28-2fc6b3864c71"),
Guid.Parse("7017c5bb-6244-45e7-9c48-d01be5ff05a0"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("d3e48fa6-b5f0-46a8-9e7b-3ee9938b8517"),
Guid.Parse("6070e26f-e19c-4909-b13a-86647418b1cd"),
Guid.Parse("dde25131-0898-4500-b755-a7b12cdefcfe"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("141e9980-a028-4025-8999-e5334a987101"),
Guid.Parse("32818579-9b00-43ed-8fe1-364fd0678ce5"),
Guid.Parse("286441b2-bf95-47a7-9ad1-477846994254"),
},
},
            new GuiduuidArray1M
{
    Id = 78,
    Value = 
new System.Guid[4]
{
Guid.Parse("c3ec3f13-8f85-4317-ade3-59c2009f2799"),
Guid.Parse("078c3cfa-5232-4649-a35f-033d06d6721f"),
Guid.Parse("00fb57d9-0009-4ab0-afd8-d4d2ff12acd4"),
Guid.Parse("4e725799-ecec-4f07-9e98-79028259ec2d"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 85,
    Value = 
new System.Guid[4]
{
Guid.Parse("08678424-6b36-46e9-bdb8-36cdbd59d6fb"),
Guid.Parse("a3dd3459-9d23-4c0b-b929-fc0d3f301ebe"),
Guid.Parse("171a10a2-1e27-485d-af15-7a627e15f1a0"),
Guid.Parse("6ed08497-211a-4e03-ac5b-e69275a5f76c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 65,
    Value = 
new System.Guid[4]
{
Guid.Parse("3ab1a805-e93c-44e3-8d98-4ef05f01dd20"),
Guid.Parse("fade9621-d952-4e51-814e-9800edaec637"),
Guid.Parse("d864813e-da74-4581-bc84-532965602bd2"),
Guid.Parse("d6c7ff71-0e71-4f35-b2e7-276f703924a9"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("34734035-7bb1-4a07-9b17-22af337f9092"),
Guid.Parse("d28c4da2-6a24-49d9-bf6a-ea4a21e32514"),
Guid.Parse("a05e42af-fa1c-4573-a354-da208fbab146"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b84bc077-cf64-40cc-a51c-5b3e23a221d9"),
Guid.Parse("3ab5fe50-cfdc-4f8b-b435-c87f26fb189a"),
Guid.Parse("e072b54b-4541-4cda-baf9-a79375285bc8"),
Guid.Parse("503cabe0-053a-429c-8510-5effaa6feae6"),
},
},
            new GuiduuidArray1M
{
    Id = 90,
    Value = 
new System.Guid[4]
{
Guid.Parse("c6cb2a8c-17a5-4027-8dea-94fa859bdce5"),
Guid.Parse("52150397-102d-4a2f-a464-f387c7c3cf69"),
Guid.Parse("a4190f70-fe25-428d-8009-7dc888f0da91"),
Guid.Parse("bd52b333-5c56-4c25-aea6-c2a5b61f59fc"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6c5fcd65-6a36-46c2-89aa-90b65449d59b"),
Guid.Parse("f737f437-ccde-4c23-bdef-0fae9b915037"),
Guid.Parse("81508ea6-7d6d-4623-82e1-27b658689bf7"),
},
},
            new GuiduuidArray1M
{
    Id = 93,
    Value = 
new System.Guid[4]
{
Guid.Parse("29001c79-b6b4-4dd0-ad43-30ca267e2fc8"),
Guid.Parse("1975c49b-a15e-416b-b2e7-a4e0d6687c9a"),
Guid.Parse("ae7aa169-731c-41d6-8b96-103ce3cd975b"),
Guid.Parse("257b31be-0038-4890-ab47-b7226520905c"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 73,
    Value = 
new System.Guid[3]
{
Guid.Parse("8f2bd3c6-a584-4826-a3fe-8f2aea2bb0fe"),
Guid.Parse("b3fcbf4f-0fdf-491b-8b1c-c8d412ef7c9c"),
Guid.Parse("33ccabec-f46d-4300-8c1d-b9e5ce9eec9e"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6a4cf2e7-f74d-4856-9e5b-eebd704b94dc"),
Guid.Parse("3e4ffd38-5dc0-4bb3-82ca-9c30cf264fe2"),
Guid.Parse("89c2459b-bd14-49a9-a463-e6ab26a6a218"),
},
},
            new GuiduuidArray1M
{
    Id = 96,
    Value = 
new System.Guid[4]
{
Guid.Parse("61dfe7bb-f792-4849-aeb2-b95621bcda1f"),
Guid.Parse("c9947347-c1db-4bd9-b740-bdd4f78d48c3"),
Guid.Parse("ebee4041-1da1-41df-b6e2-9bbca6d8016d"),
Guid.Parse("e0d34163-40a8-47f2-b762-6c2202a3cc67"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("24f220ee-8773-4e7b-9c6b-be340a211365"),
Guid.Parse("83cb740d-1c75-4c58-b81c-511d02cbf8e3"),
Guid.Parse("39711926-6a5f-4c7a-8964-e706e18ed2d7"),
},
},
            new GuiduuidArray1M
{
    Id = 97,
    Value = 
new System.Guid[4]
{
Guid.Parse("2341985a-0228-4e58-a5ff-8164498178d5"),
Guid.Parse("028f4125-119e-4d3f-96e6-b46ea1a0e2b4"),
Guid.Parse("36ab4bcd-ebdb-4772-8183-3dcf41e0a3b2"),
Guid.Parse("1415fa62-8276-485c-8e20-9e4e1b979cae"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 82,
    Value = 
new System.Guid[4]
{
Guid.Parse("ea9c4a06-1012-4d2b-b99b-0ae6948390ff"),
Guid.Parse("569b02f2-5063-49e5-b9e6-af7bece79d64"),
Guid.Parse("7611106c-0393-4178-b0a7-75c5a78da957"),
Guid.Parse("a7548834-3021-497c-98bf-53299e39b05a"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 99,
    Value = 
new System.Guid[3]
{
Guid.Parse("7ba56d5a-753d-4a02-a52f-8ff2a7aeb5c5"),
Guid.Parse("33169dec-dcb0-4cab-be3e-f1d25f6cedec"),
Guid.Parse("d7ba464a-97b0-4435-9965-c8d4c294f0cd"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("0fb642e3-238c-4326-911b-e10901a814bd"),
Guid.Parse("ff80c218-07b0-48ee-98c1-a0a1b32e97f7"),
Guid.Parse("2f21de00-d78c-4f8f-a364-a90014d20ba8"),
Guid.Parse("e7feb73f-fa9d-4367-be50-f444be291e83"),
},
},
            new GuiduuidArray1M
{
    Id = 104,
    Value = 
new System.Guid[4]
{
Guid.Parse("1698a061-bc39-473d-b06c-d220b9a59e3a"),
Guid.Parse("7109c687-5624-4659-8447-afdf7aabe3d3"),
Guid.Parse("601cf76d-31f6-443a-8a73-d89711a834a8"),
Guid.Parse("abc65135-aaa8-4c34-934a-834a28399ace"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 84,
    Value = 
new System.Guid[3]
{
Guid.Parse("a73f47f5-7446-4416-9c05-0b398fad4c60"),
Guid.Parse("eb733891-7f9d-4e64-9775-bd3e90ffb846"),
Guid.Parse("318474b3-3de5-40eb-97d3-a08b47791d16"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("8daca482-4868-43de-92e5-e59204adcc17"),
Guid.Parse("7765ba07-0c53-4091-8ac5-8f32f8f26796"),
Guid.Parse("1a01efa6-493a-41e2-9131-7c5da49f8bd0"),
Guid.Parse("26fe1c03-e5ee-45ad-9bf1-ca4436d51a02"),
},
},
            new GuiduuidArray1M
{
    Id = 105,
    Value = 
new System.Guid[3]
{
Guid.Parse("18b30831-e43e-49ce-a1fd-a22990ec7212"),
Guid.Parse("f3590c8d-35ed-470b-b023-406d13af830f"),
Guid.Parse("8fc9930d-07e6-4c06-bf25-5f2fd8fd4331"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f0393652-acb7-41b0-82ca-e5a34fd858bb"),
Guid.Parse("5b6d839b-4da1-4d17-9d46-f7f456e88da1"),
Guid.Parse("e328d7e6-0003-4ea4-b9bf-3a70897830ff"),
},
},
            new GuiduuidArray1M
{
    Id = 111,
    Value = 
new System.Guid[3]
{
Guid.Parse("c1391c78-132d-4e7c-a620-471bd8ac7d4e"),
Guid.Parse("85201057-70ae-448e-85a1-cab0a7cfdc2e"),
Guid.Parse("b4ea030b-5176-49d2-9305-29fd8889f795"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 89,
    Value = 
new System.Guid[4]
{
Guid.Parse("9bd6a841-60e7-423c-b080-a713024c65e4"),
Guid.Parse("7eb1aab0-074c-4d08-8320-8d1d0a4a8c0b"),
Guid.Parse("a64b95b9-21d7-4c12-9e5a-5a03730f8b58"),
Guid.Parse("589a7af1-5c88-49d6-8e19-4bd136198ed5"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("9fecc726-a39d-4915-bf1c-602abcf197d3"),
Guid.Parse("dd876972-e641-4805-aca2-0989b03a0e6a"),
Guid.Parse("1ac8c27d-d67b-4e89-bc1f-5281b6d52c1e"),
Guid.Parse("b4c661b7-b391-4db6-a884-41ea9ac4b79a"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 117,
    Value = 
new System.Guid[4]
{
Guid.Parse("5bd71d87-a825-4c5d-8146-285a156ba18e"),
Guid.Parse("19c58f83-bcea-4c15-ba2b-4979287c7f15"),
Guid.Parse("d0cfdf83-eb84-4928-b2ee-55c3c4dcec08"),
Guid.Parse("0adbded3-3cd9-4e3f-99cb-17542a2a9338"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a534e6c0-a53f-404b-b1fe-646b4165cd5c"),
Guid.Parse("ea27bb82-b642-427e-9d2e-c339c5c0a530"),
Guid.Parse("67a18271-fabb-4e20-82d2-742d7d8819b9"),
Guid.Parse("da38895f-1d9b-45ff-a15f-f2ee3d94b333"),
},
},
            new GuiduuidArray1M
{
    Id = 121,
    Value = 
new System.Guid[4]
{
Guid.Parse("94a25f86-6a97-4472-bcfd-e0c2831e4668"),
Guid.Parse("639565e5-cffa-4289-9910-6a1b99f931c5"),
Guid.Parse("68238ee8-8287-4937-be41-3e450646bab8"),
Guid.Parse("815c918e-348f-4bc7-a149-c38e2e14650f"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 93,
    Value = 
new System.Guid[4]
{
Guid.Parse("5f05657b-5624-4658-a729-d467b4f460d3"),
Guid.Parse("6d07a1f4-4d4a-47e3-882c-a6286d4f527f"),
Guid.Parse("7eea2c02-dc30-4084-bef2-77e26325daaa"),
Guid.Parse("55021ddb-1022-404d-8e4f-57c62617b9a5"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("bab0042b-4088-4c14-9163-a196f0eda87f"),
Guid.Parse("4fe922ac-90bd-484d-aa37-00e5fcf49f26"),
Guid.Parse("bec5543e-f808-4d6a-9f05-9c2ba3a2f1a5"),
Guid.Parse("4d148051-42c4-4faf-893f-21988759b069"),
},
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("269572f8-9094-44c6-8182-8bffd4bd0dd7"),
Guid.Parse("c1a74361-41b0-4a9e-9619-9c8692fa6257"),
Guid.Parse("47658a1c-b493-485f-821e-fe9c784bdf46"),
Guid.Parse("92384974-4857-420a-9ee8-c01c14b36488"),
},
},
            new GuiduuidArray1M
{
    Id = 128,
    Value = 
new System.Guid[4]
{
Guid.Parse("ec38f9f7-267b-4f29-b149-9ad5a61cdff2"),
Guid.Parse("ff5060e1-f528-4546-9f93-357d526cd737"),
Guid.Parse("833d0320-ca27-4778-b69c-8bc1c8ae2870"),
Guid.Parse("389a5f5d-6e17-45bb-9edb-9504386f250e"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 130,
    Value = 
new System.Guid[3]
{
Guid.Parse("238c761d-17a7-4fbe-a70d-1305afc8cafd"),
Guid.Parse("6bb17a18-e2ce-44b1-b6b2-3b00753eba74"),
Guid.Parse("a6005769-abc0-45ea-8bb4-cb418689f6cd"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 99,
    Value = 
new System.Guid[4]
{
Guid.Parse("b3592cd2-4586-46f7-8714-81bc2daac9d0"),
Guid.Parse("af069763-23db-458c-89b6-5b9b6b13bf55"),
Guid.Parse("0106762b-fcdf-45a0-96bf-0941af275380"),
Guid.Parse("e164f81b-1d03-4786-a532-3149dba5c7b2"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f04fc17f-51f0-4cfb-89f0-d2a8d38bc087"),
Guid.Parse("6be654c8-fcc9-4653-8029-d6487993c450"),
Guid.Parse("fb4a9bc3-ac02-4948-b346-b5c3940cec60"),
Guid.Parse("0d892866-a932-4e8d-b33c-782f4a51f088"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 132,
    Value = 
new System.Guid[3]
{
Guid.Parse("620dccdd-2f71-4b85-badf-e6b53c76156e"),
Guid.Parse("88ee0824-5050-470c-acc3-d4ac5ff1e3d5"),
Guid.Parse("6847d3f9-50d3-4540-a113-a20f7f642d70"),
},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 141,
    Value = 
new System.Guid[3]
{
Guid.Parse("bdde55b0-549a-4807-81d7-738972ccd5db"),
Guid.Parse("a34642b8-a1ed-4aa9-bece-a1abe1f57ca7"),
Guid.Parse("3607a468-5b75-449e-9f4f-7ad97d0d4790"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 102,
    Value = 
new System.Guid[3]
{
Guid.Parse("d22fb2bc-048f-4546-88ff-782e68d12bef"),
Guid.Parse("02b903d0-9f9c-44b8-885e-63ebd891c6f1"),
Guid.Parse("7b0153e9-49b8-4f87-af0f-b99fb545bfe9"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 143,
    Value = 
new System.Guid[3]
{
Guid.Parse("cd2ac939-f6a2-4cac-a67f-a5f08beeba1f"),
Guid.Parse("f1da90c8-e76b-4a8c-ba92-6ba06e5f3185"),
Guid.Parse("92b8b3ca-64b5-4210-8a5b-62b8a74980b2"),
},
    ModelInner = null,
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("1dd64240-9ec5-49cb-9b7f-18c48d431b5f"),
Guid.Parse("4f1e63c5-cd41-4354-942a-473d319bd16f"),
Guid.Parse("556f695f-7fe8-4bf2-89a4-5cebe52778fd"),
},
},
            new GuiduuidArray1M
{
    Id = 152,
    Value = 
new System.Guid[3]
{
Guid.Parse("bceca74a-7f86-4b23-8187-2d888f974790"),
Guid.Parse("817e5434-9400-4dae-b3cd-09778d964679"),
Guid.Parse("019d92c0-363f-4c0a-a62a-3c3eed44a951"),
},
    ModelInner = new GuiduuidArray1MI
{
    Id = 106,
    Value = 
new System.Guid[3]
{
Guid.Parse("93b114f0-0c2c-4448-bf97-c6f72ce0c234"),
Guid.Parse("3d4cf68c-a01f-41dc-a162-dd9c6a0a66b4"),
Guid.Parse("51dbeadc-c3be-4332-8d5c-7d96d95f0d2e"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2d3c1410-040b-48d1-a978-0505b7dd31d1"),
Guid.Parse("6c1ec497-fa25-4bd5-9c63-9045200ca7f7"),
Guid.Parse("0b817a42-bd75-4bd4-b92b-9c9af466c7fc"),
},
},
    NullableValue = null,
},
            new GuiduuidArray1M
{
    Id = 154,
    Value = 
new System.Guid[4]
{
Guid.Parse("330273d7-85da-40b8-a92c-1031a8d788f4"),
Guid.Parse("6a3aed37-b844-4245-9492-4084d4435a52"),
Guid.Parse("46b0f689-8f15-4724-94fa-944b5b65d8bd"),
Guid.Parse("865b3127-7aff-47e5-bb48-c44d91152331"),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1mi(
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
INSERT INTO public.guiduuidarray1mi(
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
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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

                changedRows =  ((IGuidArrayuuidArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidArrayuuidArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidArrayuuidArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidArrayuuidArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidArrayuuidArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidArrayuuidArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
            asPartInterface: typeof(IGuidArrayuuidArray)), 
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
                methodParametrName: "guiduuidarray1mi_id", 
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
                changedRows =  ((IGuidArrayuuidArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidArrayuuidArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidArrayuuidArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidArrayuuidArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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

                    nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("ea61b3f5-17a7-4016-a9c4-91a0fc1bcbac"),
Guid.Parse("734c95a8-94c5-4dfe-be8c-7ecdb9d60fd3"),
Guid.Parse("f9422c12-caef-43c5-9b8c-7bb0ca934871"),
Guid.Parse("4a51b356-65bc-4c1b-91e8-03600177d6dc"),
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

                    nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("ae1e5772-38e2-4606-bb2f-70eec76d7069"),
Guid.Parse("c662b852-2db0-421d-949c-f91575d2469b"),
Guid.Parse("a33d6bcc-7ea0-4077-9146-c36a8ab25ee4"),
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

                    nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[4]
{
Guid.Parse("d66ab587-b48f-4f1b-a1b1-6eb516d9f65e"),
Guid.Parse("41be280b-34ff-48c3-a152-2a7524e4b92a"),
Guid.Parse("d9902c28-7371-4689-99de-37db7d212f59"),
Guid.Parse("829a092b-1187-4525-916f-2779296fa118"),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                methodParametrName: "guiduuidarray1mi_id", 
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
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[] nullable = null;
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray1M> models = null;

                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray1M> models = null;

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidArrayuuidArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidArrayuuidArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 90;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 96;
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await((IGuidArrayuuidArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidArray1M.AssertModel(models[0],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidArray1M.AssertModel(models[0],_testData[2], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[3], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[31],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[32],_testData[34], false);
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
                var models = ((IGuidArrayuuidArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidArray1M.AssertModel(models[0],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        GuiduuidArray1M.AssertModel(models[0],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M), typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                await((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 41, query1, 117, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 104, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidArray1M>();
                var models2 = new List<FlatGuiduuidArray1M>();
                ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 30, query1, 132, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var firstItems2 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 93, query1, 143, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 141, query1, 93, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[14],_testData[34], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                await ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 141, query1, 105, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 132, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatGuiduuidArray1M.AssertModel(models[0],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(models[1],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(models[2],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(models[3],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(models[4],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(models[5],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(models[6],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(models[7],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(models[8],_testData[34], false);
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
FROM public.guiduuidarray1m m
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
FROM public.guiduuidarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems1 = new List<FlatGuiduuidArray1M>();
                var secondItems2 = new List<FlatGuiduuidArray1M>();
                 ((IGuidArrayuuidArray)this).DbConnectionDynQuerySelectModelBatch(connection, 34, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatGuiduuidArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await((IGuidArrayuuidArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatchAsync(connection, 23, 78))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        GuiduuidArray1M.AssertModel(models[0],_testData[4], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[5], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[6], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[7], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[8], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[9], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[10], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[11], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[12], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[13], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[14], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[15], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[16], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[18],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[19],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[20],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[21],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[22],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[23],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[24],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[25],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[26],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[27],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[28],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[29],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        GuiduuidArray1M.AssertModel(models[0],_testData[17], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[18], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[19], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[15],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[16],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[17],_testData[34], false);
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
                var models = ((IGuidArrayuuidArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidArrayuuidArray)this).DbConnectionSTSelectModelBatch(connection, 93, 97))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidArray1M.AssertModel(models[0],_testData[20], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[21], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[13],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        GuiduuidArray1M.AssertModel(models[0],_testData[22], false);
                        GuiduuidArray1M.AssertModel(models[1],_testData[23], false);
                        GuiduuidArray1M.AssertModel(models[2],_testData[24], false);
                        GuiduuidArray1M.AssertModel(models[3],_testData[25], false);
                        GuiduuidArray1M.AssertModel(models[4],_testData[26], false);
                        GuiduuidArray1M.AssertModel(models[5],_testData[27], false);
                        GuiduuidArray1M.AssertModel(models[6],_testData[28], false);
                        GuiduuidArray1M.AssertModel(models[7],_testData[29], false);
                        GuiduuidArray1M.AssertModel(models[8],_testData[30], false);
                        GuiduuidArray1M.AssertModel(models[9],_testData[31], false);
                        GuiduuidArray1M.AssertModel(models[10],_testData[32], false);
                        GuiduuidArray1M.AssertModel(models[11],_testData[33], false);
                        GuiduuidArray1M.AssertModel(models[12],_testData[34], false);
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
                await using var cmd = await ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 128);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                GuiduuidArray1M.AssertModel(models[0],_testData[29], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[30], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[31], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[32], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(13));

                GuiduuidArray1M.AssertModel(models[0],_testData[22], false);
                GuiduuidArray1M.AssertModel(models[1],_testData[23], false);
                GuiduuidArray1M.AssertModel(models[2],_testData[24], false);
                GuiduuidArray1M.AssertModel(models[3],_testData[25], false);
                GuiduuidArray1M.AssertModel(models[4],_testData[26], false);
                GuiduuidArray1M.AssertModel(models[5],_testData[27], false);
                GuiduuidArray1M.AssertModel(models[6],_testData[28], false);
                GuiduuidArray1M.AssertModel(models[7],_testData[29], false);
                GuiduuidArray1M.AssertModel(models[8],_testData[30], false);
                GuiduuidArray1M.AssertModel(models[9],_testData[31], false);
                GuiduuidArray1M.AssertModel(models[10],_testData[32], false);
                GuiduuidArray1M.AssertModel(models[11],_testData[33], false);
                GuiduuidArray1M.AssertModel(models[12],_testData[34], false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidArrayuuidArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidArrayuuidArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidArrayuuidArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidArrayuuidArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidArray1MI),
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidArrayuuidArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidArrayuuidArray)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidArrayuuidArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidArrayuuidArray)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidArray1M),
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
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
FROM public.binary_guiduuidarray1m m
LEFT JOIN public.binary_guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidArrayuuidArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidArrayuuidArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidArrayuuidArray)this).ImportModel(connection, importCollection);
                var models = ((IGuidArrayuuidArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models =  ((IGuidArrayuuidArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidArrayuuidArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA), typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                await ((IGuidArrayuuidArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                ((IGuidArrayuuidArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA), typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                await ((IGuidArrayuuidArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                ((IGuidArrayuuidArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models = await ((IGuidArrayuuidArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidarray1mi
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
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI), typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models1 = new List<GuiduuidArray1MI>();
                var models2 = new List<GuiduuidArray1MI>();
                await ((IGuidArrayuuidArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MI>();
                var models2 = new List<GuiduuidArray1MI>();
                ((IGuidArrayuuidArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)),
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
                var models = await ((IGuidArrayuuidArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA), typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                await ((IGuidArrayuuidArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidArray1MIWA>();
                var models2 = new List<GuiduuidArray1MIWA>();
                ((IGuidArrayuuidArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray))]
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
                var models = await ((IGuidArrayuuidArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidArrayuuidArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

